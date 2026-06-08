# St7GetNodeMoment3

Returns the point moment applied at the specified node in the global XYZ system. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetNodeMoment3(long uID, long NodeNum, long CaseNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

NodeNum

Node number.

CaseNum

Load case number.

Output Parameters
Doubles[0..2]

A 3-element array describing the nodal moment in the global XYZ system.

Node Attributes – Get
