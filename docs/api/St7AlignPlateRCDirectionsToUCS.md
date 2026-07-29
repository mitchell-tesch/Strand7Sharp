# St7AlignPlateRCDirectionsToUCS

Aligns the concrete reinforcement attribute of the selected plates.

long St7AlignPlateRCDirectionsToUCS(long uID, long RCLayers, long UCSAxis,
long UCSId, double AngleTol)
Input Parameters
uID
Strand7 model file ID.
RCLayers
Either raLayer13 for layers 1 and 3, or raLayer24 for layers 2 and 4.
UCSAxis
One of 1, 2 or 3 to specify coordinate system axis.
UCSId
Coordinate system identifier.
AngleTol
Angular tolerance.
Dependencies
Selection
Plates can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
