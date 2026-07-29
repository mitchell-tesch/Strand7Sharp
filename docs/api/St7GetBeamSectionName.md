# St7GetBeamSectionName

Returns the name of the section referenced by the specified beam property.

long St7GetBeamSectionName(long uID, long PropNum, char* SectionName,
long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
PropNum
Property number.
MaxStringLen
Maximum number of characters allocated for SectionName.
Output Parameters
SectionName
Name of the section.
