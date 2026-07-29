# St7GetCouplingLink

Returns the parameters for the specified coupling link.

long St7GetCouplingLink(long uID, long LinkNum, long* Couple, long* Connection)
Input Parameters
uID
Strand7 model file ID.
LinkNum
Link number.
Output Parameters
Couple
One of cpTranslational, cpRotational or cpBoth.
Connection[0..3]
[0] – Number of nodes in the link (3).
[1..3] – Node numbers.
See Element Connections for additional information.
