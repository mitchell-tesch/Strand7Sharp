# St7AlignBeam3AxisByConnection

Aligns selected beams such that they have a consistently aligned three axis.

long St7AlignBeam3AxisByConnection(long uID, bool KeepEndAttributeLocation)

Input Parameters

uID

Strand7 model file ID.

KeepEndAttributeLocation

If a beam element is flipped, exchange the end attributes such that the attributes stay in the same
physical position.

Dependencies
Selection

Beams can be selected using functions in Entity Selection.
