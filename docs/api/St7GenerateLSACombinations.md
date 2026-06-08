# St7GenerateLSACombinations

Generate the secondary result cases for the linear load case combinations in a Strand7 model. The result file must
be open.

long St7GenerateLSACombinations(long uID, long* NumSecondary, long* WarningCode)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

Output Parameters
NumSecondary

Number of secondary result cases available.

WarningCode

Either wcLSACombineNoWarning if the operation was successful, or wcLSACombineInvalidSRA if the
combinations were generated but the specified spectral file was invalid.
