# St7SetPlateColours

Sets the colours to be used for given plate display types, where such are required.

long St7SetPlateColours(long uID, long* Colours, long NumCol)

Input Parameters

uID

Strand7 model file ID.

Colours[0..5]

[ipPlateFillColour] – The fill colour.

[ipPlateLineColour] – The outline colour.

[ipPlateOrientation1Colour] – The -z orientation colour.

[ipPlateOrientation2Colour] – The +z orientation colour.

[ipPlateOrientation3Colour] – The orientation edge colour.

[ipPlateOffsetColour] – The offset line colour.

See also RGB Colours.

NumCol

The size of Colours.
