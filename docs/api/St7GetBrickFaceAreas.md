# St7GetBrickFaceAreas

Returns the face areas of the specified brick element.

long St7GetBrickFaceAreas(long uID, long BrickNum, long ResultCase,

double* Areas)

Input Parameters

uID

Strand7 model file ID.

BrickNum

Brick number.

ResultCase

Result case number – if greater than 0, it must be a valid result case; if less than 1, it is ignored.

Output Parameters
Areas[0..5]

Up to six face areas.

Usage

If a result file is open, Areas is based on the birth coordinates of the element for the specified result case (for a
staged analysis, birth coordinates can depend on the result case).  If a result file is not open, or ResultCase is 0,
Areas is based on the initial position of the nodes.
