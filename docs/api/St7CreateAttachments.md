# St7CreateAttachments

Generates attachment links based on the pre-defined attachment attributes.

long St7CreateAttachments(long uID, long BrickTarget, double AngleDelta,

bool DeleteExisting)

Input Parameters

uID

Strand7 model file ID.

BrickTarget

One of ktFreeFaces, to attach to free (exposed) brick faces, ktAllFaces, to attach to all brick faces
(exposed and internal) or ktInsideBricks, to create internal brick attachments.

AngleDelta

Angular tolerance (degrees), used when calculating attachment directions.

Strand7 API Manual

DeleteExisting

True to delete existing attachments links before attaching.

Dependencies
Selection

Entities can be selected using functions in Entity Selection.

Keep Selected

Assigned using St7SetKeepSelect.

Global Parameters

ivAttachmentsCreated, ivAttachmentsFailed.
