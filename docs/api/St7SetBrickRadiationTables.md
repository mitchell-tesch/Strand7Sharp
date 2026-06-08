# St7SetBrickRadiationTables

Sets the tables associated with the radiation coefficient assigned to the specified brick face.

long St7SetBrickRadiationTables(long uID, long BrickNum, long FaceNum,

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

Tables[0..2]

[0] – Temperature vs Time table ID associated with the radiation ambient temperature, or 0 for none.

[1] – Factor vs Temperature table ID associated with the radiation coefficient, or 0 for none.

Brick Attributes – Set

[2] – Factor vs Time table ID associated with the radiation coefficient, or 0 for none.
