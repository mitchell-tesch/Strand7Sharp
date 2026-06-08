using System;
using St7API;
namespace Strand7Sharp;
/// <summary>
/// Manages an open solver result file (LSA / NLA / NFA / ...) bound to a model.
/// Dispose to close.
/// </summary>
public sealed class St7Results : IDisposable
{
    private readonly St7Model _m;
    private bool _disposed;
    /// <summary>Number of primary result cases reported by St7OpenResultFile.</summary>
    public int PrimaryCount { get; }
    /// <summary>Number of secondary (combination / envelope) result cases.</summary>
    public int SecondaryCount { get; }
    /// <summary>Total cases (primary + secondary).</summary>
    public int Count => PrimaryCount + SecondaryCount;
    private St7Results(St7Model m, int primary, int secondary)
    {
        _m = m;
        PrimaryCount = primary;
        SecondaryCount = secondary;
    }
    internal static St7Results Open(St7Model m, string resultFileName, string? spectralFileName, int combinationCode)
    {
        var counts = St7Native.St7OpenResultFile(m.FileId, resultFileName, spectralFileName ?? string.Empty, combinationCode);
        return new St7Results(m, counts.NumPrimary, counts.NumSecondary);
    }
    /// <summary>Descriptive name of the given (1-based) result case.</summary>
    public string GetCaseName(int caseNum)
    {
        ThrowIfDisposed();
        return St7Native.St7GetResultCaseName(_m.FileId, caseNum);
    }
    /// <summary>Time/frequency parameter for the case (meaningful for transient / spectral / harmonic).</summary>
    public double GetCaseTime(int caseNum)
    {
        ThrowIfDisposed();
        return St7Native.St7GetResultCaseTime(_m.FileId, caseNum);
    }

    /// <summary>Load-factor (applied scale) for the given result case.</summary>
    public double GetCaseFactor(int caseNum)
    {
        ThrowIfDisposed();
        return St7Native.St7GetResultCaseFactor(_m.FileId, caseNum);
    }

    /// <summary>Kinetic-energy reported for the case (transient / NLA).</summary>
    public double GetCaseKineticEnergy(int caseNum)
    {
        ThrowIfDisposed();
        return St7Native.St7GetResultCaseKineticEnergy(_m.FileId, caseNum);
    }

    /// <summary>The staging stage number associated with the case (0 if not staged).</summary>
    public int GetCaseStage(int caseNum)
    {
        ThrowIfDisposed();
        return St7Native.St7GetResultCaseStage(_m.FileId, caseNum);
    }

    /// <summary>True if the nonlinear / transient case converged.</summary>
    public bool GetCaseConverged(int caseNum)
    {
        ThrowIfDisposed();
        return St7Native.St7GetResultCaseConvergence(_m.FileId, caseNum) != 0;
    }

    /// <summary>True if the case is a Reset point in a transient.</summary>
    public bool GetCaseReset(int caseNum)
    {
        ThrowIfDisposed();
        return St7Native.St7GetResultCaseReset(_m.FileId, caseNum) != 0;
    }
    /// <summary>Raw nodal result vector. Result-type constants are St7.rt*. Caller owns the buffer size.</summary>
    public double[] GetNodeResult(int resultType, int nodeNum, int caseNum, int bufferSize = 24)
    {
        ThrowIfDisposed();
        var data = new double[bufferSize];
        St7Native.St7GetNodeResult(_m.FileId, resultType, nodeNum, caseNum, data);
        return data;
    }
    /// <summary>Beam result array along the beam (positions + multi-column result data).</summary>
    public BeamResultArray GetBeamResult(int resultType, int resultSubType, int beamNum, int caseNum, int minStations = 0)
    {
        ThrowIfDisposed();
        var pos = new double[St7.kMaxBeamResult];
        var data = new double[St7.kMaxBeamResult];
        int numStations = 0, numColumns = 0;
        St7Check.Check(St7.St7GetBeamResultArray(_m.FileId, resultType, resultSubType, beamNum,
            minStations, caseNum, ref numStations, ref numColumns, pos, data), "St7GetBeamResultArray");
        return new BeamResultArray(numStations, numColumns, pos, data);
    }
    private void ThrowIfDisposed()
    {
        if (_disposed) throw new ObjectDisposedException(nameof(St7Results));
    }
    public void Dispose()
    {
        if (_disposed) return;
        _disposed = true;
        try { St7.St7CloseResultFile(_m.FileId); } catch { /* ignore */ }
    }
}
/// <summary>Lightweight station × column view over a beam result buffer.</summary>
public readonly struct BeamResultArray
{
    public int StationCount { get; }
    public int ColumnCount { get; }
    /// <summary>Stations along the beam (length = <see cref="StationCount"/>).</summary>
    public double[] Positions { get; }
    /// <summary>Flat StationCount * ColumnCount result buffer (row-major).</summary>
    public double[] Data { get; }
    internal BeamResultArray(int stationCount, int columnCount, double[] positions, double[] data)
    { StationCount = stationCount; ColumnCount = columnCount; Positions = positions; Data = data; }
    public double this[int station, int column] => Data[station * ColumnCount + column];
}
