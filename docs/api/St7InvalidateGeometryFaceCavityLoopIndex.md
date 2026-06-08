# St7InvalidateGeometryFaceCavityLoopIndex

Marks the specified cavity loop as invalid for subsequent deletion using the St7DeleteInvalidGeometry function.
This function uses the loop index number to identify the appropriate loop.

long St7InvalidateGeometryFaceCavityLoopIndex(long uID, long FaceNum,

long LoopIndex)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

FaceNum

Face number.

LoopIndex

The index number of the loop to be marked for deletion.
