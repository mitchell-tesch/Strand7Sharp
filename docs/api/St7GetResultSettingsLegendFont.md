# St7GetResultSettingsLegendFont

Returns the parameters accessible through Results Settings/Settings…/Legend in the GUI.

long St7GetResultSettingsLegendFont(long uID, long Solver, long Entity,

long Quantity, char* FontName, long MaxStringLen, long* Integers)

Input Parameters

uID

Strand7 model file ID.

Solver

One of the solver types listed in Solver Types.

Entity

One of tyBEAM, tyPLATE, tyBRICK or tyLINK.

Quantity

One of the QUANTITY options listed in Result Display Options.

Strand7 API Manual

MaxStringLen

Maximum number of characters allocated for FontName.

Output Parameters
FontName

String containing the name of the font.

Integers[0..4]

[ipFontSize] – Font size.

[ipFontColour] – Font colour. See also RGB Colours.

[ipFontStyleBold] – btTrue for bold.

[ipFontStyleItalic] – btTrue for italic.

[ipFontStyleUnderline] – btTrue for underline.
