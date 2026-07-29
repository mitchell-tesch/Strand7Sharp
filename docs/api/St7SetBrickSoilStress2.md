# St7SetBrickSoilStress2

Assigns the in-situ soil stress for the specified brick. This attribute is only active for bricks of property type soil.

long St7SetBrickSoilStress2(long uID, long BrickNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
Doubles[0..1]
A 2-element array containing the initial vertical stress and the horizontal stress ratio.
