# St7GetLoadPathTemplatePointForceData

Returns the point force data assigned to the specified load path template.

long St7GetLoadPathTemplatePointForceData(long uID, long TemplateID,
long Vehicle, long Pos, long* Integers, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
TemplateID
Load path template ID.
Vehicle
Vehicle number.
Pos
Point force number.

Output Parameters
Integers[0..3]
[ipLPTMobility] – Mobility; either lpPointForceMobilityGrouped or lpPointForceMobilityFloating.
[ipLPTAxisSystem] – Axis system; either lpAxisGlobal or lpAxisLocal.
[ipLPTAdjacency] – Consider adjacency; either btTrue or btFalse.
[ipLPTCentrifugal] – Consider centrifugal effects; either btTrue or btFalse.
Doubles[0..4]
[0..1] – XY position of the point force.
[2..4] – Components of the point force according to the 123 axis convention in the specified axis
system.
