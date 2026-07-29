# St7CreateInterpolatedMultiPointLink

Creates an interpolated multi-point link cluster between selected nodes.

long St7CreateInterpolatedMultiPointLink(long uID, long Couple, long NodeNum)
Input Parameters
uID
Strand7 model file ID.
Couple
One of cpTranslational, cpRotational or cpBoth.
NodeNum
Slave node number, or 0 to create a new slave node at the average position of the selected nodes.
Dependencies
Selection
Nodes can be selected using functions in Entity Selection.

Default Group
Target group for the link is specified by St7SetDefaultGroupID.
