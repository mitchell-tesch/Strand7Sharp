# St7GenerateAdjacencyList

Returns an index to an adjacency list that can be used to efficiently find the elements connected to a node.

long St7GenerateAdjacencyList(long uID, long* Integers, long* AdjacencyIndex)
Input Parameters
uID
Strand7 model file ID.
Integers[0..6]
[ipAdjIncludeBeams] – Include beam elements in the adjacency list; either btTrue or btFalse.
[ipAdjIncludePlates] – Include plate elements in the adjacency list; either btTrue or btFalse.
[ipAdjIncludeBricks] – Include brick elements in the adjacency list; either btTrue or btFalse.
[ipAdjIncludeLinks] – Include links in the adjacency list; either btTrue or btFalse.
[ipAdjIncludeSelected] – Include selected elements in the adjacency list; either btTrue or btFalse.
[ipAdjIncludeUnselected] – Include unselected elements in the adjacency list; either btTrue or
btFalse.
[ipAdjIgnoreBeamRefN] – Ignore beam reference nodes in the adjacency list; either btTrue or
btFalse.
Output Parameters
AdjacencyIndex
Index pointer to a new adjacency list.
Usage
Any number of adjacency lists can be generated for a model. Once generated, adjacency lists remain static. If
the model is changed, the adjacency list is not automatically updated or invalidated; data can still be extracted
from the list, even though it may no longer reflect the model. To update an adjacency list, it must be freed
using St7FreeAdjacencyList and a new one generated using St7GenerateAdjacencyList. Adjacency lists are
automatically freed when the model is closed.
