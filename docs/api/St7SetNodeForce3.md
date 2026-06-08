# St7SetNodeForce3

Sets the point force acting on the specified node in the global XYZ system.

long St7SetNodeForce3(long uID, long NodeNum, long CaseNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

NodeNum

Node number.

CaseNum

Load case number.

Doubles[0..2]

A 3-element array describing the nodal force in the global XYZ system.
