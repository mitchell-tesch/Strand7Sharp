# St7GetBeamSectionGeometry

Returns the beam cross section data assigned to the specified beam property.

long St7GetBeamSectionGeometry(long uID, long PropNum, long* SectionType,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Output Parameters
SectionType
One of the section shapes defined in Beam Cross Section Shape.
Doubles[0..5]
A 6-element array containing the beam cross section D1, D2, D3, T1, T2 and T3 parameters respectively;
see Beam Cross Section Shape.
