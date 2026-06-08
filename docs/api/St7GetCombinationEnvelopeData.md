# St7GetCombinationEnvelopeData

Returns the settings assigned to the specified combination envelope for the currently open solution.

Envelopes

long St7GetCombinationEnvelopeData(long uID, long Envelope, long* EnvType,

char* EnvName, long MaxStringLen)

Input Parameters

uID

Strand7 model file ID.

Envelope

Combination envelope number.

MaxStringLen

Maximum number of characters allocated for EnvName.

Output Parameters

EnvType

Combination envelope type; either etCombEnvelopeMin or etCombEnvelopeMax.

EnvName

Name of the envelope.
