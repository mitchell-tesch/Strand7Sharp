# St7GetToolOptions

Returns the tool options assigned to the specified model.

long St7GetToolOptions(long uID, long* Integers, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
Integers[0..21]
[ipToolOptsElementTolType] – Element tolerance type; either ztAbsolute or ztRelative.
[ipToolOptsGeometryAccuracyType] – Geometry accuracy type; either ztAbsolute or ztRelative.
[ipToolOptsGeometryFeatureType] – Geometry feature length type; either ztAbsolute or
ztRelative.
[ipToolOptsZipMesh] – Mesh zipping; one of zmAsNeeded, zmOnSave or zmOnRequest.
[ipToolOptsNodeCoordinate] – New node coordinates; one of ncAverage, ncLowerNode,
ncHigherNode or ncSelectedNode.
[ipToolOptsNodeAttributeKeep] – Attribute keep; one of naLower, naHigher or naAccumulate.
[ipToolOptsAllowZeroLengthLinks] – Allow zero length links; either btTrue or btFalse.
[ipToolOptsAllowZeroLengthBeams] – Allow zero length beams; either btTrue or btFalse.
[ipToolOptsSubdivideBeams] – Subdivide only normal beams; either btTrue or btFalse.
[ipToolOptsInterpSideAttachments] – Interpolate beam side attachments when subdividing;
either btTrue or btFalse.
[ipToolOptsCompatibleTriangle] – Compatible triangle faces; either btTrue or btFalse.
[ipToolOptsAdjustMidsideNodes] – Automatically adjust midside nodes when subdividing; either
btTrue or btFalse.
[ipToolOptsEvaluateFormulas] – Automatically re-evaluate formulas when subdividing; either
btTrue or btFalse.
[ipToolOptsPlateAxisAlign] – Axis alignment; either paCentroid or paCurvilinear.

[ipToolOptsWedgeSubdivision] – Wedge subdivision option; either wsUseAB or wsUseAC.
[ipToolOptsCopyMode] – Copy mode; either cmRoot or cmSibling.
[ipToolOptsAutoCreateProperties] – Auto create new properties; either btTrue or btFalse.
[ipToolOptsInsertMPLNodes] – Add/remove nodes on Multi-Point links; either btTrue or btFalse.
[ipToolOptsConsiderDroopedCables] – Subdivide drooped cables based on the catenary shape;
either btTrue or btFalse.
[ipToolOptsConsiderBeam3] – Consider the third node of Beam3 elements; either btTrue or
btFalse.
Doubles[0..2]
[ipToolOptsElementTol] – Element zip tolerance.
[ipToolOptsGeometryAccuracy] – Geometry accuracy.
[ipToolOptsGeometryFeatureLength] – Geometry feature length.
