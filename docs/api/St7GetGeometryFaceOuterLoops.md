# St7GetGeometryFaceOuterLoops

Returns the outer loops in the specified geometry face, note that a geometry face may have one or two outer
loops only.

long St7GetGeometryFaceOuterLoops(long uID, long FaceNum, long* OuterLoops)
Input Parameters
uID
Strand7 model file ID.
FaceNum
Face number.
Output Parameters
OuterLoops[0..1]
[0] The loop number of the first outer loop.
[1] The loop number of the second outer loop, 0 if there is no such loop.
