# St7GetPlateAxisLayer

For laminate properties, this returns the laminate layer whose material axes are displayed  when Draw Axes is set.

long St7GetPlateAxisLayer(long uID, long* Layer)

Input Parameters

uID

Strand7 model file ID.

Output Parameters

Layer

The number of the laminate layer whose axes are to be drawn, or Layer = 0 to display the plate local
axes instead.

Strand7 API Manual
