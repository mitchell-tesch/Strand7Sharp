# St7SetPlateEdgeConvection2

Sets the thermal convection coefficient and ambient temperature for the specified plate edge. This attribute is
only used when performing heat transfer analysis.

Plate Attributes – Set

long St7SetPlateEdgeConvection2(long uID, long PlateNum, long CaseNum,

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

Doubles[0..1]

[0] – Edge convection coefficient.

[1] – Ambient temperature.
