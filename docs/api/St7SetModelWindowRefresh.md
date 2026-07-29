# St7SetModelWindowRefresh

Sets the way the model window responds to actions that invalidate it.

long St7SetModelWindowRefresh(long uID, long Mode)
Input Parameters
uID
Strand7 model file ID.
Mode
One of wrAutoRefresh, wrPauseClear or wrPauseNoClear.
In wrAutoRefresh mode, the model window remains synchronised with the model, automatically
refreshing as changes are made. For example, if new elements are created, the model window will
refresh automatically as each element is added.
In wrPauseClear and wrPauseNoClear modes, the model window remains responsive until a user action
or API call invalidates it. While the model window is valid it can respond to view changes and/or
window resizes. Once the model window is invalidated, the window is not updated until either
a) St7RedrawModel is called (which performs a one-off synchronisation); or
b) this function is called with the wrAutoRefresh mode (which performs and maintains synchronisation).
The difference between wrPauseClear and wrPauseNoClear is in what is displayed in an invalidated
model window. An invalidated model window will be cleared with wrPauseClear, whereas it will
continue to display the previous graphics with wrPauseNoClear, even if the previous graphics are out of
date with the current state of the model. The advantage of wrPauseNoClear is that it avoids a screen
flicker that can occur when the window is cleared between pausing it and refreshing it after the model
has changed. Both modes will disable interaction with the model window (such as the Entity Inspector
and selecting).
API calls will take longer to perform with the wrAutoRefresh mode since more work is required to
continually redraw the model in response to changes.
