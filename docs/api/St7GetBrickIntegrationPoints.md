# St7GetBrickIntegrationPoints

Returns the number of integration (Gauss) points used by the solver along each intrinsic coordinate direction.

long St7GetBrickIntegrationPoints(long uID, long PropNum, long* Xi, long* Eta,
long* Zeta)
Input Parameters
uID
Strand7 model file ID.

PropNum
Brick property number.
Output Parameters
Xi
Number of integration points in the first intrinsic ordinate.
Eta
Number of integration points in the second intrinsic ordinate.
Zeta
Number of integration points in the third intrinsic ordinate.
