# St7InsertLimitEnvelope

Inserts a new limit envelope at the specified position for the currently open solution.

long St7InsertLimitEnvelope(long uID, long Envelope, long EnvType, char* EnvName)
Input Parameters
uID
Strand7 model file ID.
Envelope
Limit envelope number.
EnvType
One of etLimitEnvelopeAbs, etLimitEnvelopeMin, etLimitEnvelopeMax or etLimitEnvelopeMag.
EnvName
Name of the envelope.
