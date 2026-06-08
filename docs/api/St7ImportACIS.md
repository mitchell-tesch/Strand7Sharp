# St7ImportACIS

Imports a geometry file in the ACIS format.

long St7ImportACIS(long uID, char* FileName, long* Integers, double* Doubles,

long Mode)

Input Parameters

uID

Strand7 model file ID.

FileName

Full path and name for the ACIS file to be imported.

Integers[0..5]

[ipGeomImportProperty] – Default property ID.

[ipGeomImportCurvesToBeams] – Convert unreferenced curves to beam elements; either btTrue or
btFalse.

[ipGeomImportGroupsAs] – Geometry groups import; either ggNone or ggBodies.

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

Strand7 API Manual

Mode

Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
