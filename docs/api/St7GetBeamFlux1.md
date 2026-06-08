# St7GetBeamFlux1

Returns the heat flux assigned to the specified beam. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetBeamFlux1(long uID, long BeamNum, long BeamEnd, long CaseNum,

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
Doubles[0]

The heat flux through the beam.
