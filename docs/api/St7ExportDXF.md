# St7ExportDXF

Exports the current Strand7 geometry as a DXF format geometry file.

long St7ExportDXF(long uID, char* FileName, long* Integers, long Mode)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and name for the DXF file to be created.
Integers[0..7]
[ipDXFExportPlatesBricks3DFaces] – Export plates and bricks as AutoCAD 3D faces; either
btTrue or btFalse.
[ipDXFExportGroupsAsLayers] – Export groups as AutoCAD layers; either btTrue or btFalse.
[ipDXFExportPropColoursAsEntityColours] – Export property colours as AutoCAD entity
colours; either btTrue or btFalse.
[ipDXFExportBeamsAs] – Beam element export; one of ieBeamAsLine, ieBeamAsSection or
ieBeamAsSolid.
[ipDXFExportPlatesAs] – Plate element export; either iePlateAsSurface or iePlateAsSolid.
[ipDXFExportBeamOffsets] – Position beam element at offset location; either btTrue or btFalse.
[ipDXFExportPlateOffsets] – Position plate element at offset location; either btTrue or btFalse.
[ipDXFExportInternalBrickFaces] – btTrue to export All Faces, or btFalse to export Free Faces.
Mode
Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
