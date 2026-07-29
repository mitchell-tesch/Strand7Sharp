# St7SetNodeTMass1

Sets the translational mass assigned to the specified node as a single value. Translational masses are active in all
load and freedom cases.

long St7SetNodeTMass1(long uID, long NodeNum, double Mass)
Input Parameters
uID
Strand7 model file ID.
NodeNum
Node number.
Mass
The translational mass at the node, which acts in all three global axes directions.
