# St7ZoomModel

Zooms the graphical display of the model in the model window.

long St7ZoomModel(long uID, double CentreX, double CentreY, double ZoomScale)

Input Parameters

uID

Strand7 model file ID.

CentreX

The X coordinate of the zoom origin with respect to the model window.  Any positive or negative real
number may be used; 0.0 refers to the left edge of the window, 0.5 refers to the centre of the window
and 1.0 refers to the right edge of the window.  Values outside the range zero to one may be used.

Strand7 API Manual

CentreY

The Y coordinate of the zoom origin with respect to the model window. Any positive or negative real
number may be used; 0.0 refers to the bottom edge of the window, 0.5 refers to the centre of the
window and 1.0 refers to the top edge of the window.  Values outside the range zero to one may be
used.

ZoomScale

Values greater than one enlarge the model (i.e., zoom in); values less than one reduce the model (i.e.,
zoom out). ZoomScale must be greater than zero.
