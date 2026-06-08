# St7CutElementsByPlane

Cuts selected beams and plates through a plane.

long St7CutElementsByPlane(long uID, long PlaneID, long EdgeTol,

long BeamPropNum, long PlatePropNum)

Input Parameters

uID

Strand7 model file ID.

PlaneID

The ID of a plane at which to cut beams and plates.  Functions in Tools – Plane Definition are used to
define a plane and return the PlaneID.

EdgeTol

Tolerance value from 0 to 40, to avoid creating nearly collapsed elements.  Defines how close a cut can
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
