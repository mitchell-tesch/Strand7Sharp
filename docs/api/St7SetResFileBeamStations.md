# St7SetResFileBeamStations

Sets the number of result stations used to store beam results for the specified result case in the custom result file.

long St7SetResFileBeamStations(long uID, long CaseNum, long Stations)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Result case number.

Stations

Number of result stations along the length of beam elements in the specified result case.

Note that only two stations (corresponding to the beam ends) are permitted for heat transfer results.

Usage

This function should be called once per result case in the custom result file, not once per beam element. The
set value applies to all beam elements in the model for the specified result case.
