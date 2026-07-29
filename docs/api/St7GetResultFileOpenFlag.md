# St7GetResultFileOpenFlag

Returns show/hide state of certain types of result cases when opening a result file.

long St7GetResultFileOpenFlag(long uID, long Index, bool* State)
Input Parameters
uID
Strand7 model file ID.
Index
The types of result cases to show or hide; one of ipHideUnconvergedLBA, ipHideNegativeLBA,
ipHideUnconvergedNFA, ipHideZeroNFA, ipHideModalSRA, ipHideUnconvergedNLA, ipHideSubStepNLA,
ipHideUnconvergedNTA, ipHideSubStepNTA, ipHideUnconvergedQSA or ipHideSubStepQSA.
Output Parameters
State
True if the index is set, and therefore the result cases of the specified type are hidden.
