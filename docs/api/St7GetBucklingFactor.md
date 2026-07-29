# St7GetBucklingFactor

Returns the buckling factor for the specified mode in the result file currently open.

long St7GetBucklingFactor(long uID, long Mode, double* Fact)
Input Parameters
uID
Strand7 model file ID.
Mode
Result case/mode number.
Output Parameters
Fact
Buckling factor.
Applicability
Applicable to stLinearBuckling.
