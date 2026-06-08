# St7GetFaceColours

Returns the colours to be used for given face display types.

long St7GetFaceColours(long uID, long* Colours, long NumCol)

Input Parameters

uID

Strand7 model file ID.

NumCol

The size of Colours.

Output Parameters
Colours[0..7]

[ipFaceFillColour] – The fill colour.

[ipFaceLineColour] – The outline colour.

[ipFaceOrientation1Colour] – The -z orientation colour.

[ipFaceOrientation2Colour] – The +z orientation colour.

[ipFaceNIEdgesColour] – The non-interpolated edge highlight colour.

[ipFaceCPuColour] – The colour of control point u-lines.

[ipFaceCPvColour] – The colour of control point v-lines.

[ipFaceNormalsColour] – The colour of normal vectors.

See also RGB Colours.

Face Entity Display
