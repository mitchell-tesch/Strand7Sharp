# St7GetPropertyNumByIndex

Returns the property number associated with the specified property index. The property indices are stored
internally and are based on a contiguous numbering system.

long St7GetPropertyNumByIndex(long uID, long Entity, long PropIndex,

long* PropNum)

Input Parameters

uID

Strand7 model file ID.

Entity

One of ptBEAMPROP, ptPLATEPROP, ptBRICKPROP or ptPLYPROP.

PropIndex

Property index position.

Strand7 API Manual

Output Parameters

PropNum

Property number.
