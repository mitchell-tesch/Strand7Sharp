# St7GetEntityContourSettingsStyle

Returns the parameters accessible through Entity Display/Contour/Settings…/Style in the GUI.

long St7GetEntityContourSettingsStyle(long uID, long Entity, long* Integers)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE or tyBRICK.

Output Parameters

Integers[0..11]

[ipContourStyle] – One of csRainbow, csRainbowEnds, csMono, csLines or csBands.

[ipReverse] – btTrue if the contour is reversed.

[ipSeparator] – btTrue if a separator is included between ranges for the user defined contour.

[ipBand1Colour] – Colour for Band 1. See also RGB Colours.

[ipBand2Colour] – Colour for Band 2. See also RGB Colours.

[ipSeparatorColour] – Colour for Separator. See also RGB Colours.

[ipLineBackColour] – Colour for Line Back. See also RGB Colours.

[ipMonoColour] – Colour for Mono. See also RGB Colours.

[ipMinColour] – Colour for < Min. See also RGB Colours.

Strand7 API Manual

[ipMaxColour] – Colour for > Max. See also RGB Colours.

[ipLimitMin] – btTrue if the colour specified in ipMinColour is enabled for the out-of-bound contour.

[ipLimitMax] – btTrue if the colour specified in ipMaxColour is enabled for the out-of-bound
contour.
