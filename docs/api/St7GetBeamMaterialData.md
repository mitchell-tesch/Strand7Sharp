# St7GetBeamMaterialData

Returns the material properties assigned to the specified beam property.

long St7GetBeamMaterialData(long uID, long PropNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

PropNum

Beam property number.

Output Parameters
Doubles[0..8]

[ipBeamModulus] – Modulus.

[ipBeamShear] – Shear modulus.

[ipBeamPoisson] – Poisson’s ratio.

[ipBeamDensity] – Density.

[ipBeamAlpha] – Thermal expansion coefficient.

[ipBeamViscosity] – Viscous damping coefficient.

[ipBeamDampingRatio] – Damping ratio.

[ipBeamConductivity] – Thermal conductivity coefficient.

[ipBeamSpecificHeat] – Specific heat coefficient.

Usage

Note that the values of [ipBeamShear] and [ipBeamPoisson] are those used by the solver, and take into
account the setting of St7SetBeamShearModulusMode.

The function can be called for all beam property types (i.e. btSpring, btCable, btTruss, btCutoff, btContact,
btBeam, btUser, btPipe and btConnection), although not all types support the full set of material parameters.
