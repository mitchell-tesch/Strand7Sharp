# St7GetPlateUseReducedInt

Returns the state of the Reduced Integration flag for the specified plate property. This option is only used for the
2D and Axisymmetric plate property types, applicable to quadratic elements.

long St7GetPlateUseReducedInt(long uID, long PropNum, bool* UseReducedInt)
Input Parameters
uID
Strand7 model file ID.
PropNum
Plate property number.

Output Parameters
UseReducedInt
True if a reduced order integration scheme is used.
