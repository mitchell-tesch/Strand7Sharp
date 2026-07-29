# St7GetLibraryItemID

Returns the ID number assigned to the specified library item.

long St7GetLibraryItemID(long LibraryType, long LibraryID, char* ItemName,
long* ItemID)
Input Parameters
LibraryType
One of lbMaterial, lbBeamSection, lbSectionGeometry, lbComposite, lbReinforcementLayout,
lbCreepDefinition or lbLoadPathTemplate.
LibraryID
Library ID.

ItemName
Name of the item.
Output Parameters
ItemID
Item ID.
