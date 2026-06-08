# St7GetLoadPathTemplateParameters

Returns the data assigned to the specified load path template.

long St7GetLoadPathTemplateParameters(long uID, long TemplateID, long* Integers,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

TemplateID

Load path template ID.

Output Parameters

Integers[0..4]

[ipLPTColour] – Load path colour. See also RGB Colours.

[ipLPTNumLanes] – Number of lanes.

[ipLPTMultiLaneType] – Multi lane type; either lpAllSameFactors or lpAllDifferentFactors.

Strand7 API Manual

[ipLPTTransitionLoad] – Transition trailing load path in time history analysis; either btTrue or
btFalse.

[ipLPTBeamLateralTolerance] – Apply relative tolerance in the lateral direction of the path for
loads on beam elements; either btTrue or btFalse.

Doubles[0..1]

[ipLPTTolerance] – Relative tolerance.

[ipLPTMinLaneWidth] – Minimum lane width.
