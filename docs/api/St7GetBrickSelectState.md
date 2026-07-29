# St7GetBrickSelectState

Returns the selected state of the specified brick, brick face or edge on a brick face.

long St7GetBrickSelectState(long uID, long BrickNum, long FaceNum, long EdgeNum,
bool* Selected)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.

FaceNum
One of 0, 1, 2, 3, 4, 5 or 6.
EdgeNum
One of 0, 1, 2, 3 or 4.
Output Parameters
Selected
Either True or False.
