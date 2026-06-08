# St7SetExtrudeTargets

Sets the parameters for the Target options for the extrusion tools.

long St7SetExtrudeTargets(long uID, long* Targets)

Input Parameters

uID

Strand7 model file ID.

Targets[0..6]

[ipExtrudeNodeTarget] – One of etBeam2, etBeam3, etMasterSlaveLink, etPinnedLink, etRigidLink
or etShrinkLink.

[ipExtrudeNodeTargetOption] – Additional information about the node extrusion target,
depending on the setting of [ipExtrudeNodeTarget].

etBeam2, etBeam3
etMasterSlaveLink
etPinnedLink
etRigidLink
etShrinkLink

– Beam property number.
– Bitmask of flags for the constrained degrees of freedom.
– Not used.
– Plane of action; one of rlPlaneXYZ,  rlPlaneXY,  rlPlaneYZ or rlPlaneZX.
– Bitmask of flags for the constrained degrees of freedom.

[ipExtrudeNodeTargetUCS] – UCS of extruded links.  If [ipExtrudeNodeTargetOption] is

etMasterSlaveLink, any UCS can be used.  If [ipExtrudeNodeTargetOption] is etRigidLink, a
Cartesian UCS must be used.

[ipExtrudeLinksAsMPL] – Used by St7ExtrudeByProjectionToPoint and
St7ExtrudeByProjectionToAveragePoint when [ipExtrudeNodeTargetOption] is one of
etMasterSlaveLink, etPinnedLink or etRigidLink.

Strand7 API Manual

btTrue – A single MPL is generated.

btFalse –  Multiple 2-node links are generated.

[ipExtrudeBeamTarget] – One of etPlateQuad4, etPlateQuad8 or etPlateQuad9.

[ipExtrudePlateTarget] – Additional option for the extrusion of plates.

ptFaceAsBrick – Plates are extruded into bricks.

ptEdgeAsPlate – Plate edges are extruded into plates.

[ipExtrudeShrinkFreedomCase] – Nonlinear control freedom case when

[ipExtrudeNodeTargetOption] is etShrinkLink.
