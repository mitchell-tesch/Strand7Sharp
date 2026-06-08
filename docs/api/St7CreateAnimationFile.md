# St7CreateAnimationFile

Creates an animation file but does not play it.

long St7CreateAnimationFile(long uID, long* Integers, char* FileName)

Input Parameters

uID

Strand7 model file ID.

Integers[0..4]

[ipAniCase] – The result case index for a single case animation.

[ipNumFrames] – For a single animation case, the number of frames.  For a multi case animation,
use -1 to animate all frames or 0 to animate only those cases marked using St7SetAnimationCase.

[ipAniWidth] – The width in pixels for the animation window.

[ipAniHeight] – The height in pixels for the animation window.

[ipAniType] – The animation file type; one of afAniSAF, afAniEXE or afAniAVI.

FileName

Full path and name for the animation file.

Strand7 API Manual
