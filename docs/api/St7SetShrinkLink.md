# St7SetShrinkLink

Assigns the parameters for the specified shrink link.

Strand7 API Manual

long St7SetShrinkLink(long uID, long LinkNum, long* Connection, long* Integers)

Input Parameters

uID

Strand7 model file ID.

LinkNum

Link number.

Connection[0..2]

[0] – Number of nodes in the link (2).

[1..2] – Node numbers.

Integers[0..3]

[0] – btTrue to shrink in the global X direction.

[1] – btTrue to shrink in the global Y direction.

[2] – btTrue to shrink in the global Z direction.

[3] – Freedom case controlling the shrink factor when used in nonlinear analysis, or 0 to not set this
parameter.

Dependencies

Default Group

Target group for the link is specified by St7SetDefaultGroupID.
