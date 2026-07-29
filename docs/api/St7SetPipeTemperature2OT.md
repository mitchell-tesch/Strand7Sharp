# St7SetPipeTemperature2OT

Sets the internal and external pipe temperatures for the specified beam. This attribute is only active for beams of
type pipe.

long St7SetPipeTemperature2OT(long uID, long BeamNum, long CaseNum, long Status,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.

BeamNum
Beam number.
CaseNum
Load case number.
Status
Set the external temperature equal to the nodal temperatures at each end: btTrue or btFalse. In the
case of unequal end temperatures the average temperature is used.
Doubles[0..1]
A 2-element array describing the inner and outer surface temperatures respectively.
