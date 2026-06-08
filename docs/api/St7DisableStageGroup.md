# St7DisableStageGroup

Disables the specified group for a given stage. The elements in all groups enabled for a given stage will participate
in the solution once the specified stage becomes active.

long St7DisableStageGroup(long uID, long Stage, long GroupID)

Input Parameters

uID

Strand7 model file ID.

Stage

Stage index.

GroupID

The ID number for the group to be disabled for the specified stage.
