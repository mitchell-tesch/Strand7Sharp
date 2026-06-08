# St7GetEntityFont

Returns the font for displaying entity labels.

long St7GetEntityFont(long uID, long Entity, char* FontName, long MaxStringLen,

long* Integers)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyLINK, tyVERTEX, tyGEOMETRYFACE or tyLOADPATH.

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

Model Window Results Settings

Model Window Results Settings
