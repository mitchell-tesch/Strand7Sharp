# St7GetBeamSectionGeometryBGL

Returns the values that define the geometry of a cross section from the beam geometry library (BGL) contained in
the specified beam property.

long St7GetBeamSectionGeometryBGL(long uID, long PropNum, long* Shape,

double* Dimensions)

Input Parameters

uID

Strand7 model file ID.

PropNum

Beam property number.

Output Parameters

Shape

One of bgNullSection, bgRectangularHollow, bgISection, bgChannel, bgTSection, bgAngle or bgBulbFlat.

Dimensions[0..kMaxBGLDimensions-1]

Dimensions that define the beam section geometry; see Beam Geometry Library (BGL) Cross Section
Shapes.
