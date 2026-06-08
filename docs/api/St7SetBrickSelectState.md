# St7SetBrickSelectState

Sets the selected state of the specified brick, brick face or edge on a brick face.

long St7SetBrickSelectState(long uID, long BrickNum, long FaceNum, long EdgeNum,

bool Selected)

Input Parameters

uID

Strand7 model file ID.

BrickNum

Brick number.

FaceNum

One of 0, 1, 2, 3, 4, 5 or 6.

EdgeNum

One of 0, 1, 2, 3 or 4.

Selected

Either True or False.

Usage

Setting FaceNum=0 selects or unselects the whole brick, irrespective of the value of EdgeNum.

Setting EdgeNum=0 selects or unselects the whole face when FaceNum is non-zero.

When edges of a brick face are selected, all selected edges must be on the same face.  Selecting an edge on a
different face will automatically unselect edges on any other currently selected faces.
