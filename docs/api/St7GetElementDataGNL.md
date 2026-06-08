# St7GetElementDataGNL

Returns element specific geometric data for a given element for geometrically nonlinear results.

long St7GetElementDataGNL(long uID, long Entity, long EntityNum, long ResultCase,

double* EltData)

Input Parameters

uID

Strand7 model file ID.

Utility Functions

Entity

One of tyBEAM, tyPLATE, tyBRICK or tyLINK.

EntityNum

Entity number.

ResultCase

Result case number.

Output Parameters

EltData

Geometric data for the specified element:

tyBEAM – Beam deformed length; for curved pipe elements, the curved undeformed length; for cable
elements, the deformed cable length.

tyPLATE – Plate deformed area; for curved offset plates, the area considers the offset.

tyBRICK – Brick deformed volume.

tyLINK – For links with two nodes, the distance between the displaced nodes; for links with more than
two nodes, the sum of the distances between the displaced slave node and each displaced master node;
for attachment links, the distance between the displaced node and the attachment point on the
displaced target element.

Usage

A result file that includes geometric nonlinearity must be open when calling this function.  The data is
calculated based on the element deformation at an absolute displacement scale of 1 for the specified result
case.
