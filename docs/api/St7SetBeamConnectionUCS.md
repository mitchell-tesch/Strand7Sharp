# St7SetBeamConnectionUCS

Sets the UCS used in the connection element formulation at the specified beam end. The translational and
rotational stiffness components are distributed according to the 123 axis convention in the specified UCS. This
attribute is only applicable to beams of connection element type.

long St7SetBeamConnectionUCS(long uID, long BeamNum, long BeamEnd, long UCSId)
Input Parameters
uID
Strand7 model file ID.

BeamNum
Beam number.
BeamEnd
Beam end; either 1 or 2.
UCSId
ID number of the specified UCS. UCSId = 1 refers to the global XYZ system.
