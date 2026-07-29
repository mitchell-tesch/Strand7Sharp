# St7MoveBySkew

Moves selected entities by a prescribed skew amount.

long St7MoveBySkew(long uID, double* Origin, double* Skew, long Axis)
Input Parameters
uID
Strand7 model file ID.
Origin[0..2]
Coordinates of the skew origin, in the global XYZ system.

Skew[0..2]
Amount of skew in global X, Y and Z respectively.
Axis
The axis in the global XYZ system to be skewed; one of 1, 2 or 3.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
