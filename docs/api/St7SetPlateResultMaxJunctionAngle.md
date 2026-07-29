# St7SetPlateResultMaxJunctionAngle

Sets the maximum junction angle used when calculating averaged plate results.

long St7SetPlateResultMaxJunctionAngle(long uID, double MaxJunctionAngle,
bool Enabled)
Input Parameters
uID
Strand7 model file ID.
MaxJunctionAngle
Maximum allowable angle between adjacent plate surfaces.

Enabled
True to perform the angle check.
False to skip the angle check.
