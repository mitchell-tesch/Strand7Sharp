# St7CalculateBeamSectionProperties

Calculates the section properties for the standard beam cross sections defined in Beam Cross Section Shape, with
the exception of bsNullSection. The function will return an error if the property does not use one of the standard
section types.

long St7CalculateBeamSectionProperties(long uID, long PropNum, bool DoShear)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
DoShear
Include the shear area values; either True or False. If the shear areas are included the “thick” beam
formulation is used.
