# St7GetBeamRadius1

Returns the bend radius for the specified beam. This attribute is only active for beams of type pipe.

long St7GetBeamRadius1(long uID, long BeamNum, long* BeamDir, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
Output Parameters
BeamDir
The axis of the bend: axPrincipal1 or axPrincipal2. The beam will be bent in the axis direction specified,
not about the axis; see Beam Local Coordinates.
Doubles[0]
The radius of curvature of the bend.
