# St7GetBeamConvection2

Returns the thermal convection coefficient and ambient temperature assigned to the specified beam. The
convection is assumed to occur uniformly over the beam cross section. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

Beam Attributes – Get

long St7GetBeamConvection2(long uID, long BeamNum, long BeamEnd, long CaseNum,

double* Doubles)

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
Doubles[0..1]

[0] – Convection coefficient.

[1] – Ambient temperature.
