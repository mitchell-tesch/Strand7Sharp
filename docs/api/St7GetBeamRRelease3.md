# St7GetBeamRRelease3

Returns the rotational end release conditions assigned to the specified beam.

long St7GetBeamRRelease3(long uID, long BeamNum, long BeamEnd, long* Status,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
BeamEnd
Beam end; either 1 or 2.
Output Parameters
Status[0..2]
Status[i-1] describes the release conditions of the specified beam end in the principal 1-3 axis
directions of the beam – one of brReleased, brFixed or brPartial for each direction. See Beam Local
Coordinates.
Doubles[0..2]
A 3-element array containing the partial stiffnesses to be used in the case of partial end release
conditions.
