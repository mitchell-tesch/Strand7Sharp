# St7GetLibraryName

Returns the name assigned to the specified library.

long St7GetLibraryName(long LibraryType, long LibraryID, char* LibraryName,
long MaxStringLen)
Input Parameters
LibraryType
One of lbMaterial, lbBeamSection, lbSectionGeometry, lbComposite, lbReinforcementLayout,
lbCreepDefinition or lbLoadPathTemplate.
LibraryID
Library ID.
MaxStringLen
Maximum number of characters allocated for LibraryName.
Output Parameters
LibraryName
Library name.
