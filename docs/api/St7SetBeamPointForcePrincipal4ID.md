# St7SetBeamPointForcePrincipal4ID

Assigns point force data for the specified beam element. The force is defined in the principal axis system of the
beam.

long St7SetBeamPointForcePrincipal4ID(long uID, long BeamNum, long CaseNum,

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

Doubles[0..3]

[0..2] – The force components in the principal axis system of the beam.

[3] – The relative length position at which the force is applied; see Beam Local Coordinates.
