# St7SetPipeData

Sets the pipe element parameters for the specified beam property.

long St7SetPipeData(long uID, long PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Doubles[0..3]
[ipPipeFlexibility] – Flexibility factor.
[ipPipeFluidDensity] – Density of contained fluid.
[ipPipeOuterDiameter] – Outer diameter.
[ipPipeThickness] – Wall thickness.
