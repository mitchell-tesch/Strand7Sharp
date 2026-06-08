# St7GetNodeResultUCS

Returns the specified nodal result in a UCS.

long St7GetNodeResultUCS(long uID, long ResultType, long UCSId, long NodeNum,

long ResultCase, double* NodeResult)

Input Parameters

uID

Strand7 model file ID.

ResultType

Nodal result quantity; see Node Results.

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system. For ResultType=rtNodeReact,
UCSId = 0 refers to the coordinate system of the restraint attribute at the node.

NodeNum

Node number.

ResultCase

Result case number.

Output Parameters

NodeResult[0..5]

A 6-element array containing the nodal results. See Node Results for additional information.
