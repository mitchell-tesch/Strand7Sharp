# St7GetCombinedLSACombinationFactor

Returns the multiplying factor for the specified case in a linear load case combination for user-generated .LSA
files.

long St7GetCombinedLSACombinationFactor(long uID, long Pos, long CaseNum,
double* Factor)
Input Parameters
uID
Strand7 model file ID.
Pos
Load case combination number.
CaseNum
Primary result case number.
Output Parameters
Factor
Factor value.

Harmonic Time Combination
Functions in this section are equivalent to manipulating CASES/Harmonic Time in the GUI. See Solver – Harmonic
Response for harmonic response configuration prior to the solve being launched.
