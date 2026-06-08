# St7GetBeamConnectionUCS

Returns the UCS used to define the connection element formulation for the specified beam end. The translational
and rotational stiffness components are distributed according to the 123 axis convention in the specified UCS. This
attribute is only applicable to beams of connection element type.

Strand7 API Manual

long St7GetBeamConnectionUCS(long uID, long BeamNum, long BeamEnd, long* UCSId)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

BeamEnd

Beam end; either 1 or 2.

Output Parameters

UCSId

ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
