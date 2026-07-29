# St7DeleteLoadCase

Deletes the specified load case from the Strand7 model. Since load cases use contiguous numbering this will
cause all the following load case numbers to shift down by one.

long St7DeleteLoadCase(long uID, long CaseNum)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Load case number.
