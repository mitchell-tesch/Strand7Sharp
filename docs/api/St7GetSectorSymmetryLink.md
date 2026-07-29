# St7GetSectorSymmetryLink

Returns the parameters for the specified sector-symmetry link.

long St7GetSectorSymmetryLink(long uID, long LinkNum, long* Axis,
long* Connection)
Input Parameters
uID
Strand7 model file ID.
LinkNum
Link number.
Output Parameters
Axis
Axis of symmetry in the global XYZ system; one of 1, 2 or 3.
Connection[0..2]
[0] – Number of nodes in the link (2).
[1..2] – Node numbers.
