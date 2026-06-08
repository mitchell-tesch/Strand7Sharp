# St7GetPlateNonlinearType

Returns the nonlinear material type assigned to the specified plate property.

long St7GetPlateNonlinearType(long uID, long PropNum, long* NonlinType,

long* YieldType)

Input Parameters

uID

Strand7 model file ID.

PropNum

Plate property number.

Output Parameters
NonlinType

Nonlinear material type; either ntNonlinElastic or ntElastoPlastic.

YieldType

One of ycTresca, ycVonMises, ycMaxStress, ycMohrCoulomb or ycDruckerPrager.
