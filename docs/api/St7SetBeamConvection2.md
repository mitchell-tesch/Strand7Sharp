# St7SetBeamConvection2

Sets the thermal convection coefficient and ambient temperature for the specified beam. The convection is
assumed to occur uniformly over the cross section of the beam.

long St7SetBeamConvection2(long uID, long BeamNum, long BeamEnd, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

BeamNum

Beam number.

BeamEnd

Beam end; either 1 or 2.

CaseNum

Load case number.

Doubles[0..1]

[0] – Convection coefficient.

[1] – Ambient temperature.
