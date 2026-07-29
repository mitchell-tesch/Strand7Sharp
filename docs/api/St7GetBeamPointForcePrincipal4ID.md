# St7GetBeamPointForcePrincipal4ID

Returns point force data assigned to the specified beam element. The force is applied according to the principal
axis system of the beam. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetBeamPointForcePrincipal4ID(long uID, long BeamNum, long CaseNum,
long ID, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.

CaseNum
Load case number.
ID
Point force ID.
Output Parameters
Doubles[0..3]
[0..2] – The force components in the principal axis system of the beam.
[3] – The relative length position at which the force is applied; see Beam Local Coordinates.
