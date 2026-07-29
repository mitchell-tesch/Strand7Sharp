# St7CleanGeometry

Performs a geometry clean operation on the geometry included in the specified Strand7 model. Cleaning the
geometry can be used to improve geometry definitions and is typically recommended before subsequent
geometry or meshing operations are conducted. The operation consists of a number of different stages including:
vertex and curve zipping, duplicate face processing, curve and surface refitting and morphing.

long St7CleanGeometry(long uID, long* ChangesMade, long Mode)
Input Parameters
uID
Strand7 model file ID.
Mode
Controls the display of a progress bar; either ieQuietRun or ieProgressRun.

Output Parameters
ChangesMade
btTrue or btFalse.
Dependencies
Clean Geometry Data
Assigned using St7GetCleanGeometryOptions.

Global
