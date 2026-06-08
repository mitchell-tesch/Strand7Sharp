# St7GetUCS

Returns the data for the specified UCS in a Strand7 model.

long St7GetUCS(long uID, long UCSId, long* UCSType, double* UCSDoubles)

Input Parameters

uID

Strand7 model file ID.

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.

Output Parameters

UCSType

One of csCartesian, csCylindrical, csSpherical or csToroidal.

UCSDoubles[0..kMaxUCSDoubles-1]

An array defining the UCS axis system; see Coordinate System Conventions.
