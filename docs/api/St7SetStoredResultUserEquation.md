# St7SetStoredResultUserEquation

Makes a stored user defined equation the currently active user defined equation.

long St7SetStoredResultUserEquation(long uID, long Entity, long Number)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyBEAM, tyPLATE or tyBRICK.
Number
User defined equation number for the specified entity.

Result Contour File
The results contour functionality offers an alternative workflow to using the functions in Results. This workflow is
more computationally efficient when a single element-based result quantity is to be extracted from many
elements, particularly when the quantity is a nodal quantity extrapolated from Gauss point results (e.g. stress).
