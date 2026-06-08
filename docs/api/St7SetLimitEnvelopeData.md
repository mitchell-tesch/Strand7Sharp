# St7SetLimitEnvelopeData

Assigns the settings for the specified limit envelope for the currently open solution.

long St7SetLimitEnvelopeData(long uID, long Envelope, long EnvType,

char* EnvName)

Input Parameters

uID

Strand7 model file ID.

Envelope

Limit envelope number.

EnvType

One of etLimitEnvelopeAbs, etLimitEnvelopeMin, etLimitEnvelopeMax or etLimitEnvelopeMag.

EnvName

Name of the envelope.
