# St7GetDampingType

Returns the type of damping assigned for the analysis.

long St7GetDampingType(long uID, long* DampType)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
DampType
One of dtNoDamping, dtRayleighDamping, dtModalDamping or dtPropertyDamping.
