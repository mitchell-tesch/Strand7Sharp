# St7SetPlateEdgeTransverseShear1

Assigns a transverse shear stress to the specified plate edge. The shear stress acts normal to the plate surface at
its edge, in the local +z direction.

long St7SetPlateEdgeTransverseShear1(long uID, long PlateNum, long CaseNum,
long EdgeNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.

PlateNum
Plate number.
CaseNum
Load case number.
EdgeNum
Edge number; one of 1, 2, 3 or 4.
Doubles[0]
Transverse shear stress.
