# St7GetNodeNSMass5ID

Returns the non-structural mass assigned to the specified node. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetNodeNSMass5ID(long uID, long NodeNum, long CaseNum, long ID,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

NodeNum

Node number.

CaseNum

Load case number.

ID

The non-structural mass ID.

Output Parameters
Doubles[0..4]

[0] – The non-structural mass at the specified node.

[1] – The dynamic factor at the specified node. This factor is used to scale the non-structural mass
when performing dynamic analysis.

[2..4] – A 3-element array describing the offset in the global XYZ system.

Node Attributes – Get
