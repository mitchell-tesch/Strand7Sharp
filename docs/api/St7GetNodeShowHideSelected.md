# St7GetNodeShowHideSelected

Returns whether the display of nodes considers the Show/Hide Selected setting.

long St7GetNodeShowHideSelected(long uID, bool* UseSettings)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
UseSettings
If True, the visibility of selected/unselected nodes in the model window depends on the Show/Hide
Selected setting; if False, the visibility of selected/unselected nodes in the model window is not affected
by the Show/Hide Selected setting.
