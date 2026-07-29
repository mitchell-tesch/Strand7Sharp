# St7SetResFileMode

Sets the frequency or buckling factor for the specified result case in the custom result file.

long St7SetResFileMode(long uID, long CaseNum, double Mode)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Result case number.
Mode
Mode frequency (Hz) for natural frequency results, or buckling factor for linear buckling results.
