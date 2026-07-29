# St7GetLTAMethod

Returns the integration method assigned for linear transient dynamic analysis.

long St7GetLTAMethod(long uID, long* Method)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
Method
Time integration method; either ltWilson or ltNewmark.
