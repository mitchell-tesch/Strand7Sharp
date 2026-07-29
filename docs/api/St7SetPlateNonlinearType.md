# St7SetPlateNonlinearType

Sets the nonlinear material type for the specified plate property.

long St7SetPlateNonlinearType(long uID, long PropNum, long NonlinType,
long YieldType)
Input Parameters
uID
Strand7 model file ID.
PropNum
Plate property number.
NonlinType
Nonlinear material type; either ntNonlinElastic or ntElastoPlastic.
YieldType
One of ycTresca, ycVonMises, ycMaxStress, ycMohrCoulomb or ycDruckerPrager.
