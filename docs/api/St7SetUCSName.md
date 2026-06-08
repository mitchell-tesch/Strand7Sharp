# St7SetUCSName

Sets the name of the specified UCS in a Strand7 model.

long St7SetUCSName(long uID, long UCSId, char* UCSName)

Input Parameters

uID

Strand7 model file ID.

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system, which cannot be renamed.

UCSName

String containing the new name of the UCS.
