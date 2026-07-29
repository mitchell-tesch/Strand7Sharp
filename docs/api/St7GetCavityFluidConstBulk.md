# St7GetCavityFluidConstBulk

Returns the data assigned to the specified cavity fluid layout, if it is of type Constant Bulk Modulus.

long St7GetCavityFluidConstBulk(long uID, long CavityID, long* Integers,
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
Doubles[0..1]
[ipCFBulkModulus] – Constant bulk modulus of cavity fluid.
[ipCFAlpha] – Thermal expansion coefficient of cavity fluid.
