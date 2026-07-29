# St7GetModelWindowState

Returns the state of the model window for a Strand7 model.

long St7GetModelWindowState(long uID, long* State)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
State
One of wsModelWindowNotCreated, wsModelWindowVisible, wsModelWindowMaximised,
wsModelWindowMinimised or wsModelWindowHidden.
