# St7ImportSTEP

Imports a geometry file in the STEP format.

long St7ImportSTEP(long uID, char* FileName, long* Integers, double* Doubles,
long Mode)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and name for the STEP file to be imported.
Integers[0..5]
[ipGeomImportProperty] – Default property ID.
[ipGeomImportGroupsAs] – Geometry groups import; either ggNone or ggAssemblies.
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
