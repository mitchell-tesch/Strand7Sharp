# St7GetModalResultsSRA

Returns the modal results for the specified result case in the result file currently open.

long St7GetModalResultsSRA(long uID, long CaseNum, long Mode,
double* ModalResult)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Spectral load case number.
Mode
Mode number.

Output Parameters
ModalResult[0..5]
[ipFrequencySRA] – Mode frequency (Hz).
[ipSpectralValueSRA] – Spectral table value.
[ipDampRatioSRA] – Damping ratio.
[ipExcitationSRA] – Excitation.
[ipAmplitudeSRA] – Amplitude.
[ipMassPartSRA] – Mass participation (percentage).
Applicability
Applicable to stSpectralResponse.
