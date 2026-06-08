# St7GetBrickFaceAreasDeformed

Returns the face areas of the specified brick element for a result file with displacements.

long St7GetBrickFaceAreasDeformed(long uID, long BrickNum, long ResultCase,

double DispScale, double* Areas)

Input Parameters

uID

Strand7 model file ID.

BrickNum

Brick number.

ResultCase

Result case number.

DispScale

The absolute scale to be applied to the node displacements.

Output Parameters
Areas[0..5]

Up to six face areas.

Usage

A result file that produces displacements must be open when calling this function.  The areas are calculated
based on the scaled element deformation for the requested result case.
