# St7SetGeometryFaceConvectionTables

Sets the tables associated with the convection coefficient assigned to the specified geometry face surface.

long St7SetGeometryFaceConvectionTables(long uID, long FaceNum, long CaseNum,
long Surface, long* Tables)
Input Parameters
uID
Strand7 model file ID.
FaceNum
Face number.
CaseNum
Load case number.
Surface
Local plate surface; either psPlateMinusZ or psPlatePlusZ.

Tables[0..2]
[0] – Temperature vs Time table ID associated with the convection ambient temperature, or 0 for
none.
[1] – Factor vs Temperature table ID associated with the convection coefficient, or 0 for none.
[2] – Factor vs Time table ID associated with the convection coefficient, or 0 for none.
