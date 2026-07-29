# St7GeneratePlateContourFile

Generates a plate contour results file containing results of a single quantity for all plates.

long St7GeneratePlateContourFile(long uID, long ResultCase, long* Integers,
long* FileIndex)
Input Parameters
uID
Strand7 model file ID.
ResultCase
Result case.
Integers[0..7]
[ipQuantityRF] – Plate result quantity; see Plate Results. When result quantity is rtPlateUser, the
currently active user equation must be assigned via St7SetResultUserEquation or
St7SetStoredResultUserEquation before calling St7GeneratePlateContourFile.
[ipSystemRF] – Plate result system; see ResultSubType in Plate Results.
[ipComponentRF] – An index position as specified in Plate Results, for example,
ipPlateCombVonMises.
[ipLayerRF] – Relevant to reinforced concrete or composite results; see Plate Results.
[ipExtrapolateRF] – eoCentroid for Centroidal Value, eoNode for Nodal Values Extrapolated from
Gauss Points or eoGaussPoint for Gauss Point Values Placed at Nodes.
[ipAverageRF] – One of aoAlways, aoNever, aoSameProp, aoJumps, aoJumpsN, aoRange or
aoSamePropAndStage.
[ipAbsoluteRF] – btTrue to return absolute values.
[ipSubtractSupportRF] – btTrue to subtract support attribute reactions from node reactions.
Output Parameters
FileIndex
File index.
