# St7SetLaminatePly

Sets the ply property and ply orientation for the specified layer in a laminate.

long St7SetLaminatePly(long uID, long LaminateID, long Pos, long PlyPropNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
LaminateID
Laminate layout ID.
Pos
Ply position within the laminate.
PlyPropNum
Ply property number.
Doubles[0..1]
[ipLaminatePlyAngle] – The angle (degrees) between the ply material 1 axis direction and the local
x axis of the plate element.
[ipLaminatePlyThickness] – Ply thickness. If zero, the thickness defined in the ply property is
used.
