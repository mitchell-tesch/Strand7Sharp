# St7GetLibraryBeamSectionPropertyDataBGL

Returns the properties of a cross section from the beam geometry library (BGL).

long St7GetLibraryBeamSectionPropertyDataBGL(long LibraryID, long ItemID,
long LengthUnit, char* ItemName, long MaxStringLen, double* Doubles)

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

Doubles[0..38]

[ipBXSXBar] – Centroid x coordinate.

[ipBXSYBar] – Centroid y coordinate.

[ipBXSArea] – Section area.

Material Property Libraries

[ipBXSI11] – Second moment of area about the principal 1 axis.

[ipBXSI22] – Second moment of area about the principal 2 axis.

[ipBXSAngle] – Angle between the local x and principal 1 axes.

[ipBXSZ11Plus] – Section modulus about the principal 1 axis for stress on the outer fibre in the
positive 2 axis direction.

[ipBXSZ11Minus] – Section modulus about the principal 1 axis for stress on the outer fibre in the
negative 2 axis direction.

[ipBXSZ22Plus] – Section modulus about the principal 2 axis for stress on the outer fibre in the
positive 1 axis direction.

[ipBXSZ22Minus] – Section modulus about the principal 2 axis for stress on the outer fibre in the
negative 1 axis direction.

[ipBXSS11] – Plastic modulus about the principal 1 axis.

[ipBXSS22] – Plastic modulus about the principal 2 axis.

[ipBXSPC1] – Principal 1 axis direction offset for centroid of principal plastic modulus.

[ipBXSPC2] – Principal 2 axis direction offset for centroid of principal plastic modulus.

[ipBXSr1] – Radius of gyration in the principal 1 axis direction.

[ipBXSr2] – Radius of gyration in the principal 2 axis direction.

[ipBXSSA1] – Shear area in the principal 1 axis direction.

[ipBXSSA2] – Shear area in the principal 2 axis direction.

[ipBXSSL1] – Shear centre offset in the principal 1 axis direction.

[ipBXSSL2] – Shear centre offset in the principal 2 axis direction.

[ipBXSIXX] – Second moment of area about the global X axis.

[ipBXSIYY] – Second moment of area about the global Y axis.

[ipBXSIXY] – Second moment of area coupling term in the global XY axes.

[ipBXSIxxL] – Second moment of area about the local x axis.

[ipBXSIyyL] – Second moment of area about the local y axis.

[ipBXSIxyL] – Second moment of area coupling term in the local xy axes.

[ipBXSZxxPlus] – Section modulus about the local x axis for stress on the outer fibre in the positive y
axis direction.

[ipBXSZxxMinus] – Section modulus about the local x axis for stress on the outer fibre in the
negative y axis direction.

[ipBXSZyyPlus] – Section modulus about the local y axis for stress on the outer fibre in the positive x
axis direction.

Strand7 API Manual

[ipBXSZyyMinus] – Section modulus about the local y axis for stress on the outer fibre in the
negative x axis direction.

[ipBXSSxx] – Plastic modulus about the local x axis.

[ipBXSSyy] – Plastic modulus about the local y axis.

[ipBXSPCx] – Local x axis direction offset for centroid of local plastic modulus.

[ipBXSPCy] – Local y axis direction offset for centroid of local plastic modulus.

[ipBXSrx] – Radius of gyration in the local x axis direction.

[ipBXSry] – Radius of gyration in the local y axis direction.

[ipBXSrdA] – Radius area integral.

[ipBXSJ] – Torsion constant.

[ipBXSIw] – Warping constant.
