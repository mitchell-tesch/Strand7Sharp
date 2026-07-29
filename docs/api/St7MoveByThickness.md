# St7MoveByThickness

Moves selected entities by thickness.

long St7MoveByThickness(long uID, double Thickness, long BeamDir,
long PlateSurface, long FaceSurface, bool UsePlateThickness,
bool UseFaceThickness)
Input Parameters
uID
Strand7 model file ID.
Thickness
Distance to move.
BeamDir
Direction to move beams in their principal axis system; either 1 or 2.
PlateSurface
Direction to move plates if UsePlateThickness is True; either psPlateMinusZ or psPlatePlusZ.
FaceSurface
Direction to move geometry faces if UseFaceThickness is True; either psPlateMinusZ or psPlatePlusZ.

UsePlateThickness
True to base the increment on the thickness of the plate.
UseFaceThickness
True to base the increment on the thickness of the geometry faces.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
