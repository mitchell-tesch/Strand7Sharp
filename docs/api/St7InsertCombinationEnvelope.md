# St7InsertCombinationEnvelope

Inserts a new combination envelope at the specified position for the currently open solution.

long St7InsertCombinationEnvelope(long uID, long Envelope, long EnvType,
char* EnvName)
Input Parameters
uID
Strand7 model file ID.
Envelope
Combination envelope number.
EnvType
Combination envelope type; either etCombEnvelopeMin or etCombEnvelopeMax.
EnvName
Name of the envelope.
