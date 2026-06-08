# St7GetPlateEdgeTransverseShear1

Returns the transverse shear stress assigned to the specified plate edge. The shear stress acts normal to the plate
surface at its edge, in the local +z direction. See also St7GetEntityAttributeSequenceCount and
St7GetEntityAttributeSequence.

long St7GetPlateEdgeTransverseShear1(long uID, long PlateNum, long CaseNum,

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
Doubles[0]

Transverse shear stress.

Plate Attributes – Get
