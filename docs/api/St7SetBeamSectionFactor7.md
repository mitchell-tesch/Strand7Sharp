# St7SetBeamSectionFactor7

Sets the factors for the specified beam. Each stiffness factor scales the corresponding row and column in the
stiffness matrix of the beam, while the mass factor scales the entire mass matrix of the beam.  Stiffness factors
apply only to linear elastic beams, while the mass factor applies to all beam types.

long St7SetBeamSectionFactor7(long uID, long BeamNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

Strand7 API Manual

Doubles[0..6]

[0] – Shear stiffness factor plane 1.

[1] – Shear stiffness factor plane 2.

[2] – Axial stiffness factor.

[3] – Bending stiffness factor plane 1.

[4] – Bending stiffness factor plane 2.

[5] – Torsional stiffness factor.

[6] – Mass factor.
