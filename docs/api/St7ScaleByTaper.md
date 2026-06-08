# St7ScaleByTaper

Scales the radius of selected node and elements in a spherical coordinate system.

long St7ScaleByTaper(long uID, long UCSId, long LineID, long Axis, double Scale1,

double Scale2)

Input Parameters

uID

Strand7 model file ID.

UCSId

The ID of a Cartesian coordinate system in which to scale.

LineID

The ID of a line along which the selected nodes and elements will be tapered.  Functions in Tools – Line
Definition are used to define a line and return the LineID.

Axis

Axis to taper: 1, 2 or 3 for X, Y or Z.

Scale1

Taper factor at start of line.

Scale2

Taper factor at end of line.

Tools – Scale

Dependencies
Selection

Entities can be selected using functions in Entity Selection.

Keep Selected

Assigned using St7SetKeepSelect.

Strand7 API Manual

Tools – Geometry
