# St7GetNodeKRotation3F

Returns the rotational stiffness components assigned to the specified node. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetNodeKRotation3F(long uID, long NodeNum, long CaseNum, long* UCSId,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
CaseNum
Freedom case number.
Output Parameters
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
Doubles[0..2]
A 3-element array describing the rotational stiffnesses for the specified node. Doubles[i-1] describes
the stiffness for the ith rotational DoF according to the 456 axis definition in the specified UCS.
