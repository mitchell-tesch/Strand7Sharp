# St7SetCombinationEnvelopeData

Assigns the settings for the specified combination envelope for the currently open solution.

long St7SetCombinationEnvelopeData(long uID, long Envelope, long EnvType,

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
