# St7DefinePlaneUCS

Creates a new plane definition from an existing UCS.

long St7DefinePlaneUCS(long uID, long UCSId, long UCSPlane, long* PlaneID)

Input Parameters

uID

Strand7 model file ID.

UCSId

UCS ID.

UCSPlane

Plane of UCS; one of 1, 2 or 3.

Output Parameters

PlaneID

Plane identifier.

Strand7 API Manual

Tools – Projection Direction

Functions in this section set the state of the projection direction option, as referenced by later function calls.  The
state persists until the model is closed, or the state is changed by a subsequent call.  The default projection
direction, which is used if none of the functions in this chapter have been called, is Target Normal.
