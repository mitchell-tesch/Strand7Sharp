# St7GetBrickSoilRatio2

Returns the in-situ soil ratios for the specified brick. This attribute is only active for bricks of property type soil.

long St7GetBrickSoilRatio2(long uID, long BrickNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BrickNum

Brick number.

Output Parameters
Doubles[0..1]

A 2-element array containing the overconsolidation ratio and the initial void ratio.
