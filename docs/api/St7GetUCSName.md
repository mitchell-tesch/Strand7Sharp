# St7GetUCSName

Returns the name of the specified UCS in a Strand7 model.

long St7GetUCSName(long uID, long UCSId, char* UCSName, long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
MaxStringLen
The maximum number of characters allocated for UCSName.
Output Parameters
UCSName
String containing the name of the UCS.
