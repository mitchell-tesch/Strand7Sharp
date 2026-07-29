# St7CopyByIncrement

Copies selected entities by increment.

long St7CopyByIncrement(long uID, double* DXYZ, long UCSId, long NumCopies)
Input Parameters
uID
Strand7 model file ID.
DXYZ[0..2]
Increment.
UCSId
UCS in which increment has been provided.
NumCopies
Number of copies.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Property Increment
Assigned using St7SetPropertyIncrement.
Copy Flags
Assigned using St7SetCopyFlags.
Keep Selected
Assigned using St7SetKeepSelect.
