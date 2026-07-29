# St7SetEntityFont

Sets the font for displaying entity labels.

long St7SetEntityFont(long uID, long Entity, char* FontName, long* Integers)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyLINK, tyVERTEX, tyGEOMETRYFACE or tyLOADPATH.
FontName
String containing the name of the font.
Integers[0..4]
[ipFontSize] – Font size.
[ipFontColour] – Font colour. See also RGB Colours.
[ipFontStyleBold] – btTrue for bold.
[ipFontStyleItalic] – btTrue for italic.

[ipFontStyleUnderline] – btTrue for underline.
