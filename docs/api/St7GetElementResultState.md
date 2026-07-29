# St7GetElementResultState

Returns element state information for the specified result case.

long St7GetElementResultState(long uID, long Entity, long EntityNum,
long ResultCase, long* State)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyBEAM, tyPLATE, tyBRICK or tyLINK.
EntityNum
Entity number.
ResultCase
Result case number.

Output Parameters
State[0..2]
A 3-element array containing status information.
[ipResStateActive] – btTrue if element is active, btFalse otherwise.
[ipResStateResults] – btTrue if results are available, btFalse otherwise.
[ipResStateBirthStage] – Entity birth stage at this result case.
