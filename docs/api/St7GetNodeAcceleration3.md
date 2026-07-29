# St7GetNodeAcceleration3

Returns the acceleration components assigned at the specified node. These acceleration values are not used as
initial conditions when performing transient analysis, rather, they are used to generate body forces when acting
on masses. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetNodeAcceleration3(long uID, long NodeNum, long CaseNum,
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
A 3-element array describing the acceleration of the specified node in the global XYZ system.
