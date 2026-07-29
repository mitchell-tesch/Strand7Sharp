# St7GetCavityFluidIdealGas

Returns the data assigned to the specified cavity fluid layout, if it is of type Ideal Gas.

long St7GetCavityFluidIdealGas(long uID, long CavityID, long* Integers,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CavityID
Cavity fluid layout ID.
Output Parameters
Integers[0..4]
[ipCFColour] – Colour. See also RGB Colours.
[ipCFMultipleAsOne] – Either btTrue or btFalse; if btTrue, multiple volumes that reference the
cavity layout are assumed to be connected, otherwise they are assumed to be independent.
[ipCFConsiderTemperature] – Either btTrue or btFalse.
[ipCFPressureControlCase] – The load case number that controls the initial cavity pressure in
nonlinear analysis, or 0 for none.
[ipCFAssembleStiffness] – One of cfNoK, cfApproximateK or cfCompleteK.
Doubles[0..1]
[ipCFInitialPressure] – Initial pressure in cavity.
[ipCFInitialTemperature] – Initial temperature in cavity.
