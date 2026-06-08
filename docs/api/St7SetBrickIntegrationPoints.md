# St7SetBrickIntegrationPoints

Sets the number of integration (Gauss) points used by the solver along each intrinsic coordinate direction.

long St7SetBrickIntegrationPoints(long uID, long PropNum, long Xi, long Eta,

long Zeta)

Input Parameters

uID

Strand7 model file ID.

PropNum

Brick property number.

Xi

Eta

Number of integration points in the first intrinsic ordinate; one of 1, 2 or 3.

Number of integration points in the second intrinsic ordinate; one of 1, 2 or 3.

Zeta

Number of integration points in the third intrinsic ordinate; one of 1, 2 or 3.
