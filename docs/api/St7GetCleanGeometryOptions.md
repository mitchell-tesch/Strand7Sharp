# St7GetCleanGeometryOptions

Retrieves the current settings used when performing a geometry clean operation.

long St7GetCleanGeometryOptions(long uID, long* Integers, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
Integers[0..4]
[ipGeometryFeatureType] – Feature tolerance type; either ztRelative or ztAbsolute.
[ipGeometryActOnWholeModel] – If btTrue, perform clean on whole model. If btFalse, perform
clean on selected faces.
[ipGeometryFreeEdgesOnly] – Act on free edges only; either btTrue or btFalse.
[ipGeometryDuplicateFaces] – Duplicate face operation; one of dfLeaveAll, dfLeaveOne,
dfLeaveNone.
[ipGeometryWithinGroups] – If btTrue, geometry zipping occurs between faces in the same group.
If btFalse, geometry faces in different groups can also be zipped together.
Doubles[0..1]
[ipGeometryFeatureLength] – Geometry feature length.
[ipGeometryEdgeMergeAngle] – Merging angle for adjacent edges.
