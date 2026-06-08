# St7GetBeamNonlinearType

Returns the nonlinear material type assigned to the specified beam property.

long St7GetBeamNonlinearType(long uID, long PropNum, long* NonlinType,

long* YieldType)

Input Parameters

uID

Strand7 model file ID.

PropNum

Beam property number.

Strand7 API Manual

Output Parameters
NonlinType

Nonlinear material type; either ntNonlinElastic or ntElastoPlastic.

YieldType

One of ycBeamFibre, ycBeamTresca or ycBeamVonMises.
