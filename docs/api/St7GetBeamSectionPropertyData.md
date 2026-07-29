# St7GetBeamSectionPropertyData

Returns the beam section property data assigned to the specified beam property.

long St7GetBeamSectionPropertyData(long uID, long PropNum, long* Integers,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Output Parameters
Integers[0]
Number of length-wise integration slices.
Doubles[0..10]
[ipAREA] – Section area.
[ipI11] – Second moment of area about the principal 1 axis.
[ipI22] – Second moment of area about the principal 2 axis.
[ipJ] – Torsion constant.
[ipSL1] – Shear centre offset in the principal 1 axis direction.
[ipSL2] – Shear centre offset in the principal 2 axis direction.
[ipSA1] – Shear area in the principal 1 axis direction.
[ipSA2] – Shear area in the principal 2 axis direction.
[ipXBAR] – Centroid x coordinate.
[ipYBAR] – Centroid y coordinate.
[ipANGLE] – Principal axis 1 angle in radians w.r.t. the local section coordinates.
