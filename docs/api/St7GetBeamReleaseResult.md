# St7GetBeamReleaseResult

Returns the release results for the specified beam.

long St7GetBeamReleaseResult(long uID, long BeamNum, long ResultCase,
bool* BeamReleased, double* ReleaseValue)
Input Parameters
uID
Strand7 model file ID.
BeamNum
Beam number.
ResultCase
Result case number.
Output Parameters
BeamReleased[0..kMaxBeamRelease-1]
An array containing the release status for the beam ends according to the beam local axis system for
translational and rotational DoF.
Values set to True indicate a release for the corresponding DoF.
[ipRelEnd1Dir1] – End 1 translational release in the 1 axis direction.
[ipRelEnd1Dir2] – End 1 translational release in the 2 axis direction.

[ipRelEnd1Dir3] – End 1 translational release in the 3 axis direction.
[ipRelEnd1Dir4] – End 1 rotational release about the 1 axis direction.
[ipRelEnd1Dir5] – End 1 rotational release about the 2 axis direction.
[ipRelEnd1Dir6] – End 1 rotational release about the 3 axis direction.
[ipRelEnd2Dir1] – End 2 translational release in the 1 axis direction.
[ipRelEnd2Dir2] – End 2 translational release in the 2 axis direction.
[ipRelEnd2Dir3] – End 2 translational release in the 3 axis direction.
[ipRelEnd2Dir4] – End 2 rotational release about the 1 axis direction.
[ipRelEnd2Dir5] – End 2 rotational release about the 2 axis direction.
[ipRelEnd2Dir6] – End 2 rotational release about the 3 axis direction.
ReleaseValue[0..kMaxBeamRelease-1]
An array containing the displacement results for the released beam end DoF. The same format as the
BeamReleased array is used.
