# St7SetPathColours

Sets the colours to be used for given load path display types, where such are required.

long St7SetPathColours(long uID, long* Colours, long NumCol)
Input Parameters
uID
Strand7 model file ID.
Colours[0..3]
[ipPathFillColour] – The fill colour.
[ipPathLineColour] – The outline colour.
[ipPathOrientation1Colour] – The -z orientation colour.
[ipPathOrientation2Colour] – The +z orientation colour.
See also RGB Colours.
NumCol
The size of Colours.
