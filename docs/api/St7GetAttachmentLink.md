# St7GetAttachmentLink

Returns the parameters for the specified attachment link.

long St7GetAttachmentLink(long uID, long LinkNum, long* Connection,

long* Integers, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

LinkNum

Link number.

Output Parameters

Connection[0..1]

[0] – Number of nodes in the link (1).

[1] – Node number for attached node.

Integers[0..3]

[ipAttachmentElType] – Target entity type; one of tyBEAM, tyPLATE or tyBRICK.

Strand7 API Manual

[ipAttachmentElNum] – Target element number.

[ipAttachmentBrickFaceNum] – Target face number for tyBRICK; either 0 for the inside of the
brick, or one of 1, 2, 3, 4, 5 or 6 for the corresponding brick face.

[ipAttachmentCouple]- Connection between the degrees of freedom with target element; one of
cpTranslational, cpRotational or cpBoth.

Doubles[0..2]

A 3-element array containing the intrinsic uvw coordinates of the target attachment location.

For ipAttachmentElType = tyBEAM, only the first element is assigned using the range [0.0, +1.0].

For ipAttachmentElType = tyPLATE, the first two elements are assigned.  Both in the range [-1.0, +1.0].

For ipAttachmentElType = tyBRICK, if ipAttachmentBrickFaceNum=0 all three values are assigned. If
ipAttachmentBrickFaceNum>0, only the first two are assigned. In both cases the range [-1.0, +1.0] is
used.
