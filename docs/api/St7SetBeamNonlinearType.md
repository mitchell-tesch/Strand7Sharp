# St7SetBeamNonlinearType

Sets the nonlinear material type for the specified beam property.

long St7SetBeamNonlinearType(long uID, long PropNum, long NonlinType,

long YieldType)

Input Parameters

uID

Strand7 model file ID.

PropNum

Beam property number.

NonlinType

Nonlinear material type; either ntNonlinElastic or ntElastoPlastic.

YieldType

One of ycBeamFibre, ycBeamTresca or ycBeamVonMises.
