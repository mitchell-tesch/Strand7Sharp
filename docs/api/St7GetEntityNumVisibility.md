# St7GetEntityNumVisibility

Determines whether or not an entity is visible in the model window.

long St7GetEntityNumVisibility(long uID, long Entity, long EntityNum,
bool* Visible)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyLINK, tyVERTEX, tyGEOMETRYFACE or tyLOADPATH.
EntityNum
Entity number.
Output Parameters
Visible
Visible state; either True or False.
