# St7GetLibraryBeamSectionPropertyDataBSL

Returns the values that define the geometry and properties of a cross section from the beam section library (BSL).

long St7GetLibraryBeamSectionPropertyDataBSL(long LibraryID, long ItemID,
long LengthUnit, char* ItemName, long MaxStringLen, long* ItemShape,
double* SectionData)

Input Parameters
LibraryID

Library ID.

ItemID

Item ID.

LengthUnit

One of luMETRE, luCENTIMETRE, luMILLIMETRE, luFOOT or luINCH.

MaxStringLen

The maximum number of characters allocated for ItemName.

Output Parameters
ItemName

Name of the item.

ItemShape

One of the section shapes defined in Beam Cross Section Shape.

SectionData[0..kNumBeamSectionData-1]

[ipAREA] – Section area.

[ipI11] – Second moment of area about the principal 1 axis.

[ipI22] – Second moment of area about the principal 2 axis.

[ipJ] – Torsion constant.

[ipSL1] – Shear centre offset in the principal 1 axis direction.

[ipSL2] – Shear centre offset in the principal 2 axis direction.

[ipSA1] – Shear area in the principal 1 axis direction.

Strand7 API Manual

[ipSA2] – Shear area in the principal 2 axis direction.

[ipXBAR] – Centroid x coordinate.

[ipYBAR] – Centroid y coordinate.

[ipANGLE] – Principal axis 1 angle in radians w.r.t. the local section coordinates.

[ipD1] – Section geometry D1 parameter; see Beam Cross Section Shape.

[ipD2] – Section geometry D2 parameter.

[ipD3] – Section geometry D3 parameter.

[ipT1] – Section geometry T1 parameter.

[ipT2] – Section geometry T2 parameter.

[ipT3] – Section geometry T3 parameter.

[ipGapA] – Mirrored section gap parameter A.

[ipGapB] – Mirrored section gap parameter B.
