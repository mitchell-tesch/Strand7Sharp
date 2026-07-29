# St7SetPlateEdgePressure1

Assigns a normal pressure to the specified plate edge. The pressure is applied in the plane of the element,
perpendicular to the plate edge.

long St7SetPlateEdgePressure1(long uID, long PlateNum, long CaseNum,
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
Edge pressure for the specified plate edge, with positive pressures directed away from the plate.
