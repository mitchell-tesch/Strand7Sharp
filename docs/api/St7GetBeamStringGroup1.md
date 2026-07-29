# St7GetBeamStringGroup1

Returns the ID number of the string group the specified beam is assigned to. The string group attribute is only
active for truss elements and will ensure that the axial force in all members is equal.

long St7GetBeamStringGroup1(long uID, long BeamNum, long* StringID)
Input Parameters
uID
Strand7 model file ID.

BeamNum
Beam number.
Output Parameters
StringID
The ID number of the string group.
