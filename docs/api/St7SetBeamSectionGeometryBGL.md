# St7SetBeamSectionGeometryBGL

Sets the beam cross section geometry by specifying the dimensions of a cross section from the beam geometry
library (BGL).

long St7SetBeamSectionGeometryBGL(long uID, long PropNum, long Shape,

double* Dimensions)

Input Parameters

uID

Strand7 model file ID.

PropNum

Beam property number.

Shape

One of bgNullSection, bgRectangularHollow, bgISection, bgChannel, bgTSection, bgAngle or bgBulbFlat.

Properties – Beams, Plates and Bricks

Dimensions[0..kMaxBGLDimensions-1]

Dimensions that define the beam section geometry; see Beam Geometry Library (BGL) Cross Section
Shapes.
