# St7SetAttachmentLink

Assigns the parameters for the specified attachment link.

long St7SetAttachmentLink(long uID, long LinkNum, long* Connection,

long* Integers, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

LinkNum

Link number.

Connection[0..1]

[0] – Number of nodes in the link (1).

Entities – Nodes, Elements and Links

[1] – Node number for attached node.

Integers[0..3]

[ipAttachmentElType] – Target entity type; one of tyBEAM, tyPLATE or tyBRICK.

[ipAttachmentElNum] – Target element number.

[ipAttachmentBrickFaceNum] – Target face number for tyBRICK; either 0 to attach to the inside of
the brick, or one of 1, 2, 3, 4, 5 or 6 to attach to the corresponding brick face.

[ipAttachmentCouple] – Connection between the degrees of freedom with target element; one of
cpTranslational, cpRotational or cpBoth.

Doubles[0..2]

A 3-element array containing the intrinsic uvw coordinates of the target attachment location.

For ipAttachmentElType = tyBEAM, only the first element is relevant and is clipped to [0.0, +1.0].

For ipAttachmentElType = tyPLATE, only the first two elements are relevant.  Both are clipped to [-1.0,
+1.0].

For ipAttachmentElType = tyBRICK, if ipAttachmentBrickFaceNum=0 all three values are required. If
ipAttachmentBrickFaceNum>0, only the first two are relevant. In both cases the range [-1.0, +1.0] is
used.

Dependencies

Default Group

Target group for the link is specified by St7SetDefaultGroupID.
