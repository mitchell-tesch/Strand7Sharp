# St7CreateAnimationEmbedded

Creates a SAF animation embedded in a parent window. The Strand7 model referenced by uID must have a results
file open.

long St7CreateAnimationEmbedded(long uID, HWND pHandle, long* Integers,
long* aHandle)
Input Parameters
uID
Strand7 model file ID.
pHandle
The Windows handle of the parent window.
Integers[0..3]
[ipAniCase] – The result case index for a single case animation.
[ipNumFrames] – For a single animation case, the number of frames. For a multi case animation,
use -1 to animate all frames or 0 to animate only those cases marked using St7SetAnimationCase.
[ipAniWidth] – The width in pixels for the animation window.
[ipAniHeight] – The height in pixels for the animation window.
Output Parameters
aHandle
The identifier of the created animation for use by subsequent Strand7 API calls.
