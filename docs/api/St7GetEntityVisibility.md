# St7GetEntityVisibility

Returns the visibility of the entities of the specified type within the model window.

long St7GetEntityVisibility(long uID, long Entity, bool* Visible)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyLINK, tyVERTEX, tyGEOMETRYFACE or tyLOADPATH.
Output Parameters
Visible
Visible state; either True or False.
