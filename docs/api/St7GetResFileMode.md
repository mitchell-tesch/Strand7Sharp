# St7GetResFileMode

Returns the frequency or buckling factor for the specified result case in the custom result file.

long St7GetResFileMode(long uID, long CaseNum, double* Mode)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Result case number.
Output Parameters
Mode
Mode frequency (Hz) for natural frequency results, or buckling factor for linear buckling results.
