# St7SetBeamNonlinearMode

Sets the specified beam property to use either the Fibre Stress or the Moment-Curvature option for material
nonlinearity.

long St7SetBeamNonlinearMode(long uID, long PropNum, long Mode)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Mode
Either nmUseFibreStress or nmUseMomentCurvature.
