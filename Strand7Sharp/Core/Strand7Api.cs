using System;
using System.Collections.Generic;
using System.Text;
using St7API;

namespace Strand7Sharp;

/// <summary>
/// Manages the lifetime of the Strand7 API itself. Wraps <see cref="St7.St7Init"/> /
/// <see cref="St7.St7Release"/> so consumers can write:
/// <code>
/// using var api = Strand7Api.Initialize();
/// using var model = api.OpenModel(@"C:\models\beam.st7", @"C:\temp");
/// // ... work with model ...
/// </code>
/// Only one Strand7 API session may be active per process. The session can
/// host multiple open models at a time (each identified by a distinct file
/// uID); <see cref="OpenModel"/> auto-allocates a free uID by default.
/// </summary>
public sealed class Strand7Api : IDisposable
{
    private static readonly object SyncRoot = new();
    private static Strand7Api? _instance;
    private bool _disposed;

    private readonly Dictionary<int, WeakReference<St7Model>> _openModels = new();

    private Strand7Api() { }

    /// <summary>Initializes the Strand7 API. Subsequent calls return the same singleton.</summary>
    public static Strand7Api Initialize()
    {
        lock (SyncRoot)
        {
            if (_instance is { _disposed: false })
                return _instance;

            St7Check.Check(St7.St7Init());
            _instance = new Strand7Api();
            return _instance;
        }
    }

    /// <summary>The current active session, or <c>null</c> if not initialized.</summary>
    public static Strand7Api? Current => _instance is { _disposed: false } ? _instance : null;

    /// <summary>Returns the Strand7 API version as reported by <see cref="St7.St7Version"/>.</summary>
    public Version Version
    {
        get
        {
            var v = St7Native.St7Version();
            return new Version(v.Major, v.Minor, v.Point);
        }
    }

    /// <summary>Full build string reported by <see cref="St7.St7BuildString"/>.</summary>
    public string BuildString => St7Native.St7BuildString();

    /// <summary>Maximum simultaneous open-model uID supported by this API build.</summary>
    public int MaxModelFileId => St7Native.St7GetMaxModelFileID();

    /// <summary>Inspect the file version of a Strand7 file without opening it.</summary>
    public Version GetFileVersion(string fileName)
    {
        var v = St7Native.St7FileVersion(fileName);
        return new Version(v.Major, v.Minor, v.Point);
    }

    /// <summary>Licence-mode options (<see cref="St7.St7SetLicenceOptions"/>).</summary>
    public (int Mode, int MaxRetry, int RetryPause) LicenceOptions
    {
        get => St7Native.St7GetLicenceOptions();
        set => St7Native.St7SetLicenceOptions(value.Mode, value.MaxRetry, value.RetryPause);
    }

    /// <summary>System list-separator code used for delimited output.</summary>
    public int ListSeparatorCode => St7Native.St7GetListSeparatorCode();

    /// <summary>System decimal-separator code used for delimited output.</summary>
    public int DecimalSeparatorCode => St7Native.St7GetDecimalSeparatorCode();

    /// <summary>UI icon size in pixels.</summary>
    public int IconSize
    {
        get => St7Native.St7GetIconSize();
        set => St7Native.St7SetIconSize(value);
    }

    /// <summary>Application-scope settings exposed by St7 (global integer/logical/string values).</summary>
    public ApplicationSettings Settings => new(this);

    /// <summary>
    /// Opens a Strand7 model file with read/write access. If <paramref name="fileId"/>
    /// is zero (default) a free uID is allocated automatically; otherwise the
    /// caller-supplied uID is used and must not already be in use.
    /// </summary>
    public St7Model OpenModel(string fileName, string scratchPath, int fileId = 0)
    {
        ThrowIfDisposed();
        int id = ResolveFileId(fileId);
        var m = St7Model.Open(id, fileName, scratchPath, readOnly: false);
        Register(m);
        return m;
    }

    /// <summary>Opens a Strand7 model file read-only.</summary>
    public St7Model OpenModelReadOnly(string fileName, string scratchPath, int fileId = 0)
    {
        ThrowIfDisposed();
        int id = ResolveFileId(fileId);
        var m = St7Model.Open(id, fileName, scratchPath, readOnly: true);
        Register(m);
        return m;
    }

    /// <summary>Creates a new empty Strand7 model file via <see cref="St7.St7NewFile"/>.</summary>
    public St7Model NewModel(string fileName, string scratchPath, int fileId = 0)
    {
        ThrowIfDisposed();
        int id = ResolveFileId(fileId);
        St7Native.St7NewFile(id, fileName, scratchPath);
        var m = St7Model.AttachExisting(id, fileName);
        Register(m);
        return m;
    }

    /// <summary>Enumerate the models currently tracked by this session.</summary>
    public IEnumerable<St7Model> OpenModels
    {
        get
        {
            List<St7Model> alive = new();
            lock (SyncRoot)
            {
                foreach (var kv in _openModels)
                    if (kv.Value.TryGetTarget(out var m) && !m.IsDisposed)
                        alive.Add(m);
            }
            return alive;
        }
    }

    private int ResolveFileId(int requested)
    {
        if (requested > 0) return requested;
        lock (SyncRoot)
        {
            int max = MaxModelFileId;
            for (int i = 1; i <= max; i++)
            {
                if (!_openModels.TryGetValue(i, out var wr) ||
                    !wr.TryGetTarget(out var m) || m.IsDisposed)
                    return i;
            }
        }
        throw new InvalidOperationException("All Strand7 model file IDs are in use.");
    }

    private void Register(St7Model m)
    {
        lock (SyncRoot) _openModels[m.FileId] = new WeakReference<St7Model>(m);
        m.OnDisposed += id => { lock (SyncRoot) _openModels.Remove(id); };
    }

    internal void ThrowIfDisposed()
    {
        if (_disposed) throw new ObjectDisposedException(nameof(Strand7Api));
    }

    public void Dispose()
    {
        lock (SyncRoot)
        {
            if (_disposed) return;
            foreach (var wr in _openModels.Values)
                if (wr.TryGetTarget(out var m) && !m.IsDisposed)
                    try { m.Dispose(); } catch { /* ignore */ }
            _openModels.Clear();
            try { St7Check.Check(St7.St7Release()); }
            finally
            {
                _disposed = true;
                _instance = null;
            }
        }
    }
}

