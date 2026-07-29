# St7InvalidateGeometryFaceCavityLoopID

Marks the specified cavity loop as invalid for subsequent deletion using the St7DeleteInvalidGeometry function.
This function uses the loop ID number to identify the appropriate loop.

long St7InvalidateGeometryFaceCavityLoopID(long uID, long FaceNum, long LoopNum)
Input Parameters
uID
Strand7 model file ID.
FaceNum
Face number.
LoopNum
The ID number of the loop to be marked for deletion.
