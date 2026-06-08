# St7GetNodeInitialVelocity3

Returns the initial velocity components assigned at the specified node. These initial conditions are used when
performing transient dynamic analysis. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetNodeInitialVelocity3(long uID, long NodeNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

NodeNum

Node number.

CaseNum

Load case number.

Output Parameters
Doubles[0..2]

A 3-element array describing the initial velocity for the specified node in the global XYZ system.

Node Attributes – Get
