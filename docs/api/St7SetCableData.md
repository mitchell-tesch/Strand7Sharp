# St7SetCableData

Sets the cable element parameters for the specified beam property.

long St7SetCableData(long uID, long PropNum, long* Integers, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Integers[0..0]
[ipCablePreStrainScalesMass] – btTrue for pre-strain to scale the cable mass.

Doubles[0..0]
[ipCableDiameter] – Cable diameter.
