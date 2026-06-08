# St7SetLSACombinationFactor

Sets the multiplying factor for the specified case in a linear load case combination for solver-generated .LSA files.

long St7SetLSACombinationFactor(long uID, long LType, long Pos, long LoadCaseNum,

long FreedomCaseNum, double Factor)

Input Parameters

uID

Strand7 model file ID.

LType

Either ltLoadCase or ltSpectralCase.

Pos

Load case combination number.

LoadCaseNum

Load or Spectral case number.

Linear Load Case Combinations

FreedomCaseNum

Freedom case number.

Factor

Factor value.
