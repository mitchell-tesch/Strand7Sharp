# St7GetGeometryFaceNSMass5ID

Returns the non-structural mass assigned to the specified geometry face. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

Strand7 API Manual

long St7GetGeometryFaceNSMass5ID(long uID, long FaceNum, long CaseNum, long ID,

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

Output Parameters
Doubles[0..4]

[0] – Non-structural mass for the specified face.

[1] – Dynamic factor for the specified face. This factor is used to scale the non-structural mass when
performing dynamic analysis.

[2..4] – A 3-element array describing the offset in the global XYZ system.
