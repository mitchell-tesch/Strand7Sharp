# St7GetPinnedLink

Returns the parameters for the specified pinned link.

long St7GetPinnedLink(long uID, long LinkNum, long* Connection)

Input Parameters

uID

Strand7 model file ID.

LinkNum

Link number.

Output Parameters

Connection[0..2]

[0] – Number of nodes in the link (2).

[1..2] – Node numbers.
