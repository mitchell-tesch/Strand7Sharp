# St7GetLibraryID

Returns the ID number assigned to the specified library.

long St7GetLibraryID(long LibraryType, char* LibraryName, long* LibraryID)

Input Parameters
LibraryType

One of lbMaterial, lbBeamSection, lbSectionGeometry, lbComposite, lbReinforcementLayout,
lbCreepDefinition or lbLoadPathTemplate.

LibraryName

Library name without the extension.  For example, “RHS (350 Grade)” rather than “RHS (350
Grade).bsl”.

Output Parameters
LibraryID

Library ID.
