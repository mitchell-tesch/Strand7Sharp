# St7GetPathColours

Returns the colours to be used for given load path display types.

long St7GetPathColours(long uID, long* Colours, long NumCol)
Input Parameters
uID
Strand7 model file ID.
NumCol
The size of Colours.
Output Parameters
Colours[0..3]
[ipPathFillColour] – The fill colour.
[ipPathLineColour] – The outline colour.
[ipPathOrientation1Colour] – The -z orientation colour.
[ipPathOrientation2Colour] – The +z orientation colour.
See also RGB Colours.
