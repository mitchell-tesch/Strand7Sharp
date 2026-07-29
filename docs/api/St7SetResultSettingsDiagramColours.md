# St7SetResultSettingsDiagramColours

Sets the beam diagram colours accessible through Results Settings in the GUI.

long St7SetResultSettingsDiagramColours(long uID, long Solver, long* Integers)
Input Parameters
uID
Strand7 model file ID.
Solver
One of the solver types listed in Solver Types.
Integers[0..5]
[ipBeamSF1] – Shear force 1 and shear force x diagram colour.
[ipBeamBM1] – Bending moment 1 and bending moment x diagram colour.
[ipBeamSF2] – Shear force 2 and shear force y diagram colour.
[ipBeamBM2] – Bending moment 2 and bending moment y diagram colour.
[ipBeamAxialF] – Axial force diagram colour.
[ipBeamTorque] – Torque diagram colour.
