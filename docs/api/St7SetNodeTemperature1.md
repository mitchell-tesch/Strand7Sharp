# St7SetNodeTemperature1

Sets the temperature at the specified node.

long St7SetNodeTemperature1(long uID, long NodeNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

NodeNum

Node number.

CaseNum

Load case number.

Doubles[0]

 The nodal temperature value at the specified node.
