# St7GetSoilFluidOptions

Returns the soil/fluid parameters assigned for the analysis. These parameters are only used for models containing
soil or fluid properties.

long St7GetSoilFluidOptions(long uID, long* CaseNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Output Parameters

CaseNum

Gravitational load case number.

Doubles[0..2]

[0] – Default fluid level.

[1] – Fluid mass density per unit volume.

[2] – Fluid bulk modulus.
