# St7GetBrickSoilType

Returns the soil type for a brick property assigned as a soil material.

long St7GetBrickSoilType(long uID, long PropNum, long* SoilType)

Input Parameters

uID

Strand7 model file ID.

PropNum

Brick property number.

Output Parameters
SoilType

One of stDuncanChang, stModifiedCamClay, stMohrCoulomb, stDruckerPrager or stLinearElastic.

Strand7 API Manual
