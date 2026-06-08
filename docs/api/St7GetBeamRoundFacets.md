# St7GetBeamRoundFacets

Returns the number of circumferential facets used to render circular beam sections and spring elements.

Beam Entity Display

long St7GetBeamRoundFacets(long uID, long* Facets)

Input Parameters

uID

Strand7 model file ID.

Output Parameters

Facets

The number of facets around one revolution in the range kMinFacets to kMaxFacets.
