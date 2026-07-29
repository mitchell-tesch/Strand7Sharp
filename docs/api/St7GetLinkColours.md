# St7GetLinkColours

Returns the colours used for displaying links.

long St7GetLinkColours(long uID, long* Colours, long NumCol)
Input Parameters
uID
Strand7 model file ID.
NumCol
The size of Colours.
Output Parameters
Colours[0..14]
[ipLinkColour] – The global link colour.
[ipMasterSlaveColour] – The colour of master slave links.
[ipSectorSymmetryColour] – The colour of sector-symmetry links.
[ipCouplingColour] – The colour of coupling links.
[ipPinnedColour] – The colour of pinned links.
[ipRigidColour] – The colour of rigid links.
[ipShrinkColour] – The colour of shrink links.
[ipTwoPointColour] – The colour of two-point links.
[ipAttachmentColour] – The colour of attachment links.
[ipInterpolatedMPLColour] – The colour of interpolated multi-point links.
[ipMasterSlaveMPLColour] – The colour of master-slave multi-point links.
[ipPinnedMPLColour] – The colour of pinned multi-point links.
[ipRigidMPLColour] – The colour of rigid multi-point links.
[ipUserMPLColour] – The colour of user-defined multi-point links.
[ipReactionMPLColour] – The colour of reaction multi-point links.
See also RGB Colours.
