# St7GetGeometryFaceCavityLoops

Returns the cavity loop numbers for the specified geometry face. Use St7GetNumGeometryFaceCavityLoops to
determine the number of cavity loops in the specified geometry face.

long St7GetGeometryFaceCavityLoops(long uID, long FaceNum, long MaxCavityLoops,
long* Integers)
Input Parameters
uID
Strand7 model file ID.
FaceNum
Face number.

MaxCavityLoops
Maximum amount of storage allocated for Integers. Returns all loops if set greater than or equal to
NumCavityLoops.
Output Parameters
Integers[0..MaxCavityLoops-1]
An array containing the cavity loop numbers for the specified face such that Integers[i-1] contains
the ith cavity loop number.
