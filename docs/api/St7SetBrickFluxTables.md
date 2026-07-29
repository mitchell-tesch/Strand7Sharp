# St7SetBrickFluxTables

Sets the tables associated with the heat flux assigned to the specified brick face.

long St7SetBrickFluxTables(long uID, long BrickNum, long FaceNum, long CaseNum,
long* Tables)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
FaceNum
Local face number. See Brick Local Coordinates for additional information.
CaseNum
Load case number.
Tables[0..1]
[0] – Factor vs Time table ID associated with the heat flux, or 0 for none.
[1] – Factor vs Temperature table ID associated with the heat flux, or 0 for none.
