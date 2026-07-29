# St7ExportSTL

Exports the current Strand7 model as a STL file.

long St7ExportSTL(long uID, char* FileName, long* Integers, long Mode)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and name for the STL file to be created.
Integers[0..10]
[ipSTLExportFormat] – Format of file; either ieSTLText or ieSTLBinary.

[ipSTLExportGrouping] – Grouping of elements; one of ieSTLGroupByNone,
ieSTLGroupByEntityType or ieSTLGroupByGroups.
[ipSTLExportBeams] – Export beam elements; either btTrue or btFalse.
[ipSTLExportPlates] – Export plate elements; either btTrue or btFalse.
[ipSTLExportBricks] – Export brick faces; either btTrue or btFalse.
[ipSTLExportGeometryFaces] – Export geometry faces; either btTrue or btFalse
[ipSTLExportBeamsAs] – Export beams as either a section or solid; either ieBeamAsSection or
ieBeamAsSolid.
[ipSTLExportPlatesAs] – Export plates as either a surface or solid; either iePlateAsSurface or
iePlateAsSolid.
[ipSTLExportBeamOffsets] – Export Beam offsets; either btTrue or btFalse.
[ipSTLExportPlateOffsets] – Export Plate offsets; either btTrue or btFalse.
[ipSTLExportInternalBrickFaces] – One of ieSTLBrickFreeFaces, ieSTLBrickAllFaces or
ieSTLBrickGroupFreeFaces.
Mode
Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
