# St7SetPlateEdgeShear1

Assigns a shear stress to the specified plate edge. The shear stress is applied tangential to the plate edge.

long St7SetPlateEdgeShear1(long uID, long PlateNum, long CaseNum, long EdgeNum,
double* Doubles)
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
Shear stress.
