# St7GetGlobalIntegerValue

Returns a global integer state variable, which is internal to the Strand7 application.

long St7GetGlobalIntegerValue(long Index, long* Value)
Input Parameters
Index
One of the following global integer indexes.
Index Notes
ivAttachmentsCreated The number of successful attachments created by
St7CreateAttachments.
ivAttachmentsFailed The number of unsuccessful attachments attempted by
St7CreateAttachments.
ivAttributesApplied
ivBeamsChanged
ivBeamsCollapsed
ivBeamsCreated

ivBeamsDeleted
ivBeamsFailed
ivBeamsMoved
ivBeamsSplit
ivBeamsSubdivided
ivBricksChanged
ivBricksCollapsed
ivBricksCreated
ivBricksDeleted
ivBricksFailed
ivBricksGraded
ivBricksMoved
ivBricksSplit
ivBricksSubdivided
ivClipboardBeams
ivClipboardBricks
ivClipboardFaces
ivClipboardLinks
ivClipboardLoadPaths
ivClipboardNodes
ivClipboardPlates
ivClipboardVertices
ivDuplicateBeamsDeleted
ivDuplicateBricksDeleted

ivDuplicateLinksDeleted
ivDuplicatePlatesDeleted
ivEdgesMorphed The number of edges morphed.
ivEdgesSubdivided
ivFacesChanged The number of faces modified by a geometry operation.
ivFacesCreated The number of faces created by a geometry operation.
ivFacesDeleted
ivFacesFailed The number of faces that could not be processed by a
geometry operation.
ivFacesMeshed
ivFacesMoved
ivFacesNotMeshed
ivFacesPartiallyMeshed
ivFilletsCreated
ivFilletsFailed
ivIntersectionsFound The number of edges intersected by an intersection
operation.
ivLinksChanged
ivLinksCollapsed
ivLinksCreated
ivLinksDeleted
ivLinksMoved
ivLoadCasesCreated
ivLoadPathsChanged
ivLoadPathsCreated

ivLoadPathsMoved
ivLoftSeriesFound
ivLoopsDeleted The number of deleted loops.
ivNodesCreated
ivNodesDeleted
ivNodesMoved
ivPatchPlatesCreated
ivPlateEdgesAssigned The numbers of plate edges assigned by
St7ConvertPatchLoads.
ivPlateEdgesNotFullyAssigned The number of plate edges not fully assigned by
St7ConvertPatchLoads.
ivPlatesChanged
ivPlatesCollapsed
ivPlatesCreated
ivPlatesDeleted
ivPlatesFailed
ivPlatesGraded
ivPlatesMoved
ivPlatesSplit
ivPlatesSubdivided
ivSeamsAdded The number of seams added by a geometry operation.
ivSolidsMeshed
ivSolidsNotMeshed
ivSolidsPartiallyMeshed
ivSolverTerminationCode The termination code of the most recent solve if the .dll
solver is in use. See

Solver termination error codes for possible return values.
ivStringGroupsPacked
ivTessellationsFailed The number of geometry faces that could not be rendered.
ivUCSCreated The number of User Coordinate Systems (UCS) created.
Output Parameters
Value
Global integer state variable.
