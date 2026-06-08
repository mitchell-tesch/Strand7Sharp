# St7GetFactorsEnvelopeCaseData

Returns the settings assigned to the specified factors envelope case for the currently open solution.

Envelopes

long St7GetFactorsEnvelopeCaseData(long uID, long Envelope, long Pos,

long* Integers, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Envelope

Factors envelope number.

Pos

Factors envelope case number.

Output Parameters

Integers[0..1]

A 2-element array containing the result case number and set number for the factors envelope case
respectively.

Doubles[0..1]

A 2-element array containing the Factor1 and Factor2 values for the factors envelope case.
