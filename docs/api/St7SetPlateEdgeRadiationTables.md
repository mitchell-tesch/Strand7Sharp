# St7SetPlateEdgeRadiationTables

Sets the tables associated with the radiation coefficient for the specified plate edge.

long St7SetPlateEdgeRadiationTables(long uID, long PlateNum, long CaseNum,

long EdgeNum, long* Tables)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

EdgeNum

Local edge number; one of 1, 2, 3 or 4.

Tables[0..2]

[0] – Temperature vs Time table ID associated with the radiation ambient temperature, or 0 for none.

[1] – Factor vs Temperature table ID associated with the radiation coefficient, or 0 for none.

Plate Attributes – Set

[2] – Factor vs Time table ID associated with the radiation coefficient, or 0 for none.
