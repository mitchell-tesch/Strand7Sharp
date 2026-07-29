# St7CopyByProjectionToEntityFace

Copies selected entities by projection to the faces of predefined entities.

long St7CopyByProjectionToEntityFace(long uID, long CollectionID)
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
Copy Flags
Assigned using St7SetCopyFlags.
Keep Selected
Assigned using St7SetKeepSelect.
