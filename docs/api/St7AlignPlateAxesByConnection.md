# St7AlignPlateAxesByConnection

Aligns selected plates such that they have a consistently aligned local axes.

long St7AlignPlateAxesByConnection(long uID, long PlateNum, double MaxShearAngle)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Master plate element on which the alignment is based.
MaxShearAngle
Maximum shearing angle (degrees) to accept when double curvature leads to conflicting specifications
of plate local axes x and y.

Dependencies
Selection
Plates can be selected using functions in Entity Selection.
