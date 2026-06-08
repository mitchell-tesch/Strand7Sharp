# St7GetNodeResult

Returns the specified nodal result quantity in the global XYZ system.

long St7GetNodeResult(long uID, long ResultType, long NodeNum, long ResultCase,

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

NodeResult[0..5]

A 6-element array containing the nodal results. See Node Results for additional information.
