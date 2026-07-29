# St7CreateSectorSymmetryLinkCluster

Creates a sector-symmetry links that couple nodes on angular planes.

long St7CreateSectorSymmetryLinkCluster(long uID, long Axis, double Plane1,
double Plane2, double RadialTol, double AngularTol)
Input Parameters
uID
Strand7 model file ID.
Axis
One of 1, 2 or 3 for the global X, Y or Z axis, respectively.
Plane1
Angle of first plane (degrees).
Plane2
Angle of second plane (degrees).
RadialTol
Radial tolerance.
AngularTol
Angular tolerance.
Dependencies
Default Group
Target group for the links is specified by St7SetDefaultGroupID.
