# St7GetBeamResultEndPos

Returns the specified beam result at the beam endpoints.

long St7GetBeamResultEndPos(long uID, long ResultType, long ResultSubType,

long BeamNum, long ResultCase, long* NumColumns, double* BeamResult)

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

Output Parameters
NumColumns

Number of result quantities returned at each endpoint.

BeamResult[0..kMaxBeamResult-1]

[0..NumColumns-1] – a block of results for End1.

[NumColumns..2*NumColumns-1] – a block of results for End2.

See Beam Results for additional information.
