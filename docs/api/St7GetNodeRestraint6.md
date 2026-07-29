# St7GetNodeRestraint6

Returns the restraint conditions assigned to the specified node. The UCS in which these restraints were applied is
also returned. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetNodeRestraint6(long uID, long NodeNum, long CaseNum, long* UCSId,
long* Status, double* Doubles)
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
Status[0..5]
A 6-element array describing the restraint conditions for the six DoF at the specified node. Status[i-
1] = btTrue indicates that the ith DoF is restrained. The DoF are restrained according to the 123456
axis convention in the specified UCS.

Doubles[0..5]
A 6-element array describing the enforced displacement conditions for the six DoF at the specified
node. Doubles[i-1] describes the displacement of the ith DoF according to the 123456 axis
convention in the specified UCS.
