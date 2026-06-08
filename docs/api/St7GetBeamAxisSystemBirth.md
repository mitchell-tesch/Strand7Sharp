# St7GetBeamAxisSystemBirth

Returns the beam axis system for the specified beam element based on the node coordinates at the element’s
birth stage. The birth stage is determined from the requested result case. See Beam Local Coordinates for
additional information.

long St7GetBeamAxisSystemBirth(long uID, long BeamNum, long ResultCase,

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
