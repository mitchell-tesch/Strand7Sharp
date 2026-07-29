# St7GetWindowImageSize

Returns the size of the image used for bgImage and bgImageGradient background modes.

long St7GetWindowImageSize(long uID, long* ImageSize)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
ImageSize
A value between 0 and 100 representing the size of the image as a percentage of the width of the
model window. The height of the image is scaled proportionally. If ImageSize is 0, the image is rendered
pixel by pixel, unscaled.
