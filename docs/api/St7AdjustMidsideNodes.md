# St7AdjustMidsideNodes

Adjusts the mid-side nodes of selected elements.

long St7AdjustMidsideNodes(long uID, bool MakeStraight)

Input Parameters

uID

Strand7 model file ID.

MakeStraight

True to move the mid-side node to the middle of the circle defined by the three original node positions.

False to move the mid-side node to the Cartesian average position.

Dependencies
Selection

Plates and bricks can be selected using functions in Entity Selection.

Keep Selected

Assigned using St7SetKeepSelect.
