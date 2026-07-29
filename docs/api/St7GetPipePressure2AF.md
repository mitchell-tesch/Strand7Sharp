# St7GetPipePressure2AF

Returns the internal and external pressures applied to the specified beam. This attribute is only active for beams
of type pipe. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.

long St7GetPipePressure2AF(long uID, long BeamNum, long CaseNum, long* Status,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
CaseNum
Load case number.

Output Parameters
Status
Either btTrue or btFalse. If btTrue, an additional axial force is applied to account for the pressure acting
on the closed ends.
Doubles[0..1]
A 2-element array describing the inner and outer radial pressures acting on the element surface
respectively.
