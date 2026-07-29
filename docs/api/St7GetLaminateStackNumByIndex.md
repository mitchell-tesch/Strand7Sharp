# St7GetLaminateStackNumByIndex

Returns the laminate number associated with the specified laminate index. The laminate indices are stored
internally and are based on a contiguous numbering system.

long St7GetLaminateStackNumByIndex(long uID, long Index, long* LaminateID)
Input Parameters
uID
Strand7 model file ID.
Index
Laminate index.
Output Parameters
LaminateID
Laminate layout ID.
