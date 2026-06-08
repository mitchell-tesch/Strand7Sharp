# St7GetSRALoadCaseState

Returns the enabled state of the specified Load Excitation case for Spectral Response analysis.

long St7GetSRALoadCaseState(long uID, long SRACase, bool* Enabled)

Input Parameters

uID

Strand7 model file ID.

SRACase

Spectral Response load excitation case number.

Output Parameters

Enabled

True if the case is enabled.
