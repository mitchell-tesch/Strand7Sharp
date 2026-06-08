# St7GetBrickPreLoad3

Returns the pre-load conditions assigned to the specified brick. The pre-loads are defined in the local axis system
of the brick. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetBrickPreLoad3(long uID, long BrickNum, long CaseNum, long* LoadType,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BrickNum

Brick number.

CaseNum

Load case number.

Output Parameters
LoadType

plBrickPreStress or plBrickPreStrain.

Doubles[0..2]

A 3-element array describing the pre-load magnitudes according to the orientation of the local brick axis
system.

Strand7 API Manual
