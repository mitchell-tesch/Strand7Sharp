# St7AlignBeamAxisToVector

Aligns an axis of the selected beams with a given vector.

long St7AlignBeamAxisToVector(long uID, long BeamAxis, long BeamAxisType,
double AngleTol, double* Vector)
Input Parameters
uID
Strand7 model file ID.
BeamAxis
The 1 or 2 local beam axis to align.
BeamAxisType
Local beam axis type – axBeamLocal or axBeamPrincipal.
AngleTol
Angular tolerance providing the range over which the tools operates, from 0 and 90 degrees.
Vector[0..2]
Vector to align beams to in the global XYZ system.
Dependencies
Selection
Beams can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
