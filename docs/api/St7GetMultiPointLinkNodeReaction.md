# St7GetMultiPointLinkNodeReaction

Returns the force/moment results at nodes of the reaction multi-point link for structural solvers.

long St7GetMultiPointLinkNodeReaction(long uID, long LinkNum, long UCSId,
long ResultCase, double* Reaction, long MaxNodes)
Input Parameters
uID
Strand7 model file ID.
LinkNum
Link number.
UCSId
ID number of a UCS frame for the reaction results. UCSId = 1 refers to the global XYZ system. For non-
Cartesian systems, the origin of the UCS is the origin of the reaction multi-point link.
ResultCase
Result case number.
MaxNodes
The maximum number of nodes that can be stored in the Reaction array.
Output Parameters
Reaction[0..6*MaxNodes-1]
An array of doubles that stores the force/moment results for each node in the link, up to MaxNodes.
For example,
[0..2] – Force components for the first node in the link.
[3..5] – Moment components for the first node in the link.
[(i-1)*6..(i-1)*6+2] – Force components for the ith node in the link.
[(i-1)*6+3..(i-1)*6+5] – Moment components for the ith node in the link.
