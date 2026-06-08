# St7GetLimitEnvelopeData

Returns the settings assigned to the specified limit envelope for the currently open solution.

long St7GetLimitEnvelopeData(long uID, long Envelope, long* EnvType,

char* EnvName, long MaxStringLen)

Input Parameters

uID

Strand7 model file ID.

Envelopes

Envelope

Limit envelope number.

MaxStringLen

Maximum number of characters allocated for EnvName.

Output Parameters

EnvType

One of etLimitEnvelopeAbs, etLimitEnvelopeMin, etLimitEnvelopeMax or etLimitEnvelopeMag.

EnvName

Name of the envelope.
