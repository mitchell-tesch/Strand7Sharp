# St7SetSectorSymmetryLink

Assigns the parameters for the specified sector-symmetry link.

long St7SetSectorSymmetryLink(long uID, long LinkNum, long Axis,

long* Connection)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

LinkNum

Link number.

Axis

Axis of symmetry in the global XYZ system; one of 1, 2 or 3.

Connection[0..2]

[0] – Number of nodes in the link (2).

[1..2] – Node numbers.

Dependencies

Default Group

Target group for the link is specified by St7SetDefaultGroupID.
