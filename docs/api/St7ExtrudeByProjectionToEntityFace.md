# St7ExtrudeByProjectionToEntityFace

Extrudes selected entities by projection to the faces of predefined entities.

long St7ExtrudeByProjectionToEntityFace(long uID, long CollectionID)

Input Parameters

uID

Strand7 model file ID.

CollectionID

The ID of a collection of entities returned by a previous call to St7DefineEntityCollection.

Dependencies
Selection

Entities can be selected using functions in Entity Selection.

Property Increment

Assigned using St7SetPropertyIncrement.

Direction

Assigned by the most recent call to a function in Tools – Projection Direction.

Source Action

Assigned using St7SetSourceAction.

Extrusion Targets

Assigned using St7SetExtrudeTargets.

Extrusion Flags

Assigned using St7SetExtrudeFlags.

Keep Selected

Assigned using St7SetKeepSelect.

Strand7 API Manual

Default Group

Target group for nodes extruded into beams is specified by St7SetDefaultGroupID; for other targets the
group is inherited.
