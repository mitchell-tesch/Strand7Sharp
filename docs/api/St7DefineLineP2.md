# St7DefineLineP2

Creates a new line definition using two points in the global XYZ system.

long St7DefineLineP2(long uID, double* P1, double* P2, long* LineID)
Input Parameters
uID
Strand7 model file ID.
P1[0..2]
Start point in global XYZ coordinates.
P2[0..2]
End point in global XYZ coordinates.
Output Parameters
LineID
Line identifier.

Tools – Plane Definition
Functions in this section create API plane definitions. These planes are referenced by other functions, for
example, to represent an extrusion target. API plane definitions do not correspond to plates or coordinate
systems in the model, are not visible to the user and no longer exist once the model is closed.
