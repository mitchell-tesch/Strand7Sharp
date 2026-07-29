# St7GetBeamAxisSystemInitial

Returns the beam axis system for the specified beam element based on the initial node coordinates. See Beam
Local Coordinates for additional information.

long St7GetBeamAxisSystemInitial(long uID, long BeamNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.

BeamNum
Beam number.
Output Parameters
Doubles[0..8]
[0..2] – A unit vector in the global XYZ system, defining the 1-direction of the beam.
[3..5] – A unit vector in the global XYZ system, defining the 2-direction of the beam.
[6..8] – A unit vector in the global XYZ system, defining the 3-direction of the beam.
