# St7SetGeometryFaceHeatSourceTables

Specifies the tables associated with the heat source assigned to the specified geometry face.

long St7SetGeometryFaceHeatSourceTables(long uID, long FaceNum, long CaseNum,

long* Tables)

Input Parameters

uID

Strand7 model file ID.

FaceNum

Face number.

CaseNum

Load case number.

Face Attributes – Set

Tables[0..1]

[0] – Factor vs Time table ID associated with the heat source, or 0 for none.

[1] – Factor vs Temperature table ID associated with the heat source, or 0 for none.
