# St7RepairTri3Mesh

Repairs meshes of selected Tri3 plate elements by removing sliver and slit elements that have internal angles less
than a set angular tolerance.  The tool is typically used to improve the geometry of imported STL files, particularly
when these need to be solid automeshed into tetrahedral elements.

long St7RepairTri3Mesh(long uID, double MaxAngle)

Input Parameters

uID

Strand7 model file ID.

MaxAngle

The maximum angle (degrees) allowed at the corners of a Tri3 element.  Elements with at least one
angle below this value will be collapsed and removed.  Surrounding elements will then be adjusted
and/or split to maintain the closed topology of the mesh.

Dependencies
Selection

Plates can be selected using functions in Entity Selection.

Keep Selected

Assigned using St7SetKeepSelect.
