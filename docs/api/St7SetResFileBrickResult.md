# St7SetResFileBrickResult

Sets the specified brick result quantities for a given brick element and result case in the custom result file.

long St7SetResFileBrickResult(long uID, long CaseNum, long BrickNum,
long Quantity, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Result case number.
BrickNum
Brick number.
Quantity
One of rtBrickStress, rtBrickStrain, rtBrickNodeReact, rtBrickFlux or rtBrickNodeFlux.
Doubles[..]
An array defining the specified brick result quantity at each Gauss point or node on the brick, depending
on the quantity. See Custom Results for additional information.
