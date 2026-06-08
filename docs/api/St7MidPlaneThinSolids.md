# St7MidPlaneThinSolids

Extracts a mid-plane geometry from thin solids defined by a collection of faces.

long St7MidPlaneThinSolids(long uID, double NormalsTol)

Input Parameters

uID

Strand7 model file ID.

NormalsTol

Angular tolerance (degrees) – connected faces with angles between normals below this tolerance are
considered as being part of the same mid-planable surface. The edge of the mid-planed surface occurs
where a normal between adjacent faces exceeds this value. The normals are checked only at the
vertices of the edge.

Strand7 API Manual

Dependencies
Selection

Entities can be selected using functions in Entity Selection.

Source Action

Erase or keep the faces that define the solid, depending on St7SetSourceAction.

Keep Selected

Assigned using St7SetKeepSelect.

Global Parameters

ivFacesCreated, ivFacesDeleted
