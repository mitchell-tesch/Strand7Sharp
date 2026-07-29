# St7GetNodeResultEx

Returns the specified nodal result quantity in the global XYZ system. In addition to components, a number of
combined results may also be returned, depending on ResultType.

long St7GetNodeResultEx(long uID, long ResultType, long NodeNum, long ResultCase,
double* NodeResult)
Input Parameters
uID
Strand7 model file ID.
ResultType
Nodal result quantity; see Node Results.

NodeNum
Node number.
ResultCase
Result case number.
Output Parameters
NodeResult[0..13]
A 14-element array containing the nodal results. See Node Results for additional information.
