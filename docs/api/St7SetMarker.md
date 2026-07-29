# St7SetMarker

Assigns a marker to an element or element face.

long St7SetMarker(long uID, long Entity, long EntityNum, long FaceNum,
long* Integers)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyLINK, tyVERTEX, tyGEOMETRYFACE or tyLOADPATH.
EntityNum
Entity number.
FaceNum
Brick element face number (1-6). For marker type mtEntityHighlight, 0 is also valid and indicates the
marker applies to the whole brick.
Integers[0..11]
[ipMarkerType] – One of mtCircleMarker, mtSquareMarker, mtTriangleMarker, mtRectangleMarker,
mtEntityHighlight or mtBanner.
[ipMarkerStyle] – One of msFilled, msOutlined or msFilledOutlined.
[ipMarkerFillColour] – Fill colour. See also RGB Colours.
[ipMarkerLineColour] – Line colour. See also RGB Colours.
[ipMarkerLineThickness] – Line thickness.
[ipMarkerSize] – Marker size.
[ipMarkerHeight] – Marker height.
[ipMarkerAnchorX] – The model window X anchor for banner markers. X values increase from left to
right in the model window.
[ipMarkerAnchorY] – The model window Y anchor for banner markers. Y values increase from top
to bottom in the model window.
[ipMarkerVisible] – btTrue to show the marker; btFalse to hide the marker.
[ipMarkerNumber] – btTrue to show the entity number; btFalse to hide the entity number.

[ipMarkerLabelled] – btTrue to show the entity label with the entity number (e.g., “Node 123”);
btFalse to show only the entity number (e.g., “123”).
