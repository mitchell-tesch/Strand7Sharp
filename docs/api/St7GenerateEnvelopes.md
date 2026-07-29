# St7GenerateEnvelopes

Generate the secondary result cases for the result envelopes specified in the Strand7 model. The result file must
be open.

long St7GenerateEnvelopes(long uID, long* NumLimitEnvelopes,
long* NumCombinationEnvelopes, long* NumFactorsEnvelopes)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
NumLimitEnvelopes
Number of limit envelope results cases available.
NumCombinationEnvelopes
Number of combination envelope results cases available.
NumFactorsEnvelopes
Number of factors envelope results cases available.
