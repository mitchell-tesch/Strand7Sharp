# St7GetVertexRestraint6

Returns the restraint conditions assigned at the specified vertex. See also St7GetEntityAttributeSequenceCount
and St7GetEntityAttributeSequence.

long St7GetVertexRestraint6(long uID, long VertexNum, long CaseNum, long* UCSId,

long* Status, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

VertexNum

Vertex number.

CaseNum

Load case number.

Output Parameters

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

Status[0..5]

An array describing the restraint conditions for the six DoF at the specified vertex. Status[i-1] =
btTrue indicates that the ith DoF is restrained. The DoF are restrained according to the 123456 axis
convention in the specified UCS.

Doubles[0..5]

An array describing the enforced displacement conditions for the six DoF at the specified vertex.
Doubles[i-1] describes the displacement of the ith DoF according to the 123456 axis convention in
the specified UCS.
