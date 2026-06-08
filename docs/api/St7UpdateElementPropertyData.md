# St7UpdateElementPropertyData

Updates the display database used by the model window so that St7RedrawModel shows modifications made to
entities; e.g., changes to property colours, beam section dimensions, plate thickness, etc.

long St7UpdateElementPropertyData(long uID, long Entity, long PropNum)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

Entity

The property type; either ptBEAMPROP, ptPLATEPROP or ptBRICKPROP.

PropNum

The updated property number.
