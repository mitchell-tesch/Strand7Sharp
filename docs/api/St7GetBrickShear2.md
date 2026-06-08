# St7GetBrickShear2

Returns the shear stress assigned to the specified brick face. The shear stress acts in the plane of the face and is
constant over the surface. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

Strand7 API Manual

long St7GetBrickShear2(long uID, long BrickNum, long FaceNum, long CaseNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BrickNum

Brick number.

FaceNum

Local face number. See Brick Local Coordinates for additional information.

CaseNum

Load case number.

Output Parameters
Doubles[0..1]

A 2-element array describing the shear stress components in the local face xy axis system.  See Brick
Local Coordinates for details.
