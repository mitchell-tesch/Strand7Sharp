# St7CutElementsByUCS

Cuts selected beams and plates at a given radius.

Strand7 API Manual

long St7CutElementsByUCS(long uID, long UCSId, long EdgeTol, long BeamPropNum,

long PlatePropNum, double Radius)

Input Parameters

uID

Strand7 model file ID.

UCSId

The ID of a cylindrical or spherical UCS in which to cut the beams and plates.

EdgeTol

Tolerance value from 0 to 40, to avoid creating nearly collapsed elements.  Defines how close a cut can
be to the end of an edge.

BeamPropNum

The property number of beams created on cut plate edges, or a negative number to not create beams.

PlatePropNum

The property number of plates created on cut brick faces edges, or a negative number to not create
plates.

Radius

The radius at which to cut elements.

Dependencies
Selection

Beam and plate elements can be selected using functions in Entity Selection.

Keep Selected

Assigned using St7SetKeepSelect.
