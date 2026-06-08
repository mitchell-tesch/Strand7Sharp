# St7GetPlateFluxTables

Returns the tables associated with the heat flux assigned to the specified plate edge. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetPlateFluxTables(long uID, long PlateNum, long CaseNum, long EdgeNum,

long* Tables)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Plate Attributes – Get

CaseNum

Load case number.

EdgeNum

Local edge number; one of 1, 2, 3 or 4.

Output Parameters
Tables[0..1]

[0] – Factor vs Time table ID associated with the heat flux, or 0 for none.

[1] – Factor vs Temperature table ID associated with the heat flux, or 0 for none.
