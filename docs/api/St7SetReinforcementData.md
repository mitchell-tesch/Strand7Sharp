# St7SetReinforcementData

Sets the concrete reinforcement data for the specified concrete reinforcement layout.

long St7SetReinforcementData(long uID, long LayoutID, long* Integers,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
LayoutID
Reinforcement layout ID.
Integers[0..9]
[ipRCLayoutType] – Layup type; either crRCSymmetric or crRCAntiSymmetric.
[ipRCColour13] – Layer 13 colour. See also RGB Colours.
[ipRCColour24] – Layer 24 colour. See also RGB Colours.
[ipRCCalcMethod] – Either crRCSimplified or crRCElastoPlasticIter.
[ipRCConsiderMembrane] – Consider membrane effects; either btTrue or btFalse.
[ipRCAllowCompressionReo] – Allow the steel reinforcement to support compression; either
btTrue or btFalse.
[ipRCCode] – One of crAS3600, crEC2 or crACI318.
[ipRCLimitConcreteStrain] – Add reinforcement to limit concrete strain; either btTrue or btFalse.
[ipRCUseMembraneThickness] – If btTrue, use plate element membrane thickness, otherwise use
plate element bending thickness.
[ipRCWoodArmerForce] – one of crRCWoodArmerShearForceMag, crRCWoodArmerShearForceSign
or crRCWoodArmerShearForceNone.
Doubles[0..20]
[ipRCDiam1] – Layer 1 bar diameter.
[ipRCDiam2] – Layer 2 bar diameter.
[ipRCDiam3] – Layer 3 bar diameter.
[ipRCDiam4] – Layer 4 bar diameter.
[ipRCCover1] – Cover 1 depth.
[ipRCCover2] – Cover 2 depth.
[ipRCSpacing1] – Layer 1 bar spacing.
[ipRCSpacing2] – Layer 2 bar spacing.
[ipRCSpacing3] – Layer 3 bar spacing.
[ipRCSpacing4] – Layer 4 bar spacing.
[ipRCConcreteModulus] – Concrete modulus.

[ipRCConcreteStrain] – Concrete strain limit.
[ipRCConcreteStress] – Concrete stress limit.
[ipRCConcreteAlpha] – Concrete alpha parameter.
[ipRCConcreteGamma] – Concrete gamma parameter.
[ipRCSteelModulus] – Steel modulus.
[ipRCSteelStress] – Steel stress limit.
[ipRCSteelGamma] – Steel gamma parameter.
[ipRCSteelMinArea] – Steel minimum area value.
[ipRCReduction] – Reduction factor.
[ipRCConcreteEta] – Concrete eta parameter.
