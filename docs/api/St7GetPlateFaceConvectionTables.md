# St7GetPlateFaceConvectionTables

Returns the tables associated with convection coefficient assigned to the specified plate surface. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetPlateFaceConvectionTables(long uID, long PlateNum, long CaseNum,
long Surface, long* Tables)
Input Parameters
uID
Strand7 model file ID.
PlateNum
Plate number.
CaseNum
Load case number.
Surface
Local plate surface; either psPlateMinusZ or psPlatePlusZ.
Output Parameters
Tables[0..2]
[0] – Temperature vs Time table ID associated with the convection ambient temperature, or 0 for
none.
[1] – Factor vs Temperature table ID associated with the convection coefficient, or 0 for none.
[2] – Factor vs Time table ID associated with the convection coefficient, or 0 for none.
