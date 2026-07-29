# St7InsertFactorsEnvelope

Inserts a new factors envelope at the specified position for the currently open solution.

long St7InsertFactorsEnvelope(long uID, long Envelope, long EnvType,
char* EnvName)
Input Parameters
uID
Strand7 model file ID.

Envelope
Factors envelope number.
EnvType
Factors envelope type; either etFactEnvelopeMin or etFactEnvelopeMax.
EnvName
Name of the envelope.
