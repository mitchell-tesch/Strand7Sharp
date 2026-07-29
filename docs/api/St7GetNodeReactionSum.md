# St7GetNodeReactionSum

Returns the force/moment sum of node reactions for structural solvers.

long St7GetNodeReactionSum(long uID, long UCSId, long ResultCase, double* Origin,
long NodeState, double* ReactionSum)
Input Parameters
uID
Strand7 model file ID.
UCSId
ID number of a UCS frame for the reaction results. UCSId = 1 refers to the global XYZ system.
ResultCase
Result case number.
Origin[0..2]
Origin position in global XYZ coordinates.

NodeState
Nodes to be included in the sum – either ssSelected or ssUnselected.
Output Parameters
ReactionSum[0..5]
[0..2] – Force components.
[3..5] – Moment components.
