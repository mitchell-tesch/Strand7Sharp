# St7GetSRABaseCaseState

Returns the enabled state of the specified Base Excitation case for Spectral Response analysis.

Solver – Spectral Response

long St7GetSRABaseCaseState(long uID, long SRACase, bool* Enabled)

Input Parameters

uID

Strand7 model file ID.

SRACase

Spectral Response base excitation case number.

Output Parameters

Enabled

True if the case is enabled.
