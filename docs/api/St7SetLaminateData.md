# St7SetLaminateData

Sets the user-definable data for the specified laminate.

Properties – Laminates

long St7SetLaminateData(long uID, long LaminateID, long* Integers,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

LaminateID

Laminate layout ID.

Integers[0..1]

[ipLaminateIgnoreCoupling] – Coupled membrane/bending option; either btTrue or btFalse.

[ipLaminateAutoTransverseShear] – Automatic transverse shear calculation; either btTrue or
btFalse. If btTrue, the Doubles values are ignored and the transverse shear terms are automatically
calculated based on the laminate layup.

Doubles[0..2]

[0..2] – Transverse shear terms of the material stress-strain matrix Gxz, Gyz and Gcz respectively.
