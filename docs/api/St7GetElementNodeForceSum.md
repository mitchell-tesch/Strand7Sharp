# St7GetElementNodeForceSum

Returns the force/moment contributions of element node forces at nodes for structural solvers.

long St7GetElementNodeForceSum(long uID, long UCSId, long ResultCase,
double* Origin, long* EntityState, double* ReactionSum)
Input Parameters
uID
Strand7 model file ID.
UCSId
ID number of a UCS frame for the reaction results. UCSId = 1 refers to the global XYZ system.
ResultCase
Result case number.
Origin[0..2]
Origin position in global XYZ coordinates.
EntityState[0..kMaxEntity-1]
[tyNODE] – Nodes for which the entity node force should be collected – either ssSelected or
ssUnselected.
[tyBEAM] – Beams that contribute element node force – either ssSelected or ssUnselected.
[tyPLATE] – Plates that contribute element node force – either ssSelected or ssUnselected.
[tyBRICK] – Bricks that contribute element node force – either ssSelected or ssUnselected.
[tyLINK] – Links that contribute element node force – either ssSelected or ssUnselected.
Output Parameters
ReactionSum[0..5]
[0..2] – Force components.
[3..5] – Moment components.
