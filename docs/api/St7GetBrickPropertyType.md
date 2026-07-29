# St7GetBrickPropertyType

Returns the material type for the specified brick property.

long St7GetBrickPropertyType(long uID, long PropNum, long* MaterialType)
Input Parameters
uID
Strand7 model file ID.
PropNum
Brick property number.
Output Parameters
MaterialType
One of mtNull, mtIsotropic, mtOrthotropic, mtAnisotropic, mtRubber, mtSoil or mtFluid.
