# St7SliceOnPlane

Cuts selected beams that pass through a plane, and inserts beams on plate edges that lie on the plane.

long St7SliceOnPlane(long uID, long PlaneID, long PropNum, long NumRepeats,

double Increment, bool DoBeams, bool DoPlates)

Input Parameters

uID

Strand7 model file ID.

PlaneID

The ID of a plane at which to slice.  Functions in Tools – Plane Definition are used to define a plane and
return the PlaneID.

PropNum

Property number of beam, if beams are being generated.

NumRepeats

Number of slices to make.

Increment

Distance between each slice.

DoBeams

True to cut selected beams if they pass through the slice plane.

DoPlates

True to create beams on selected plates that pass through the cutting plane.

Strand7 API Manual

Dependencies
Selection

Beams can be selected using functions in Entity Selection.

Keep Selected

Assigned using St7SetKeepSelect.
