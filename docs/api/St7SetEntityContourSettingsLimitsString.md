# St7SetEntityContourSettingsLimitsString

Sets the parameters accessible through Entity Display/Contour/Settings…/Limits in the GUI.

long St7SetEntityContourSettingsLimitsString(long uID, long Entity,

char* LimitsString)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE or tyBRICK.

LimitsString

String containing the user defined contour boundaries. Use St7GetListSeparatorCode to get the system’s
list separator character.
