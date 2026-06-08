# St7SplitFaceByVertices

Splits a geometry face between pairs of vertices.

long St7SplitFaceByVertices(long uID, long NumVertexSets, long* VertexSetData)

Input Parameters

uID

Strand7 model file ID.

NumVertexSets

Number of vertex pairs to perform split operations.

VertexSetData[0..3*NumVertexSets-1]

For each of the iVertexSet vertex pairs to split,

[3*iVertexSet] – First vertex.

[3*iVertexSet+1] – Second vertex.

[3*iVertexSet+2] – Split direction.  Use 0 for the shortest distance split, or a higher number to
select an alternative for faces where multiple splits are possible.

Dependencies

Keep Selected

Assigned using St7SetKeepSelect.

Global Parameters

ivSeamsAdded, ivIntersectionsFound, ivFacesChanged, ivFacesCreated,
ivFacesFailed.
