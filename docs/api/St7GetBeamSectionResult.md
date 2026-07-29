# St7GetBeamSectionResult

Returns the section results at the specified point on a beam.

long St7GetBeamSectionResult(long uID, long ResultType, long BeamNum,
long ResultCase, double BeamPos, double x, double y, double* BeamResult)
Input Parameters
uID
Strand7 model file ID.
ResultType
One of rtBeamSectionStress, rtBeamSectionStrain, rtBeamSectionTotalStrain or
rtBeamSectionCreepStrain.
BeamNum
Beam number.
ResultCase
Result case number.
BeamPos
The position along the beam measured from end 1. Positions vary between zero and the length of the
element, or between zero and one, depending on the mode set via St7SetBeamResultPosMode.
x
x position on the beam cross section, relative to the centroid, in the local axis system of the beam.

y
y position on the beam cross section, relative to the centroid, in the local axis system of the beam.
Output Parameters
BeamResult[0..12]
An array containing the beam section results. For rtBeamSectionStress the following are returned:
[ipFibreStressXY] – Fibre stress.
[ipShearStress1XY] – Shear stress in the 1 direction.
[ipShearStress2XY] – Shear stress in the 2 direction.
[ipMinPrincipalStressXY] – Minimum principal stress.
[ipMaxPrincipalStressXY] – Maximum principal stress.
[ipAxialStressXY] – Axial stress.
[ipBendingStress1XY] – Stress due to bending in plane 1.
[ipBendingStress2XY] – Stress due to bending in plane 2.
[ipVonMisesStressXY] – von Mises stress.
[ipTrescaStressXY] – Tresca stress.
[ipTorqueStressXY] – Shear stress due to torque.
[ipShearF1ShearStressXY] – Shear stress due to shear force in plane 1.
[ipShearF2ShearStressXY] – Shear stress due to shear force in plane 2.
For rtBeamSectionStrain, rtBeamSectionTotalStrain and rtBeamSectionCreepStrain only the first entry is
used:
[0] – Fibre strain.
