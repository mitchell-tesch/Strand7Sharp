# St7GetResFileBeamReleaseResult

Returns the specified beam end release quantities for a given beam element and result case in the custom result
file.

long St7GetResFileBeamReleaseResult(long uID, long CaseNum, long BeamNum,

bool* BeamReleased, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Result case number.

BeamNum

Beam number.

Output Parameters

BeamReleased[0..kMaxBeamRelease-1]

An array containing the release status for the beam ends according to the local beam axis system for
translational and rotational DoF. See Custom Results for additional information.

Doubles[0..kMaxBeamRelease-1]

An array containing the displacement results for the released beam end DoF. See Custom Results for
additional information.
