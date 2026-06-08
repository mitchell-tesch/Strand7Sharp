# St7SetReferenceDisplacement

Sets the reference case for extracted displacement results.

long St7SetReferenceDisplacement(long uID, long RefCase, bool ApplyToDisplay)

Input Parameters

uID

Strand7 model file ID.

RefCase

One of:

rdNone – absolute displacements;
rdPreviousCase – displacements relative to the previous case; or
A result case number – displacements relative to that specific case.

ApplyToDisplay

True to apply the reference displacement to both model window and extracted results.

False to apply the reference displacement only to extracted results.
