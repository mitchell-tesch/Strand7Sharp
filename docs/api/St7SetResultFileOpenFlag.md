# St7SetResultFileOpenFlag

Shows or hides certain types of result cases when opening a result file.

long St7SetResultFileOpenFlag(long uID, long Index, bool State)
Input Parameters
uID
Strand7 model file ID.
Index
The types of result cases to show or hide; one of ipHideUnconvergedLBA, ipHideNegativeLBA,
ipHideUnconvergedNFA, ipHideZeroNFA, ipHideModalSRA, ipHideUnconvergedNLA, ipHideSubStepNLA,
ipHideUnconvergedNTA, ipHideSubStepNTA, ipHideUnconvergedQSA or ipHideSubStepQSA.
State
True sets the index and therefore hides the result cases of the specified type.
False clears the index and therefore shows the result cases of the specified type.
