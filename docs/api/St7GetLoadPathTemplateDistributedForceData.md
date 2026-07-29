# St7GetLoadPathTemplateDistributedForceData

Returns the distributed force data assigned to the specified load path template.

long St7GetLoadPathTemplateDistributedForceData(long uID, long TemplateID,
long Vehicle, long Pos, long* Integers, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
TemplateID
Load path template ID.
Vehicle
Vehicle number.

Pos
Distributed force number.
Output Parameters
Integers[0..3]
[ipLPTMobility] – Mobility; one of lpDistrForceMobilityGrouped, lpDistrForceMobilityLeading,
lpDistrForceMobilityTrailing, lpDistrForceMobilityFullLength or lpDistrForceMobilityFloating.
[ipLPTAxisSystem] – Axis system; either lpAxisGlobal or lpAxisLocal.
[ipLPTAdjacency] – Consider adjacency; either btTrue or btFalse.
[ipLPTCentrifugal] – Consider centrifugal effects; either btTrue or btFalse.
Doubles[0..6]
[0..3] – Position of endpoints according to the [x1, x2, y1, y2] format.
[4..6] – Components of distributed force according to the 123 axis convention in the specified
coordinate system.
