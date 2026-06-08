# St7SaveViewOnlyCopy

Saves a copy of the Strand7 model as a new View-Only file (.St7V). The function offers controls to allow or restrict
access to specific aspects of the model data when subsequently opening the View-Only file.

long St7SaveViewOnlyCopy(long uID, char* FileName, long* Integers)

Input Parameters

uID

Strand7 model file ID.

FileName

Full path and filename for the Strand7 model.

Integers[0..15]

[ipVoShowCoordinates] – btTrue to show node coordinate values in Entity Inspector, Whiteboard,
TEXT tab, Peek Window and LISTINGS tab.

[ipVoShowTEXT] – btTrue to allow access to the TEXT tab.

[ipVoShowCASES] – btTrue to allow access to the CASES tab.

[ipVoAllowSave] – btTrue to allow the file to be saved to enable view changes and other display
settings to be updated in the file.

[ipVoShowTables] – btTrue to allow access to the LAYOUTS/Tables tab.

[ipVoShowPlies] – btTrue to allow access to the LAYOUTS/Plies tab.

[ipVoShowLaminates] – btTrue to allow access to the LAYOUTS/Laminates tab.

[ipVoShowPlateRC] – btTrue to allow access to the LAYOUTS/Plate RC tab.

[ipVoShowCreep] – btTrue to allow access to the LAYOUTS/Creep tab.

[ipVoShowPaths] – btTrue to allow access to the LAYOUTS/Paths tab.

[ipVoShowCavities] – btTrue to allow access to the LAYOUTS/Cavities tab.

[ipVoShowProperties] – btTrue to allow access to VISUAL/Global/Properties.

[ipVoShowLISTINGS] – btTrue to allow access to the LISTINGS tab.

[ipVoShowAttribSummary] – btTrue to allow access to the SUMMARY/Attributes tab.

[ipVoShowPropSummary] – btTrue to allow access to the SUMMARY/Property tab.

[ipVoShowModelSummary] – btTrue to allow access to the SUMMARY/Model tab.
