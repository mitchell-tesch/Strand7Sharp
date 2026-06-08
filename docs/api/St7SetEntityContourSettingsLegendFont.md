# St7SetEntityContourSettingsLegendFont

Sets the parameters accessible through Entity Display/Contour/Settings…/Legend in the GUI.

long St7SetEntityContourSettingsLegendFont(long uID, long Entity, char* FontName,

long* Integers)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE or tyBRICK.

FontName

String containing the name of the font.

Integers[0..4]

[ipFontSize] – Font size.

[ipFontColour] – Font colour. See also RGB Colours.

[ipFontStyleBold] – btTrue for bold.

[ipFontStyleItalic] – btTrue for italic.

[ipFontStyleUnderline] – btTrue for underline.
