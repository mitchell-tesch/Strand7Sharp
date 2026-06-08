# St7CreateEntityUCS

Creates User Coordinate Systems on selected entities.

long St7CreateEntityUCS(long uID, long CurvedPipeAxis, long BeamAxis,

long OriginLocation, bool OriginNode)

Input Parameters

uID

Strand7 model file ID.

CurvedPipeAxis

Target coordinate system type for curved pipe elements; either puCylindrical or puCartesian.

BeamAxis

Target coordinate system type for non pipe elements; either buPrincipal or buLocal.

OriginLocation

One of ulAtMin, ulAtMax or ulAtMean to locate the coordinate system at the minimum corner,
maximum corner or centre of the entity UCS bounding box.

OriginNode

True to create a node at the origin of the UCS.

Dependencies
Selection

Entities can be selected using functions in Entity Selection.

Keep Selected

Assigned using St7SetKeepSelect.

Tools – Create
