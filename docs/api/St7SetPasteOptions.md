# St7SetPasteOptions

Sets paste options that will be applied by subsequent paste operations.

long St7SetPasteOptions(long uID, long* Integers)

Input Parameters

uID

Strand7 model file ID.

Integers[0..7]

[ipPasteCases] – One poCasesInOrder, poCasesMatchNames or poCasesNewData.

[ipPasteProperties] – One of poPropertiesUsePropertyID, poPropertiesMatchExisting or
poPropertiesCreateNew.

[ipPasteLoadPaths] – Either poLoadPathUseTemplateID or poLoadPathCreateNew.

[ipPasteAttributes] – btTrue to Paste Attributes.

[ipPasteGroups] – btTrue to Match Group Names.

[ipPasteSets] – btTrue to Match Set Names.

[ipPasteGlobals] – btTrue to Merge Load Case Globals.

[ipPasteTables] – btTrue to Paste tables.
