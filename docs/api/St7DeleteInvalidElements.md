# St7DeleteInvalidElements

Deletes all elements marked as invalid from a Strand7 model.

long St7DeleteInvalidElements(long uID, long Entity, long* NumDeleted)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyBEAM, tyPLATE, tyBRICK or tyLINK.

Output Parameters
NumDeleted
Number of entities deleted.
