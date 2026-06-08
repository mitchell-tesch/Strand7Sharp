# St7SetLoadPath

Sets the data for a load path in the specified model. A new load path is created if a new load path ID is specified.

long St7SetLoadPath(long uID, long LoadPathID, long* Integers, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

LoadPathID

Load path ID.

Integers[0..6]

[ipLoadPathCase] – Load case number.

[ipLoadPathTemplate] – Load path template number.

[ipLoadPathShape] – Load path shape; one of lpShapeStraight, lpShapeCurved, lpShapeQuadratic.

[ipLoadPathSurface] – Load path surface; either lpSurfaceFlat or lpSurfaceCurved. Note that this
parameter is ignored when lpShapeStraight is set in Integers[ipLoadPathShape].

[ipLoadPathTarget] – Load path target entity.  lpAnyEntity for all entities, lpEntitySet to target the
entity set specified at Integers[ipLoadPathSet], or one of lpBeamElement, lpPlateElement or
lpBrickElement for all Beams, Plates or Bricks respectively.

[ipLoadPathDivisions] – Number of divisions along the load path.

[ipLoadPathSet] – Entity set the load path targets if Integers[ipLoadPathTarget] is
lpEntitySet.

Doubles[0..8]

[0..2] – The start XYZ point in the definition of the load path (defined in the global XYZ system).

[3..5] – The end XYZ point in the definition of the load path.

[6..8] – The lateral XYZ point in the definition of the load path; used to define the plane of the load
path and its curvature (for circular load paths).

Dependencies

Default Group

Target group for the load path is specified by St7SetDefaultGroupID.
