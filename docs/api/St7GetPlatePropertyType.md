# St7GetPlatePropertyType

Returns the property type for the specified plate property.

long St7GetPlatePropertyType(long uID, long PropNum, long* PlateType,

long* MaterialType)

Input Parameters

uID

Strand7 model file ID.

PropNum

Plate property number.

Output Parameters
PlateType

One of ptNull, ptPlaneStress, ptPlaneStrain, ptAxisymmetric, ptPlateShell, ptShearPanel, ptMembrane
or ptLoadPatch.

MaterialType

One of mtNull, mtIsotropic, mtOrthotropic, mtAnisotropic, mtRubber, mtSoil, mtLaminate,
mtUserDefined or mtFluid.
