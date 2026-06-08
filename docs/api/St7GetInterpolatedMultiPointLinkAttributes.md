# St7GetInterpolatedMultiPointLinkAttributes

Returns attributes assigned to an interpolated multi-point link.

long St7GetInterpolatedMultiPointLinkAttributes(long uID, long LinkNum,

long* Couple)

Input Parameters

uID

Strand7 model file ID.

LinkNum

Link number.

Output Parameters

Couple

One of cpTranslational, cpRotational or cpBoth.
