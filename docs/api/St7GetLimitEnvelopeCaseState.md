# St7GetLimitEnvelopeCaseState

Returns the enabled state of the specified result case in a limit envelope for the currently open solution. Only
results from enabled result cases are included in the envelope.

long St7GetLimitEnvelopeCaseState(long uID, long Envelope, long CaseNum,
bool* Enabled)
Input Parameters
uID
Strand7 model file ID.
Envelope
Limit envelope number.
CaseNum
Result case number.
Output Parameters
Enabled
True if the specified result case is enabled.
