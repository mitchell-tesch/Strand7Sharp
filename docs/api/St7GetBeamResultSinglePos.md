# St7GetBeamResultSinglePos

Returns the specified beam result at a single position along the length of the beam.

long St7GetBeamResultSinglePos(long uID, long ResultType, long ResultSubType,

long BeamNum, long ResultCase, double BeamPos, long* NumColumns,
double* BeamResult)

Input Parameters

uID

Strand7 model file ID.

ResultType

Beam result quantity; see Beam Results.

Results

ResultSubType

Beam result sub-type; see Beam Results.

BeamNum

Beam number.

ResultCase

Result case number.

BeamPos

The position along the beam measured from end 1. Positions vary between zero and the length of the
element, or between zero and one, depending on the mode set via St7SetBeamResultPosMode.

Output Parameters
NumColumns

Number of result quantities returned at the specified Position.

BeamResult[0..kMaxBeamResult-1]

[0..NumColumns-1] – a block of results at the specified Position.

See Beam Results for additional information.
