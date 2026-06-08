# St7GetResultSettingsStyle

Returns the parameters accessible through Results Settings/Settings…/Style in the GUI.

long St7GetResultSettingsStyle(long uID, long Solver, long Entity, long Quantity,

long* Integers)

Input Parameters

uID

Strand7 model file ID.

Solver

One of the solver types listed in Solver Types.

Entity

One of tyBEAM, tyPLATE, tyBRICK or tyLINK.

Quantity

One of the QUANTITY options listed in Result Display Options.

Output Parameters

Integers[0..14]

[ipContourStyle] – One of csRainbow, csRainbowEnds, csMono, csLines or csBands.

[ipReverse] – btTrue if the contour is reversed.

[ipSeparator] – btTrue if a separator is included between ranges for the user defined contour.

[ipBand1Colour] – Colour for Band 1. See also RGB Colours.

[ipBand2Colour] – Colour for Band 2. See also RGB Colours.

[ipSeparatorColour] – Colour for Separator. See also RGB Colours.

[ipLineBackColour] – Colour for Line Back. See also RGB Colours.

[ipMonoColour] – Colour for Mono. See also RGB Colours.

[ipMinColour] – Colour for < Min. See also RGB Colours.

[ipMaxColour] – Colour for > Max. See also RGB Colours.

[ipLimitMin] – btTrue if the colour specified in ipMinColour is enabled for the out-of-bound contour.

[ipLimitMax] – btTrue if the colour specified in ipMaxColour is enabled for the out-of-bound
contour.

[ipVectorThickness] – Vector Thickness.

[ipVectorLength] – Vector Nominal Length.

[ipVectorAnchor] – One of vaTail, vaHead or vaBoth.

Model Window Results Settings
