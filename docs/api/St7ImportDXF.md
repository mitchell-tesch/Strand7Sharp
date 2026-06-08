# St7ImportDXF

Imports a geometry file in the DXF format.

long St7ImportDXF(long uID, char* FileName, long* Integers, double* Doubles,

long Mode)

Input Parameters

uID

Strand7 model file ID.

FileName

Full path and name for the DXF file to be imported.

Integers[0..11]

[ipDXFImportFrozenLayers] – Import frozen layers.

[ipDXFImportLayersAsGroups] – Import geometry layers as groups; either btTrue or btFalse.

[ipDXFImportColoursAsProps] – Use geometry colours as property definitions; either btTrue or
btFalse.

Strand7 API Manual

[ipDXFImportMatchExistingProperty] – If importing geometry colour definitions as property
definitions, and a property of the same colour already exists, use that property, do not create a new
one; either btTrue or btFalse.

[ipDXFImportPolylineAsPlates] – Import polyline definitions as plate elements; either btTrue or
btFalse.

[ipDXFImportPolygonAsBricks] – Import polygon definitions as brick elements; either btTrue or
btFalse.

[ipDXFImportSegmentsPerCircle] – Number of line segments used to discretise curves.

[ipDXFImportUseSegmentsPerCircle] – btTrue to use Segments per Circle, or btFalse to use Arc
Length for curve discretisation.

[ipDXFImportLengthUnit] – Specifies a length unit for the import file; one of luGeomNone,
luGeomInch, luGeomMillimetre, luGeomFoot, luGeomMile, luGeomMetre, luGeomKilometre,
luGeomMil, luGeomMicron, luGeomCentimetre, luGeomMicroinch, or luGeomUnspecified.

[ipDXFImportProperty] – Import colours as properties; either btTrue or btFalse.

[ipDXFImportAcisBodiesAsGroups] – Import ACIS bodies as groups; either btTrue or btFalse.

[ipDXFImportCurvesToBeams] – Convert unreferenced curves in ACIS data to beam elements;
either btTrue or btFalse.

Doubles[0..1]

[ipDXFImportArcLength] – Length of the line segment used to discretise curves, specified in
Strand7 model units.

[ipDXFImportAcisTol] – Relative tolerance used when importing ACIS geometry.

Mode

Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
