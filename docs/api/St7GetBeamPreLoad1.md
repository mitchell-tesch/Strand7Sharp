# St7GetBeamPreLoad1

Returns the pre-load assigned to the specified beam. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetBeamPreLoad1(long uID, long BeamNum, long CaseNum, long* LoadType,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
CaseNum
Load case number.
Output Parameters
LoadType
Either plBeamPreTension or plBeamPreStrain.
Doubles[0]
Pre-load value.
