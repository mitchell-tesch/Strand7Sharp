# St7SetPlatePropertyType

Sets the property type for the specified plate property.

long St7SetPlatePropertyType(long uID, long PropNum, long PlateType,
long MaterialType)
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
