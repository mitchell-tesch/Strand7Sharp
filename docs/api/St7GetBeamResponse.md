# St7GetBeamResponse

Returns the response variable assigned for the specified beam. Response variables are only used by the load
influence solver. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetBeamResponse(long uID, long BeamNum, long BeamEnd, long CaseNum,

long* Status)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

BeamEnd

Beam end; either 1 or 2.

CaseNum

Load case number.

Output Parameters
Status[0..5]

[ipBeamResponseSF1] – Shear force in the principal 1 axis direction; either btTrue or btFalse.

[ipBeamResponseSF2] – Shear force in the principal 2 axis direction; either btTrue or btFalse.

[ipBeamResponseAxial] – Axial force; either btTrue or btFalse.

[ipBeamResponseBM1] – Bending moment in the principal 1 axis direction; either btTrue or btFalse.

[ipBeamResponseBM2] – Bending moment in the principal 2 axis direction; either btTrue or btFalse.

[ipBeamResponseTorque] – Torque; either btTrue or btFalse.

Strand7 API Manual
