# St7GetNumLibraryItems

Returns the number of items assigned to the specified library.

long St7GetNumLibraryItems(long LibraryType, long LibraryID, long* NumItems)
Input Parameters
LibraryType
One of lbMaterial, lbBeamSection, lbSectionGeometry, lbComposite, lbReinforcementLayout,
lbCreepDefinition or lbLoadPathTemplate.

LibraryID
Library ID.
Output Parameters
NumItems
Number of library items.
