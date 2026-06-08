# St7GetBrickFaceAreasGNL

Returns the face areas of the specified brick element for geometrically nonlinear results.

long St7GetBrickFaceAreasGNL(long uID, long BrickNum, long ResultCase,

double* Areas)

Input Parameters

uID

Strand7 model file ID.

BrickNum

Brick number.

Utility Functions

ResultCase

Result case number.

Output Parameters
Areas[0..5]

Up to six face areas.

Usage

A result file that includes geometric nonlinearity must be open when calling this function.  The areas are
calculated based on the element deformation at an absolute displacement scale of 1 for the specified result
case.
