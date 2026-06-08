# St7SetWindowImageFile

Sets the image file to be used for bgImage and bgImageGradient background modes.

long St7SetWindowImageFile(long uID, char* FileName)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

FileName

The name of the image file.  The file name extension must be one of ‘.BMP’, ‘.JPG’, ‘.JPEG’ or ‘.PNG’,
each representing the respective image file type.  A blank string may be used to clear the current image
file name.
