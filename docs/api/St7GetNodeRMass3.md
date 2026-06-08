# St7GetNodeRMass3

Returns the rotational mass components assigned to the specified node. Rotational masses are active in all load
and freedom cases.

Strand7 API Manual

long St7GetNodeRMass3(long uID, long NodeNum, long* UCSId, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

NodeNum

Node number.

Output Parameters

UCSId

ID number of the specified UCS.  UCSId = 1 refers to the global XYZ system.

Doubles[0..2]

A 3-element array defining the rotational mass for the node about the axes of the specified UCS.
