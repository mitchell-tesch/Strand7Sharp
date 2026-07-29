# St7ConvertBeamOffsetsToRigidLinks

Moves selected offset beams to their spatial locations, sets the offset attributes to zero, and connects the beams
to their original nodes via rigid links.

long St7ConvertBeamOffsetsToRigidLinks(long uID)
Input Parameters
uID
Strand7 model file ID.
Dependencies
Selection
Beams can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
