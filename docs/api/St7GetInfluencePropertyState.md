# St7GetInfluencePropertyState

Returns the included status of a property from load influence combinations.

long St7GetInfluencePropertyState(long uID, long Entity, long PropNum,

bool* Included)

Input Parameters

uID

Strand7 model file ID.

Entity

One of ptBEAMPROP, ptPLATEPROP or ptBRICKPROP.

PropNum

Property number.

Output Parameters
Included

True if the property is included.

Strand7 API Manual
