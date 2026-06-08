# St7GetBeamResultArrayPos

Returns the specified beam results at a series of positions along the length of the beam.

long St7GetBeamResultArrayPos(long uID, long ResultType, long ResultSubType,
long BeamNum, long ResultCase, long NumStations, double* BeamPos,
long* NumColumns, double* BeamResult)

Input Parameters

uID

Strand7 model file ID.

ResultType

Beam result quantity; see Beam Results.

ResultSubType

Beam result sub-type; see Beam Results.

BeamNum

Beam number.

ResultCase

Result case number.

NumStations

Number of stations specified.

BeamPos[0..kMaxBeamResult-1]

[0..NumStations-1] – an array of positions along the beam measured from end 1. Positions vary
between zero and the length of the element, or between zero and one, depending on the mode set via
St7SetBeamResultPosMode.

Output Parameters
NumColumns

Number of result quantities returned at each station.

BeamResult[0..kMaxBeamResult-1]

[0..NumStations*NumColumns-1] – an array containing the beam results at each station.

The results are returned in blocks of length NumColumns with the start of the ith block for the ith station
at BeamResult[(i-1)*NumColumns].

See Beam Results for additional information.

Strand7 API Manual
