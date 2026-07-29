# St7GetBeamSlices

Returns the number of straight line segments used to render curved beam elements.

long St7GetBeamSlices(long uID, long* Slices)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
Slices
The number of segments along a beam element in the range kMinSlices to kMaxSlices.
