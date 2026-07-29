# St7AddLaminatePly

Adds a new ply to the specified laminate. The ply is appended to the end of the current laminate stack.

long St7AddLaminatePly(long uID, long LaminateID, long PlyPropNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
LaminateID
Laminate layout ID.
PlyPropNum
Ply property number.
Doubles[0..1]
[ipLaminatePlyAngle] – The angle (degrees) between the ply material 1 axis direction and the local
x axis of the plate element.
[ipLaminatePlyThickness] – Ply thickness. If zero, the thickness defined in the ply property is
used.
