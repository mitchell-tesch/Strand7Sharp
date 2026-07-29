# St7GetBeamReferenceAngle1

Returns the reference angle for the specified beam. This angle controls the local rotation of the beam cross
section about the 3-axis of the beam as per the beam local axis system definition. See Beam Local Coordinates for
additional information.

long St7GetBeamReferenceAngle1(long uID, long BeamNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
Output Parameters
Doubles[0]
The reference angle (degrees) used to align the principal axis system of the beam; see Beam Local
Coordinates.
