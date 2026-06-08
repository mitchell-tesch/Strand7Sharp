# St7DetachElements

Detaches the selected cluster of elements from the rest of the mesh by duplicating nodes at the boundary and
optionally connecting the duplicated nodes with links or beams.

long St7DetachElements(long uID, long* Integers)

Input Parameters

uID

Strand7 model file ID.

Integers[0..5]

[ipDetachConnectionType] – One of ctNone, ctMasterSlaveLink or ctBeam2.

[ipDetachUCSId] – UCSId of the coordinate system in which Master-Slave links are defined.  Only
applicable if [ipDetachConnectionType] is ctMasterSlaveLink.

[ipDetachDoFBits] – Bitmask of flags for six degrees of freedom if Master-Slave links are created.  For
example, to couple DX, DY and RZ, set ConstraintBits = 1+2+32 = 35.

[ipDetachPropNum] – Property number of beams created at boundary.

Strand7 API Manual

[ipDetachUseElementGroup] – btTrue to assign the connecting links or beams to the same group as the
detached element; btFalse to assign the connecting links or beams to the default group.

[ipDetachDetectCorners] – btTrue to automatically detect unselected plate corners and unselected brick
edges within the selected edges and faces, respectively, and detach those as well.  This option is
necessary because a single corner of a triangle (for example) cannot be selected (only plate edges and
brick faces can be selected).

Dependencies
Selection

Elements can be selected using functions in Entity Selection.

Keep Selected

Assigned using St7SetKeepSelect.

Tools – Create

Tools – Create
