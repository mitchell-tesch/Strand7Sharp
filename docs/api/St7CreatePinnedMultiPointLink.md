# St7CreatePinnedMultiPointLink

Creates a pinned multi-point link.

long St7CreatePinnedMultiPointLink(long uID, long NodeNum)

Input Parameters

uID

Strand7 model file ID.

NodeNum

Slave node number, or 0 to create a new slave node at the average position of the selected nodes.

Dependencies
Selection

Nodes can be selected using functions in Entity Selection.

Tools – Create

Default Group

Target group for the links is specified by St7SetDefaultGroupID.
