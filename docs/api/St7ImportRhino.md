# St7ImportRhino

Imports a geometry file in the Rhino format.

long St7ImportRhino(long uID, char* FileName, long* Integers, double* Doubles,

long Mode)

Input Parameters

uID

Strand7 model file ID.

Import/Export Utilities

FileName

Full path and name for the Rhino file to be imported.

Integers[0..5]

[ipGeomImportProperty] – Default property ID.

[ipGeomImportCurvesToBeams] – Convert unreferenced curves to beam elements; either btTrue or
btFalse.

[ipGeomImportGroupsAs] – Geometry groups import; one of ggNone, ggAuto, ggBlocks or ggLayers.

[ipGeomImportColourAsProperty] – Import geometry colour definitions as property definitions;
either btTrue or btFalse.

[ipGeomImportMatchExistingProperty] – If importing geometry colour definitions as property
definitions, and a property of the same colour already exists, use that property, do not create a new
one; either btTrue or btFalse.

[ipGeomImportLengthUnit] – Specifies a length unit for the import file; one of luGeomNone,
luGeomInch, luGeomMillimetre, luGeomFoot, luGeomMile, luGeomMetre, luGeomKilometre,
luGeomMil, luGeomMicron, luGeomCentimetre, luGeomMicroinch, or luGeomUnspecified.

Doubles[0..0]

[ipGeomImportTol] – Relative tolerance used when importing geometry.

Mode

Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
