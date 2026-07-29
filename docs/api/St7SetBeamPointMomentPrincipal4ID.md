# St7SetBeamPointMomentPrincipal4ID

Assigns point moment data for the specified beam element. The moment is defined in the principal axis system of
the beam.

long St7SetBeamPointMomentPrincipal4ID(long uID, long BeamNum, long CaseNum,
long ID, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
CaseNum
Load case number.
ID
Point moment ID.
Doubles[0..3]
[0..2] – The moment components in the principal axis system of the beam.
[3] – The relative length position at which the moment is applied; see Beam Local Coordinates.
