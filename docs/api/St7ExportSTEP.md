# St7ExportSTEP

Exports the current Strand7 geometry as a STEP format geometry file.

long St7ExportSTEP(long uID, char* FileName, long* Integers, long Mode)

Input Parameters

uID

Strand7 model file ID.

FileName

Full path and name for the STEP file to be created.

Integers[0..6]

[ipGeomExportColour] – Export colours; one of ieGeomColourNone, ieGeomFaceColour,
ieGeomGroupColour or ieGeomPropertyColour.

[ipGeomExportFullGroupPath] – Export the full group definition; either btTrue or btFalse.

[ipGeomExportFormatProtocol] – Export format; one of ieSTEPConfigControlDesign or
ieSTEPAutomotiveDesign.

[ipGeomExportCurve] – Export curves; one of ieGeomModelOnly, ieGeomParameterOnly,
ieGeomModelPreferred or ieGeomParameterPreferred.

[ipGeomExportPeriodicFace] – Periodic face control; one of ieGeomSeamOnlyAsRequired,
ieGeomSplitOnFaceBoundary or ieGeomSplitIntoHalves.

[ipGeomExportKeepAnalytic] – Export the analytic geometry definitions; either btTrue or btFalse.

Mode

Controls the display of a progress bar; either ieQuietRun or ieProgressRun.

Strand7 API Manual
