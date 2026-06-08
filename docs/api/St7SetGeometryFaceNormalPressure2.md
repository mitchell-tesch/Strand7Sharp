# St7SetGeometryFaceNormalPressure2

Assigns normal pressure attributes to the specified geometry face. Two pressures are specified, corresponding to
the normal pressure attributes eventually inherited by automeshed plates on their outer +z and -z surfaces.

long St7SetGeometryFaceNormalPressure2(long uID, long FaceNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

FaceNum

Face number.

CaseNum

Load case number.

Doubles[0..1]

[0] – Normal face pressure over the -Z surface of plates automeshed from the face.

[1] – Normal face pressure over the +Z surface of plates automeshed from the face.

Positive pressure is directed from the relevant plate surface into the plate.

Face Attributes – Set
