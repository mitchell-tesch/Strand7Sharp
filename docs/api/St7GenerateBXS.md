# St7GenerateBXS

Using the plate elements in the specified model, calculates and returns the BXS section properties, and saves BXS
file.

long St7GenerateBXS(long uID, char* BXSName, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BXSName

String containing the full path name of the BXS, for example, ‘C:\Users\My Name\Custom Section.bxs’.

Output Parameters

Doubles[0..38]

[ipBXSXBar] – Centroid x coordinate.

[ipBXSYBar] – Centroid y coordinate.

[ipBXSArea] – Section area.

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

Strand7 API Manual

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

Load and Freedom Cases

Load and Freedom Cases
