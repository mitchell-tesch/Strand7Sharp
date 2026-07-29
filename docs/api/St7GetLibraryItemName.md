# St7GetLibraryItemName

Returns the name assigned to the specified library item.

long St7GetLibraryItemName(long LibraryType, long LibraryID, long ItemID,
char* ItemName, long MaxStringLen)
Input Parameters
LibraryType
One of lbMaterial, lbBeamSection, lbSectionGeometry, lbComposite, lbReinforcementLayout,
lbCreepDefinition or lbLoadPathTemplate.
LibraryID
Library ID.
ItemID
Item ID.
MaxStringLen
Maximum number of characters allocated for ItemName.
Output Parameters
ItemName
Name of the item.
