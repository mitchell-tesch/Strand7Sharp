# St7SetWindowStatusBarRefreshMode

Sets the way the status bar responds to actions that invalidate it.

Strand7 API Manual

long St7SetWindowStatusBarRefreshMode(long uID, bool AutoRefresh)

Input Parameters

uID

Strand7 model file ID.

AutoRefresh

True to automatically update the entity counts in the status bar as they change.

False to pause entity count updates in the status bar.

API calls will take longer to perform with AutoRefresh=True since more work is required to continually
update the status bar in response to changes.
