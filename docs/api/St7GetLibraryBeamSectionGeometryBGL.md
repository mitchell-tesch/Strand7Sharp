# St7GetLibraryBeamSectionGeometryBGL

Returns the values that define the geometry of a cross section from the beam geometry library (BGL).

long St7GetLibraryBeamSectionGeometryBGL(long LibraryID, long ItemID,
long LengthUnit, char* ItemName, long MaxStringLen, long* ItemShape,
double* ItemDimensions)
Input Parameters
LibraryID
Library ID.
ItemID
Item ID.
LengthUnit
One of luMETRE, luCENTIMETRE, luMILLIMETRE, luFOOT or luINCH.
MaxStringLen
The maximum number of characters allocated for ItemName.
Output Parameters
ItemName
Name of the item.
ItemShape
One of bgNullSection, bgRectangularHollow, bgISection, bgChannel, bgTSection, bgAngle or bgBulbFlat.
ItemDimensions[0..kMaxBGLDimensions-1]
Dimensions that define the beam section geometry; see Beam Geometry Library (BGL) Cross Section
Shapes.
