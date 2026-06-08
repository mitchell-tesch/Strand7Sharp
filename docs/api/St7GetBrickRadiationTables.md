# St7GetBrickRadiationTables

Returns the tables associated with the radiation coefficient assigned to the specified brick face. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetBrickRadiationTables(long uID, long BrickNum, long FaceNum,

long CaseNum, long* Tables)

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
Tables[0..2]

[0] – Temperature vs Time table ID associated with the radiation ambient temperature, or 0 for none.

[1] – Factor vs Temperature table ID associated with the radiation coefficient, or 0 for none.

[2] – Factor vs Time table ID associated with the radiation coefficient, or 0 for none.
