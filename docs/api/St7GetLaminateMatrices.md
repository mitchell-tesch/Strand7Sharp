# St7GetLaminateMatrices

Returns the material matrices for the specified laminate.

long St7GetLaminateMatrices(long uID, long LaminateID, long* Integers,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

LaminateID

Laminate layout ID.

Output Parameters

Integers[0..2]

[ipLaminateIgnoreCoupling] – Coupled membrane/bending option; either btTrue or btFalse.

[ipLaminateAutoTransverseShear] – Automatic transverse shear calculation; either btTrue or
btFalse.

[ipLaminateSingularMatrix] – Either btTrue or btFalse, depending on whether the laminate
matrix is singular or not.

Doubles[0..23]

[0..2] – Transverse shear terms of the material stress-strain matrix Gxz, Gyz and Gcz respectively.

[3..8] – Membrane terms of the material stress-strain matrix defined by the coefficients C11, C12, C13,
C22, C23 and C33 respectively.

Strand7 API Manual

[9..14] – Bending terms of the material stress-strain matrix defined by the coefficients D11, D12, D13,
D22, D23 and D33 respectively.

[15..23] – Coupling terms of the material stress-strain matrix defined by the coefficients B11, B12, B13,
B21, B22, B23, B31, B32 and B33 respectively.
