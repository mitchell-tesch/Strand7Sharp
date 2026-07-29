# St7GetBrickContourFileResult

Returns a result from the most recently loaded brick contour file.

long St7GetBrickContourFileResult(long uID, long BrickNum, double* BrickResult)
Input Parameters
uID
Strand7 model file ID.
BrickNum
Brick number.
Output Parameters
BrickResult[0..kMaxBrickResult-1]
[0..19] – An array containing the brick result at each node.

Linear load case combination information is stored by the Strand7 model. Secondary result cases are defined by
scaling and combining a number of primary result cases. Two tables are associated with each model; one or the
other is used to generate combined cases depending on the class of .LSA file being opened:
1. Solver generated .LSA files. These are created by running the Strand7 solver; either from the API or GUI.
2. User generated .LSA files. These are created by the Combine Result Files tool (CASES/Combine Files), or
with the API Custom Result Files functionality.
