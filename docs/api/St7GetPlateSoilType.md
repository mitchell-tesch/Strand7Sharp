# St7GetPlateSoilType

Returns the soil type for a plate property assigned as a soil material.

long St7GetPlateSoilType(long uID, long PropNum, long* SoilType)
Input Parameters
uID
Strand7 model file ID.
PropNum
Plate property number.
Output Parameters
SoilType
One of stDuncanChang, stModifiedCamClay, stMohrCoulomb, stDruckerPrager or stLinearElastic.
