# St7GetResFileQuantityState

Returns the included/excluded state of an element result quantity in a given result case of the custom result file.

long St7GetResFileQuantityState(long uID, long CaseNum, long Entity,
long Quantity, bool* Included)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Result case number.
Entity
One of tyNODE, tyBEAM, tyPLATE or tyBRICK.
Quantity
Result quantity. See Custom Results for additional information.
Output Parameters
Included
True if the specified entity result quantity is included in the given result case of the custom result file.
