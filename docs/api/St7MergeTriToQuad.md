# St7MergeTriToQuad

Merges triangular plates into quadrilateral plates.

Tools – Merge

long St7MergeTriToQuad(long uID, double MinInternalAngle,
double MaxInternalAngle, double MaxNormalAngle)

Input Parameters

uID

Strand7 model file ID.

MinInternalAngle

Minimum internal angle (degrees); if a potential quad plate has an internal angle less than this, it will
not be generated.

MaxInternalAngle

Maximum internal angle (degrees); if a potential quad plate has an internal angle larger than this, it will
not be generated.

MaxNormalAngle

Maximum angular difference between tri plate normals; if the angle between normals of adjacent
triangles exceed this value, they will not be merged into a single quad plate.

Dependencies
Selection

Plates can be selected using functions in Entity Selection.

Strand7 API Manual

Tools – Convert
