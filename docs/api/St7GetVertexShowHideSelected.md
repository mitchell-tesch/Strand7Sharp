# St7GetVertexShowHideSelected

Returns whether the display of vertices considers the Show/Hide Selected setting.

long St7GetVertexShowHideSelected(long uID, bool* UseSettings)

Input Parameters

uID

Strand7 model file ID.

Output Parameters
UseSettings

If True, the visibility of selected/unselected vertices in the model window depends on the Show/Hide
Selected setting; if False, the visibility of selected/unselected vertices in the model window is not
affected by the Show/Hide Selected setting.
