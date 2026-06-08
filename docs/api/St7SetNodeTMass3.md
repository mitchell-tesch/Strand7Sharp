# St7SetNodeTMass3

Sets the translational mass assigned to the specified node as three components. Translational masses are active in
all load and freedom cases.

long St7SetNodeTMass3(long uID, long NodeNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

NodeNum

Node number.

Doubles[0..2]

A 3-element array describing the translational mass for the node in the global XYZ directions.
