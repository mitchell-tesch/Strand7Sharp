# St7SetBeamCableFreeLength1

Sets the free cable length for the specified beam. This is the unstressed cable length and is only active for beams
of type cable.

long St7SetBeamCableFreeLength1(long uID, long BeamNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

Doubles[0]

Cable free length.
