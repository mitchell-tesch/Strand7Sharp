# St7SetPlateFaceConvectionTables

Sets the tables associated with convection coefficient for the specified plate surface.

long St7SetPlateFaceConvectionTables(long uID, long PlateNum, long CaseNum,

long Surface, long* Tables)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

Surface

Local plate surface number; either psPlateMinusZ or psPlatePlusZ.

Tables[0..2]

[0] – Temperature vs Time table ID associated with the convection ambient temperature, or 0 for
none.

Plate Attributes – Set

[1] – Factor vs Temperature table ID associated with the convection coefficient, or 0 for none.

[2] – Factor vs Time table ID associated with the convection coefficient, or 0 for none.
