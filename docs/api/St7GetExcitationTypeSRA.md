# St7GetExcitationTypeSRA

Returns the excitation type for the specified result case in the result file currently open.

long St7GetExcitationTypeSRA(long uID, long CaseNum, long* ExcitationType)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Spectral load case number.

Output Parameters

ExcitationType

One of slBaseAcc, slBaseVel, slBaseDisp or slAppliedLoad.

Applicability

Applicable to stSpectralResponse.
