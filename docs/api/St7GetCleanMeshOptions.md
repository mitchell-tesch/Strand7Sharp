# St7GetCleanMeshOptions

Returns the current settings used by St7CleanMesh.

long St7GetCleanMeshOptions(long uID, long* Integers, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
Integers[0..19]
[ipMeshToleranceType] – Tolerance type; either ztAbsolute or ztRelative.
[ipZipNodes] – Clean nodes; either btTrue or btFalse.
[ipRemoveDuplicateElements] – Remove duplicate elements; either btTrue or btFalse.
[ipFixElementConnectivity] – Repair element connectivity; either btTrue or btFalse.
[ipDeleteFreeNodes] – Delete unconnected nodes; either btTrue or btFalse.
[ipDoBeams] – Act on beam elements; either btTrue or btFalse.
[ipDoPlates] – Act on plate elements; either btTrue or btFalse.
[ipDoBricks] – Act on bricks; either btTrue or btFalse.
[ipDoLinks] – Act on links; either btTrue or btFalse.
[ipZeroLengthLinks] – Allow zero length links; either btTrue or btFalse.

[ipZeroLengthBeams] – Allow zero length beams; either btTrue or btFalse.
[ipNodeAttributeKeep] – Keep attributes from nodes; one of naLower, naHigher or naAccumulate.
[ipNodeCoordinates] – Move nodes; one of ncAverage, ncLowerNode, ncHigherNode or
ncSelectedNode.
[ipAllowDifferentProps] – Allow duplicate elements of different properties; either btTrue or
btFalse.
[ipActOnWholeModel] – Clean whole model; either btTrue or btFalse.
[ipAllowDifferentGroups] – Allow duplicate elements of different groups; either btTrue or
btFalse.
[ipPackStringGroupIDs] – Pack beam string group IDs; either btTrue or btFalse.
[ipAllowDifferentBeamOffset] – Allow duplicate beam elements with different offset; either
btTrue or btFalse.
[ipAllowDifferentPlateOffset] – Allow duplicate plate elements with different offset; either
btTrue or btFalse.
[ipDeleteInvalidElements] – Delete invalid elements; either btTrue or btFalse.
Doubles[0..0]
[ipMeshTolerance] – Zip tolerance, scaled based on Integers[ipMeshToleranceType].
