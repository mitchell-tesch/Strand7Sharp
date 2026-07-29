# St7GetBXSLoopType

Returns the loop type of the specified loop. Each BXS has at least one outer loop. Strand7 supports multi-part
BXSs whereby each part has an outer loop.

long St7GetBXSLoopType(long uID, long PropNum, long LoopNum, long* LoopType)
Input Parameters
uID
Strand7 model file ID.
PropNum
The BXS property number.
LoopNum
The loop number.

Output Parameters
LoopType
One of ltUnknown, ltOuter or ltInner.
