using System;
using St7API;
namespace Strand7Sharp;
/// <summary>Strongly-typed wrapper for the Strand7 unit system.</summary>
public readonly record struct Strand7Units(
    int Length, int Force, int Stress, int Mass, int Temperature, int Energy)
{
    public int[] ToArray()
    {
        var a = new int[St7.kLastUnit];
        a[St7.ipLENGTHU]  = Length;
        a[St7.ipFORCEU]   = Force;
        a[St7.ipSTRESSU]  = Stress;
        a[St7.ipMASSU]    = Mass;
        a[St7.ipTEMPERU]  = Temperature;
        a[St7.ipENERGYU]  = Energy;
        return a;
    }
    public static Strand7Units FromArray(int[] a) => new(
        a[St7.ipLENGTHU], a[St7.ipFORCEU], a[St7.ipSTRESSU],
        a[St7.ipMASSU], a[St7.ipTEMPERU], a[St7.ipENERGYU]);
    /// <summary>SI: metre, newton, pascal, kilogram, celsius, joule.</summary>
    public static Strand7Units SI => new(
        St7.luMETRE, St7.fuNEWTON, St7.suPASCAL,
        St7.muKILOGRAM, St7.tuCELSIUS, St7.euJOULE);
    /// <summary>Common structural: millimetre, newton, megapascal, tonne, celsius, joule.</summary>
    public static Strand7Units MmNMPa => new(
        St7.luMILLIMETRE, St7.fuNEWTON, St7.suMEGAPASCAL,
        St7.muTONNE, St7.tuCELSIUS, St7.euJOULE);
}
/// <summary>Entity type tag used by many St7API calls.</summary>
public enum EntityType
{
    Node = St7.tyNODE,
    Beam = St7.tyBEAM,
    Plate = St7.tyPLATE,
    Brick = St7.tyBRICK,
    Link = St7.tyLINK,
    Vertex = St7.tyVERTEX,
    GeometryEdge = St7.tyGEOMETRYEDGE,
    GeometryFace = St7.tyGEOMETRYFACE,
    LoadPath = St7.tyLOADPATH,
    GeometryCoEdge = St7.tyGEOMETRYCOEDGE,
    GeometryLoop = St7.tyGEOMETRYLOOP,
}
/// <summary>Solver type passed to <see cref="St7.St7RunSolver"/>.</summary>
public enum SolverType
{
    LinearStatic = St7.stLinearStatic,
    LinearBuckling = St7.stLinearBuckling,
    NonlinearStatic = St7.stNonlinearStatic,
    NaturalFrequency = St7.stNaturalFrequency,
    HarmonicResponse = St7.stHarmonicResponse,
    SpectralResponse = St7.stSpectralResponse,
    LinearTransientDynamic = St7.stLinearTransientDynamic,
    NonlinearTransientDynamic = St7.stNonlinearTransientDynamic,
    SteadyHeat = St7.stSteadyHeat,
    TransientHeat = St7.stTransientHeat,
    LoadInfluence = St7.stLoadInfluence,
    QuasiStatic = St7.stQuasiStatic,
}
/// <summary>How the solver is launched. Mirrors <c>St7.sm*Run</c>.</summary>
public enum SolverRunMode
{
    Normal = St7.smNormalRun,
    Progress = St7.smProgressRun,
    Background = St7.smBackgroundRun,
    NormalClose = St7.smNormalCloseRun,
}

/// <summary>Beam element type (<c>St7.bt*</c>).</summary>
public enum BeamType
{
    Null = St7.btNull,
    Spring = St7.btSpring,
    Cable = St7.btCable,
    Truss = St7.btTruss,
    Cutoff = St7.btCutoff,
    Contact = St7.btContact,
    Beam = St7.btBeam,
    User = St7.btUser,
    Pipe = St7.btPipe,
    Connection = St7.btConnection,
}

/// <summary>Plate element type (<c>St7.pt*</c>).</summary>
public enum PlateType
{
    Null = St7.ptNull,
    PlaneStress = St7.ptPlaneStress,
    PlaneStrain = St7.ptPlaneStrain,
    Axisymmetric = St7.ptAxisymmetric,
    PlateShell = St7.ptPlateShell,
    ShearPanel = St7.ptShearPanel,
    Membrane = St7.ptMembrane,
    LoadPatch = St7.ptLoadPatch,
}

/// <summary>Property kind passed to St7AssignLibrary*.</summary>
public enum PropertyKind
{
    Beam = St7.ptBEAMPROP,
    Plate = St7.ptPLATEPROP,
    Brick = St7.ptBRICKPROP,
    Ply = St7.ptPLYPROP,
}

/// <summary>Material model (<c>St7.mt*</c>).</summary>
public enum MaterialType
{
    Null = St7.mtNull,
    Isotropic = St7.mtIsotropic,
    Orthotropic = St7.mtOrthotropic,
    Anisotropic = St7.mtAnisotropic,
    Rubber = St7.mtRubber,
    Soil = St7.mtSoil,
    Laminate = St7.mtLaminate,
    UserDefined = St7.mtUserDefined,
    Fluid = St7.mtFluid,
}

/// <summary>Link element type (<c>St7.lt*Link</c>).</summary>
public enum LinkType
{
    MasterSlave = St7.ltMasterSlaveLink,
    SectorSymmetry = St7.ltSectorSymmetryLink,
    Coupling = St7.ltCouplingLink,
    Pinned = St7.ltPinnedLink,
    Rigid = St7.ltRigidLink,
    Shrink = St7.ltShrinkLink,
    TwoPoint = St7.ltTwoPointLink,
    Attachment = St7.ltAttachmentLink,
    InterpolatedMultiPoint = St7.ltInterpolatedMultiPointLink,
    ReactionMultiPoint = St7.ltReactionMultiPointLink,
    RigidMultiPoint = St7.ltRigidMultiPointLink,
    PinnedMultiPoint = St7.ltPinnedMultiPointLink,
    MasterSlaveMultiPoint = St7.ltMasterSlaveMultiPointLink,
    UserDefinedMultiPoint = St7.ltUserDefinedMultiPointLink,
}

/// <summary>Selection state (<c>St7.ss*</c>).</summary>
public enum SelectState
{
    Unselected = St7.ssUnselected,
    Selected = St7.ssSelected,
}

/// <summary>Node temperature attribute type (<c>St7.nt*</c>).</summary>
public enum NodeTemperatureType
{
    Reference = St7.ntReferenceTemperature,
    Fixed = St7.ntFixedTemperature,
    Initial = St7.ntInitialTemperature,
    Table = St7.ntTableTemperature,
}

/// <summary>Beam end-release state (<c>St7.br*</c>).</summary>
public enum BeamReleaseState
{
    Released = St7.brReleased,
    Fixed = St7.brFixed,
    Partial = St7.brPartial,
}

/// <summary>Plate edge-release state (<c>St7.pr*</c>).</summary>
public enum PlateReleaseState
{
    Released = St7.prReleased,
    Fixed = St7.prFixed,
}

/// <summary>Library kind used by <see cref="St7.St7AssignLibraryMaterial"/> etc.</summary>
public enum LibraryKind
{
    Material = St7.lbMaterial,
    BeamSection = St7.lbBeamSection,
    Composite = St7.lbComposite,
    ReinforcementLayout = St7.lbReinforcementLayout,
    CreepDefinition = St7.lbCreepDefinition,
    LoadPathTemplate = St7.lbLoadPathTemplate,
    SectionGeometry = St7.lbSectionGeometry,
}

/// <summary>Table-type code (<c>St7.tt*</c>) passed to <see cref="St7.St7NewTableType"/>.</summary>
public enum TableType
{
    VsTime = St7.ttVsTime,
    VsTemperature = St7.ttVsTemperature,
    VsFrequency = St7.ttVsFrequency,
    StressStrain = St7.ttStressStrain,
    ForceDisplacement = St7.ttForceDisplacement,
    MomentCurvature = St7.ttMomentCurvature,
    MomentRotation = St7.ttMomentRotation,
    AccVsTime = St7.ttAccVsTime,
    ForceVelocity = St7.ttForceVelocity,
    VsPosition = St7.ttVsPosition,
    StrainTime = St7.ttStrainTime,
    DispVsTime = St7.ttDispVsTime,
    VelVsTime = St7.ttVelVsTime,
    VsVelocity = St7.ttVsVelocity,
    TemperatureVsTime = St7.ttTemperatureVsTime,
}

/// <summary>Six DOF status flags for a node/vertex restraint (1=fixed, 0=free).</summary>
public readonly record struct DofStatus(int Dx, int Dy, int Dz, int Rx, int Ry, int Rz)
{
    public static DofStatus Free => new(0, 0, 0, 0, 0, 0);
    public static DofStatus Fixed => new(1, 1, 1, 1, 1, 1);
    public static DofStatus PinnedXYZ => new(1, 1, 1, 0, 0, 0);
    public int[] ToArray() => new[] { Dx, Dy, Dz, Rx, Ry, Rz };
    public static DofStatus FromArray(int[] a) => new(a[0], a[1], a[2], a[3], a[4], a[5]);
}

/// <summary>Six prescribed DOF values (Dx,Dy,Dz,Rx,Ry,Rz).</summary>
public readonly record struct DofValues(double Dx, double Dy, double Dz, double Rx, double Ry, double Rz)
{
    public static DofValues Zero => default;
    public double[] ToArray() => new[] { Dx, Dy, Dz, Rx, Ry, Rz };
    public static DofValues FromArray(double[] a) => new(a[0], a[1], a[2], a[3], a[4], a[5]);
}

/// <summary>Three-component vector (Fx,Fy,Fz / Mx,My,Mz / X,Y,Z).</summary>
public readonly record struct Vector3(double X, double Y, double Z)
{
    public static Vector3 Zero => default;
    public double[] ToArray() => new[] { X, Y, Z };
    public static Vector3 FromArray(double[] a) => new(a[0], a[1], a[2]);
}

