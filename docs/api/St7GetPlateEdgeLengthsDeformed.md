# St7GetPlateEdgeLengthsDeformed

Returns the edge lengths of the specified plate element for a result file with displacements.

long St7GetPlateEdgeLengthsDeformed(long uID, long PlateNum, long ResultCase,

double DispScale, double* Lengths)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

ResultCase

Result case number.

DispScale

The absolute scale to be applied to the node displacements.

Strand7 API Manual

Output Parameters
Lengths[0..3]

Up to four edge lengths.

Usage

A result file that produces displacements must be open when calling this function.  The lengths are then
calculated based on the scaled element deformation for the requested result case.
