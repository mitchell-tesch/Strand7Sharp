# St7SetGeometryFaceNSMass5ID

Assigns a non-structural mass to the specified geometry face.

long St7SetGeometryFaceNSMass5ID(long uID, long FaceNum, long CaseNum, long ID,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
FaceNum
Face number.
CaseNum
Load case number.
ID
Non-structural mass ID.
Doubles[0..4]
[0] – Non-structural mass for the specified face.

[1] – Dynamic factor for the specified face. This factor is used to scale the non-structural mass when
performing dynamic analysis.
[2..4] – A 3-element array describing the offset in the global XYZ system.
