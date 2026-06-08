# St7GetPropertyVisibility

Determines the visibility of a property within the model window.

long St7GetPropertyVisibility(long uID, long Entity, long PropNum, bool* Visible)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE, tyBRICK or tyGEOMETRYFACE.

PropNum

Property number.

Output Parameters

Visible

Visible state; either True or False.

Strand7 API Manual
