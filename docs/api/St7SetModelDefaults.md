# St7SetModelDefaults

Resets display related parameters in a Strand7 model to default values.

long St7SetModelDefaults(long uID, long Options, long Mode, long* Integers)
Input Parameters
uID
Strand7 model file ID.
Options
One of mdViewOptions, mdEntityOptions, mdBeamPreContourOptions, mdPlatePreContourOptions,
mdBrickPreContourOptions, mdAttributeOptions, mdResultOptions, mdBeamResultContourOptions,
mdPlateResultContourOptions, mdBrickResultContourOptions, mdLinkResultContourOptions or
mdPrintOptions.
Mode
Either mdFactoryDefaults or mdUserDefaults.
Integers[0..7]
For mdViewOptions:
[ipDefBackgroundTab] – btTrue to set defaults on the Background tab, or btFalse to leave as-is.
[ipDefAxisTab] – btTrue to set defaults on the Axes tab, or btFalse to leave as-is.

[ipDefRotationTab] – btTrue to set defaults on the Rotation tab, or btFalse to leave as-is.
[ipDefDrawingTab] – btTrue to set defaults on the Drawing tab, or btFalse to leave as-is.
[ipDefPreNumbersTab] – btTrue to set defaults on the Pre Numbers tab, or btFalse to leave as-is.
[ipDefFreeEdgeTab] – btTrue to set defaults on the Free Edge tab, or btFalse to leave as-is.
[ipDefSelectionTab] – btTrue to set defaults on the Selecting tab, or btFalse to leave as-is.
For mdEntityOptions:
[ipDefNodeTab] – btTrue to set defaults on the Node tab, or btFalse to leave as-is.
[ipDefBeamTab] – btTrue to set defaults on the Beam tab, or btFalse to leave as-is.
[ipDefPlateTab] – btTrue to set defaults on the Plate tab, or btFalse to leave as-is.
[ipDefBrickTab] – btTrue to set defaults on the Brick tab, or btFalse to leave as-is.
[ipDefLinkTab] – btTrue to set defaults on the Link tab, or btFalse to leave as-is.
[ipDefPathTab] – btTrue to set defaults on the Load Path tab, or btFalse to leave as-is.
[ipDefVertexTab] – btTrue to set defaults on the Vertex tab, or btFalse to leave as-is.
[ipDefFaceTab] – btTrue to set defaults on the Geometry Face tab, or btFalse to leave as-is.
For mdBeamPreContourOptions, mdPlatePreContourOptions and mdBrickPreContourOptions:
[ipDefContourStyleTab] – btTrue to set defaults on the Style tab, or btFalse to leave as-is.
[ipDefContourLimitsTab] – btTrue to set defaults on the Limits tab, or btFalse to leave as-is.
[ipDefContourLegendTab] – btTrue to set defaults on the Legend tab, or btFalse to leave as-is.
For mdResultOptions:
[ipDefResShowHideTab] – btTrue to set defaults on the Show/Hide tab, or btFalse to leave as-is.
[ipDefResPostNumbersTab] – btTrue to set defaults on the Numbers tab, or btFalse to leave as-is.
[ipDefResCombinationsTab] – btTrue to set defaults on the Combinations tab, or btFalse to leave
as-is.
[ipDefResEnvelopesTab] – btTrue to set defaults on the Envelopes tab, or btFalse to leave as-is.
[ipDefResOtherTab] – btTrue to set defaults on the Other tab, or btFalse to leave as-is.
For mdBeamResultContourOptions, mdPlateResultContourOptions, mdBrickResultContourOptions and
mdLinkResultContourOptions:
[ipDefContourStyleTab] – btTrue to set defaults on the Style tab, or btFalse to leave as-is.
[ipDefContourLimitsTab] – btTrue to set defaults on the Limits tab, or btFalse to leave as-is.
[ipDefContourLegendTab] – btTrue to set defaults on the Legend tab, or btFalse to leave as-is.
[ipDefContourDiagramTab] – btTrue to set defaults on the Diagram tab, or btFalse to leave as-is.

For mdAttributeOptions:
[ipDefNodeAttribTab] – btTrue to set defaults on the Node Attribute tab, or btFalse to leave as-is.
[ipDefBeamAttribTab] – btTrue to set defaults on the Beam Attribute tab, or btFalse to leave as-is.
[ipDefPlateAttribTab] – btTrue to set defaults on the Plate Attribute tab, or btFalse to leave as-is.
[ipDefBrickAttribTab] – btTrue to set defaults on the Brick Attribute tab, or btFalse to leave as-is.
[ipDefPathAttribTab] – btTrue to set defaults on the Load Path Attribute tab, or btFalse to leave
as-is.
For mdPrintOptions:
[ipHeaderFooterTab] – btTrue to set defaults on the Header/Footer tab, or btFalse to leave as-is.
[ipPageSetupTab] – btTrue to set defaults on the Page Setup tab, or btFalse to leave as-is.
[ipFontsTab] – btTrue to set defaults on the Fonts tab, or btFalse to leave as-is.
