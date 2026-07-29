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
[0..2] – Transverse shear terms of the material stress-strain matrix G , G and G respectively.
xz yz cz
[3..8] – Membrane terms of the material stress-strain matrix defined by the coefficients C , C , C ,
11 12 13
C , C and C respectively.
22 23 33

[9..14] – Bending terms of the material stress-strain matrix defined by the coefficients D , D , D ,
11 12 13
D , D and D respectively.
22 23 33
[15..23] – Coupling terms of the material stress-strain matrix defined by the coefficients B , B , B ,
11 12 13
B , B , B , B , B and B respectively.
21 22 23 31 32 33
