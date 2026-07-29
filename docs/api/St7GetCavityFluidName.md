# St7GetCavityFluidName

Returns the name assigned to the specified cavity fluid layout.

long St7GetCavityFluidName(long uID, long CavityID, char* LayoutName,
long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
CavityID
Cavity fluid layout ID.
MaxStringLen
Maximum number of characters allocated to LayoutName.
Output Parameters
LayoutName
Name of the layout.
