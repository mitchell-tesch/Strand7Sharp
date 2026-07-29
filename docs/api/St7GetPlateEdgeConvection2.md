# St7GetPlateEdgeConvection2

Returns the edge thermal convection coefficient and ambient temperature assigned to the specified plate. This
attribute is only used when performing heat transfer analysis. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetPlateEdgeConvection2(long uID, long PlateNum, long CaseNum,
long EdgeNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.

PlateNum
Plate number.
CaseNum
Load case number.
EdgeNum
Local edge number; one of 1, 2, 3 or 4.
Output Parameters
Doubles[0..1]
[0] – Convection coefficient.
[1] – Ambient temperature.
