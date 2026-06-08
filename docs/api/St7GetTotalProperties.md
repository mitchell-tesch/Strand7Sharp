# St7GetTotalProperties

Returns the total number and highest property index for each of the Strand7 property types in the specified
model.

long St7GetTotalProperties(long uID, long* NumProperties, long* LastProperty)

Input Parameters

uID

Strand7 model file ID.

Output Parameters

NumProperties[0..kMaxEntityTotals-1]

[ipBeamPropTotal] – the total number of beam property types.

[ipPlatePropTotal] – the total number of plate property types.

[ipBrickPropTotal] – the total number of brick property types.

[ipPlyPropTotal] – the total number of ply property types.

LastProperty[0..kMaxEntityTotals-1]

[ipBeamPropTotal] – the highest beam property number.

[ipPlatePropTotal] – the highest plate property number.

[ipBrickPropTotal] – the highest brick property number.

[ipPlyPropTotal] – the highest ply property number.
