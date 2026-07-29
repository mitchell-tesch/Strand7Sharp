# St7GetResFileBeamStations

Returns the number of result stations used to store beam results for the specified result case in the custom result
file.

long St7GetResFileBeamStations(long uID, long CaseNum, long* Stations)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Result case number.
Output Parameters
Stations
Number of result stations along the length of beam elements in the specified result case of the custom
result file.
