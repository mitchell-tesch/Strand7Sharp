# St7GetVertexColours

Returns the colours used to display vertices.

long St7GetVertexColours(long uID, long* Colours, long NumCol)
Input Parameters
uID
Strand7 model file ID.
NumCol
The size of Colours.
Output Parameters
Colours[0..2]
[ipVertexFreeColour] – The unselected vertex colour.
[ipVertexFixedColour] – The fixed vertex colour.
[ipVertexSelectedColour] – The selected vertex colour.
See also RGB Colours.
