# St7GetPlateSectionFactor10

Returns the factors for the specified plate. Each stiffness factor scales the corresponding row and column in the
stiffness matrix of the plate, while the mass factor scales the entire mass matrix of the plate.  Stiffness factors
apply only to linear elastic plates, while the mass factor applies to all plate types.

long St7GetPlateSectionFactor10(long uID, long PlateNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Output Parameters
Doubles[0..9]

[0] – Membrane stiffness factor Cxx.

[1] – Membrane stiffness factor Cyy.

[2] – Membrane shear stiffness factor Cgg.

[3] – Normal stiffness factor Czz for plane strain and axisymmetric plates.

[4] – Bending stiffness factor Dxx.

[5] – Bending stiffness factor Dyy.

[6] – Twisting stiffness factor Dgg.

[7] – Transverse shear stiffness factor Gxx.

[8] – Transverse shear stiffness factor Gyy.

[9] – Mass factor.
