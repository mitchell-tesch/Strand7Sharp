# St7GetBeamPreCurvature2

Returns the pre-curvature assigned to the specified beam. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetBeamPreCurvature2(long uID, long BeamNum, long CaseNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
CaseNum
Load case number.
Output Parameters
Doubles[0..1]
A 2-element array describing the pre-curvature in the 1 and 2 directions of the principal axis system of
the beam; see Beam Local Coordinates.
