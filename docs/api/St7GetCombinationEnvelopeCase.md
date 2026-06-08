# St7GetCombinationEnvelopeCase

Returns the state of the specified result case in a combination envelope for the currently open solution.

long St7GetCombinationEnvelopeCase(long uID, long Envelope, long CaseNum,

long* State)

Input Parameters

uID

Strand7 model file ID.

Envelope

Combination envelope number.

CaseNum

Result case number.

Output Parameters

State

One of esCombEnvelopeOn, esCombEnvelopeOff or esCombEnvelopeCheck.
