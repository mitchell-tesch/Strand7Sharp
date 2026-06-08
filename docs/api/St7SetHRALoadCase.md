# St7SetHRALoadCase

Assigns a harmonic load case factor, phase angle and frequency to the specified load case. This option is only used
when the load type is set to Applied Load.

long St7SetHRALoadCase(long uID, long CaseNum, long TableID, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Load case number.

TableID

Factor vs Frequency/Period table ID, or 0 for none.

Doubles[0..2]

A 3-element array containing the load factor, the phase angle (degrees) and the frequency (Hz), for load
case CaseNum. Note that the frequency is only used in vs Time analyses.
