# St7SetBeamPointMomentGlobal4ID

Assigns point moment data for the specified beam element. The moment is defined in the global XYZ system.

long St7SetBeamPointMomentGlobal4ID(long uID, long BeamNum, long CaseNum,
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
[0..2] – The moment components in the global XYZ system.
[3] – The relative length position at which the moment is applied; see Beam Local Coordinates.
