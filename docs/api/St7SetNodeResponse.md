# St7SetNodeResponse

Assigns a response variable to the specified node.

long St7SetNodeResponse(long uID, long NodeNum, long CaseNum, long ResponseType,
long UCSId, long* Status)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
CaseNum
Load case number.
ResponseType
Type of response variable; either rvNodeDisplacement or rvNodeReaction.
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
Status[0..5]
A 6-element array describing the active DoFs for the response variable in the UCS axis system. Each
element may be set to btTrue or btFalse to enable or disable the corresponding DoF.
