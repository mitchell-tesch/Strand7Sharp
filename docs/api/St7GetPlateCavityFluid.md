# St7GetPlateCavityFluid

Returns the cavity fluid layout assigned to a surface of the specified plate.

Plate Attributes – Get

long St7GetPlateCavityFluid(long uID, long PlateNum, long Surface,

long* CavityID)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Surface

Local plate surface; either psPlateMinusZ or psPlatePlusZ.

Output Parameters
CavityID

Cavity fluid layout ID.

Strand7 API Manual

Brick Attributes – Set
