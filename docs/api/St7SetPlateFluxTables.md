# St7SetPlateFluxTables

Sets the tables associated with the heat flux for the specified plate edge.

long St7SetPlateFluxTables(long uID, long PlateNum, long CaseNum, long EdgeNum,

long* Tables)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

CaseNum

Load case number.

EdgeNum

Local edge number; one of 1, 2, 3 or 4.

Tables[0..1]

[0] – Factor vs Time table ID associated with the heat flux, or 0 for none.

[1] – Factor vs Temperature table ID associated with the heat flux, or 0 for none.

Strand7 API Manual
