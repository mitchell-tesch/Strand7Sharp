# St7SetSoilFluidOptions

Sets the soil/fluid options for the analysis. These parameters are only used for models containing soil or fluid
properties.

long St7SetSoilFluidOptions(long uID, long CaseNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Gravitational load case number.

Doubles[0..2]
[0] – Default fluid level.
[1] – Fluid mass density per unit volume.
[2] – Fluid bulk modulus.
