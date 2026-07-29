# St7AlignFaceNormalByConnection

Aligns the normals of selected faces such that they have consistent normal, based on a master face. The master
face must be connected to the selected faces.

long St7AlignFaceNormalByConnection(long uID, long FaceNum)
Input Parameters
uID
Strand7 model file ID.
FaceNum
Master face number.
Dependencies
Selection
Faces can be selected using functions in Entity Selection.
