# St7ConvertBeamsToLinks

Converts selected beams into links.

long St7ConvertBeamsToLinks(long uID, long LinkType, long LinkOption,

long CaseID)

Input Parameters

uID

Strand7 model file ID.

LinkType

One of ltMasterSlaveLink, ltPinnedLink, ltRigidLink or ltShrinkLink.

LinkOption

Additional information about the link, depending on the setting of LinkType:

ltMasterSlaveLink
ltPinnedLink
ltRigidLink
ltShrinkLink

– Bitmask of flags for the constrained degrees of freedom
– Not used
– Plane of action; one of rlPlaneXYZ,  rlPlaneXY,  rlPlaneYZ or rlPlaneZX
– Bitmask of flags for the constrained degrees of freedom

CaseID

For LinkType ltMasterSlaveLink and ltRigidLink, the UCS for the created links.

For LinkType ltShrinkLink, the freedom case that controls the shrink in a nonlinear analysis.

Dependencies
Selection

Beams can be selected using functions in Entity Selection.

Source Action

Assigned using St7SetSourceAction.

Keep Selected

Assigned using St7SetKeepSelect.
