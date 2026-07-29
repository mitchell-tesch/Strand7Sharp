# St7GetCableData

Returns the cable element parameters for the specified beam property.

long St7GetCableData(long uID, long PropNum, long* Integers, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Output Parameters
Integers[0..0]
[ipCablePreStrainScalesMass] – btTrue for pre-strain to scale the cable mass.
Doubles[0..0]
[ipCableDiameter] – Cable diameter.
