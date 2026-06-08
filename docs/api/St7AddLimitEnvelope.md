# St7AddLimitEnvelope

Adds a new limit envelope for the currently open solution.

long St7AddLimitEnvelope(long uID, long EnvType, char* EnvName)

Input Parameters

uID

Strand7 model file ID.

EnvType

One of etLimitEnvelopeAbs, etLimitEnvelopeMin, etLimitEnvelopeMax or etLimitEnvelopeMag.

EnvName

Name of the envelope.
