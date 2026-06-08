# St7InsertLaminatePly

Inserts a new ply at the specified position within a laminate.  Note that if a laminate is at the maximum stack
depth of 300 plies, inserting a new ply will cause the existing ply number 300 to be popped off the end of the
stack and removed from the laminate.

long St7InsertLaminatePly(long uID, long LaminateID, long Pos, long PlyPropNum,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

LaminateID

Laminate layout ID.

Pos

Ply position within laminate.

PlyPropNum

Ply property number.

Doubles[0..1]

[ipLaminatePlyAngle] – The angle (degrees) between the ply material 1 axis direction and the local
x axis of the plate element.

[ipLaminatePlyThickness] – Ply thickness. If zero, the thickness defined in the ply property is
used.
