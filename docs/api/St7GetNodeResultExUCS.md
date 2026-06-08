# St7GetNodeResultExUCS

Returns the specified nodal result in a UCS. In addition to components, a number of combined results may also be
returned, depending on ResultType.

Results

long St7GetNodeResultExUCS(long uID, long ResultType, long UCSId, long NodeNum,

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

NodeResult[0..13]

A 14-element array containing the nodal results. See Node Results for additional information.
