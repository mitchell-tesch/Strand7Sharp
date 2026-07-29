# St7SetPlateFaceRadiationTables

Sets the tables associated with the radiation coefficient for the specified plate surface.

long St7SetPlateFaceRadiationTables(long uID, long PlateNum, long CaseNum,
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

Tables[0..2]
[0] – Temperature vs Time table ID associated with the radiation ambient temperature, or 0 for none.
[1] – Factor vs Temperature table ID associated with the radiation coefficient, or 0 for none.
[2] – Factor vs Time table ID associated with the radiation coefficient, or 0 for none.
