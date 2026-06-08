# St7PlateHullVolume

Returns the volume enclosed by the selected plates.  If multiple enclosed volumes are present in the selection the
sum of all volumes is returned.  The selected plates must form a closed boundary surface around the region(s) for
which the volume is to be calculated.

long St7PlateHullVolume(long uID, long ResultCase, double* Volume)

Input Parameters

uID

Strand7 model file ID.

ResultCase

Either the result case number, or 0 for the undeformed hull volume.

Utility Functions

Output Parameters

Volume

The enclosed volume.

Dependencies
Selection

Plates can be selected using functions in Entity Selection.
