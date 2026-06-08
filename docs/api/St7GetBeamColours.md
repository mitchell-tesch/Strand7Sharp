# St7GetBeamColours

Returns the colours to be used for given beam display types.

long St7GetBeamColours(long uID, long* Colours, long NumCol)

Input Parameters

uID

Strand7 model file ID.

NumCol

The size of Colours.

Output Parameters
Colours[0..4]

[ipBeamFillColour] – The fill colour.

[ipBeamLineColour] – The outline colour.

[ipBeamOrientation1Colour] – The end 1 orientation colour.

[ipBeamOrientation2Colour] – The end 2 orientation colour.

[ipBeamNRefColour] – The orientation edge colour.

See also RGB Colours.
