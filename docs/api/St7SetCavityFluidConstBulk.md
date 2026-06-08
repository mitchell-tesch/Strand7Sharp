# St7SetCavityFluidConstBulk

Sets the cavity fluid type to Constant Bulk Modulus and assigns the data for the specified cavity fluid layout.

long St7SetCavityFluidConstBulk(long uID, long CavityID, long* Integers,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

CavityID

Cavity fluid layout ID.

Integers[0..4]

[ipCFColour] – Colour. See also RGB Colours.

[ipCFMultipleAsOne] – Either btTrue or btFalse; if btTrue, multiple volumes that reference the
cavity layout are assumed to be connected, otherwise they are assumed to be independent.

[ipCFAssembleStiffness] – One of cfNoK, cfApproximateK or cfCompleteK.

Strand7 API Manual

Doubles[0..1]

[ipCFBulkModulus] – Constant bulk modulus of cavity fluid.

[ipCFAlpha] – Thermal expansion coefficient of cavity fluid.
