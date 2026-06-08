# St7GetEntityContourSettingsLimitsString

Returns the parameters accessible through Entity Display/Contour/Settings…/Limits in the GUI.

long St7GetEntityContourSettingsLimitsString(long uID, long Entity,

char* LimitsString, long MaxStringLen)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE or tyBRICK.

Strand7 API Manual

MaxStringLen

Maximum number of characters allocated for LimitsString.

Output Parameters
LimitsString

String containing the user defined contour boundaries. Use St7GetListSeparatorCode to get the system’s
list separator character.
