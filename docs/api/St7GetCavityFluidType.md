# St7GetCavityFluidType

Returns the type of fluid contained in the specified cavity fluid layout.

long St7GetCavityFluidType(long uID, long CavityID, long* FluidType)
Input Parameters
uID
Strand7 model file ID.
CavityID
Cavity fluid layout ID.
Output Parameters
FluidType
Type of fluid contained in the cavity – either ftIdealGas or ftConstantBulkModulus.
