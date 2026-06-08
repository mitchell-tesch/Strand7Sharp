# St7SetSRABaseCaseFactors

Assigns the components of the direction vector for the specified Spectral Response analysis Base Excitation case.

long St7SetSRABaseCaseFactors(long uID, long SRACase, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

SRACase

Spectral Response base excitation case number.

Doubles[0..2]

A 3-element array containing the direction vector in the global XYZ system.
