# St7GetSRABaseCaseFactors

Returns the components of the direction vector assigned to the specified Spectral Response analysis Base
Excitation case.

long St7GetSRABaseCaseFactors(long uID, long SRACase, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

SRACase

Spectral Response base excitation case number.

Output Parameters
Doubles[0..2]

A 3-element array containing the direction vector in the global XYZ system.
