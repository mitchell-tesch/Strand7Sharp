using System.IO;
using St7API;
namespace Strand7Sharp;
/// <summary>Solver controls scoped to a single model.</summary>
public readonly struct SolverApi
{
    private readonly St7Model _m;
    internal SolverApi(St7Model m) => _m = m;

    /// <summary>Override the output result file name used by the next solver run.</summary>
    public void SetResultFile(string fileName) => St7Native.St7SetResultFileName(_m.FileId, fileName);

    /// <summary>Set the log file written by the solver.</summary>
    public void SetLogFile(string fileName) => St7Native.St7SetResultLogFileName(_m.FileId, fileName);

    /// <summary>Active freedom case the solver will use.</summary>
    public int FreedomCase
    {
        get => St7Native.St7GetSolverFreedomCase(_m.FileId);
        set => St7Native.St7SetSolverFreedomCase(_m.FileId, value);
    }

    /// <summary>Returns whether the solver process with the given ID is still running.</summary>
    public static bool IsProcessRunning(int processId) => St7Native.St7CheckSolverRunning(processId) != 0;

    /// <summary>Number of CPU cores the solver should use.</summary>
    public int NumCpu
    {
        get => St7Native.St7GetSolverNumCPU(_m.FileId);
        set => St7Native.St7SetSolverNumCPU(_m.FileId, value);
    }

    /// <summary>Solver scheme (ipSolverDirect / ipSolverIterative / ipSolverAuto).</summary>
    public int Scheme
    {
        get => St7Native.St7GetSolverScheme(_m.FileId);
        set => St7Native.St7SetSolverScheme(_m.FileId, value);
    }

    /// <summary>Whether large-deflection (nonlinear-geometry) is on.</summary>
    public bool NonlinearGeometry
    {
        get => St7Native.St7GetSolverNonlinearGeometry(_m.FileId) != 0;
        set => St7Native.St7SetSolverNonlinearGeometry(_m.FileId, St7Check.AsByte(value));
    }
    public bool NonlinearMaterial
    {
        get => St7Native.St7GetSolverNonlinearMaterial(_m.FileId) != 0;
        set => St7Native.St7SetSolverNonlinearMaterial(_m.FileId, St7Check.AsByte(value));
    }
    public bool IncludeKG
    {
        get => St7Native.St7GetSolverIncludeKG(_m.FileId) != 0;
        set => St7Native.St7SetSolverIncludeKG(_m.FileId, St7Check.AsByte(value));
    }
    public bool TemperatureDependence
    {
        get => St7Native.St7GetSolverTemperatureDependence(_m.FileId) != 0;
        set => St7Native.St7SetSolverTemperatureDependence(_m.FileId, St7Check.AsByte(value));
    }
    public bool StressStiffening
    {
        get => St7Native.St7GetSolverStressStiffening(_m.FileId) != 0;
        set => St7Native.St7SetSolverStressStiffening(_m.FileId, St7Check.AsByte(value));
    }
    public bool Creep
    {
        get => St7Native.St7GetSolverCreep(_m.FileId) != 0;
        set => St7Native.St7SetSolverCreep(_m.FileId, St7Check.AsByte(value));
    }
    public bool Sort
    {
        get => St7Native.St7GetSolverSort(_m.FileId) != 0;
        set => St7Native.St7SetSolverSort(_m.FileId, St7Check.AsByte(value));
    }

    /// <summary>Runs the given solver. Throws on any non-zero error code.</summary>
    public void Run(SolverType solver,
        SolverRunMode mode = SolverRunMode.Background,
        bool wait = true,
        string? resultFileName = null)
    {
        if (resultFileName is not null) SetResultFile(resultFileName);
        St7Native.St7RunSolver(_m.FileId, (int)solver, (int)mode, St7Check.AsByte(wait));
    }

    /// <summary>Launches the solver as a separate process. Returns the OS process ID.</summary>
    public int RunProcess(SolverType solver, SolverRunMode mode = SolverRunMode.Background, bool wait = false)
        => St7Native.St7RunSolverProcess(_m.FileId, (int)solver, (int)mode, St7Check.AsByte(wait));

    /// <summary>Stops the running solver process for the given processID.</summary>
    public static void StopProcess(int processId) => St7Native.St7StopSolverProcess(processId);

    /// <summary>Opens the named result file against the model.</summary>
    public St7Results OpenResults(string resultFileName, string? spectralFileName = null, int combinationCode = 0)
    {
        if (!File.Exists(resultFileName))
            throw new FileNotFoundException("Result file not found.", resultFileName);
        return _m.OpenResults(resultFileName, spectralFileName, combinationCode);
    }

    /// <summary>Get a solver-defaults integer parameter (use one of the ip* constants).</summary>
    public int GetDefaultInt(int parameter)     => St7Native.St7GetSolverDefaultsInteger(_m.FileId, parameter);
    public void SetDefaultInt(int parameter, int value) => St7Native.St7SetSolverDefaultsInteger(_m.FileId, parameter, value);
    public double GetDefaultDouble(int parameter) => St7Native.St7GetSolverDefaultsDouble(_m.FileId, parameter);
    public void SetDefaultDouble(int parameter, double value) => St7Native.St7SetSolverDefaultsDouble(_m.FileId, parameter, value);
    public bool GetDefaultBool(int parameter)   => St7Native.St7GetSolverDefaultsLogical(_m.FileId, parameter) != 0;
    public void SetDefaultBool(int parameter, bool value) => St7Native.St7SetSolverDefaultsLogical(_m.FileId, parameter, value ? (byte)1 : (byte)0);

    /// <summary>Resolve a solver error code to its descriptive string.</summary>
    public string GetErrorString(int errorCode) => St7Native.St7GetSolverErrorString(errorCode);
}
