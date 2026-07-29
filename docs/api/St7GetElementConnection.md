# St7GetElementConnection

Returns the connectivity information for the specified element.

long St7GetElementConnection(long uID, long Entity, long EntityNum,
long* Connection)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyBEAM, tyPLATE, tyBRICK or tyLINK.
EntityNum
Entity number; note that multi-point links are not supported.

Output Parameters
Connection[0..kMaxElementNode]
[0] – Number of nodes in the element.
[1..20] – Node numbers in the element.
See Element Connections for additional information.
