# St7GetBeamTaper2

Returns the taper properties for the specified beam.

long St7GetBeamTaper2(long uID, long BeamNum, long TaperAxis, long* TaperType,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

BeamNum

Beam number.

TaperAxis

The local beam axis to be tapered: axLocalX or axLocalY. See Beam Local Coordinates for additional
information.

Output Parameters
TaperType

One of btTop, btSymm or btBottom.

Doubles[0..1]

A 2-element array that specifies the taper ratios at both ends of the beam. The dimensions of the beam
section are scaled by these values to calculate the tapered shape.
