# St7CreatePlatesOnBricks

Creates plates on selected brick faces.

long St7CreatePlatesOnBricks(long uID, bool FreeFacesOnly, bool AllowDuplicates)

Input Parameters

uID

Strand7 model file ID.

FreeFacesOnly

True to create plates on selected free brick faces.

Strand7 API Manual

False to create plates on all selected brick faces.

AllowDuplicates

If True, two overlapping plates will be created when two selected brick faces share nodes. If False, only
a single plate is created when two selected brick faces share nodes.

Relevant only when FreeFacesOnly=False.

Dependencies
Selection

Brick faces can be selected using functions in Entity Selection.

Keep Selected

Assigned using St7SetKeepSelect.
