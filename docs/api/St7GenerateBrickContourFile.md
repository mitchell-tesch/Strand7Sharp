# St7GenerateBrickContourFile

Generates a brick contour results file containing results of a single quantity for all bricks.

long St7GenerateBrickContourFile(long uID, long ResultCase, long* Integers,
long* FileIndex)
Input Parameters
uID
Strand7 model file ID.
ResultCase
Result case.
Integers[0..7]
[ipQuantityRF] – Brick result quantity; see Brick Results. When result quantity is rtBrickUser, the
currently active user equation must be assigned via St7SetResultUserEquation or
St7SetStoredResultUserEquation before calling St7GenerateBrickContourFile.
[ipSystemRF] – Brick result system; see ResultSubType in Brick Results.
[ipComponentRF] – An index position as specified in Brick Results. For example,
ipBrickCombPrincipal11.
[ipExtrapolateRF] – eoCentroid for Centroidal Value, eoNode for Nodal Values Extrapolated from
Gauss Points or eoGaussPoint for Gauss Point Values Placed at Nodes.
[ipAverageRF] – One of aoAlways, aoNever, aoSameProp, aoJumps, aoJumpsN, aoRange or
aoSamePropAndStage.
[ipAbsoluteRF] – btTrue to return absolute values.
[ipSubtractSupportRF] – btTrue to subtract support attribute reactions from node reactions.
Output Parameters
FileIndex
File index.
