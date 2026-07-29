# St7LoftBeams

Generates cross beams and/or surfaces of plates across a set of lofting planes.

long St7LoftBeams(long uID, long CrossBeamPropNum, long PlatePropNum,
long NumSteps, long NumSubSteps, bool MakeCrossBeams, bool MakePlates)
Input Parameters
uID
Strand7 model file ID.
CrossBeamPropNum
Beam property number for cross beams.
PlatePropNum
Plate property number for plates.

NumSteps
Number of steps in which to divide lofting beams.
NumSubSteps
Number of lofting plates to put in each step.
MakeCrossBeams
True to create lofting cross beams.
MakePlates
True to create lofting plates.
Dependencies
Selection
Beams can be selected using functions in Entity Selection.
