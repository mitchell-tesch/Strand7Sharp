# St7GetVertexKDamping3F

Returns the translational damping coefficients assigned to the specified vertex. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

Strand7 API Manual

long St7GetVertexKDamping3F(long uID, long VertexNum, long CaseNum, long* UCSId,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

VertexNum

Vertex number.

CaseNum

Freedom case number.

Output Parameters

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

Doubles[0..2]

A 3-element array describing the damping factors for the specified vertex. Doubles[i-1] describes
the damping factor for the ith translational DoF according to the 123 axis definition in the specified UCS.
