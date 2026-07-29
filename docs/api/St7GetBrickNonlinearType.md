# St7GetBrickNonlinearType

Returns the nonlinear material type assigned to the specified brick property.

long St7GetBrickNonlinearType(long uID, long PropNum, long* NonlinType,
long* YieldType)
Input Parameters
uID
Strand7 model file ID.
PropNum
Brick property number.
Output Parameters
NonlinType
Nonlinear material type; either ntNonlinElastic or ntElastoPlastic.
YieldType
One of ycTresca, ycVonMises, ycMaxStress, ycMohrCoulomb or ycDruckerPrager.
