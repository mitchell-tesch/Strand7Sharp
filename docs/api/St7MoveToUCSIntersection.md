# St7MoveToUCSIntersection

Moves selected entities to the intersection of two coordinate systems.

long St7MoveToUCSIntersection(long uID, long UCSId1, long UCSId2,
double Ordinate1, double Ordinate2)
Input Parameters
uID
Strand7 model file ID.
UCSId1
ID of first coordinate system.
UCSId2
ID of second coordinate system.
Ordinate1
Ordinate in first coordinate system – if UCSId1 is Cartesian this is a Z ordinate. Otherwise, it is the
radius.
Ordinate2
Ordinate in second coordinate system – if UCSId2 is Cartesian this is a Z ordinate. Otherwise, it is the
radius.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
