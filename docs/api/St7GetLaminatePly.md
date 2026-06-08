# St7GetLaminatePly

Returns the ply property and ply orientation assigned to the specified layer in a laminate.

Properties – Laminates

long St7GetLaminatePly(long uID, long LaminateID, long Pos, long* PlyPropNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

LaminateID

Laminate layout ID.

Pos

Ply position within the laminate.

Output Parameters
PlyPropNum

Ply property number.

Doubles[0..1]

[ipLaminatePlyAngle] – The angle (degrees) between the ply material 1 axis direction and the local
x axis of the plate element.

[ipLaminatePlyThickness] – Ply thickness. If zero, the thickness defined in the ply property is
used.
