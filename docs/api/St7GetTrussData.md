# St7GetTrussData

Returns the truss element parameters for the specified beam property.

long St7GetTrussData(long uID, long PropNum, long* Integers)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Output Parameters
Integers[0..0]
[ipTrussIncludeTorsion] – Include torsion; either btTrue or btFalse.
