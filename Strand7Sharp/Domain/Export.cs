using St7API;
namespace Strand7Sharp;

/// <summary>How Strand7 renders beam elements in a DXF export.</summary>
public enum BeamExport
{
    /// <summary>Straight line at the beam centroid.</summary>
    Line = St7.ieBeamAsLine,
    /// <summary>2D outline of the beam's cross-section.</summary>
    Section = St7.ieBeamAsSection,
    /// <summary>3D solid volume swept along the beam.</summary>
    Solid = St7.ieBeamAsSolid,
}

/// <summary>How Strand7 renders plate elements in a DXF export.</summary>
public enum PlateExport
{
    /// <summary>Mid-plane surface.</summary>
    Surface = St7.iePlateAsSurface,
    /// <summary>3D solid volume with plate thickness.</summary>
    Solid = St7.iePlateAsSolid,
}

/// <summary>Whether long-running St7 operations render a progress dialog.</summary>
public enum ProgressMode
{
    /// <summary>No progress UI. Preferred for headless / scripted callers.</summary>
    Quiet = St7.ieQuietRun,
    /// <summary>Show the standard Strand7 progress dialog.</summary>
    Progress = St7.ieProgressRun,
}

/// <summary>
/// Options for <see cref="St7Model.ExportDXF"/>. Serialises to the 8-element
/// <c>Integers</c> array that <c>St7ExportDXF</c> expects. Defaults match the
/// most common structural-modelling workflow: solids for beams and plates,
/// offsets included, groups mapped to AutoCAD layers, property colours mapped
/// to entity colours.
/// </summary>
public readonly record struct DxfExportOptions
{
    public BeamExport BeamExport                    { get; init; }
    public PlateExport PlateExport                  { get; init; }
    public bool IncludeBeamOffsets                  { get; init; }
    public bool IncludePlateOffsets                 { get; init; }
    public bool GroupsAsLayers                      { get; init; }
    public bool PropertyColoursAsEntityColours      { get; init; }
    public bool PlatesBricksAs3DFaces               { get; init; }
    public bool ExportInternalBrickFaces            { get; init; }

    public DxfExportOptions()
    {
        BeamExport = BeamExport.Solid;
        PlateExport = PlateExport.Solid;
        IncludeBeamOffsets = true;
        IncludePlateOffsets = true;
        GroupsAsLayers = true;
        PropertyColoursAsEntityColours = true;
        PlatesBricksAs3DFaces = true;
        ExportInternalBrickFaces = false;
    }

    /// <summary>Default options — the record's parameterless-ctor values.</summary>
    public static DxfExportOptions Default => new();

    /// <summary>
    /// Serialise to the 8-element option array Strand7 expects. Index positions
    /// come from <c>ipDXFExport*</c> constants.
    /// </summary>
    public int[] ToNativeOptions()
    {
        var options = new int[8];
        options[St7.ipDXFExportPlatesBricks3DFaces]        = Bt(PlatesBricksAs3DFaces);
        options[St7.ipDXFExportGroupsAsLayers]             = Bt(GroupsAsLayers);
        options[St7.ipDXFExportPropColoursAsEntityColours] = Bt(PropertyColoursAsEntityColours);
        options[St7.ipDXFExportBeamsAs]                    = (int)BeamExport;
        options[St7.ipDXFExportPlatesAs]                   = (int)PlateExport;
        options[St7.ipDXFExportBeamOffsets]                = Bt(IncludeBeamOffsets);
        options[St7.ipDXFExportPlateOffsets]               = Bt(IncludePlateOffsets);
        options[St7.ipDXFExportInternalBrickFaces]         = Bt(ExportInternalBrickFaces);
        return options;
    }

    private static int Bt(bool b) => b ? St7.btTrue : St7.btFalse;
}
