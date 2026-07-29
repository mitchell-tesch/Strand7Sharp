# St7CutElementsByLine

Cuts selected beams and plates along a line.

long St7CutElementsByLine(long uID, long LineID, long EdgeTol, long BeamPropNum,
long PlatePropNum)
Input Parameters
uID
Strand7 model file ID.
LineID
The ID of a line at which the selected elements will be cut. Functions in Tools – Line Definition are used
to define a line and return the LineID.
EdgeTol
Tolerance value from 0 to 40, to avoid creating nearly collapsed elements. Defines how close a cut can
be to the end of an edge.
BeamPropNum
The property number of beams created on cut plate edges, or a negative number to not create beams.
PlatePropNum
The property number of plates created on cut brick faces edges, or a negative number to not create
plates.

Dependencies
Selection
Beam and plate elements can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
