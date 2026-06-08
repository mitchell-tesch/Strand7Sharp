# St7Subdivide

Subdivides selected elements.

long St7Subdivide(long uID, long DivsA, long DivsB, long DivsC, long PlateTarget,

long BrickTarget)

Input Parameters

uID

Strand7 model file ID.

DivsA

Number of subdivisions in the A direction.  Applies to beams, plates and bricks.

DivsB

Number of subdivisions in the B direction.  Applies to plates and bricks.

DivsC

Number of subdivisions in the C direction.  Applies to bricks.

PlateTarget

One of stPlateTri3, stPlateTri6, stPlateQuad4, stPlateQuad8, stPlateQuad9, stPlateSource, stPlateTri or
stPlateQuad.

BrickTarget

One of stBrickTetra4, stBrickTetra10, stBrickWedge6, stBrickWedge15, stBrickHexa8, stBrickHexa16,
stBrickHexa20, stBrickSource, stBrickTetra, stBrickWedge or stBrickHexa.

Strand7 API Manual
