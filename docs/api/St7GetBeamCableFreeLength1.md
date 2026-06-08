# St7GetBeamCableFreeLength1

Returns the free cable length for the specified beam. This is the unstressed cable length and is only active for
beams of type cable.

long St7GetBeamCableFreeLength1(long uID, long BeamNum, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

BeamNum

Beam number.

Output Parameters
Doubles[0]

The free cable length.
