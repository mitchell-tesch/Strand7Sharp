# St7GetElementData

Returns element specific geometric data for a given element.

long St7GetElementData(long uID, long Entity, long EntityNum, long ResultCase,

double* EltData)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE, tyBRICK or tyLINK.

EntityNum

Entity number.

ResultCase

Result case number – if greater than 0, it must be a valid result case; if less than 1, it is ignored.

Output Parameters

EltData

Geometric data for the specified element:

tyBEAM – Beam length; for curved pipe elements, the curved length; for cable elements, the cable
length.

tyPLATE – Plate area; for curved offset plates, the area considers the offset.

tyBRICK – Brick volume.

tyLINK – For links with two nodes, the distance between the nodes; for links with more than two nodes,
the sum of the distances between the slave node and each master node; for attachment links, the
distance between the node and the attachment point on the target element.

Usage

If a result file is open, EltData is based on the birth coordinates of the element for the specified result case (for
a staged analysis, birth coordinates can depend on the result case).  If a result file is not open, or ResultCase is
0, EltData is based on the initial position of the nodes.
