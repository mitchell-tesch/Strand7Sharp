# St7GetVertexNSMass5ID

Returns the non-structural mass assigned to the specified vertex. See also St7GetEntityAttributeSequenceCount
and St7GetEntityAttributeSequence.

long St7GetVertexNSMass5ID(long uID, long VertexNum, long CaseNum, long ID,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
VertexNum
Vertex number.
CaseNum
Load case number.
ID
Non-structural mass ID.
Output Parameters
Doubles[0..4]
[0] – Non-structural mass at the specified vertex.
[1] – Dynamic factor for the specified vertex. This factor is used to scale the non-structural mass when
performing dynamic analysis.
[2..4] – A 3-element array describing the offset in the global XYZ system.
