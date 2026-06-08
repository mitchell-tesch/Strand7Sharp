# St7SetGeometryEdgeCluster

Sets the cluster type and ID on the edge.  After automeshing, all nodes along edges with the same cluster type and
ID are connected according to the parameters.

long St7SetGeometryEdgeCluster(long uID, long EdgeNum, long ClusterID,
long Entity, long EntityType, long OriginCode, double* Origin)

Input Parameters

uID

Strand7 model file ID.

EdgeNum

Edge number.

ClusterID

Cluster ID.

Entity

Either tyBEAM to create a beam cluster or tyLINK to create a multi-point link.

EntityType

For beams, the property number of beams to be created.

For links, one of ltInterpolatedMultiPointLink, ltMasterSlaveMultiPointLink, ltPinnedMultiPointLink or
ltRigidMultiPointLink.

OriginCode

Either coAutoClusterOrigin or coManualClusterOrigin.

Origin[0..2]

Origin position in global XYZ coordinates when OriginCode is coManualClusterOrigin.

Strand7 API Manual

Edge Attributes – Get
