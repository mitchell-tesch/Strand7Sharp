# St7SetBrickNonlinearType

Sets the nonlinear material type for the specified brick property.

long St7SetBrickNonlinearType(long uID, long PropNum, long NonlinType,

long YieldType)

Input Parameters

uID

Strand7 model file ID.

PropNum

Brick property number.

NonlinType

Nonlinear material type; either ntNonlinElastic or ntElastoPlastic.

YieldType

One of ycTresca, ycVonMises, ycMaxStress, ycMohrCoulomb or ycDruckerPrager.
