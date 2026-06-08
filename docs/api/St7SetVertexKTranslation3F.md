# St7SetVertexKTranslation3F

Assigns a translational stiffness to the specified vertex.

Vertex Attributes – Set

long St7SetVertexKTranslation3F(long uID, long VertexNum, long CaseNum,

long UCSId, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

VertexNum

Vertex number.

CaseNum

Freedom case number.

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

Doubles[0..2]

A 3-element array describing the translational stiffnesses for the specified vertex. Doubles[i-1]
describes the stiffness for the ith translational DoF according to the 123 axis definition in the specified
UCS.
