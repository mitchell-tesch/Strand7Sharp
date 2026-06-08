# St7SetUserBeamData

Sets the user defined element parameters for the specified beam property.

long St7SetUserBeamData(long uID, long PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Beam property number.

Doubles[0..21]

[0..20] – User defined material matrix K defined by the upper triangular matrix of coefficients Kij. See
User Defined Material Matrix for indexing.

[21] – Element mass.
