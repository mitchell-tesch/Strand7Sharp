# St7GetUserBeamData

Returns the user defined element property for the specified beam property.

long St7GetUserBeamData(long uID, long PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Beam property number.

Output Parameters

Doubles[0..21]

[0..20] – User defined material matrix K defined by the upper triangular matrix of coefficients Kij. See
User Defined Material Matrix for indexing.

Strand7 API Manual

[21] – Element mass.
