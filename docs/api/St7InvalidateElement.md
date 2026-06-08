# St7InvalidateElement

Marks the specified element as invalid to be subsequently removed using the St7DeleteInvalidElements function.

long St7InvalidateElement(long uID, long Entity, long EntityNum)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE, tyBRICK or tyLINK.

EntityNum

Entity number.
