# St7AlignBeamAxesToFramework

Aligns the selected beams with a notional surface that spans the beam framework.

long St7AlignBeamAxesToFramework(long uID, long BeamAxis, long BeamAxisType,
bool PositiveDir)
Input Parameters
uID
Strand7 model file ID.
BeamAxis
The 1 or 2 local beam axis to align.
BeamAxisType
Local beam axis type – axBeamLocal or axBeamPrincipal.
PositiveDir
True to align in the same direction as the normal to the notional surface.
Dependencies
Selection
Beams can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
