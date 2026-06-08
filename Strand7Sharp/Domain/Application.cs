using St7API;
namespace Strand7Sharp;

/// <summary>
/// Application-scope settings exposed by the Strand7 API outside of any model.
/// Includes the global integer / logical / string value slots
/// (<see cref="St7.St7GetGlobalIntegerValue"/> et al.) which the host application
/// uses to expose its current selection / units context to scripted tools.
/// </summary>
public readonly struct ApplicationSettings
{
    internal ApplicationSettings(Strand7Api _) { }

    /// <summary>Read a global integer value by index (St7GetGlobalIntegerValue).</summary>
    public int GetInteger(int index) => St7Native.St7GetGlobalIntegerValue(index);
    /// <summary>Read a global logical (true/false) value by index.</summary>
    public bool GetBool(int index) => St7Native.St7GetGlobalLogicalValue(index) != 0;
    /// <summary>Read a global string value by index.</summary>
    public string GetString(int index) => St7Native.St7GetGlobalStringValue(index);

    /// <summary>Reset all global integer slots to zero.</summary>
    public void ClearIntegers() => St7Native.St7ClearGlobalIntegerValues();
    /// <summary>Reset all global logical slots to false.</summary>
    public void ClearBools() => St7Native.St7ClearGlobalLogicalValues();
    /// <summary>Reset all global string slots to empty.</summary>
    public void ClearStrings() => St7Native.St7ClearGlobalStringValues();

    /// <summary>Set the Solver-DLL preference (St7SetUseSolverDLL).</summary>
    public bool UseSolverDll
    {
        get => St7Native.St7GetUseSolverDLL() != 0;
        set => St7Native.St7SetUseSolverDLL(St7Check.AsByte(value));
    }

    /// <summary>Strand7 API install path (read-only).</summary>
    public string ApiPath => St7Native.St7GetAPIPath();

    /// <summary>Filesystem path for shared library files (materials, sections, ...).</summary>
    public string LibraryPath
    {
        get => St7Native.St7GetLibraryPath();
        set => St7Native.St7SetLibraryPath(value);
    }

    /// <summary>Filesystem path of the display-options config file.</summary>
    public string DisplayOptionsPath
    {
        get => St7Native.St7GetDisplayOptionsPath();
        set => St7Native.St7SetDisplayOptionsPath(value);
    }
}

