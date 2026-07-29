# St7GetMultiPointLinkReactionSum

Returns the reaction multi-point link force/moment result for structural solvers.

long St7GetMultiPointLinkReactionSum(long uID, long LinkNum, long UCSId,
long ResultCase, double* Reaction)
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
Output Parameters
Reaction[0..5]
[0..2] – Force components.
[3..5] – Moment components.
