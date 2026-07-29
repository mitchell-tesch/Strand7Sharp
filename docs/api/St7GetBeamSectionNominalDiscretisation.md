# St7GetBeamSectionNominalDiscretisation

Returns the discretisation values used when discretising the cross section for nonlinear beam types.

long St7GetBeamSectionNominalDiscretisation(long uID, long PropNum,
long* Integers)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Output Parameters
Integers[0..2]
[0] – nominal divisions used to discretise the beam (along the longest ordinate), or divisions in the x
ordinate when divisions are specified.
[1] – divisions in the y ordinate used to discretise the beam when divisions are specified.
[2] – btTrue to use nominal divisions, btFalse to specify the divisions in each ordinate explicitly.
