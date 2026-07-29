# St7RotatePlateConnections

Rotates the selected plate elements by reordering the nodes. This effectively swaps the A and B directions in
St7Subdivide.

long St7RotatePlateConnections(long uID, bool Clockwise)
Input Parameters
uID
Strand7 model file ID.
Clockwise
Rotation direction about the local z axis of the plate. True for clockwise; False for anti-clockwise.
Dependencies
Selection
Plates can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
