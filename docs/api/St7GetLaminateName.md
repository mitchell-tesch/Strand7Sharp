# St7GetLaminateName

Returns the name of the specified laminate.

long St7GetLaminateName(long uID, long LaminateID, char* LamName,
long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
LaminateID
Laminate layout ID.
MaxStringLen
Maximum number of characters allocated for LamName.
Output Parameters
LamName
Name of the laminate.
