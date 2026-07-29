# St7GetResultSettingsLimitsString

Returns the parameters accessible through Results Settings/Settings…/Limits in the GUI.

long St7GetResultSettingsLimitsString(long uID, long Solver, long Entity,
long Quantity, char* LimitsString, long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
Solver
One of the solver types listed in Solver Types.
Entity
One of tyBEAM, tyPLATE, tyBRICK or tyLINK.
Quantity
One of the QUANTITY options listed in Result Display Options.
MaxStringLen
Maximum number of characters allocated for LimitsString.
Output Parameters
LimitsString
String containing the user defined contour boundaries. Use St7GetListSeparatorCode to get the system’s
list separator character.
