# St7SetBeamReferenceAngle1

Sets the reference angle for the specified beam. This angle controls the local rotation of the beam cross section
from the default orientation about the 3-axis of the beam. See Beam Local Coordinates for additional information.

long St7SetBeamReferenceAngle1(long uID, long BeamNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

Doubles[0]

The reference angle (degrees) used to align the beam principal axis system; see Beam Local Coordinates.
