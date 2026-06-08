# St7GetPlateColours

Returns the colours to be used for given plate display types.

long St7GetPlateColours(long uID, long* Colours, long NumCol)

Input Parameters

uID

Strand7 model file ID.

NumCol

The size of Colours.

Output Parameters
Colours[0..5]

[ipPlateFillColour] – The fill colour.

[ipPlateLineColour] – The outline colour.

[ipPlateOrientation1Colour] – The -z orientation colour.

[ipPlateOrientation2Colour] – The +z orientation colour.

[ipPlateOrientation3Colour] – The orientation edge colour.

[ipPlateOffsetColour] – The offset line colour.

See also RGB Colours.
