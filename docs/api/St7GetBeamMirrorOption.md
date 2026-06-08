# St7GetBeamMirrorOption

Returns the section mirror type for the specified beam property.

long St7GetBeamMirrorOption(long uID, long PropNum, long* MirrorType,

long* CompatibleTwist, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Properties – Beams, Plates and Bricks

PropNum

Beam property number.

Output Parameters
MirrorType

One of the section mirror types defined in Beam Cross Section Mirror Options.

CompatibleTwist

Compatible twist option for mirrored sections; either btTrue or btFalse.

Doubles[0..1]

A 2-element array containing the mirror gap parameters A and B respectively.
