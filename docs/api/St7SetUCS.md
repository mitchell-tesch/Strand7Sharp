# St7SetUCS

Sets the data for the specified User Coordinate System (UCS) in a Strand7 model, or creates a UCS if the specified
UCSId does not exist.

long St7SetUCS(long uID, long UCSId, long UCSType, double* UCSDoubles)
Input Parameters
uID
Strand7 model file ID.
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
UCSType
One of csCartesian, csCylindrical, csSpherical or csToroidal.
UCSDoubles[0..kMaxUCSDoubles-1]
An array defining the UCS axis system; see Coordinate System Conventions.
