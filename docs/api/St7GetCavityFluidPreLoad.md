# St7GetCavityFluidPreLoad

Returns the pre load data for the specified cavity fluid layout, if it is of type Constant Bulk Modulus.

long St7GetCavityFluidPreLoad(long uID, long CavityID, long CaseNum, long*

PreType, double* Value)

Input Parameters

uID

Strand7 model file ID.

CavityID

Cavity fluid layout ID.

CaseNum

Load case number.

Output Parameters

PreType

Either plCavityPreStress or plCavityPreStrain.

Value

The pre load value.
