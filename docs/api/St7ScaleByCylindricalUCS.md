# St7ScaleByCylindricalUCS

Scales selected entities by a cylindrical coordinate system.

long St7ScaleByCylindricalUCS(long uID, long UCSId, long ScaleAbout,
double* Factors, double* Point, double AngularCentre)
Input Parameters
uID
Strand7 model file ID.
UCSId
The cylindrical coordinate system in which to scale.

ScaleAbout
One of saMiddle, saOrigin or saPoint.
Factors[0..2]
Scaling factors in X, Y and Z respectively.
Point[0..2]
Global Cartesian coordinates of point about which to scale. Only applicable if ScaleAbout is saPoint.
AngularCentre
Angular origin about which to scale the Theta ordinates (degrees).
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
