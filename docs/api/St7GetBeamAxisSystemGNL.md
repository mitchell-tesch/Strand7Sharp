# St7GetBeamAxisSystemGNL

Returns the beam axis system for the specified beam element based on the absolute deformed node coordinates
at the requested result case for an analysis that considers geometric nonlinearity. See Beam Local Coordinates for
additional information.

Strand7 API Manual

long St7GetBeamAxisSystemGNL(long uID, long BeamNum, long ResultCase,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

ResultCase

Result case number.

Output Parameters
Doubles[0..8]

[0..2] – A unit vector in the global XYZ system, defining the 1-direction of the beam.

[3..5] – A unit vector in the global XYZ system, defining the 2-direction of the beam.

[6..8] – A unit vector in the global XYZ system, defining the 3-direction of the beam.
