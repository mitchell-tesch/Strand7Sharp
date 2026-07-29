# St7NewPlateProperty

Creates a new plate property.

long St7NewPlateProperty(long uID, long PropNum, long PlateType,
long MaterialType, char* PropName)
Input Parameters
uID
Strand7 model file ID.
PropNum
Plate property number.
PlateType
One of ptPlaneStress, ptPlaneStrain, ptAxisymmetric, ptPlateShell, ptShearPanel, ptMembrane or
ptLoadPatch.
MaterialType
One of mtIsotropic, mtOrthotropic, mtAnisotropic, mtRubber, mtSoil, mtLaminate, mtUserDefined or
mtFluid.
PropName
Name of the plate property.
