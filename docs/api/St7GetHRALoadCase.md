# St7GetHRALoadCase

Returns the harmonic load case factor, phase angle and frequency assigned to the specified load case. This option
is only used when the load type is set to Applied Load.

long St7GetHRALoadCase(long uID, long CaseNum, long* TableID, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Solver – Harmonic Response

CaseNum

Load case number.

Output Parameters

TableID

Factor vs Frequency/Period table ID, or 0 for none.

Doubles[0..2]

A 3-element array containing the load factor, the phase angle (degrees) and the frequency (Hz), for load
case CaseNum. Note that the frequency is only used in vs Time analyses.

Strand7 API Manual

Solver – Spectral Response
