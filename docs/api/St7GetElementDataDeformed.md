# St7GetElementDataDeformed

Returns element specific geometric data for a given element for a result file with displacements.

long St7GetElementDataDeformed(long uID, long Entity, long EntityNum, long

ResultCase, double DispScale, double* EltData)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE, tyBRICK or tyLINK.

EntityNum

Entity number.

ResultCase

Result case number.

Strand7 API Manual

DispScale

The absolute scale to be applied to the node displacements.

Output Parameters

EltData

Geometric data for the specified element:

tyBEAM – Distance between the two displaced nodes, irrespective of beam type.

tyPLATE – Plate deformed area; for curved offset plates, the area considers the offset.

tyBRICK – Brick deformed volume.

tyLINK – For links with two nodes, the distance between the displaced nodes; for links with more than
two nodes, the sum of the distances between the displaced slave node and each displaced master node;
for attachment links, the distance between the displaced node and the attachment point on the
displaced target element.

Usage

A result file that produces displacements must be open when calling this function.  The data is calculated
based on the scaled element deformation for the requested result case.
