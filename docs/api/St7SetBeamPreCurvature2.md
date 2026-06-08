# St7SetBeamPreCurvature2

Sets the pre-curvature for the specified beam.

long St7SetBeamPreCurvature2(long uID, long BeamNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

CaseNum

Load case number.

Doubles[0..1]

A 2-element array describing the pre-curvature in the 1 and 2 directions of the beam principal axis
system; see Beam Local Coordinates.

Beam Attributes – Set
