# St7GetBrickColours

Returns the colours to be used for given brick display types.

long St7GetBrickColours(long uID, long* Colours, long NumCol)
Input Parameters
uID
Strand7 model file ID.
NumCol
The size of Colours.
Output Parameters
Colours[0..1]
[ipBrickFillColour] – The fill colour.
[ipBrickLineColour] – The outline colour.
See also RGB Colours.
