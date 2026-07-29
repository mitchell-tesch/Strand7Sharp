# St7ScaleByCartesianUCS

Scales selected entities by a Cartesian coordinate system.

long St7ScaleByCartesianUCS(long uID, long UCSId, long ScaleAbout,
double* Factors, double* Point)
Input Parameters
uID
Strand7 model file ID.
UCSId
The Cartesian coordinate system in which to scale.
ScaleAbout
One of saMiddle, saOrigin or saPoint.
Factors[0..2]
Scaling factors in X, Y and Z respectively.
Point[0..2]
Global Cartesian coordinates of point about which to scale. Only applicable if ScaleAbout is saPoint.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
