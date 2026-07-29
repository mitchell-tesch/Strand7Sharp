# St7AlignPlateAxesToUCS

Aligns the local axes of selected plates with the axis of the specified UCS.

long St7AlignPlateAxesToUCS(long uID, long PlateAxis, long UCSAxis, long UCSId,
double AngleTol)
Input Parameters
uID
Strand7 model file ID.
PlateAxis
The local x, y or z plate axis to align.
UCSAxis
The 1, 2 or 3 UCS axis to align with.
UCSId
ID number of the UCS supplying the UCSAxis to align with. UCSId = 1 refers to the global XYZ system.
AngleTol
Angular tolerance providing the range over which the tools operates, from 0 and 90 degrees.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
