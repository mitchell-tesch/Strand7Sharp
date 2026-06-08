# St7GetModalResultsHRA

Returns the modal results for the specified result case in the result file currently open.

long St7GetModalResultsHRA(long uID, long CaseNum, long Mode,

double* ModalResult)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Harmonic load case number.  For analyses in which multiple load cases do not apply, use 1.

Mode

Mode number.

Output Parameters

ModalResult[0..4]

[ipFrequencyHRA] – Mode frequency (Hz).

Strand7 API Manual

[ipDampRatioHRA] – Damping Ratio.

[ipAmplitudeHRA] – Amplitude.

[ipPhaseAngleHRA] – Phase angle (degrees).

[ipMassPartHRA] – Mass participation (percentage).

Applicability

Applicable to stHarmonicResponse.
