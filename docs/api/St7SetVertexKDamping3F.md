# St7SetVertexKDamping3F

Assigns the translational damping coefficients for the specified vertex.

long St7SetVertexKDamping3F(long uID, long VertexNum, long CaseNum, long UCSId,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
VertexNum
Vertex number.
CaseNum
Load case number.
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

Doubles[0..2]
A 3-element array describing the damping factors for the specified vertex. Doubles[i-1] describes
the damping factor for the ith translational DoF according to the 123 axis definition in the specified UCS.
