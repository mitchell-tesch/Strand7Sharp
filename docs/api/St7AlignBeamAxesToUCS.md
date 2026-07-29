# St7AlignBeamAxesToUCS

Aligns the local axes of selected beams to the axes of the specified UCS.

long St7AlignBeamAxesToUCS(long uID, long BeamAxis, long BeamAxisType,
long UCSAxis, long UCSId, double AngleTol, bool KeepEndAttributeLocation)
Input Parameters
uID
Strand7 model file ID.
BeamAxis
The 1, 2 or 3 local beam axis to align.
BeamAxisType
Local beam axis type – axBeamLocal or axBeamPrincipal.
UCSAxis
The 1, 2 or 3 UCS axis to align with. Valid values include ±1, ±2 or ±3.
UCSId
ID number of the UCS supplying the UCSAxis to align with. UCSId = 1 refers to the global XYZ system.
AngleTol
Angular tolerance providing the range over which the tools operates, from 0 and 90 degrees.

KeepEndAttributeLocation
If a beam element is flipped, exchange the end attributes such that the attributes stay in the same
physical position. Relevant if BeamAxis=3.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
