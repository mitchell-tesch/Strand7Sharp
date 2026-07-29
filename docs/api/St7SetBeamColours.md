# St7SetBeamColours

Sets the colours to be used for given beam display types, where such are required.

long St7SetBeamColours(long uID, long* Colours, long NumCol)
Input Parameters
uID
Strand7 model file ID.
Colours[0..4]
[ipBeamFillColour] – The fill colour.
[ipBeamLineColour] – The outline colour.
[ipBeamOrientation1Colour] – The end 1 orientation colour.
[ipBeamOrientation2Colour] – The end 2 orientation colour.
[ipBeamNRefColour] – The orientation edge colour.
See also RGB Colours.
NumCol
The size of Colours.
