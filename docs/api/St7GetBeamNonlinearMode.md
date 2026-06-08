# St7GetBeamNonlinearMode

Returns whether the specified beam property uses the Fibre Stress or the Moment-Curvature option for material
nonlinearity.

Strand7 API Manual

long St7GetBeamNonlinearMode(long uID, long PropNum, long* Mode)

Input Parameters

uID

Strand7 model file ID.

PropNum

Beam property number.

Output Parameters

Mode

Either nmUseFibreStress or nmUseMomentCurvature.
