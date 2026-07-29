# St7SetPinnedLink

Assigns the parameters for the specified pinned link.

long St7SetPinnedLink(long uID, long LinkNum, long* Connection)
Input Parameters
uID
Strand7 model file ID.
LinkNum
Link number.
Connection[0..2]
[0] – Number of nodes in the link (2).
[1..2] – Node numbers.
Dependencies
Default Group
Target group for the link is specified by St7SetDefaultGroupID.
