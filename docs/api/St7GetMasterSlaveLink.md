# St7GetMasterSlaveLink

Returns the parameters for the specified master-slave link.

long St7GetMasterSlaveLink(long uID, long LinkNum, long* UCSId, long* Connection,
long* Integers)
Input Parameters
uID
Strand7 model file ID.
LinkNum
Link number.
Output Parameters
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
Connection[0..2]
[0] – Number of nodes in the link (2).
[1..2] – Node numbers.
Integers[0..5]
A 6-element array describing the relationship between each DoF in the linked nodes according to the
UCS axis system. Entries for each DoF may be one of msFree, msFix or msFixNegate.
