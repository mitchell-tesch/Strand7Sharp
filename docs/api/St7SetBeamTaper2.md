# St7SetBeamTaper2

Sets the taper properties for the specified beam.

long St7SetBeamTaper2(long uID, long BeamNum, long TaperAxis, long TaperType,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

TaperAxis

The local beam axis to be tapered: axLocalX or axLocalY. See Beam Local Coordinates for additional
information.

TaperType

One of btTop, btSymm or btBottom.

Doubles[0..1]

A 2-element array that specifies the taper ratios at both ends of the beam. The dimension of the beam
section is scaled by this value to calculate the tapered shape.
