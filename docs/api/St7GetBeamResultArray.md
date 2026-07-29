# St7GetBeamResultArray

Returns the specified beam result quantity at several stations along the length of the beam. Additional stations
may be inserted to ensure that the maximum/minimum results are captured.

long St7GetBeamResultArray(long uID, long ResultType, long ResultSubType,
long BeamNum, long MinStations, long ResultCase, long* NumStations,
long* NumColumns, double* BeamPos, double* BeamResult)
Input Parameters
uID
Strand7 model file ID.
ResultType
Beam result quantity; see Beam Results.
ResultSubType
Beam result sub-type; see Beam Results.
BeamNum
Beam number.
MinStations
Minimum number of stations required.
ResultCase
Result case number.
Output Parameters
NumStations
Number of stations used.
NumColumns
Number of result quantities returned at each station.
BeamPos[0..kMaxBeamResult-1]
[0..NumStations-1] – an array of positions of the beam stations measured along the element from
end 1. Positions vary between zero and the length of the element, or between zero and one, depending
on the mode set via St7SetBeamResultPosMode.
BeamResult[0..kMaxBeamResult-1]
[0..NumStations*NumColumns-1] – an array containing the beam results at each station.

The results are returned in blocks of length NumColumns with the start of the ith block for the ith station
at BeamResult[(i-1)*NumColumns].
See Beam Results for additional information.
