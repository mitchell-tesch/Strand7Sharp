# St7SetResFileQuantity

Includes the specified result quantity in a given result case of the custom result file.

long St7SetResFileQuantity(long uID, long CaseNum, long Entity, long Quantity)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Result case number.

Entity

One of tyNODE, tyBEAM, tyPLATE or tyBRICK.

Quantity

Result quantity. See Custom Results for additional information.
