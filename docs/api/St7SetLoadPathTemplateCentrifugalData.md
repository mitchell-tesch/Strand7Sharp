# St7SetLoadPathTemplateCentrifugalData

Sets the centrifugal data for the specified load path template.

long St7SetLoadPathTemplateCentrifugalData(long uID, long TemplateID, char* K0,

char* K1, long* Integers, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

TemplateID

Load path template ID.

K0

K1

Expression for the K0 term in the centrifugal force equation: Fc = K0 + K1*Fz. This formula can be a
function of R, L, V and g.

Expression for the K1 term in the centrifugal force equation: Fc = K0 + K1*Fz. This formula can be a
function of R, L, V and g.

Integers[0..2]

[ipLPTLimitK1] – Impose K1 limits; either btTrue or btFalse.

[ipLPTLengthUnit] – Length unit; one of luMETRE, luCENTIMETRE, luMILLIMETRE, luFOOT or
luINCH.

Load Path Templates

[ipLPTForceUnit] – Force unit; one of fuNEWTON, fuKILONEWTON, fuMEGANEWTON,
fuKILOFORCE, fuPOUNDFORCE, fuTONNEFORCE or fuKIPFORCE.

Doubles[0..1]

[ipLPTMinK1] – Minimum K1 value.

[ipLPTMaxK1] – Maximum K1 value.
