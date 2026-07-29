# St7GetPlyPropertyResultsState

Determines if a ply is enabled for inclusion when extracting selected composite results. To access the results and
for additional information see St7GetPlateResultArray.

long St7GetPlyPropertyResultsState(long uID, long PropNum, bool* Enabled)
Input Parameters
uID
Strand7 model file ID.
PropNum
Ply property number.
Output Parameters
Enabled
True if the ply property is to be included in the results.
