# St7GetPlateEdgeRadiationTables

Returns the tables associated with the radiation coefficient assigned to the specified plate edge. See also
St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetPlateEdgeRadiationTables(long uID, long PlateNum, long CaseNum,

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

Strand7 API Manual

Output Parameters
Tables[0..2]

[0] – Temperature vs Time table ID associated with the radiation ambient temperature, or 0 for none.

[1] – Factor vs Temperature table ID associated with the radiation coefficient, or 0 for none.

[2] – Factor vs Time table ID associated with the radiation coefficient, or 0 for none.
