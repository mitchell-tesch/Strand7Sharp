# St7GetFactorsEnvelopeData

Returns the settings assigned to the specified factors envelope for the currently open solution.

long St7GetFactorsEnvelopeData(long uID, long Envelope, long* EnvType,
char* EnvName, long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
Envelope
Factors envelope number.
MaxStringLen
Maximum number of characters allocated for EnvName.
Output Parameters
EnvType
Factors envelope type; either etFactEnvelopeMin or etFactEnvelopeMax.
EnvName
Name of the envelope.
