# St7SetTrussData

Sets the truss element parameters for the specified beam property.

long St7SetTrussData(long uID, long PropNum, long* Integers)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Integers[0..0]
[ipTrussIncludeTorsion] – Include torsion; either btTrue or btFalse.
