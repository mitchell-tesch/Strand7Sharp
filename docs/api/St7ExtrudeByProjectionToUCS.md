# St7ExtrudeByProjectionToUCS

Extrudes selected entities by projection to the specified ordinate on a coordinate system.

long St7ExtrudeByProjectionToUCS(long uID, long UCSId, long UCSPlane,

double Ordinate)

Input Parameters

uID

Strand7 model file ID.

UCSId

UCS onto which projection will occur.  Cartesian, Cylindrical and Spherical coordinate systems can be
used.

UCSPlane

Plane of the UCS onto which projection will occur; one of 1, 2 or 3 for planes XY, YZ or ZX of Cartesian
coordinate systems.  Not applicable to Cylindrical and Spherical coordinate systems.

Ordinate

For Cartesian systems: The ordinate that locates the plane.  For example, the Y ordinate if a ZX plane is
used as the projection target.

For Cylindrical and Spherical systems: Radius.

Dependencies
Selection

Entities can be selected using functions in Entity Selection.

Property Increment

Assigned using St7SetPropertyIncrement.

Direction

Assigned by the most recent call to a function in Tools – Projection Direction.

Source Action

Assigned using St7SetSourceAction.

Tools – Extrude

Extrusion Targets

Assigned using St7SetExtrudeTargets.

Extrusion Flags

Assigned using St7SetExtrudeFlags.

Keep Selected

Assigned using St7SetKeepSelect.

Default Group

Target group for nodes extruded into beams is specified by St7SetDefaultGroupID; for other targets the
group is inherited.
