# St7GetBrickConvectionTables

Returns the tables associated with the convection coefficient assigned to the specified brick face. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetBrickConvectionTables(long uID, long BrickNum, long FaceNum,

long CaseNum, long* Tables)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

BrickNum

Brick number.

FaceNum

Local face number. See Brick Local Coordinates for additional information.

CaseNum

Load case number.

Output Parameters
Tables[0..2]

[0] – Temperature vs Time table ID associated with the convection ambient temperature, or 0 for
none.

[1] – Factor vs Temperature table ID associated with the convection coefficient, or 0 for none.

[2] – Factor vs Time table ID associated with the convection coefficient, or 0 for none.
