# St7GetBeamOffset2

Returns the offsets assigned to the specified beam.

Beam Attributes – Get

long St7GetBeamOffset2(long uID, long BeamNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

Output Parameters
Doubles[0..1]

A 2-element array describing the beam offsets in the principal 1-2 axis directions of the beam; see Beam
Local Coordinates.
