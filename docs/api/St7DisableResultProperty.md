# St7DisableResultProperty

Disables the specified property results for the analysis. Only element results corresponding to enabled properties
are written to the result file.

long St7DisableResultProperty(long uID, long Entity, long PropNum)

Input Parameters

uID

Strand7 model file ID.

Entity

One of ptBEAMPROP, ptPLATEPROP or ptBRICKPROP.

PropNum

Property number.
