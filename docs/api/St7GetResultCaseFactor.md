# St7GetResultCaseFactor

Returns a context-dependent factor for the specified result case in the result file currently open.

long St7GetResultCaseFactor(long uID, long CaseNum, double* Factor)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Result case number.

Output Parameters

Factor

The value of this output depends on the analysis that produced the results file.

Linear Static Analysis – undefined.

Linear Buckling Analysis – buckling factor for mode CaseNum.

Load Influence Analysis – undefined.

Nonlinear Static Analysis – the fractional substep when CaseNum is a substep, otherwise 0 for complete
steps.

Linear Transient Dynamic Analysis – integration time at CaseNum.

Quasi-static Analysis – integration time at CaseNum.

Strand7 API Manual

Nonlinear Transient Dynamic Analysis – integration time at CaseNum.

Natural Frequency Analysis – undefined.

Harmonic Response Analysis – frequency (Hz) of applied load for CaseNum, when CaseNum is a
harmonic result case. When a harmonic time history is generated, it is the time at CaseNum.

Spectral Response Analysis – returns the natural frequency (Hz) of the mode from which the spectral
response arises when CaseNum is not combined:

-1.0 when CaseNum is an SRSS combination,
-2.0 when CaseNum is a CQC combination,
-3.0 when CaseNum has been generated as any other combination.

Steady Heat Analysis – undefined.

Transient Heat Analysis – integration time at CaseNum.
