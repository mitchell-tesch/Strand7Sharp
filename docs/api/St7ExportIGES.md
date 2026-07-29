# St7ExportIGES

Exports the current Strand7 geometry as an IGES format geometry file.

long St7ExportIGES(long uID, char* FileName, long* Integers, long Mode)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and name for the IGES file to be created.
Integers[0..6]
[ipGeomExportColour] – Export colours; one of ieGeomColourNone, ieGeomFaceColour,
ieGeomGroupColour or ieGeomPropertyColour.

[ipGeomExportGroupsAsLevels] – Export the groups as levels; either btTrue or btFalse.
[ipGeomExportFullGroupPath] – Export the full group definition; either btTrue or btFalse.
[ipGeomExportFormatProtocol] – Export format; one of ieIGESBoundedSurface,
ieIGESTrimmedParametricSurface, ieIGESOpenShell or ieIGESManifoldSolidBRep.
[ipGeomExportCurve] – Export curves; one of ieGeomModelOnly, ieGeomParameterOnly,
ieGeomModelPreferred or ieGeomParameterPreferred.
[ipGeomExportPeriodicFace] – Periodic face control; one of ieGeomSeamOnlyAsRequired,
ieGeomSplitOnFaceBoundary or ieGeomSplitIntoHalves.
[ipGeomExportKeepAnalytic] – Export the analytic geometry definitions; either btTrue or btFalse.
Mode
Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
