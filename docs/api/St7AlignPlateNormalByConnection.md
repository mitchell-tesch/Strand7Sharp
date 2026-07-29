# St7AlignPlateNormalByConnection

Aligns the normals on selected and connected plate elements such that their normals are consistent with the
master element. The master element must be connected to the selected elements.

long St7AlignPlateNormalByConnection(long uID, long PlateNum)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Master element number.
Dependencies
Selection
Plates can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
