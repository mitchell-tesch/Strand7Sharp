# St7GetVertexMoment3

Returns the point moment assigned at the specified vertex. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetVertexMoment3(long uID, long VertexNum, long CaseNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
VertexNum
Vertex number.
CaseNum
Load case number.
Output Parameters
Doubles[0..2]
A 3-element array containing the force in the global XYZ system for the specified vertex.
