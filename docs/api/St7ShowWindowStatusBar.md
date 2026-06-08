# St7ShowWindowStatusBar

Strand7 API Manual

RGB Colours

When colours are passed to or returned from a Strand7 API function, the 32-bit RGB format integer is used.  The
format is composed of four bytes, the least significant three of which carry the colour components.

Most Significant

Least Significant

Null

Blue (0-255)

Green (0-255)

Red (0-255)

For example, consider the colour defined by the components Red = 33, Green = 165 and Blue = 239. The colour
would be passed to Strand7 as

𝑅𝐺𝐵 = (2562 × 𝐵𝑙𝑢𝑒)   + (256 × 𝐺𝑟𝑒𝑒𝑛) + 𝑅𝑒𝑑

=

15705377

When passing in a colour value, the most significant bit should always be 0. That is, the RGB value should always
be less than 16777216.

The functions  St7RGBToColour and St7ColourToRGB are provided to facilitate the conversion of colour
representations.

Entity Contours

Entity Contours

The following constants are passed by St7SetEntityContourIndex and St7GetEntityContourIndex as the parameter
Index. They identify the pre-processor contour types listed in the Entity Display combo boxes.

Beam Contour Types

Constant

ctBeamNone

Description

No contour

ctBeamLength

Beam length

ctBeamAxis1

ctBeamAxis2

ctBeamAxis3

ctBeamEA

ctBeamEI11

ctBeamEI22

ctBeamGJ

Coordinate system axis 1 component

Coordinate system axis 2 component

Coordinate system axis 3 component

EA axial stiffness

EI1 bending stiffness

EI2 bending stiffness

GJ torsional stiffness

ctBeamEAFactor

Scaled EA axial stiffness

ctBeamEI11Factor

Scaled EI1 bending stiffness

ctBeamEI22Factor

Scaled EI2 bending stiffness

ctBeamGJFactor

Scaled GJ torsional stiffness

ctBeamOffset1

Offset in the local beam 1 direction

ctBeamOffset2

Offset in the local beam 2 direction

ctBeamStiffnessFactor1

Stiffness factor for shear stiffness 1

ctBeamStiffnessFactor2

Stiffness factor for shear stiffness 2

ctBeamStiffnessFactor3

Stiffness factor for axial stiffness

ctBeamStiffnessFactor4

Stiffness factor for bending stiffness in plane 1 (about 2 axis)

ctBeamStiffnessFactor5

Stiffness factor for bending stiffness in plane 2 (about 1 axis)

Strand7 API Manual

ctBeamStiffnessFactor6

Stiffness factor for torque stiffness

ctBeamMassFactor

Mass factor

ctBeamSupportM1

Support in the -1 principal beam direction

ctBeamSupportP1

Support in the +1 principal beam direction

ctBeamSupportM2

Support in the -2 principal beam direction

ctBeamSupportP2

Support in the +2 principal beam direction

ctBeamSupportGapM1

Compression-only support activation gap in the -1 beam direction

ctBeamSupportGapP1

Compression-only support activation gap in the +1 beam direction

ctBeamSupportGapM2

Compression-only support activation gap in the -2 beam direction

ctBeamSupportGapP2

Compression-only support activation gap in the +2 beam direction

ctBeamTemperature

Applied node temperature

ctBeamPreTension

Pre-tension

ctBeamPreStrain

Pre-strain

ctBeamPreCurvature1

Pre-curvature in the local beam 1 direction

ctBeamPreCurvature2

Pre-curvature in the local beam 2 direction

ctBeamTempGradient1

Temperature gradient in the local beam 1 direction

ctBeamTempGradient2

Temperature gradient in the local beam 2 direction

ctBeamPipePressureIn

Internal pipe pressure

ctBeamPipePressureOut

External pipe pressure

ctBeamPipeTempIn

Internal pipe temperature

ctBeamPipeTempOut

External pipe temperature

ctBeamConvectionCoeff

Convection coefficient

ctBeamConvectionAmbient

Convection ambient temperature

ctBeamRadiationCoeff

Radiation coefficient

Entity Contours

ctBeamRadiationAmbient

Radiation ambient temperature

ctBeamHeatFlux

Heat flux

ctBeamHeatSource

Heat source

ctBeamAgeAtFirstLoading

Age at first loading

ctBeamPropertyName

Property name

ctBeamMaterialName

Material name

ctBeamSectionName

Cross section name

ctBeamEntityID

Entity ID

Plate Contour Types

Constant

ctPlateNone

Description

No Contour

ctPlateAspectRatioMin

Minimum aspect ratio

ctPlateAspectRatioMax

Maximum aspect ratio

ctPlateWarping

Warping

ctPlateInternalAngle

Internal angle

ctPlateInternalAngleRatio

Internal angle ratio

ctPlateDiscreteThicknessM

Discrete membrane thickness

ctPlateContinuousThicknessM

Continuous membrane thickness

ctPlateDiscreteThicknessB

Discrete bending thickness

ctPlateContinuousThicknessB

Continuous bending thickness

ctPlateOffset

Normal offset

ctPlateStiffnessFactor1

Cxx membrane stiffness factor

ctPlateStiffnessFactor2

Cyy membrane stiffness factor

ctPlateStiffnessFactor3

Cgg membrane stiffness factor

Strand7 API Manual

ctPlateStiffnessFactor4

Dxx bending stiffness factor

ctPlateStiffnessFactor5

Dyy bending stiffness factor

ctPlateStiffnessFactor6

Dgg bending stiffness factor

ctPlateStiffnessFactor7

Gxx transverse stiffness factor

ctPlateStiffnessFactor8

Gyy transverse stiffness factor

ctPlateMassFactor

Mass factor

ctPlateArea

ctPlateAxis1

ctPlateAxis2

ctPlateAxis3

Area

Coordinate system axis 1 component

Coordinate system axis 2 component

Coordinate system axis 3 component

ctPlateTemperature

Applied temperature

ctPlateEdgeNormalSupport

Edge normal support

ctPlateEdgeLateralSupport

Edge lateral support

ctPlateEdgeSupportGap

Edge support gap

ctPlateFaceNormalSupportMinusZ

Face normal support on the -z plate surface

ctPlateFaceNormalSupportPlusZ

Face normal support on the +z plate surface

ctPlateFaceLateralSupportMinusZ

Face lateral support on the -z plate surface

ctPlateFaceLateralSupportPlusZ

Face lateral support on the +z plate surface

ctPlateFaceSupportGapMinusZ

Compression only face support activation gap on the -z plate surface

ctPlateFaceSupportGapPlusZ

Compression only face support activation gap on the +z plate surface

ctPlatePreStressX

Pre-stress in the local plate x direction

ctPlatePreStressY

Pre-stress in the local plate y direction

ctPlatePreStressZ

Pre-stress in the local plate z direction

ctPlatePreStressMagnitude

Pre-stress magnitude

Entity Contours

ctPlatePreStrainX

Pre-strain in the local plate x direction

ctPlatePreStrainY

Pre-strain in the local plate y direction

ctPlatePreStrainZ

Pre-strain in the local plate z direction

ctPlatePreStrainMagnitude

Pre-strain magnitude

ctPlatePreCurvatureX

Pre-curvature in the local plate x direction

ctPlatePreCurvatureY

Pre-curvature in the local plate y direction

ctPlatePreCurvatureMagnitude

Pre-curvature magnitude

ctPlateTempGradient

Temperature gradient

ctPlateEdgeNormalPressure

Edge normal pressure

ctPlateEdgeShear

Edge shear stress

ctPlateEdgeTransverseShear

Edge transverse shear stress

ctPlateEdgeGlobalPressure

Edge global pressure magnitude

ctPlateEdgeGlobalPressureX

Edge global pressure in the global X direction

ctPlateEdgeGlobalPressureY

Edge global pressure in the global Y direction

ctPlateEdgeGlobalPressureZ

Edge global pressure in the global Z direction

ctPlateNormalPressureMinusZ

Normal pressure (-z)

ctPlateNormalPressurePlusZ

Normal pressure (+z)

ctPlateGlobalPressureMinusZ

Global pressure magnitude (-z)

ctPlateGlobalPressureXMinusZ

Pressure in the global X direction (-z)

ctPlateGlobalPressureYMinusZ

Pressure in the global Y direction (-z)

ctPlateGlobalPressureZMinusZ

Pressure in the global Z direction (-z)

ctPlateGlobalPressurePlusZ

Global pressure magnitude (+z)

ctPlateGlobalPressureXPlusZ

Pressure in the global X direction (+z)

ctPlateGlobalPressureYPlusZ

Pressure in the global Y direction (+z)

Strand7 API Manual

ctPlateGlobalPressureZPlusZ

Pressure in the global Z direction (+z)

ctPlateFaceShearX

Face shear stress in the local plate x direction

ctPlateFaceShearY

Face shear stress in the local plate y direction

ctPlateFaceShearMagnitude

Face shear stress magnitude

ctPlateNSMass

Non-structural mass

ctPlateDynamicFactor

Non-structural mass dynamic factor

ctPlateConvectionCoeff

Edge convection coefficient

ctPlateConvectionAmbient

Edge convection ambient temperature

ctPlateRadiationCoeff

Edge radiation coefficient

ctPlateRadiationAmbient

Edge radiation ambient temperature

ctPlateHeatFlux

Edge heat flux

ctPlateConvectionCoeffPlusZ

Face convection coefficient (+z)

ctPlateConvectionCoeffMinusZ

Face convection coefficient (-z)

ctPlateConvectionAmbientPlusZ

Face convection ambient temperature (+z)

ctPlateConvectionAmbientMinusZ

Face convection ambient temperature (-z)

ctPlateRadiationCoeffPlusZ

Face radiation coefficient (+z)

ctPlateRadiationCoeffMinusZ

Face radiation coefficient (-z)

ctPlateRadiationAmbientPlusZ

Face radiation ambient temperature (+z)

ctPlateRadiationAmbientMinusZ

Face radiation ambient temperature (-z)

ctPlateHeatSource

Heat source

ctPlateSoilStressSV

Soil stress Sv

ctPlateSoilStressK0

Soil stress K0

ctPlateSoilStressSH

Soil stress Sh

ctPlateSoilRatioOCR

Soil OCR (over-consolidation ratio)

Entity Contours

ctPlateSoilRatioE0

Soil ratio e0

ctPlateSoilFluidLevel

Soil fluid level

ctPlateAgeAtFirstLoading

Age at first loading

ctPlatePropertyName

Property name

ctPlateMaterialName

Material name

ctPlateEntityID

Entity ID

Brick Contour Types

Constant

ctBrickNone

Description

No contour

ctBrickAspectRatioMin

Minimum aspect ratio

ctBrickAspectRatioMax

Maximum aspect ratio

ctBrickVolume

Brick volume

ctBrickDeterminant

Determinant of brick Jacobian matrix

ctBrickInternalAngle

Internal angle

ctBrickMixedProduct

Mixed product

ctBrickDihedral

Dihedral angle ratio

ctBrickAxis1

ctBrickAxis2

ctBrickAxis3

Coordinate system axis 1 component

Coordinate system axis 2 component

Coordinate system axis 3 component

ctBrickTemperature

Applied temperature

ctBrickNormalSupport

Face normal support

ctBrickLateralSupport

Face lateral support

ctBrickSupportGap

Compression only face support activation gap

ctBrickPreStressX

Pre-stress in the local brick x direction

Strand7 API Manual

ctBrickPreStressY

Pre-stress in the local brick y direction

ctBrickPreStressZ

Pre-stress in the local brick z direction

ctBrickPreStressMagnitude

Pre-stress magnitude

ctBrickPreStrainX

Pre-strain in the local brick x direction

ctBrickPreStrainY

Pre-strain in the local brick y direction

ctBrickPreStrainZ

Pre-strain in the local brick z direction

ctBrickPreStrainMagnitude

Pre-strain magnitude

ctBrickNormalPressure

Normal pressure

ctBrickGlobalPressureMagnitude   Global pressure magnitude

ctBrickGlobalPressureX

Pressure in the global X direction

ctBrickGlobalPressureY

Pressure in the global Y direction

ctBrickGlobalPressureZ

Pressure in the global Z direction

ctBrickShearX

Face shear in the local brick face x direction

ctBrickShearY

Face shear in the local brick face y direction

ctBrickShearMagnitude

Face shear magnitude

ctBrickNSMass

Non-structural mass

ctBrickDynamicFactor

Non-structural mass dynamic factor

ctBrickConvectionCoeff

Convection coefficient

ctBrickConvectionAmbient

Convection ambient temperature

ctBrickRadiationCoeff

Radiation coefficient

ctBrickRadiationAmbient

Radiation ambient temperature

ctBrickHeatFlux

Heat flux

ctBrickHeatSource

Heat source

ctBrickSoilStressSV

Soil stress Sv

Entity Contours

ctBrickSoilStressK0

Soil stress K0

ctBrickSoilStressSH

Soil stress Sh

ctBrickSoilRatioOCR

Soil OCR (over-consolidation ratio)

ctBrickSoilRatioE0

Soil ratio e0

ctBrickSoilFluidLevel

Soil fluid level

ctBrickAgeAtFirstLoading

Age at first loading

ctBrickPropertyName

Property name

ctBrickMaterialName

Material name

ctBrickEntityID

Entity ID

Strand7 API Manual

Result Display Options

It is possible to set the result displays found in Results Settings for a Strand7 API model window when a result file
is open. The display options found in Results Settings can be configured with the functions
St7SetBeamResultDisplay, St7SetPlateResultDisplay, St7SetBrickResultDisplay and St7SetLinkResultDisplay. These
functions all pass an Integers array, whose contents are detailed below – note that the bold type indicates the
Results Settings combo box name seen in the GUI.

Result type – Integers[ipResultType]

SHOW AS:

rtAsNone – No result display.

rtAsContour – Display result as element contour.

rtAsDiagram – Display result as element diagram.

rtAsVector – Display result as element vector.

Result quantity – Integers[ipResultQuantity]

QUANTITY:

For beams, plates, bricks and links:

rqDispC – Displacement results.

rqInfluenceC – Influence results.

rqVelC – Velocity results.

rqAccC – Acceleration results.

rqPhaseC – Phase results.

rqReactC – Reaction results.

rqNodeForceC – Element node force results.

rqNodeInertiaC – Node inertia results.

rqTempC – Temperature results.

rqNodeFluxC – Flux results.

For beams:

rqBeamForceC – Beam force results.

rqBeamStrainC – Beam deformational strain results.

rqBeamTotalStrainC – Beam total strain results.

rqBeamStressC – Beam stress results.

rqBeamCreepStrainC – Beam creep strain results.

rqBeamEnergyC – Beam energy results.

rqBeamFluxC – Beam heat flux results.

Result Display Options

rqBeamTGradC – Beam temperature gradient results.

rqBeamUserC – Beam user defined equation results.

For plates:

rqPlateForceC – Plate force results.

rqPlateMomentC – Plate moment results.

rqPlateStressC – Plate stress results.

rqPlateStrainC – Plate deformational strain results.

rqPlateTotalStrainC – Plate total strain results.

rqPlateCurvatureC – Plate deformational curvature results.

rqPlateTotalCurvatureC – Plate total curvature results.

rqPlateCreepStrainC – Plate creep strain results.

rqPlateEnergyC – Plate energy results.

rqPlateFluxC – Plate heat flux results.

rqPlateTGradC – Plate temperature gradient results.

rqPlateRCDesignC – Plate concrete reinforcement results.

rqPlatePlyStressC – Plate ply stress results.

rqPlatePlyStrainC – Plate ply strain results.

rqPlatePlyReserveC – Plate ply reserve factor results.

rqPlateSoilC – Plate soil results.

rqPlateUserC – Plate user defined equation results.

For bricks:

rqBrickStressC – Brick stress results.

rqBrickStrainC – Brick deformational strain results.

rqBrickTotalStrainC – Brick total strain results.

rqBrickCreepStrainC – Brick creep strain results.

rqBrickEnergyC – Brick energy results.

rqBrickFluxC – Brick heat flux results.

rqBrickTGradC – Brick temperature gradient results.

rqBrickSoilC – Brick soil results.

rqBrickUserC – Brick user defined equation results.

Strand7 API Manual

For links:

rqLinkForceC – Link force results.

rqLinkFluxC – Link flux results.

rqLinkMPLReactionC – Reaction MPL summation results.

Result axis – Integers[ipResultSystem]

SYSTEM:

stBeamLocal – use beam local axes.

stBeamPrincipal – use beam principal axes.

stBeamGlobal – use global axes.

stPlateLocal – use plate local axes.

stPlateGlobal – use global axes.

stPlateCombined – use plate combined results.

stBrickLocal – use brick local axes.

stBrickGlobal – use global axes.

stBrickCombined – use brick combined results.

stLinkGlobal – use global axes.

Alternatively, you can use the UCS ID in which frame the result is to be defined.
Similar to the GUI behaviour, UCS ID must agree with that set by St7SetWindowUCSCase, for expected
results. Note that the UCS IDs in a model begin at an index of 2.

In the special case of presenting the steel requirement of reinforced concrete plate results, the following
constants are used:

rsAreaPerLength.

rsBarSpacing.

rsBarDiameter.

rsAreaPerAreaSlab.

rsAreaPerAreaBase.

In the special case of presenting the laminate plate results; one of the following constants can be used:

Layer input

Ply number

rsPlyMinValue

rsPlyMaxValue

rsPlyMaxMag

Result output

One specified ply.

Minimum of all plies.

Maximum of all plies.

Maximum magnitude of all plies.

Result Display Options

rsPlyMinValueActivePlies

Minimum of plies enabled by True to perform the angle check; False to skip
the angle check.

rsPlyMaxValueActivePlies

rsPlyMaxMagActivePlies

St7EnablePlyPropertyResults.

Maximum of plies enabled by True to perform the angle check; False to skip
the angle check.
St7EnablePlyPropertyResults.

Maximum magnitude of plies enabled by True to perform the angle check;
False to skip the angle check.
St7EnablePlyPropertyResults.

Result surface – Integers[ipResultSurface]

For plates, the SURFACE for general results:

psPlateMidPlane – contour the mid-plane.

psPlateMinusZ – contour the value occurring on the local -z side of the plate.

psPlatePlusZ – contour the value occurring on the local +z side of the plate.

For reinforced concrete plate results, the SURFACE is the reinforcement layer (1, 2, 3 or 4).

Result components – Integers[ipResultComponent]

COMPONENT:

The position index of the desired result component in the combo box labelled COMPONENT: in the
Results Settings. Indices start at 1 at the top of the combo list, and increment downwards.

Note that this setting is in reference to the GUI, and its behaviour depends on Integers[ipResultType],
Integers[ipResultQuantity] and Integers[ipResultSystem]. For example, it would be ignored when
Integers[ipResultType] = rtAsDiagram or Integers[ipResultType] = rtAsVector.

When reinforced concrete plate results are presented, the following constants may be used:
rcWoodArmerMoment, rcWoodArmerForce, rcSteelRequirementMin, rcConcreteStrain,
rcSteelRequirementLessBase, rcUserSteelStress, rcUserConcreteStrain or rcBlockRatio.

Result vector components – Integers[ipVectorStyle]

Where Integers[ipResultType] = rtAsVector with appropriate Integers[ipResultQuantity] and
Integers[ipResultSystem] settings, the vector style is set by COMPONENT:

vtVectorTranslationMag – the translation vector is drawn as a single arrow in the appropriate direction.

vtVectorTranslationComponents – the translation vector is drawn as three component arrows.

vtVectorRotationMag – the rotation vector is drawn as a single arrow in the appropriate direction.

vtVectorRotationComponents – the rotation vector is drawn as three component arrows.

For vtVectorTranslationComponents and vtVectorRotationComponents above, the flags labelled by AXES: are
manipulated by the following indices into Integers.

Integers[ipVector1] – display the first vector translational component, btTrue or btFalse.

Strand7 API Manual

Integers[ipVector2] – display the second vector translational component, btTrue or btFalse.

Integers[ipVector3] – display the third vector translational component, btTrue or btFalse.

Integers[ipVector4] – display the first vector rotational component, btTrue or btFalse.

Integers[ipVector5] – display the second vector rotational component, btTrue or btFalse.

Integers[ipVector6] – display the third vector rotational component, btTrue or btFalse.

Diagram Flags – Integers[ipDiagram1..ipDiagram6]

Where Integers[ipResultType] = rtAsDiagram for beam elements, the flags labelled COMPONENT: are manipulated
by the following indices into Integers.

Integers[ipDiagram1] – shear force in Plane 1/Plane x; either btTrue or btFalse.

Integers[ipDiagram2] – bending moment in Plane 1/Plane x; either btTrue or btFalse.

Integers[ipDiagram3] – shear force in Plane 2/Plane y; either btTrue or btFalse.

Integers[ipDiagram4] – bending moment in Plane 2/Plane y; either btTrue or btFalse.

Integers[ipDiagram5] – axial force; either btTrue or btFalse.

Integers[ipDiagram6] – torque, btTrue or btFalse.

Custom Results

Custom Results

User defined results files (custom result files) can be created directly using the Strand7 API. Once created, these
results can be opened and manipulated in the same way as normal Strand7 result files.

The basic workflow for creating a custom result file involves the following steps.

St7NewResFile – to create a new, empty custom result file.

St7SetResFileNumCases – to set up a number of result cases to store results in. Optionally they can also
be given names using St7SetResFileCaseName.

St7SetResFileQuantity – to set result file quantity types to be stored in the custom result file.

St7SetResFileBeamStations – to set the number of beam stations, should the model include beam
results. This function should be called once per result case in the custom result file, not once per beam
element. The set number of stations applies to all beam elements in the model for the specified result
case.

St7SetResFileNodeResult/St7SetResFileBeamResult/St7SetResFileBeamReleaseResult/St7SetResFilePlate
Result/St7SetResFilePlatePressureResult/St7SetResFileBrickResult – to write elemental results.

St7CloseResFile – to close the custom result file.

St7NewResFile will initialise the units of the result file with a set of units based on the length unit of the model file
with which the result file is associated. The result file units are set as follows:

Units automatically assigned to custom result file

Model Length Unit

Force

Mass

m

cm

mm

ft

in

N

kgf

N

lbf

lbf

kg

kg

t

sl

lb

Stress

Pa

kgf/cm2

N/mm2 (MPa)

lb/ft2 (psf)

lbf/in2 (psi)

The other two base units, temperature and energy, are independent of all other units; the custom result file will
be assigned the same temperature and energy units as defined in the associated model file. St7GetResFileUnits
can be used to retrieve the units in the result file. Irrespective of the units assigned to the custom result file, result
quantities will always be available in any units system (i.e., in the units of the model file that opens the result file).

The following basic quantities may be stored in custom result files. They are manipulated using the functions
St7SetResFileQuantity, St7ClearResFileQuantity, St7GetResFileQuantityState.

Node Results

rtNodeDisp, rtNodeVel, rtNodeAcc, rtNodeReact, rtNodeTemp or rtNodeFlux.

Beam Results

rtBeamForce, rtBeamAllStrain, rtBeamNodeReact, rtBeamExtraResults or rtBeamFlux.

Strand7 API Manual

Plate Results

rtPlateStress, rtPlateStrain, rtPlateNodeReact or rtPlateFlux.

Brick Results

rtBrickStress, rtBrickStrain, rtBrickNodeReact or rtBrickFlux.

Node Results

The functions St7SetResFileNodeResult/St7GetResFileNodeResult pass an array Doubles of nodal results relevant
to the nominated result Quantity.

Quantity: [rtNodeDisp/rtNodeVel/rtNodeAcc/rtNodeReact]

These quantities refer to vector results of nodal displacement, velocity, acceleration, and reaction, respectively.
The following indices into the array Doubles specify translational and rotational results:

ipNodeResFileDX – in the global X direction.

ipNodeResFileDY – in the global Y direction.

ipNodeResFileDZ – in the global Z direction.

ipNodeResFileRX – about the global X axis.

ipNodeResFileRY – about the global Y axis.

ipNodeResFileRZ – about the global Z axis.

The units of the result data must be consistent with the length unit of the result file based on the following table.

Quantity

Type

rtNodeDisp

Translation

rtNodeDisp

Rotation

rtNodeVel

Translation

rtNodeVel

Rotation

rtNodeAcc

Translation

m

m

rad

m/s

rad/s

m/s2

Result File Length Unit

cm

cm

rad

cm/s

rad/s

cm/s2

mm

mm

rad

mm/s

rad/s

mm/s2

ft

ft

rad

ft/s

rad/s

ft/s2

in

in

rad

in/s

rad/s

in/s2

rtNodeAcc

Rotation

rad/s2

rad/s2

rad/s2

rad/s2

rad/s2

rtNodeReact

Translation

N

kgf

N

lbf

lbf

rtNodeReact

Rotation

N.m

kgf.cm

N.mm

lbf.ft

lbf.in

Quantity: [rtNodeTemp/rtNodeFlux]

These quantities refer to scalar quantities of nodal temperature and heat flux, respectively. The following index
into the array Doubles specifies both results:

ipNodeResTempFlux – Temperature/flux result.

Custom Results

The units of the result data must be consistent with the temperature and energy units of the result file based on
the following table.

Quantity

Result File Units

Temperature, Energy

rtNodeTemp

temperature

rtNodeFlux

energy/s

Beam Results

The functions St7SetResFileBeamResult/St7GetResFileBeamResult pass an array Doubles of nodal results relevant
to the nominated result Quantity.  For station-dependent results such as rtBeamForce and rtBeamAllStrain, the
number of beam stations should be set for the result file using St7SetResFileBeamStations. End release results are
handled by the dedicated functions St7SetResFileBeamReleaseResult/St7GetResFileBeamReleaseResult.

Quantity: rtBeamForce

For each beam station, a block of results kBeamResFileForceSize long is stored in Doubles. The following constants
index the results in each block:

ipBeamResFileSF1 – Shear force in the principal 1 axis direction.

ipBeamResFileSF2 – Shear force in the principal 2 axis direction.

ipBeamResFileAxial – Axial force.

ipBeamResFileBM1 – Bending moment in the principal 1 axis direction.

ipBeamResFileBM2 – Bending moment in the principal 2 axis direction.

ipBeamResFileTorque – Torque.

For example, the axial force at the ith beam station is stored at:

Doubles[(i-1)*kBeamResFileForceSize + ipBeamResFileAxial].

The units of the result data must be consistent with the length units of the result file based on the following table.

Result File Length Unit

rtBeamForce

Force

m

N

cm

kgf

mm

N

ft

lbf

in

lbf

Moment

N.m

kgf.cm

N.mm

lbf.ft

lbf.in

Quantity: rtBeamAllStrain

For each beam station, a block of results kBeamResFileStrainSize long is stored in Doubles. The following
constants index the results in each block:

Strand7 API Manual

ipBeamResFileAxialStrain – Axial strain.

ipBeamResFileCurvature1 – Curvature in the principal 1 axis direction.

ipBeamResFileCurvature2 – Curvature in the principal 2 axis direction.

ipBeamResFileTwist – Twisting strain.

The units of the result data must be consistent with the length units of the result file based on the following table.

rtBeamAllStrain

Result File Length Unit

m

cm

mm

ft

in

Axial Strain

none

none

Curvature

Twist

m-1

m-1

cm-1

cm-1

none

mm-1

mm-1

none

none

ft-1

ft-1

in-1

in-1

Quantity: rtBeamNodeReact

For each beam end, a block of results kBeamResFileReactSize long is stored in Doubles. The following constants
index the results in each block:

ipBeamResFileFX – Force reaction in the X axis direction.

ipBeamResFileFY – Force reaction in the Y axis direction.

ipBeamResFileFZ – Force reaction in the Z axis direction.

ipBeamResFileMX – Moment reaction in the X axis direction.

ipBeamResFileMY – Moment reaction in the Y axis direction.

ipBeamResFileMZ – Moment reaction in the Z axis direction.

The units of the result data must be consistent with the length units of the result file based on the following table.

Result File Length Unit

rtBeamNodeReact

Force

Moment

m

N

cm

kgf

mm

N

ft

lbf

in

lbf

N.m

kgf.cm

N.mm

lbf.ft

lbf.in

Quantity: Beam End Release

Beam end release results are assigned using St7SetResFileBeamReleaseResult. The following constants index the
results in the array:

ipRelEnd1Dir1 – End 1 translational release in the 1 axis direction.

ipRelEnd1Dir2 – End 1 translational release in the 2 axis direction.

Custom Results

ipRelEnd1Dir3 – End 1 translational release in the 3 axis direction.

ipRelEnd1Dir4 – End 1 rotational release about the 1 axis direction.

ipRelEnd1Dir5 – End 1 rotational release about the 2 axis direction.

ipRelEnd1Dir6 – End 1 rotational release about the 3 axis direction.

ipRelEnd2Dir1 – End 2 translational release in the 1 axis direction.

ipRelEnd2Dir2 – End 2 translational release in the 2 axis direction.

ipRelEnd2Dir3 – End 2 translational release in the 3 axis direction.

ipRelEnd2Dir4 – End 2 rotational release about the 1 axis direction.

ipRelEnd2Dir5 – End 2 rotational release about the 2 axis direction.

ipRelEnd2Dir6 – End 2 rotational release about the 3 axis direction.

The units of the result data must be consistent with the length unit of the result file based on the following table.

Release Direction

Dir1, Dir2, Dir3

m

m

Dir4, Dir5, Dir6

rad

Result File Length Unit

cm

mm

cm

rad

mm

rad

ft

ft

in

in

rad

rad

Quantity: rtBeamFlux

For each beam end, a block of results kBeamResFileFluxSize long is stored in Doubles. The following constants
index the results in each block:

ipBeamResFileF – Beam heat flux at the end.

ipBeamResFileG – Beam temperature gradient at the end.

The units of the result data must be consistent with the energy, length and temperature units of the result file
based on the following table.

rtBeamFlux

Result File Units

Energy, Length, Temperature

Flux

energy/s/length2

Temperature Gradient

temperature/length

Quantity: rtBeamNodeFlux

For each beam end, one flux result is stored in Doubles.

The units of the result data must be consistent with the energy units of the result file based on the following table.

Strand7 API Manual

rtBeamNodeFlux

Flux

Plate Results

Result File Units

Energy

energy/s

The functions St7SetResFilePlateResult/St7GetResFilePlateResult pass an array Doubles containing Gauss point or
node results depending on the nominated result Quantity. When the results are intended to correspond to a
material nonlinear analysis, a flag NonlinearMaterial is set to btTrue to indicate that extra indices in Doubles are
used to define the nonlinear stress state, for plate/shell type elements.

Result blocks

The number of Gauss point or node result blocks expected by St7SetResFilePlateResult depends on the number of
nodes on the element, according to the following table.  This is independent of solution, material or element type
and may differ compared with the raw results produced directly by the solvers.

Plate nodes

Plate type

Number of Gauss point related
result blocks required

Number of node related
result blocks required

Tri3

Tri6

Quad4

Quad8

Quad9

Quantity: rtPlateStress resultants for plate/shell type elements

For each Gauss point, a block of results kPlateShellResFileStressSize long is stored in Doubles. The following
constants index the results in each block.

ipPlateShellResFileNxx – Membrane force per unit width in the local x axis direction.

ipPlateShellResFileNyy – Membrane force per unit width in the local y axis direction.

ipPlateShellResFileNxy – Membrane shear force per unit width in the local xy axis direction.

ipPlateShellResFileMxx – Moment per unit width in the local x axis direction.

ipPlateShellResFileMyy – Moment per unit width in the local y axis direction.

ipPlateShellResFileMxy – Twisting moment per unit width in the local xy axis direction.

ipPlateShellResFileQxz – Transverse shear force per unit width in the local xz axis direction.

ipPlateShellResFileQyz – Transverse shear force per unit width in the local yz axis direction.

Linear plate stress results are then derived from the plate internal force results and the plate thickness. The plate
thickness is taken from the model file associated with the custom result file.

Custom Results

The units of the result data must be consistent with the length unit of the result file based on the following table.

rtPlateStress

Force

Moment

Result File Length Unit

m

cm

mm

ft

in

N/m

kgf/cm

N/mm

lbf/ft

lbf/in

N.m/m

kgf.cm/cm

N.mm/mm

lbf.ft./ft

lbf.in/in

Transverse Shear Force

N/m

kgf/cm

N/mm

lbf/ft

lbf/in

Quantity: rtPlateStress for plate/shell type elements with NonlinearMaterial = btTrue

Nonlinear plate stress results additionally set data at the following indices in each block.

ipPlateShellResFileSxxMinusZ – Direct stress in the local x axis direction, at the -z surface.

ipPlateShellResFileSyyMinusZ – Direct stress in the local y axis direction, at the -z surface.

ipPlateShellResFileSxyMinusZ – Shear stress in the local xy axis direction, at the -z surface.

ipPlateShellResFileSxxMidPlane – Direct stress in the local x axis direction, at the mid-plane surface.

ipPlateShellResFileSyyMidPlane – Direct stress in the local y axis direction, at the mid-plane surface.

ipPlateShellResFileSxyMidPlane – Shear stress in the local xy axis direction, at the mid-plane surface.

ipPlateShellResFileSxxPlusZ – Direct stress in the local x axis direction, at the +z surface.

ipPlateShellResFileSyyPlusZ – Direct stress in the local y axis direction, at the +z surface.

ipPlateShellResFileSxyPlusZ – Shear stress in the local xy axis direction, at the +z surface.

The units of the result data must be consistent with the length unit of the result file based on the following table.

rtPlateStress

Result File Length Unit

m

cm

mm

ft

in

Stress

N/m2

kgf/cm2

N/mm2

lbf/ft2

lbf/in2

Quantity: rtPlateStrain for plate/shell type elements

For each Gauss point, a block of results kPlateShellResFileStrainSize long is stored in Doubles. The following
constants index the results in each block.

ipPlateShellResFileExx – In-plane strain in the local x axis direction.

ipPlateShellResFileEyy – In-plane strain in the local y axis direction.

ipPlateShellResFileExy – In-plane shear strain in the local xy axis direction.

ipPlateShellResFileEzz – Strain in the local z axis direction.

ipPlateShellResFileKxx – Curvature in the local x axis direction.

Strand7 API Manual

ipPlateShellResFileKyy – Curvature in the local y axis direction.

ipPlateShellResFileKxy – Twist in the local xy axis direction.

ipPlateShellResFileTxz – Transverse strain in the local zx axis direction.

ipPlateShellResFileTyz – Transverse strain in the local yz axis direction.

ipPlateShellResFileStoredE – Stored elastic strain energy density.

ipPlateShellResFileSpentE – Irreversible work performed, as an energy density.

Strain results on the  surfaces of the plate are derived from the strain and curvature results together with the
plate thickness. The plate thickness is taken from the model file associated with the custom result file.

The units of the result data must be consistent with the length unit of the result file based on the following table.

rtPlateStrain

Strain

Curvature

m

none

m-1

Transverse Shear Strain

none

Result File Length Unit

cm

none

cm-1

none

mm

none

mm-1

none

ft

none

ft-1

none

in

none

in-1

none

Energy Density

N.m/m2

kgf.cm/cm2

N.mm/mm2

lbf.ft/ft2

lbf.in/in2

Quantity: rtPlateStress for 2D plane stress/strain type elements

For each Gauss point, a block of results kPlate2DResFileStressSize long is stored in Doubles. The following
constants index the results in each block.

ipPlate2DResFileSXX – Direct stress in the global X axis direction.

ipPlate2DResFileSYY – Direct stress in the global Y axis direction.

ipPlate2DResFileSXY – Direct shear stress in the global XY axis direction.

ipPlate2DResFileSZZ – Direct stress in the global Z axis direction.

The units of the result data must be consistent with the length unit of the result file based on the following table.

rtPlateStress

Result File Length Unit

m

cm

mm

ft

in

Stress

N/m2

kgf/cm2

N/mm2

lbf/ft2

lbf/in2

Quantity: rtPlateStrain for 2D plane stress/strain type elements

For each Gauss point, a block of results kPlate2DResFileStrainSize long is stored in Doubles. The following
constants index the results in each block.

ipPlate2DResFileEXX – Strain in the global X axis direction.

Custom Results

ipPlate2DResFileEYY – Strain in the global Y axis direction.

ipPlate2DResFileEXY – Shear strain in the global XY axis direction.

ipPlate2DResFileEZZ – Strain in the global Z axis direction.

ipPlate2DResFileStoredE – Stored elastic strain energy density.

ipPlate2DResFileSpentE – Irreversible work performed, as an energy density.

The units of the result data must be consistent with the length unit of the result file based on the following table.

Result File Length Unit

rtPlateStrain

m

cm

Strain

none

none

mm

none

ft

in

none

none

Energy Density

N.m/m2

kgf.cm/cm2

N.mm/mm2

lbf.ft/ft2

lbf.in/in2

Quantity: rtPlateStress for 2D axisymmetric type elements

For each Gauss point, a block of results kPlateAxiResFileStressSize long is stored in Doubles. The following
constants index the results in each block.

ipPlateAxiResFileSRR – Direct stress in the axisymmetric R axis direction.

ipPlateAxiResFileSZZ – Direct stress in the axisymmetric Z axis direction.

ipPlateAxiResFileSTT – Direct stress in the axisymmetric T axis direction.

ipPlateAxiResFileSRZ – Shear stress in the axisymmetric RZ axis direction.

The units of the result data must be consistent with the length unit of the result file based on the following table.

rtPlateStress

Result File Length Unit

m

cm

mm

ft

in

Stress

N/m2

kgf/cm2

N/mm2

lbf/ft2

lbf/in2

Quantity: rtPlateStrain for 2D axisymmetric type elements

For each Gauss point, a block of results kPlateAxiResFileStrainSize long is stored in Doubles. The following
constants index the results in each block.

ipPlateAxiResFileERR – Strain in the axisymmetric R axis direction.

ipPlateAxiResFileEZZ – Strain in the axisymmetric Z axis direction.

ipPlateAxiResFileETT – Strain in the axisymmetric T axis direction.

ipPlateAxiResFileERZ – Shear strain in the axisymmetric RZ axis direction.

ipPlateAxiResFileStoredE – Stored elastic strain energy density.

Strand7 API Manual

ipPlateAxiResFileSpentE – Irreversible work performed, as an energy density.

The units of the result data must be consistent with the length unit of the result file based on the following table.

Result File Length Unit

rtPlateStrain

m

cm

Strain

none

none

mm

none

ft

in

none

none

Energy Density

N.m/m3

kgf.cm/cm3

N.mm/mm3

lbf.ft/ft3

lbf.in/in3

Quantity: rtPlateStress for 3D membrane type elements

For each Gauss point, a block of results kPlateMembraneResFileStressSize long is stored in Doubles. The following
constants index the results in each block.

ipPlateMembraneResFileSXX – Direct stress in the local x direction.

ipPlateMembraneResFileSYY – Direct stress in the local y direction.

ipPlateMembraneResFileSXY – Shear stress in the local xy direction.

The units of the result data must be consistent with the length unit of the result file based on the following table.

rtPlateStress

Result File Length Unit

m

cm

mm

ft

in

Stress

N/m2

kgf/cm2

N/mm2

lbf/ft2

lbf/in2

Quantity: rtPlateStrain for 3D membrane type elements

For each Gauss point, a block of results kPlateMembraneResFileStrainSize long is stored in Doubles. The following
constants index the results in each block.

ipPlateMembraneResFileExx – Strain in the local x direction.

ipPlateMembraneResFileEyy – Strain in the local y axis direction.

ipPlateMembraneResFileExy – Shear strain in the local xy axis direction.

ipPlateMembraneResFileEzz – Strain in the local z axis direction.

ipPlateMembraneResFileStoredE – Stored elastic strain energy density.

ipPlateMembraneResFileSpentE – Irreversible work performed, as an energy density.

The units of the result data must be consistent with the length unit of the result file based on the following table.

Custom Results

Result File Length Unit

rtPlateStrain

m

cm

Strain

none

none

mm

none

ft

in

none

none

Energy Density

N.m/m2

kgf.cm/cm2

N.mm/mm2

lbf.ft/ft2

lbf.in/in2

Quantity: rtPlateStress resultants for shear panel type elements

For each Gauss point, a block of results kPlateShearPanelResFileStressSize long is stored in Doubles. The following
constants index the result in each block.

ipPlateShearPanelResFileNxy – Membrane shear force per unit width in the local xy direction.

The units of the result data must be consistent with the length unit of the result file based on the following table.

rtPlateStress

Result File Length Unit

m

cm

mm

ft

in

Shear Force

N/m

kgf/cm

N/mm

lbf/ft

lbf/in

Quantity: rtPlateStrain for shear panel type elements

For each Gauss point, a block of results kPlateShearPanelResFileStrainSize long is stored in Doubles. The following
constants index the results in each block.

ipPlateShearPanelResFileExy – Shear strain in the local xy direction.

ipPlateShearPanelResFileStoredE – Stored elastic strain energy density.

ipPlateShearPanelResFileSpentE  – Irreversible work performed, as an energy density.

The units of the result data must be consistent with the length unit of the result file based on the following table.

Result File Length Unit

rtPlateStrain

m

cm

Shear Strain

none

none

mm

none

ft

in

none

none

Energy Density

N.m/m2

kgf.cm/cm2

N.mm/mm2

lbf.ft/ft2

lbf.in/in2

Quantity: rtPlateNodeReact

For each node, a block of results kPlateResFileReactSize long is stored in Doubles. The following constants index
the results in each block.

ipPlateResFileFX – Reaction force in the global X axis direction.

ipPlateResFileFY – Reaction force in the global Y axis direction.

Strand7 API Manual

ipPlateResFileFZ – Reaction force in the global Z axis direction.

ipPlateResFileMX – Reaction moment about the global X axis direction.

ipPlateResFileMY – Reaction moment about the global Y axis direction.

ipPlateResFileMZ – Reaction moment about the global Z axis direction.

The units of the result data must be consistent with the length units of the result file based on the following table.

Result File Length Unit

rtPlateNodeReact

Force

Moment

m

N

cm

kgf

mm

N

ft

lbf

in

lbf

N.m

kgf.cm

N.mm

lbf.ft

lbf.in

Quantity: Plate Normal Pressure

Plate normal pressure applied in the analysis should be assigned to surfaces of a plate/shell element by using
St7SetResFilePlatePressureResult. This information is required to calculate normal stress on the plate surface. The
units of the pressure must be consistent with the length units of the result file based on the following table.

Plate Pressure

Result File Length Unit

m

cm

mm

ft

in

Pressure

N/m2

kgf/cm2

N/mm2

lbf/ft2

lbf/in2

Quantity: rtPlateFlux

For each Gauss point, a block of results kPlateResFileFluxSize long is stored in Doubles. The following constants
index the results in each block.

ipPlateResFileFxx – Heat flux in the local x axis direction.

ipPlateResFileFyy – Heat flux in the local y axis direction.

ipPlateResFileGxx – Temperature gradient in the local x axis direction.

ipPlateResFileGyy – Temperature gradient in the local y axis direction.

The units of the result data must be consistent with the energy, length and temperature units of the result file
based on the following table.

rtPlateFlux

Result File Units

Energy, Length, Temperature

Flux

energy/s/length2

Temperature Gradient

temperature/length

Custom Results

Quantity: rtPlateNodeFlux

For each node, one flux result is stored in Doubles.

The units of the result data must be consistent with the energy units of the result file based on the following table.

Result File Units

Energy

energy/s

rtPlateNodeFlux

Flux

Brick Results

The functions St7SetResFileBrickResult/St7GetResFileBrickResult pass an array Doubles of nodal results relevant to
the nominated result Quantity.

Result blocks

The number of Gauss point or node result blocks expected by St7SetResFileBrickResult depends on the number of
nodes on the element, according to the following table.  This is independent of solution, material or element type
and may differ compared with the raw results produced directly by the solvers.

Brick nodes

Brick type

Number of Gauss point related
result blocks required

Number of node related
result blocks required

Tetra4

Tetra10

Pyra5

Pyra13

Wedge6

Wedge15

Hexa8

Hexa16

Hexa20

Quantity: rtBrickStress

For each Gauss point, a block of results kBrickResFileStressSize long is stored in Doubles. The following constants
index the results in each block.

ipBrickResFileSXX – Direct stress in the global x axis direction.

ipBrickResFileSYY – Direct stress in the global y axis direction.

ipBrickResFileSZZ – Direct stress in the global z axis direction.

ipBrickResFileSXY – Shear stress in the global xy axis direction.

Strand7 API Manual

ipBrickResFileSYZ – Shear stress in the global yz axis direction.

ipBrickResFileSZX – Shear stress in the global zx axis direction.

The units of the result data must be consistent with the length unit of the result file based on the following table.

rtBrickStress

Result File Length Unit

m

cm

mm

ft

in

Stress

N/m2

kgf/cm2

N/mm2

lbf/ft2

lbf/in2

Quantity: rtBrickStrain

For each Gauss point, a block of results kBrickResFileStrainSize long is stored in Doubles. The following constants
index the results in each block.

ipBrickResFileExx – Strain in the global x axis direction.

ipBrickResFileEyy – Strain in the global y axis direction.

ipBrickResFileEzz – Strain in the global z axis direction.

ipBrickResFileExy – Shear strain in the global xy axis direction.

ipBrickResFileEyz – Shear strain in the global yz axis direction.

ipBrickResFileEzx – Shear strain in the global zx axis direction.

ipBrickResFileStoredE – Stored elastic strain energy density.

ipBrickResFileSpentE – Irreversible work performed, as an energy density.

The units of the result data must be consistent with the length unit of the result file based on the following table.

Result File Length Unit

rtBrickStrain

m

cm

Strain

none

none

mm

none

ft

in

none

none

Energy Density

N.m/m3

kgf.cm/cm3

N.mm/mm3

lbf.ft/ft3

lbf.in/in3

Quantity: rtBrickNodeReact

For each node, a block of results kBrickResFileReactSize long is stored in Doubles. The following constants index
the results in each block.

ipBrickResFileFX – Reaction force in the global X axis direction.

ipBrickResFileFY – Reaction force in the global Y axis direction.

ipBrickResFileFZ – Reaction force in the global Z axis direction.

The units of the result data must be consistent with the length units of the result file based on the following table.

Custom Results

Quantity

rtBrickNodeReact

Quantity: rtBrickFlux

Result File Length Unit

m

N

cm

kgf

mm

ft

in

N

lbf

lbf

For each Gauss point, a block of results kBrickResFileFluxSize long is stored in Doubles. The following constants
index the results in each block.

ipBrickResFileFXX – Heat flux in the global x axis direction.

ipBrickResFileFYY – Heat flux in the global y axis direction.

ipBrickResFileFZZ – Heat flux in the global z axis direction.

ipBrickResFileGXX – Temperature gradient in the global x axis direction.

ipBrickResFileGYY – Temperature gradient in the global y axis direction.

ipBrickResFileGZZ – Temperature gradient in the global z axis direction.

The units of the result data must be consistent with the energy, length and temperature units of the result file
based on the following table.

rtBrickFlux

Result File Units

Energy, Length, Temperature

Flux

energy/s/length2

Temperature Gradient

temperature/length

Quantity: rtBrickNodeFlux

For each node, one flux result is stored in Doubles.

The units of the result data must be consistent with the energy units of the result file based on the following table.

rtBrickNodeFlux

Flux

Result File Units

Energy

energy/s

Strand7 API Manual

Strand7 Function Index

St7AddCombinationEnvelope ........................................ 775
St7AddCombinedLSACombination ................................ 764
St7AddComment .......................................................... 162
St7AddFactorsEnvelope ............................................... 778
St7AddFactorsEnvelopeCase........................................ 780
St7AddFactorsEnvelopeSet .......................................... 782
St7AddInfluenceMultiVariableCase................................ 796
St7AddLaminatePly ...................................................... 534
St7AddLimitEnvelope .................................................... 771
St7AddLoadPathTemplateDistributedForce ................... 576
St7AddLoadPathTemplateHeatSource .......................... 579
St7AddLoadPathTemplatePointForce ............................ 573
St7AddLoadPathTemplateVehicle ................................. 568
St7AddLSACombination ............................................... 760
St7AddNLAIncrement ................................................... 620
St7AddResultFileCombCase ......................................... 787
St7AddResultFileCombFileName .................................. 785
St7AddSelectedToEntitySet .......................................... 204
St7AddSRABaseCase .................................................. 646
St7AddSRALoadCase................................................... 642
St7AddStage ................................................................ 197
St7AddTransientNodeHistoryCase ................................ 670
St7AdjustMidsideNodes ................................................ 918
St7AlignBeam3AxisByConnection ................................. 923
St7AlignBeamAxesToFramework .................................. 922
St7AlignBeamAxesToPlate ........................................... 922
St7AlignBeamAxesToUCS ............................................ 921
St7AlignBeamAxisToVector .......................................... 923
St7AlignFaceNormalByConnection ................................ 928
St7AlignPlateAxesByConnection ................................... 926
St7AlignPlateAxesToUCS ............................................. 925
St7AlignPlateNormalByConnection................................ 927
St7AlignPlateRCDirectionsToUCS................................. 926
St7AssignBXS .............................................................. 461
St7AssignLibraryBeamSection ...................................... 598
St7AssignLibraryBeamSectionBGL ............................... 599
St7AssignLibraryComposite .......................................... 598
St7AssignLibraryCreepDefinition ................................... 600
St7AssignLibraryLoadPathTemplate .............................. 600
St7AssignLibraryMaterial .............................................. 598
St7AssignLibraryReinforcementLayout .......................... 601
St7AssociateResFileCase ............................................. 803
St7AssociateResFileNSMassCase ................................ 804
St7AssociateResFileStage ............................................ 803
St7BeamOffsetsByCrossSection ................................... 921
St7BuildString ................................................................. 15
St7CalculateBeamSectionProperties ............................. 461
St7CheckBeamSectionQuality....................................... 460
St7CheckPatchLoads ................................................... 915
St7CheckSolverRunning ............................................... 715
St7CleanGeometry ....................................................... 955
St7CleanMesh .............................................................. 955
St7ClearGlobalIntegerValues ........................................ 961
St7ClearGlobalLogicalValues ........................................ 961
St7ClearGlobalStringValues .......................................... 962
St7ClearHRATimeHistory .............................................. 790
St7ClearModelWindow.................................................... 45
St7ClearResFileQuantity ............................................... 807
St7ClearSolverWindowPos ........................................... 716
St7CloneLoadPathTemplateVehicle .............................. 569

St7CloseAnimation........................................................ 159
St7CloseFile ................................................................... 20
St7CloseResFile ........................................................... 801
St7CloseResultFile.......................................................... 27
St7ColourToRGB .......................................................... 963
St7ConvertBeamOffsetsToRigidLinks ............................ 914
St7ConvertBeamPolygonsToPlates ............................... 916
St7ConvertBeamsToLinks ............................................. 913
St7ConvertElementResultNodeToGaussPoint ............... 964
St7ConvertLinksToBeams ............................................. 913
St7ConvertLoadPathsToLoadCases .............................. 915
St7ConvertPatchLoads ................................................. 914
St7ConvertTimeTableUnits............................................ 609
St7ConvertToNURBS.................................................... 868
St7ConvertUnits ............................................................ 209
St7CopyByIncrement .................................................... 831
St7CopyByMirror........................................................... 836
St7CopyByProjectionToEntityFace ................................ 834
St7CopyByProjectionToLine .......................................... 832
St7CopyByProjectionToPlane........................................ 833
St7CopyByProjectionToUCS ......................................... 833
St7CopyByRotation ....................................................... 831
St7CopyByThickness .................................................... 835
St7CopyToAbsolute ...................................................... 836
St7CopyToSt7Clipboard ................................................ 818
St7CorrectAttachmentLinkGroups ................................. 919
St7CreateAnimation ...................................................... 157
St7CreateAnimationEmbedded ..................................... 157
St7CreateAnimationFile ................................................ 158
St7CreateAttachments .................................................. 908
St7CreateBeamsOnElementEdges ................................ 905
St7CreateBeamsOnGeometryEdges ............................. 906
St7CreateCartesianSymmetryRestraints ........................ 909
St7CreateCylindricalSymmetryRestraints ....................... 909
St7CreateEntityUCS ..................................................... 907
St7CreateInterpolatedMultiPointLink .............................. 902
St7CreateLinksFromMultiPointLink ................................ 233
St7CreateLoadPatches ................................................. 908
St7CreateMasterSlaveLinkCluster ................................. 901
St7CreateMasterSlaveMultiPointLink ............................. 903
St7CreateModelWindow .................................................. 33
St7CreatePinnedLinkCluster ......................................... 900
St7CreatePinnedMultiPointLink ..................................... 903
St7CreatePlatesOnBricks .............................................. 906
St7CreateReactionMultiPointLink .................................. 904
St7CreateRigidLinkCluster ............................................ 900
St7CreateRigidMultiPointLink ........................................ 904
St7CreateSectorSymmetryLinkCluster ........................... 901
St7CutElementsByLine ................................................. 875
St7CutElementsByPlane ............................................... 876
St7CutElementsByUCS ................................................. 876
St7CutToSt7Clipboard .................................................. 817
St7DefineEntityCollection .............................................. 829
St7DefineLineN2 ........................................................... 821
St7DefineLineNV .......................................................... 822
St7DefineLineP2 ........................................................... 822
St7DefineLineV2 ........................................................... 821
St7DefinePlaneGlobalN ................................................ 823
St7DefinePlaneGlobalV ................................................. 823
St7DefinePlaneP3 ......................................................... 824

Strand7 Function Index

St7DefinePlaneUCS ..................................................... 824
St7DeleteAllGraphs ...................................................... 142
St7DeleteAttribute......................................................... 436
St7DeleteCavityFluidLayout .......................................... 590
St7DeleteCavityLoops................................................... 868
St7DeleteCombinationEnvelope .................................... 776
St7DeleteCombinedLSACombination ............................ 765
St7DeleteComment....................................................... 163
St7DeleteCreepDefinition .............................................. 563
St7DeleteEntitySet ........................................................ 203
St7DeleteFactorsEnvelope ............................................ 779
St7DeleteFactorsEnvelopeCase .................................... 781
St7DeleteFactorsEnvelopeSet....................................... 783
St7DeleteFreedomCase ................................................ 187
St7DeleteGroup ............................................................ 195
St7DeleteInfluenceMultiVariableCase ............................ 796
St7DeleteInvalidElements ............................................. 953
St7DeleteInvalidGeometry ............................................ 955
St7DeleteLaminate ....................................................... 537
St7DeleteLaminatePly................................................... 535
St7DeleteLimitEnvelope ................................................ 771
St7DeleteLoadCase ...................................................... 187
St7DeleteLoadPath ....................................................... 244
St7DeleteLoadPathTemplate ........................................ 583
St7DeleteLoadPathTemplateDistributedForce ............... 577
St7DeleteLoadPathTemplateHeatSource ...................... 580
St7DeleteLoadPathTemplatePointForce ........................ 574
St7DeleteLoadPathTemplateVehicle ............................. 570
St7DeleteLSACombination ............................................ 761
St7DeleteMarker ........................................................... 132
St7DeleteNLAIncrement ............................................... 621
St7DeleteProperty ........................................................ 527
St7DeleteReinforcementLayout ..................................... 542
St7DeleteResultFileCombCase ..................................... 787
St7DeleteResultFileCombFileName .............................. 786
St7DeleteSRABaseCase............................................... 646
St7DeleteSRALoadCase ............................................... 642
St7DeleteStage ............................................................ 198
St7DeleteStoredResultUserEquation ............................. 752
St7DeleteTableType ..................................................... 603
St7DeleteTransientNodeHistoryCase ............................ 670
St7DeleteUCS .............................................................. 189
St7DeleteUnusedLaminates .......................................... 537
St7DeleteUnusedNodes ................................................ 953
St7DeleteUnusedProperties .......................................... 527
St7DestroyModelWindow ................................................ 33
St7DetachElements ...................................................... 882
St7DetachFaces ........................................................... 869
St7DirectSolidTetMesh ................................................. 872
St7DisableCreepConcreteUserTable ............................. 554
St7DisableCreepUserTable ........................................... 547
St7DisableHeatLoadCase ............................................. 681
St7DisableHRALoadCase ............................................. 639
St7DisableInitialPCGFile ............................................... 706
St7DisableLIALoadCase ............................................... 617
St7DisableLimitEnvelopeCase ...................................... 772
St7DisableLoadPathTemplateVehicleLane .................... 572
St7DisableLSALoadCase .............................................. 612
St7DisableMode ........................................................... 661
St7DisableModelRCUnit................................................ 210
St7DisableModelRotationUnit ........................................ 210
St7DisableModelStrainUnit............................................ 210
St7DisableMovingLoad ................................................. 687
St7DisableNLAFreedomCase........................................ 626
St7DisableNLALoadCase.............................................. 625

St7DisableNLAPseudoTime .......................................... 627
St7DisableNLAStage .................................................... 619
St7DisableNSMassCaseInMassMatrix ........................... 683
St7DisablePlyPropertyResults ....................................... 742
St7DisableResultGroup ................................................. 703
St7DisableResultProperty ............................................. 705
St7DisableSaveLastRestartStep .................................... 711
St7DisableSaveRestart ................................................. 711
St7DisableSRABaseCase ............................................. 647
St7DisableSRALoadCase ............................................. 643
St7DisableStageGroup .................................................. 201
St7DisableTransientFreedomCase ................................ 678
St7DisableTransientLoadCase ...................................... 677
St7DisableWindowEntityInspector ................................... 41
St7DisableWindowResize ............................................... 44
St7DisableWindowStatusBar ........................................... 40
St7DisableWindowViewChanges ..................................... 44
St7EnableCreepConcreteUserTable .............................. 554
St7EnableCreepUserTable ............................................ 547
St7EnableHeatLoadCase .............................................. 681
St7EnableHRALoadCase .............................................. 638
St7EnableInitialPCGFile ................................................ 705
St7EnableLIALoadCase ................................................ 617
St7EnableLimitEnvelopeCase ....................................... 772
St7EnableLoadPathTemplateVehicleLane ..................... 571
St7EnableLSALoadCase ............................................... 612
St7EnableMode ............................................................ 661
St7EnableModelRCUnit ................................................ 210
St7EnableModelRotationUnit ......................................... 210
St7EnableModelStrainUnit ............................................ 209
St7EnableMovingLoad .................................................. 687
St7EnableNLAFreedomCase......................................... 626
St7EnableNLALoadCase............................................... 625
St7EnableNLAPseudoTime ........................................... 627
St7EnableNLAStage ..................................................... 619
St7EnableNSMassCaseInMassMatrix............................ 683
St7EnablePlyPropertyResults ........................................ 742
St7EnableResultGroup .................................................. 703
St7EnableResultProperty .............................................. 704
St7EnableSaveLastRestartStep..................................... 711
St7EnableSaveRestart .................................................. 710
St7EnableSRABaseCase .............................................. 647
St7EnableSRALoadCase .............................................. 643
St7EnableStageGroup .................................................. 201
St7EnableTransientFreedomCase ................................. 678
St7EnableTransientLoadCase ....................................... 677
St7EnableWindowEntityInspector .................................... 41
St7EnableWindowResize ................................................ 44
St7EnableWindowStatusBar ............................................ 40
St7EnableWindowViewChanges...................................... 44
St7ExportANSYS .......................................................... 155
St7ExportBXS ............................................................... 462
St7ExportDXF ............................................................... 153
St7ExportIGES ............................................................. 151
St7ExportImage ............................................................ 150
St7ExportImageToClipboard ......................................... 150
St7ExportNASTRAN ..................................................... 154
St7ExportST7 ............................................................... 151
St7ExportSTEP ............................................................. 152
St7ExportSTL ............................................................... 153
St7ExtrudeByIncrement ................................................ 846
St7ExtrudeByLine ......................................................... 854
St7ExtrudeByProjectionToAveragePoint ........................ 848
St7ExtrudeByProjectionToEntityFace ............................ 852
St7ExtrudeByProjectionToLine ...................................... 849

Strand7 API Manual

St7ExtrudeByProjectionToPlane.................................... 850
St7ExtrudeByProjectionToPoint .................................... 847
St7ExtrudeByProjectionToUCS ..................................... 851
St7ExtrudeByRotation ................................................... 846
St7ExtrudeByThickness ................................................ 853
St7ExtrudeToAbsolute .................................................. 855
St7FaceFromBeamPolygon .......................................... 865
St7FaceFromCavity ...................................................... 866
St7FaceFromPlate ........................................................ 864
St7FileVersion ................................................................ 19
St7FilletPlates .............................................................. 881
St7FlipEntity ................................................................. 928
St7FreeAdjacencyList ................................................... 944
St7GenerateAdjacencyList ............................................ 942
St7GenerateBrickContourFile ........................................ 755
St7GenerateBXS .......................................................... 174
St7GenerateEnvelopes ................................................... 27
St7GenerateHRATimeHistory........................................ 790
St7GenerateInfluenceCases ......................................... 799
St7GenerateLSACombinations ........................................ 26
St7GeneratePlateContourFile........................................ 755
St7GenerateResultFileComb ......................................... 789
St7GetAccVsTimeTableUnits ........................................ 610
St7GetAlphaTempType ................................................. 449
St7GetAnimationCase................................................... 159
St7GetAPIErrorString ...................................................... 17
St7GetAPIPath ............................................................... 13
St7GetAppendSRA ....................................................... 653
St7GetAttachmentLink .................................................. 224
St7GetAttributeDisplay .................................................. 128
St7GetBeamAxisSystemBirth ........................................ 164
St7GetBeamAxisSystemGNL ........................................ 164
St7GetBeamAxisSystemInitial ....................................... 163
St7GetBeamCableAsLine ............................................... 81
St7GetBeamCableFreeLength1 .................................... 288
St7GetBeamColours ....................................................... 83
St7GetBeamConnectionUCS ........................................ 284
St7GetBeamConvection2 .............................................. 297
St7GetBeamConvectionTables ..................................... 298
St7GetBeamCreepLoadingAge1 ................................... 303
St7GetBeamDistributedForceGlobal6ID......................... 296
St7GetBeamDistributedForcePrincipal6ID ..................... 295
St7GetBeamDistributedMomentPrincipal6ID .................. 295
St7GetBeamDrawAxes ................................................... 84
St7GetBeamEndAttachment1........................................ 303
St7GetBeamFill .............................................................. 81
St7GetBeamFlux1 ........................................................ 300
St7GetBeamFluxTables ................................................ 300
St7GetBeamHeatSource1 ............................................. 301
St7GetBeamHeatSourceTables .................................... 301
St7GetBeamID ............................................................. 284
St7GetBeamLabelStyle ................................................... 82
St7GetBeamLighting ....................................................... 83
St7GetBeamLineThickness ............................................. 82
St7GetBeamMaterialData ............................................. 474
St7GetBeamMirrorOption .............................................. 453
St7GetBeamMoveToOffset ............................................. 84
St7GetBeamNonlinearMode.......................................... 476
St7GetBeamNonlinearType........................................... 454
St7GetBeamNRef ........................................................... 83
St7GetBeamNSMass10ID ............................................. 297
St7GetBeamOffset2 ...................................................... 285
St7GetBeamOffsetNodes ................................................ 84
St7GetBeamOutline ........................................................ 82
St7GetBeamPointForceGlobal4ID ................................. 293

St7GetBeamPointForcePrincipal4ID .............................. 292
St7GetBeamPointMomentGlobal4ID .............................. 294
St7GetBeamPointMomentPrincipal4ID .......................... 293
St7GetBeamPreCurvature2 ........................................... 292
St7GetBeamPreLoad1 .................................................. 291
St7GetBeamPropertyData ............................................. 450
St7GetBeamPropertyType ............................................ 452
St7GetBeamRadiation2 ................................................. 299
St7GetBeamRadiationTables ........................................ 299
St7GetBeamRadius1 .................................................... 289
St7GetBeamReferenceAngle1....................................... 284
St7GetBeamReleaseResult ........................................... 738
St7GetBeamResponse .................................................. 302
St7GetBeamResultArray ............................................... 735
St7GetBeamResultArrayPos ......................................... 736
St7GetBeamResultEndPos ........................................... 737
St7GetBeamResultPosMode ......................................... 734
St7GetBeamResultSinglePos ........................................ 737
St7GetBeamRoundFacets ............................................... 85
St7GetBeamRRelease3 ................................................ 288
St7GetBeamSectionCircularDiscretisation ..................... 460
St7GetBeamSectionFactor7 .......................................... 287
St7GetBeamSectionGeometry....................................... 457
St7GetBeamSectionGeometryBGL ................................ 458
St7GetBeamSectionName ............................................ 452
St7GetBeamSectionNominalDiscretisation..................... 459
St7GetBeamSectionPropertyData ................................. 455
St7GetBeamSectionResult ............................................ 739
St7GetBeamShearModulusMode .................................. 476
St7GetBeamShrink ......................................................... 86
St7GetBeamSideAttachment1 ....................................... 304
St7GetBeamSlices .......................................................... 86
St7GetBeamSpringAspect ............................................... 85
St7GetBeamSpringCoils.................................................. 85
St7GetBeamStringGroup1 ............................................. 290
St7GetBeamStyle ........................................................... 81
St7GetBeamSupport2 ................................................... 286
St7GetBeamTaper2 ...................................................... 285
St7GetBeamTempGradient2 ......................................... 291
St7GetBeamTRelease3 ................................................ 287
St7GetBrickAddBubbleFunction..................................... 525
St7GetBrickAnisotropicMaterial ..................................... 511
St7GetBrickCavityFluid ................................................. 375
St7GetBrickColours....................................................... 102
St7GetBrickContourFileResult ....................................... 757
St7GetBrickConvection2 ............................................... 368
St7GetBrickConvectionTables ....................................... 368
St7GetBrickCreepLoadingAge1 ..................................... 374
St7GetBrickDrawAxes ................................................... 103
St7GetBrickFaceAreas .................................................. 937
St7GetBrickFaceAreasDeformed ................................... 938
St7GetBrickFaceAreasGNL ........................................... 937
St7GetBrickFaceAttachment1........................................ 374
St7GetBrickFaceAxisSystemBirth .................................. 167
St7GetBrickFaceAxisSystemGNL .................................. 168
St7GetBrickFaceAxisSystemInitial ................................. 167
St7GetBrickFill .............................................................. 101
St7GetBrickFluidMaterial ............................................... 524
St7GetBrickFlux1 .......................................................... 370
St7GetBrickFluxTables .................................................. 371
St7GetBrickGlobalPressure3 ......................................... 366
St7GetBrickHeatSource1 .............................................. 371
St7GetBrickHeatSourceTables ...................................... 372
St7GetBrickID ............................................................... 363
St7GetBrickIntegrationPoints ......................................... 526

Strand7 Function Index

St7GetBrickIsotropicMaterial ......................................... 507
St7GetBrickLabelStyle .................................................. 102
St7GetBrickLighting ...................................................... 103
St7GetBrickLineThickness ............................................ 101
St7GetBrickLocalAxes1 ................................................ 363
St7GetBrickMCDPMaterial ............................................ 514
St7GetBrickNonlinearType ............................................ 506
St7GetBrickNormalPressure1........................................ 365
St7GetBrickNSMass5ID ................................................ 367
St7GetBrickOrthotropicMaterial ..................................... 509
St7GetBrickOutline ....................................................... 101
St7GetBrickOutlineMode ............................................... 104
St7GetBrickPointForce6 ................................................ 365
St7GetBrickPreLoad3 ................................................... 364
St7GetBrickPropertyType.............................................. 506
St7GetBrickRadiation2 .................................................. 369
St7GetBrickRadiationTables ......................................... 370
St7GetBrickResponse ................................................... 373
St7GetBrickResultArray ................................................ 744
St7GetBrickResultGaussPoints ..................................... 744
St7GetBrickRubberMaterial ........................................... 512
St7GetBrickSelectState ................................................... 29
St7GetBrickShear2 ....................................................... 366
St7GetBrickShrink ........................................................ 103
St7GetBrickSoilCCMaterial ........................................... 518
St7GetBrickSoilDCMaterial ........................................... 516
St7GetBrickSoilDPMaterial............................................ 521
St7GetBrickSoilLSMaterial ............................................ 523
St7GetBrickSoilMCMaterial ........................................... 520
St7GetBrickSoilRatio2................................................... 373
St7GetBrickSoilStress2 ................................................. 372
St7GetBrickSoilType ..................................................... 514
St7GetBrickSupport4 .................................................... 363
St7GetBrickUVW .......................................................... 941
St7GetBrickWireframeAll............................................... 104
St7GetBucklingFactor ................................................... 730
St7GetBXSLoop ........................................................... 173
St7GetBXSLoopType .................................................... 173
St7GetCableData.......................................................... 464
St7GetCableDroopDirection .......................................... 160
St7GetCavityFluidConstBulk ......................................... 589
St7GetCavityFluidIdealGas ........................................... 587
St7GetCavityFluidLayoutNumByIndex ........................... 585
St7GetCavityFluidName ................................................ 586
St7GetCavityFluidPreLoad ............................................ 590
St7GetCavityFluidType ................................................. 586
St7GetCleanGeometryOptions ...................................... 950
St7GetCleanMeshOptions ............................................. 948
St7GetCombinationEnvelopeCase ................................ 777
St7GetCombinationEnvelopeData ................................. 777
St7GetCombinedLSACombinationFactor ....................... 765
St7GetCombinedLSACombinationName ....................... 763
St7GetCombinedLSACombinationState......................... 764
St7GetComment ........................................................... 163
St7GetConnectionData ................................................. 469
St7GetConnectionThermalData ..................................... 473
St7GetCouplingLink ...................................................... 218
St7GetCreepBasicData ................................................. 547
St7GetCreepConcreteCementCuringData ..................... 562
St7GetCreepConcreteFunctionType .............................. 556
St7GetCreepConcreteHyperbolicData ........................... 552
St7GetCreepConcreteLoadingAge ................................ 557
St7GetCreepConcreteLoadingTimeUnit ......................... 558
St7GetCreepConcreteShrinkageFormulaData ............... 559
St7GetCreepConcreteShrinkageTableData ................... 560

St7GetCreepConcreteShrinkageType ............................ 558
St7GetCreepConcreteTemperatureData ........................ 561
St7GetCreepConcreteUserTableData ............................ 555
St7GetCreepConcreteUserTableState ........................... 554
St7GetCreepConcreteViscoChainData .......................... 553
St7GetCreepDefinitionName ......................................... 545
St7GetCreepDefinitionNumByIndex ............................... 544
St7GetCreepHardeningType ......................................... 549
St7GetCreepLaw .......................................................... 546
St7GetCreepTemperatureInclude .................................. 551
St7GetCreepTimeUnit ................................................... 550
St7GetCreepUserTableData .......................................... 549
St7GetCreepUserTableState ......................................... 548
St7GetCutoffBarData .................................................... 465
St7GetDampingType ..................................................... 696
St7GetDecimalSeparatorCode ........................................ 16
St7GetDefaultGroupID .................................................. 196
St7GetDisplacementScale ............................................. 142
St7GetDisplayOptionsPath .............................................. 18
St7GetDrawAreaPosition................................................. 51
St7GetDrawAreaSize ...................................................... 51
St7GetDynamicRestartFile ............................................ 709
St7GetElementCentroid ................................................ 938
St7GetElementCentroidAtBirth ...................................... 939
St7GetElementConnection ............................................ 214
St7GetElementCoordinatesAtBirth ................................. 940
St7GetElementData ...................................................... 933
St7GetElementDataDeformed ....................................... 934
St7GetElementDataGNL ............................................... 933
St7GetElementNodeFluxSum ........................................ 750
St7GetElementNodeForceSum ..................................... 749
St7GetElementProperty ................................................ 434
St7GetElementPropertySequence ................................. 435
St7GetElementResultState ............................................ 731
St7GetElementsAtNode ................................................ 943
St7GetEntityAttributeSequence ..................................... 438
St7GetEntityAttributeSequenceCount ............................ 437
St7GetEntityAttributesVisibility......................................... 49
St7GetEntityContourFile ................................................ 134
St7GetEntityContourIndex ............................................. 135
St7GetEntityContourSettingsLegend ............................. 139
St7GetEntityContourSettingsLegendFont ....................... 140
St7GetEntityContourSettingsLimits ................................ 137
St7GetEntityContourSettingsLimitsString ....................... 138
St7GetEntityContourSettingsStyle ................................. 136
St7GetEntityFont............................................................. 61
St7GetEntityGroup ........................................................ 437
St7GetEntityNumVisibility ................................................ 55
St7GetEntityResult ........................................................ 703
St7GetEntitySelectCount ................................................. 32
St7GetEntitySelectState .................................................. 28
St7GetEntitySetEntityState ............................................ 205
St7GetEntitySetName ................................................... 204
St7GetEntitySetVisibility .................................................. 54
St7GetEntityVisibility ....................................................... 48
St7GetEnvelopeAdditionalBeamSlices ........................... 775
St7GetEnvelopeAveragingOrder.................................... 774
St7GetExcitationTypeSRA ............................................ 729
St7GetFaceColours....................................................... 119
St7GetFaceControlPoints .............................................. 121
St7GetFaceFill .............................................................. 118
St7GetFaceFillStyle ...................................................... 118
St7GetFaceLabelStyle .................................................. 119
St7GetFaceLighting ...................................................... 120
St7GetFaceLineThickness ............................................ 120

Strand7 API Manual

St7GetFaceNIEdges ..................................................... 121
St7GetFaceNormals ..................................................... 122
St7GetFaceNormalsSize ............................................... 121
St7GetFaceOutline ....................................................... 118
St7GetFaceWireDensity ................................................ 121
St7GetFaceWireThickness ............................................ 120
St7GetFactorsEnvelopeCaseData ................................. 781
St7GetFactorsEnvelopeData ......................................... 779
St7GetFactorsEnvelopeSetData .................................... 784
St7GetFreedomCaseDefaults........................................ 182
St7GetFreedomCaseName ........................................... 178
St7GetFreedomCaseRigidMotion .................................. 187
St7GetFreedomCaseType ............................................ 184
St7GetFreeNodes ........................................................... 74
St7GetFreeVertices ...................................................... 112
St7GetFrequency.......................................................... 724
St7GetFrequencyPeriodTableType................................ 607
St7GetFrequencyPeriodTableUnits ............................... 608
St7GetGeometryCoedgeAttachment1............................ 416
St7GetGeometryCoedgeConvection2 ............................ 412
St7GetGeometryCoedgeConvectionTables ................... 413
St7GetGeometryCoedgeEdge ....................................... 239
St7GetGeometryCoedgeFlux1 ...................................... 415
St7GetGeometryCoedgeFluxTables .............................. 415
St7GetGeometryCoedgePressure1 ............................... 411
St7GetGeometryCoedgePressure3 ............................... 412
St7GetGeometryCoedgeRadiation2 .............................. 414
St7GetGeometryCoedgeRadiationTables ...................... 414
St7GetGeometryCoedgeRelease1 ................................ 410
St7GetGeometryCoedgeShear1 .................................... 411
St7GetGeometryCoedgeSupport4 ................................. 410
St7GetGeometryCoedgeTransverseShear1 ................... 412
St7GetGeometryEdgeBeamProperty ............................. 401
St7GetGeometryEdgeCluster ........................................ 402
St7GetGeometryEdgeLength ........................................ 240
St7GetGeometryEdgeMinDivisions................................ 401
St7GetGeometryEdgeType ........................................... 401
St7GetGeometryEdgeVertices ...................................... 241
St7GetGeometryFaceAttachment1 ................................ 432
St7GetGeometryFaceCavityLoops ................................ 235
St7GetGeometryFaceCoedges ..................................... 238
St7GetGeometryFaceConvection2 ................................ 429
St7GetGeometryFaceConvectionTables ........................ 430
St7GetGeometryFaceEdges ......................................... 236
St7GetGeometryFaceGlobalPressure3S ....................... 428
St7GetGeometryFaceHeatSource1 ............................... 431
St7GetGeometryFaceHeatSourceTables ....................... 432
St7GetGeometryFaceID ................................................ 425
St7GetGeometryFaceNormalPressure2......................... 427
St7GetGeometryFaceNSMass5ID ................................. 428
St7GetGeometryFaceOffset1 ........................................ 426
St7GetGeometryFaceOuterLoops ................................. 234
St7GetGeometryFaceProperty ...................................... 425
St7GetGeometryFaceRadiation2 ................................... 430
St7GetGeometryFaceRadiationTables .......................... 431
St7GetGeometryFaceSupport4 ..................................... 426
St7GetGeometryFaceSurface ....................................... 241
St7GetGeometryFaceTempGradient1 ........................... 427
St7GetGeometryFaceThickness2 .................................. 425
St7GetGeometryFaceVertices ....................................... 240
St7GetGeometryLoopCoedges ..................................... 239
St7GetGeometryLoopEdges ......................................... 237
St7GetGeometrySize .................................................... 242
St7GetGeometrySurfaceType ....................................... 242
St7GetGlobalIntegerValue ............................................ 957

St7GetGlobalLogicalValue ............................................ 957
St7GetGlobalStringValue .............................................. 961
St7GetGroupByIndex .................................................... 193
St7GetGroupChild ......................................................... 194
St7GetGroupColour ...................................................... 195
St7GetGroupIDName .................................................... 192
St7GetGroupParent ...................................................... 194
St7GetGroupSibling ...................................................... 194
St7GetGroupVisibility ...................................................... 53
St7GetHardeningType................................................... 445
St7GetHeatLoadCaseState ........................................... 681
St7GetHRABaseCombinationFactor .............................. 768
St7GetHRABaseVector ................................................. 638
St7GetHRACaseCombinationFactor .............................. 768
St7GetHRACombinationFactorLSA ............................... 769
St7GetHRACombinationLSAName ................................ 767
St7GetHRALoadCase ................................................... 639
St7GetHRALoadType.................................................... 637
St7GetHRAMode .......................................................... 637
St7GetHRARange ......................................................... 636
St7GetIconSize ............................................................... 13
St7GetInertiaReliefResults ............................................ 725
St7GetInfluenceCombinationOptions ............................. 799
St7GetInfluenceFileName ............................................. 791
St7GetInfluenceGroupState........................................... 797
St7GetInfluenceMaxVariableState ................................. 794
St7GetInfluenceMinVariableState .................................. 793
St7GetInfluenceMultiVariableName ............................... 797
St7GetInfluenceMultiVariableState ................................ 794
St7GetInfluenceMultiVariableType ................................. 795
St7GetInfluencePropertyState ....................................... 798
St7GetInfluenceVariable................................................ 792
St7GetInitialPCGFile ..................................................... 707
St7GetInitialPCGFileState ............................................. 706
St7GetInitialTemperatureInTHAFile ............................... 676
St7GetInitialTemperatureTHA........................................ 730
St7GetInsituStressOptions ............................................ 952
St7GetInterpolatedMultiPointLink................................... 227
St7GetInterpolatedMultiPointLinkAttributes .................... 379
St7GetLaminateMatrices ............................................... 536
St7GetLaminateName ................................................... 532
St7GetLaminateNumPlies ............................................. 532
St7GetLaminatePly ....................................................... 533
St7GetLaminateStackNumByIndex ................................ 531
St7GetLastError .............................................................. 16
St7GetLastOpenFileCode ............................................... 16
St7GetLastSaveFileCode ................................................ 17
St7GetLBAInitial ........................................................... 614
St7GetLBANumModes .................................................. 615
St7GetLBAShift ............................................................. 615
St7GetLIALoadCaseState ............................................. 617
St7GetLibraryBeamSectionGeometryBGL ..................... 597
St7GetLibraryBeamSectionPropertyDataBGL ................ 595
St7GetLibraryBeamSectionPropertyDataBSL................. 594
St7GetLibraryID ............................................................ 592
St7GetLibraryItemID ..................................................... 593
St7GetLibraryItemName ................................................ 593
St7GetLibraryName ...................................................... 591
St7GetLibraryPath ........................................................ 591
St7GetLicenceOptions .................................................... 14
St7GetLimitEnvelopeCaseState..................................... 772
St7GetLimitEnvelopeData ............................................. 773
St7GetLinkColours ........................................................ 108
St7GetLinkDashes ........................................................ 108
St7GetLinkID ................................................................ 379

Strand7 Function Index

St7GetLinkLabelStyle ................................................... 107
St7GetLinkLineThickness.............................................. 107
St7GetLinkOutline......................................................... 107
St7GetLinkResultArray.................................................. 745
St7GetLinkType ............................................................ 215
St7GetListSeparatorCode ............................................... 16
St7GetLoadCaseDefaults.............................................. 179
St7GetLoadCaseGravity ............................................... 184
St7GetLoadCaseGravityDir ........................................... 183
St7GetLoadCaseMassOption ........................................ 185
St7GetLoadCaseName ................................................. 177
St7GetLoadCaseType................................................... 182
St7GetLoadPath ........................................................... 243
St7GetLoadPathTemplateCentrifugalData ..................... 584
St7GetLoadPathTemplateDistributedForceData............. 578
St7GetLoadPathTemplateHeatSourceData.................... 581
St7GetLoadPathTemplateLaneFactor............................ 567
St7GetLoadPathTemplateName .................................... 565
St7GetLoadPathTemplateNumByIndex ......................... 564
St7GetLoadPathTemplateParameters ........................... 566
St7GetLoadPathTemplatePointForceData ..................... 575
St7GetLoadPathTemplateVehicleData .......................... 571
St7GetLoadPathTemplateVehicleLaneState .................. 572
St7GetLoadPathTemplateVehicleName......................... 568
St7GetLoadPathTemplateVehicleSet ............................ 582
St7GetLSACombinationFactor ...................................... 762
St7GetLSACombinationName ....................................... 758
St7GetLSACombinationSRAName ................................ 759
St7GetLSACombinationState ........................................ 760
St7GetLSALoadCaseState ............................................ 612
St7GetLTAInitial ........................................................... 655
St7GetLTAMethod ........................................................ 656
St7GetLTASolutionType ............................................... 656
St7GetMarker ............................................................... 131
St7GetMasterSlaveLink ................................................ 216
St7GetMasterSlaveMultiPointLink ................................. 228
St7GetMasterSlaveMultiPointLinkAttributes ................... 379
St7GetMaterialName .................................................... 445
St7GetMaxModelFileID ................................................... 15
St7GetModalConvergence ............................................ 721
St7GetModalResultsHRA .............................................. 728
St7GetModalResultsNFA .............................................. 726
St7GetModalResultsNodeDofNFA ................................. 728
St7GetModalResultsSRA .............................................. 729
St7GetModalSuperpositionFile ...................................... 660
St7GetModeDampingRatio............................................ 662
St7GetModelWindowHandle ........................................... 33
St7GetModelWindowParent ............................................ 34
St7GetModelWindowPosition .......................................... 50
St7GetModelWindowState .............................................. 33
St7GetModeState ......................................................... 662
St7GetMomentRotationTableUnits ................................ 610
St7GetMovingLoadAutoDivisions .................................. 689
St7GetMovingLoadState ............................................... 687
St7GetMovingLoadTimeTable ....................................... 688
St7GetMultiPointLinkFluxSum ....................................... 747
St7GetMultiPointLinkNodeFlux ...................................... 748
St7GetMultiPointLinkNodeReaction ............................... 746
St7GetMultiPointLinkReactionSum ................................ 746
St7GetNFAFileOpenMinMass ......................................... 25
St7GetNFAInitial ........................................................... 632
St7GetNFAModeParticipationCalculate ......................... 634
St7GetNFAModeParticipationVectors ............................ 635
St7GetNFANumModes ................................................. 633
St7GetNFAShift ............................................................ 633

St7GetNLAFreedomCaseState ...................................... 627
St7GetNLAFreedomIncrementFactor ............................. 624
St7GetNLAIncrementName ........................................... 621
St7GetNLAInitial ........................................................... 629
St7GetNLALoadCaseState ............................................ 626
St7GetNLALoadIncrementFactor ................................... 623
St7GetNLAPseudoTime ................................................ 628
St7GetNLAPseudoTimeState ........................................ 628
St7GetNLAResetAtIncrement ........................................ 624
St7GetNLAStagedAnalysis ............................................ 619
St7GetNLAStageState .................................................. 620
St7GetNodeAcceleration3 ............................................. 262
St7GetNodeColours ........................................................ 75
St7GetNodeFluxSum .................................................... 749
St7GetNodeForce3 ....................................................... 255
St7GetNodeHeatSource1 .............................................. 260
St7GetNodeHeatSourceTables ..................................... 261
St7GetNodeHistoryFile .................................................. 710
St7GetNodeID .............................................................. 254
St7GetNodeInitialVelocity3 ............................................ 261
St7GetNodeKDamping3F .............................................. 260
St7GetNodeKRotation3F ............................................... 258
St7GetNodeKTranslation3F........................................... 257
St7GetNodeLabelStyle .................................................... 75
St7GetNodeMoment3.................................................... 255
St7GetNodeNSMass5ID................................................ 259
St7GetNodeReactionSum ............................................. 748
St7GetNodeResponse .................................................. 262
St7GetNodeRestraint6 .................................................. 254
St7GetNodeResult ........................................................ 732
St7GetNodeResultEx .................................................... 732
St7GetNodeResultExUCS ............................................. 733
St7GetNodeResultUCS ................................................. 733
St7GetNodeRMass3 ..................................................... 258
St7GetNodeShowHideSelected ....................................... 74
St7GetNodeSize ............................................................. 74
St7GetNodeStyle ............................................................ 74
St7GetNodeTemperature1 ............................................ 256
St7GetNodeTemperatureTable ...................................... 257
St7GetNodeTemperatureType1 ..................................... 256
St7GetNodeTMass3...................................................... 258
St7GetNodeUCS........................................................... 213
St7GetNodeXYZ ........................................................... 212
St7GetNSMassCaseInMassMatrixState ......................... 683
St7GetNTAInitial ........................................................... 657
St7GetNumBXSLoopPoints ........................................... 172
St7GetNumBXSLoopsAndPlates ................................... 172
St7GetNumCombinedLSACombinations ........................ 762
St7GetNumComments .................................................. 162
St7GetNumElementResultGaussPoints ......................... 963
St7GetNumElementsAtNode ......................................... 942
St7GetNumEntitySets ................................................... 203
St7GetNumEnvelopes ................................................... 770
St7GetNumEnvelopesSolver ......................................... 770
St7GetNumericOptions ................................................... 59
St7GetNumFactorsEnvelopeCases ............................... 782
St7GetNumFactorsEnvelopeSets .................................. 783
St7GetNumFreedomCase ............................................. 177
St7GetNumGeometryFaceCavityLoops ......................... 235
St7GetNumGeometryFaceCoedges .............................. 238
St7GetNumGeometryFaceEdges .................................. 236
St7GetNumGeometryFaceVertices ................................ 240
St7GetNumGeometryLoopCoedges .............................. 238
St7GetNumGeometryLoopEdges .................................. 237
St7GetNumGroups........................................................ 192

Strand7 API Manual

St7GetNumInfluenceMultiVariableCases ....................... 792
St7GetNumInfluenceVariables ...................................... 791
St7GetNumIterations .................................................... 719
St7GetNumLibraries ..................................................... 591
St7GetNumLibraryItems ................................................ 592
St7GetNumLoadCase ................................................... 176
St7GetNumLoadPathTemplateDistributedForces ........... 577
St7GetNumLoadPathTemplateHeatSources .................. 580
St7GetNumLoadPathTemplatePointForces ................... 574
St7GetNumLoadPathTemplateVehicles ......................... 570
St7GetNumLSACombinations ....................................... 758
St7GetNumModes ........................................................ 726
St7GetNumModesInModalFile....................................... 660
St7GetNumModesInNFAFile ......................................... 661
St7GetNumMultiPointLinkNodes ................................... 225
St7GetNumNLAIncrements ........................................... 622
St7GetNumSeismicCase............................................... 176
St7GetNumSRABaseCases .......................................... 647
St7GetNumSRACases .................................................. 726
St7GetNumSRALoadCases .......................................... 643
St7GetNumStages ........................................................ 198
St7GetNumStoredResultUserEquations ........................ 754
St7GetNumTables ........................................................ 602
St7GetNumTableTypeRows .......................................... 605
St7GetNumTimeStepRows ........................................... 684
St7GetNumTransientNodeHistoryCases ........................ 671
St7GetNumUCS ........................................................... 191
St7GetPathColours ....................................................... 126
St7GetPathDivisions ..................................................... 127
St7GetPathFill .............................................................. 125
St7GetPathLabelStyle ................................................... 126
St7GetPathLighting ....................................................... 126
St7GetPathLineThickness ............................................. 127
St7GetPathOutline ........................................................ 125
St7GetPinnedLink ......................................................... 219
St7GetPinnedMultiPointLink .......................................... 230
St7GetPipeData ............................................................ 468
St7GetPipePressure2AF ............................................... 289
St7GetPipeTemperature2OT ......................................... 290
St7GetPlateAddBubbleFunction .................................... 503
St7GetPlateAnisotropicMaterial ..................................... 486
St7GetPlateAverageNormals .......................................... 92
St7GetPlateAverageNormalsAngle .................................. 92
St7GetPlateAxisLayer ..................................................... 96
St7GetPlateAxisSystemBirth ......................................... 165
St7GetPlateAxisSystemGNL ......................................... 166
St7GetPlateAxisSystemInitial ........................................ 165
St7GetPlateCavityFluid ................................................. 349
St7GetPlateColours ........................................................ 94
St7GetPlateContourFileResult....................................... 757
St7GetPlateCreepLoadingAge1 .................................... 348
St7GetPlateDrawAxes .................................................... 95
St7GetPlateEdgeAttachment1 ....................................... 348
St7GetPlateEdgeConvection2 ....................................... 338
St7GetPlateEdgeConvectionTables............................... 339
St7GetPlateEdgeLengths .............................................. 935
St7GetPlateEdgeLengthsDeformed ............................... 936
St7GetPlateEdgeLengthsGNL ....................................... 936
St7GetPlateEdgePressure1 .......................................... 334
St7GetPlateEdgePressure3 .......................................... 336
St7GetPlateEdgeRadiation2.......................................... 340
St7GetPlateEdgeRadiationTables ................................. 340
St7GetPlateEdgeRelease1 ........................................... 330
St7GetPlateEdgeShear1 ............................................... 334
St7GetPlateEdgeSupport4 ............................................ 328

St7GetPlateEdgeTransverseShear1 .............................. 335
St7GetPlateFaceAttachment1 ....................................... 349
St7GetPlateFaceConvection2........................................ 342
St7GetPlateFaceConvectionTables ............................... 342
St7GetPlateFaceNodes ................................................... 96
St7GetPlateFaceRadiation2 .......................................... 343
St7GetPlateFaceRadiationTables .................................. 344
St7GetPlateFaceSupport4 ............................................. 329
St7GetPlateFill ................................................................ 92
St7GetPlateFluidMaterial............................................... 501
St7GetPlateFlux1 .......................................................... 341
St7GetPlateFluxTables ................................................. 341
St7GetPlateGlobalPressure3S ...................................... 337
St7GetPlateHeatSource1 .............................................. 344
St7GetPlateHeatSourceTables ...................................... 345
St7GetPlateID ............................................................... 327
St7GetPlateIsotropicMaterial ......................................... 481
St7GetPlateLabelStyle .................................................... 93
St7GetPlateLaminateMaterial ........................................ 487
St7GetPlateLayers ........................................................ 504
St7GetPlateLighting ........................................................ 94
St7GetPlateLineThickness .............................................. 93
St7GetPlateLoadPatch4 ................................................ 347
St7GetPlateMCDPMaterial ............................................ 490
St7GetPlateMoveToOffset ............................................... 95
St7GetPlateNonlinearType ............................................ 479
St7GetPlateNormalPressure2........................................ 336
St7GetPlateNSMass5ID ................................................ 338
St7GetPlateNumPlies.................................................... 169
St7GetPlateOffset1 ....................................................... 328
St7GetPlateOffsetNodes ................................................. 95
St7GetPlateOrthotropicMaterial ..................................... 482
St7GetPlateOutline ......................................................... 93
St7GetPlateOutlineMode ................................................. 97
St7GetPlatePatchTol ..................................................... 505
St7GetPlatePointForce6 ................................................ 332
St7GetPlatePointMoment6 ............................................ 333
St7GetPlatePreCurvature2 ............................................ 331
St7GetPlatePreLoad3 ................................................... 331
St7GetPlatePropertyType .............................................. 478
St7GetPlateReinforcement2 .......................................... 347
St7GetPlateResponse ................................................... 346
St7GetPlateResultArray ................................................ 740
St7GetPlateResultGaussPoints ..................................... 743
St7GetPlateResultMaxJunctionAngle............................. 742
St7GetPlateRubberMaterial ........................................... 484
St7GetPlateSectionFactor10 ......................................... 330
St7GetPlateShear2 ....................................................... 337
St7GetPlateShrink .......................................................... 96
St7GetPlateSoilCCMaterial ........................................... 495
St7GetPlateSoilDCMaterial ........................................... 492
St7GetPlateSoilDPMaterial............................................ 498
St7GetPlateSoilLSMaterial ............................................ 500
St7GetPlateSoilMCMaterial ........................................... 497
St7GetPlateSoilRatio2................................................... 346
St7GetPlateSoilStress2 ................................................. 345
St7GetPlateSoilType ..................................................... 491
St7GetPlateStyle............................................................. 91
St7GetPlateTempGradient1 .......................................... 332
St7GetPlateThickness ................................................... 480
St7GetPlateThickness2 ................................................. 327
St7GetPlateUserDefinedMaterial ................................... 489
St7GetPlateUseReducedInt........................................... 502
St7GetPlateUV ............................................................. 940
St7GetPlateXAngle1 ..................................................... 327

Strand7 Function Index

St7GetPlyMaterial ......................................................... 529
St7GetPlyPropertyResultsState ..................................... 743
St7GetPointAttributesVisibility ......................................... 49
St7GetPointContactData ............................................... 467
St7GetPointContactThermalData .................................. 472
St7GetPropertyColour ................................................... 442
St7GetPropertyCreepID ................................................ 444
St7GetPropertyName .................................................... 441
St7GetPropertyNumByIndex ......................................... 440
St7GetPropertyRayleighFactors .................................... 448
St7GetPropertyTable .................................................... 443
St7GetPropertyVisibility .................................................. 52
St7GetQSAInitial........................................................... 631
St7GetQuasiStaticRestartFile ........................................ 709
St7GetRayleighFactors ................................................. 697
St7GetRCUnits ............................................................. 208
St7GetReactionMultiPointLink ....................................... 226
St7GetReactionMultiPointLinkAttributes......................... 380
St7GetReinforcementData ............................................ 541
St7GetReinforcementLayoutNumByIndex ...................... 538
St7GetReinforcementName .......................................... 539
St7GetResFileBeamReleaseResult ............................... 813
St7GetResFileBeamResult............................................ 811
St7GetResFileBeamStations ......................................... 810
St7GetResFileBrickResult ............................................. 816
St7GetResFileDescription ............................................. 802
St7GetResFileFreedomCase ........................................ 804
St7GetResFileMode...................................................... 805
St7GetResFileNodeResult ............................................ 809
St7GetResFilePlatePressureResult ............................... 815
St7GetResFilePlateResult ............................................. 814
St7GetResFileQuantityState ......................................... 808
St7GetResFileTime....................................................... 806
St7GetResFileTimeUnit ................................................ 807
St7GetResFileUnits ...................................................... 808
St7GetResultCaseConvergence .................................... 721
St7GetResultCaseFactor .............................................. 722
St7GetResultCaseInfluenceVariable .............................. 724
St7GetResultCaseKineticEnergy ................................... 723
St7GetResultCaseName ............................................... 719
St7GetResultCaseReset ............................................... 723
St7GetResultCaseStage ............................................... 720
St7GetResultCaseTime ................................................ 722
St7GetResultFileCombCaseData .................................. 788
St7GetResultFileCombCaseName ................................ 789
St7GetResultFileCombFileName ................................... 786
St7GetResultFileCombTargetFileName ......................... 785
St7GetResultFileOpenFlag.............................................. 24
St7GetResultFreedomCaseName ................................. 720
St7GetResultGroupState............................................... 704
St7GetResultOptions .................................................... 951
St7GetResultPropertyState ........................................... 705
St7GetResultSettingsDiagram ......................................... 69
St7GetResultSettingsDiagramColours ............................. 70
St7GetResultSettingsLegend .......................................... 67
St7GetResultSettingsLegendFont ................................... 68
St7GetResultSettingsLimits ............................................. 64
St7GetResultSettingsLimitsString .................................... 66
St7GetResultSettingsStyle .............................................. 63
St7GetResultUserEquation ........................................... 751
St7GetRigidLink ............................................................ 220
St7GetRigidMultiPointLink ............................................. 231
St7GetRigidMultiPointLinkAttributes .............................. 380
St7GetSectorSymmetryLink .......................................... 217
St7GetSeismicCaseDefaults ......................................... 180

St7GetSeismicCaseDynamicNSMassState .................... 186
St7GetShrinkLink .......................................................... 221
St7GetSoilAutoDrained ................................................. 698
St7GetSoilFluidOptions ................................................. 698
St7GetSolverActiveStage .............................................. 692
St7GetSolverCreep ....................................................... 701
St7GetSolverDefaultsDouble ......................................... 713
St7GetSolverDefaultsInteger ......................................... 712
St7GetSolverDefaultsLogical ......................................... 712
St7GetSolverErrorString .................................................. 17
St7GetSolverFontName ................................................ 718
St7GetSolverFreedomCase........................................... 695
St7GetSolverIncludeKG ................................................ 701
St7GetSolverLoadCaseCableInertia .............................. 694
St7GetSolverLoadCaseCablePreLoad ........................... 694
St7GetSolverLoadCaseTemperatureDependence .......... 693
St7GetSolverNonlinearGeometry ................................... 700
St7GetSolverNonlinearMaterial ..................................... 700
St7GetSolverNumCPU .................................................. 717
St7GetSolverScheme .................................................... 690
St7GetSolverSort .......................................................... 690
St7GetSolverStressStiffening ........................................ 702
St7GetSolverTemperatureDependence ......................... 692
St7GetSolverTreeStartNumber ...................................... 691
St7GetSpringDamperData ............................................. 463
St7GetSpringDamperThermalData ................................ 471
St7GetSRABaseCaseFactors ........................................ 649
St7GetSRABaseCaseName .......................................... 650
St7GetSRABaseCaseState ........................................... 647
St7GetSRABaseCaseTable........................................... 648
St7GetSRABaseCaseType............................................ 650
St7GetSRABaseExcitation ............................................ 641
St7GetSRALoadCaseName .......................................... 645
St7GetSRALoadCaseState ........................................... 644
St7GetSRALoadCaseTable ........................................... 644
St7GetSRALoadExcitation ............................................ 641
St7GetSRAResultCQC .................................................. 652
St7GetSRAResultSRSS ................................................ 651
St7GetSRAResultsSign ................................................. 653
St7GetSRAType ........................................................... 652
St7GetStageData .......................................................... 199
St7GetStageFluidLevel ................................................. 200
St7GetStageGroupState................................................ 201
St7GetStageName ........................................................ 199
St7GetStaticRestartFile ................................................. 708
St7GetSturmCheck ....................................................... 699
St7GetTableID .............................................................. 604
St7GetTableInfoByIndex ............................................... 602
St7GetTableTypeData................................................... 606
St7GetTableTypeName ................................................. 604
St7GetTHAInitial ........................................................... 658
St7GetTHAInitialAttributeOverride ................................. 659
St7GetTHATemperatureLoadCase ................................ 659
St7GetTimeDependentModType ................................... 446
St7GetTimeStepData .................................................... 685
St7GetTimeStepUnit ..................................................... 686
St7GetTimeTableUnits .................................................. 608
St7GetTitle ................................................................... 161
St7GetToolOptions ....................................................... 946
St7GetTotal .................................................................. 160
St7GetTotalCavityFluidLayouts ..................................... 585
St7GetTotalCreepDefinitions ......................................... 544
St7GetTotalLaminateStacks .......................................... 531
St7GetTotalLoadPathTemplates .................................... 564
St7GetTotalProperties ................................................... 440

Strand7 API Manual

St7GetTotalReinforcementLayouts ................................ 538
St7GetTransientBaseAcceleration ................................. 667
St7GetTransientBaseDisplacement ............................... 669
St7GetTransientBaseExcitation ..................................... 664
St7GetTransientBaseTables ......................................... 669
St7GetTransientBaseVector .......................................... 666
St7GetTransientBaseVelocity ........................................ 668
St7GetTransientFreedomCaseState .............................. 678
St7GetTransientFreedomPositionTable ......................... 676
St7GetTransientFreedomTimeTable .............................. 680
St7GetTransientHeatFile ............................................... 674
St7GetTransientInitialConditionsNodalVelocity .............. 666
St7GetTransientInitialConditionsType ............................ 664
St7GetTransientInitialConditionsVectors ........................ 665
St7GetTransientLoadCaseState .................................... 677
St7GetTransientLoadPositionTable ............................... 675
St7GetTransientLoadTimeTable .................................... 679
St7GetTransientNodeHistoryCaseData ......................... 672
St7GetTransientTemperatureInputType ......................... 673
St7GetTrussData .......................................................... 464
St7GetTwoPointLink ..................................................... 222
St7GetUCS .................................................................. 189
St7GetUCSID ............................................................... 191
St7GetUCSName ......................................................... 190
St7GetUnits .................................................................. 207
St7GetUserBeamData .................................................. 470
St7GetUserBeamThermalData ...................................... 472
St7GetUserDefinedMultiPointLink ................................. 232
St7GetUseSolverDLL .................................................... 716
St7GetVertexColours .................................................... 113
St7GetVertexForce3 ..................................................... 391
St7GetVertexHeatSource1 ............................................ 397
St7GetVertexHeatSourceTables.................................... 397
St7GetVertexID ............................................................ 390
St7GetVertexKDamping3F ............................................ 396
St7GetVertexKRotation3F ............................................. 394
St7GetVertexKTranslation3F ......................................... 394
St7GetVertexLabelStyle ................................................ 113
St7GetVertexMeshSize1 ............................................... 390
St7GetVertexMoment3.................................................. 392
St7GetVertexNSMass5ID.............................................. 396
St7GetVertexRestraint6 ................................................ 391
St7GetVertexRMass3 ................................................... 395
St7GetVertexShowHideSelected ................................... 112
St7GetVertexSize ......................................................... 112
St7GetVertexStyle ........................................................ 112
St7GetVertexTemperature1 .......................................... 392
St7GetVertexTemperatureTable .................................... 393
St7GetVertexTemperatureType1 ................................... 393
St7GetVertexTMass3 .................................................... 395
St7GetVertexType ........................................................ 390
St7GetVertexXYZ ......................................................... 234
St7GetWindowBackgroundMode ..................................... 35
St7GetWindowColours .................................................... 36
St7GetWindowImageFile................................................. 37
St7GetWindowImageLocation ......................................... 37
St7GetWindowImageSize ............................................... 38
St7Grade ...................................................................... 875
St7GraftEdgesToFaces ................................................. 861
St7HideEntity .................................................................. 47
St7HideEntityAttributes ................................................... 49
St7HideEntitySet............................................................. 54
St7HideGroup ................................................................. 53
St7HideMarker.............................................................. 132
St7HideModelWindow ..................................................... 34

St7HidePointAttributes .................................................... 48
St7HideProperty ............................................................. 52
St7HideWindowCaption .................................................. 42
St7HideWindowCombos.................................................. 39
St7HideWindowEntityPanel ............................................. 39
St7HideWindowResultsToolbar ....................................... 43
St7HideWindowSelectionToolbar ..................................... 42
St7HideWindowShowHideToolbar ................................... 43
St7HideWindowStatusBar ............................................... 40
St7HideWindowViewToolbar ........................................... 43
St7ImportACIS .............................................................. 144
St7ImportANSYS .......................................................... 148
St7ImportDXF ............................................................... 146
St7ImportIGES.............................................................. 143
St7ImportNASTRAN ..................................................... 148
St7ImportRhino ............................................................. 145
St7ImportSAP2000 ....................................................... 149
St7ImportST7 ............................................................... 143
St7ImportSTAAD .......................................................... 149
St7ImportSTEP ............................................................. 145
St7ImportSTL ............................................................... 147
St7Init ............................................................................. 13
St7InsertCombinationEnvelope ..................................... 775
St7InsertCombinedLSACombination .............................. 764
St7InsertFactorsEnvelope ............................................. 778
St7InsertFactorsEnvelopeCase ..................................... 780
St7InsertFactorsEnvelopeSet ........................................ 783
St7InsertLaminatePly .................................................... 535
St7InsertLimitEnvelope ................................................. 771
St7InsertLoadPathTemplateDistributedForce ................. 576
St7InsertLoadPathTemplateHeatSource ........................ 579
St7InsertLoadPathTemplatePointForce ......................... 573
St7InsertLoadPathTemplateVehicle ............................... 569
St7InsertLSACombination ............................................. 761
St7InsertNLAIncrement ................................................. 620
St7InsertSRABaseCase ................................................ 646
St7InsertSRALoadCase ................................................ 642
St7InsertStage .............................................................. 197
St7InsertTransientNodeHistoryCase .............................. 670
St7InsertVerticesOnEdge .............................................. 234
St7InsituStress.............................................................. 930
St7InterpolateBeamSections ......................................... 878
St7IntersectBeamsAndLinks .......................................... 879
St7IntersectEdges ......................................................... 861
St7InvalidateElement .................................................... 953
St7InvalidateGeometryFace .......................................... 954
St7InvalidateGeometryFaceCavityLoopID ...................... 954
St7InvalidateGeometryFaceCavityLoopIndex ................. 954
St7InvertPathNormal ..................................................... 928
St7LoadBrickContourFile............................................... 756
St7LoadPlateContourFile .............................................. 756
St7LoftBeams ............................................................... 879
St7MergeElementPairs ................................................. 911
St7MergeLineOfBeams ................................................. 911
St7MergeTriToQuad ..................................................... 911
St7MeshFromLoops ...................................................... 873
St7MidPlanePlateProjection .......................................... 881
St7MidPlaneThinSolids ................................................. 866
St7MorphEdges ............................................................ 862
St7MoveByIncrement .................................................... 838
St7MoveByMirror .......................................................... 842
St7MoveByProjectionToEntityFace ................................ 841
St7MoveByProjectionToLine ......................................... 839
St7MoveByProjectionToPlane ....................................... 839
St7MoveByProjectionToUCS ......................................... 840

Strand7 Function Index

St7MoveByRotation ...................................................... 838
St7MoveBySkew........................................................... 842
St7MoveByThickness ................................................... 841
St7MoveToAbsolute...................................................... 843
St7MoveToOriginByPoint .............................................. 844
St7MoveToOriginMinXYZ.............................................. 845
St7MoveToPlane .......................................................... 845
St7MoveToUCSIntersection .......................................... 843
St7NewBeamProperty................................................... 449
St7NewBrickProperty .................................................... 505
St7NewCavityFluidLayout ............................................. 585
St7NewChildGroup ....................................................... 193
St7NewCreepDefinition ................................................. 544
St7NewEntitySet ........................................................... 203
St7NewFile ..................................................................... 20
St7NewFreedomCase ................................................... 176
St7NewLaminate .......................................................... 531
St7NewLoadCase ......................................................... 176
St7NewLoadPathTemplate............................................ 564
St7NewPlateProperty .................................................... 477
St7NewPlyProperty ....................................................... 528
St7NewReinforcementLayout ........................................ 538
St7NewResFile ............................................................. 801
St7NewTableType ........................................................ 603
St7OpenFile ................................................................... 19
St7OpenFileReadOnly .................................................... 19
St7OpenResFile ........................................................... 801
St7OpenResultFile .......................................................... 25
St7PanModel .................................................................. 47
St7PasteFromSt7ClipboardByAnchors .......................... 818
St7PasteFromSt7ClipboardByIncrements ...................... 818
St7PlateHullVolume ...................................................... 941
St7PlateOffsetByThickness ........................................... 924
St7PLAverage2 ............................................................ 887
St7PlayAnimationFile .................................................... 157
St7PLCircleC3 .............................................................. 892
St7PLCircleCentre3 ...................................................... 895
St7PLCircleLineInnerFillet3R ........................................ 896
St7PLCircleLineIntersect3 ............................................. 898
St7PLCircleLineOuterFillet3R ........................................ 897
St7PLCircleO3 .............................................................. 889
St7PLCirclesFillet3R ..................................................... 899
St7PLCirclesIntersect3R ............................................... 895
St7PLCirclesTangent3R ................................................ 893
St7PLCircleTangent3R ................................................. 894
St7PLCurve3 ................................................................ 891
St7PLEllipseO3 ............................................................ 890
St7PLExtend2R ............................................................ 886
St7PLFillet3R ............................................................... 888
St7PLFillet4R ............................................................... 889
St7PLIntersect4 ............................................................ 893
St7PLLine2 ................................................................... 884
St7PLNormal3 .............................................................. 885
St7PLNormal3R ............................................................ 886
St7PLParabola3 ........................................................... 884
St7PositionModelWindow................................................ 50
St7RebuildFaces .......................................................... 867
St7RebuildFacesUV...................................................... 867
St7RedrawModel ............................................................ 46
St7RefreshWindowStatusBar .......................................... 41
St7Release ..................................................................... 14
St7RemoveBeamReferenceNode .................................. 924
St7RemoveSelectedFromEntitySet................................ 205
St7ReorderNodesAMD ................................................. 919
St7ReorderNodesGeometry .......................................... 919

St7ReorderNodesTree .................................................. 919
St7RepairTri3Mesh ....................................................... 882
St7ReplaceStoredResultUserEquation .......................... 752
St7RetrieveResultFileComb .......................................... 789
St7RetrieveStoredResultUserEquation .......................... 753
St7RGBToColour .......................................................... 963
St7RotateModel .............................................................. 46
St7RotatePlateConnections........................................... 927
St7RunSolver ............................................................... 714
St7RunSolverProcess ................................................... 714
St7SaveBeamSectionMesh ........................................... 461
St7SaveDeformedCopy ................................................... 21
St7SaveFile .................................................................... 20
St7SaveFileCopy ............................................................ 21
St7SaveSubModel .......................................................... 22
St7SaveViewOnlyCopy ................................................... 22
St7ScaleByCartesianUCS ............................................. 857
St7ScaleByCylindricalUCS ............................................ 857
St7ScaleBySphericalUCS ............................................. 858
St7ScaleByTaper .......................................................... 859
St7ScaleByToroidalUCS ............................................... 858
St7SetAccVsTimeTableUnits ......................................... 610
St7SetAllEntitiesOn ......................................................... 54
St7SetAllEntitySelectState .............................................. 30
St7SetAlphaTempType ................................................. 449
St7SetAnimationCase ................................................... 159
St7SetAppendSRA ....................................................... 653
St7SetAttachmentLink ................................................... 223
St7SetAttributeDisplay .................................................. 128
St7SetBeamCableAsLine ................................................ 76
St7SetBeamCableFreeLength1 ..................................... 268
St7SetBeamColours........................................................ 77
St7SetBeamConnectionUCS ......................................... 264
St7SetBeamConvection2 .............................................. 276
St7SetBeamConvectionTables ...................................... 277
St7SetBeamCreepLoadingAge1 .................................... 281
St7SetBeamDistributedForceGlobal6ID ......................... 275
St7SetBeamDistributedForcePrincipal6ID ...................... 274
St7SetBeamDistributedMomentPrincipal6ID .................. 274
St7SetBeamDrawAxes .................................................... 79
St7SetBeamEndAttachment1 ........................................ 281
St7SetBeamFill ............................................................... 76
St7SetBeamFlux1 ......................................................... 279
St7SetBeamFluxTables ................................................. 279
St7SetBeamHeatSource1 ............................................. 280
St7SetBeamHeatSourceTables ..................................... 280
St7SetBeamID .............................................................. 264
St7SetBeamLabelStyle ................................................... 77
St7SetBeamLighting ....................................................... 78
St7SetBeamLineThickness.............................................. 77
St7SetBeamMaterialData .............................................. 474
St7SetBeamMirrorOption .............................................. 453
St7SetBeamMoveToOffset .............................................. 79
St7SetBeamNonlinearMode .......................................... 476
St7SetBeamNonlinearType ........................................... 454
St7SetBeamNRef............................................................ 78
St7SetBeamNSMass10ID ............................................. 276
St7SetBeamOffset2 ...................................................... 265
St7SetBeamOffsetNodes ................................................ 79
St7SetBeamOutline......................................................... 76
St7SetBeamPointForceGlobal4ID .................................. 272
St7SetBeamPointForcePrincipal4ID .............................. 272
St7SetBeamPointMomentGlobal4ID .............................. 273
St7SetBeamPointMomentPrincipal4ID ........................... 273
St7SetBeamPreCurvature2 ........................................... 271

Strand7 API Manual

St7SetBeamPreLoad1 .................................................. 270
St7SetBeamPropertyType ............................................. 452
St7SetBeamRadiation2 ................................................. 277
St7SetBeamRadiationTables ........................................ 278
St7SetBeamRadius1 ..................................................... 268
St7SetBeamReferenceAngle1 ....................................... 264
St7SetBeamResponse .................................................. 280
St7SetBeamResultDisplay .............................................. 55
St7SetBeamResultPosMode ......................................... 734
St7SetBeamRoundFacets ............................................... 80
St7SetBeamRRelease3 ................................................ 267
St7SetBeamSectionCircularDiscretisation ..................... 459
St7SetBeamSectionFactor7 .......................................... 266
St7SetBeamSectionGeometry ....................................... 456
St7SetBeamSectionGeometryBGL ................................ 457
St7SetBeamSectionName ............................................. 451
St7SetBeamSectionNominalDiscretisation ..................... 458
St7SetBeamSectionPropertyData .................................. 455
St7SetBeamShearModulusMode................................... 475
St7SetBeamShrink ......................................................... 80
St7SetBeamSideAttachment1 ....................................... 282
St7SetBeamSlices .......................................................... 80
St7SetBeamSpringAspect ............................................... 80
St7SetBeamSpringCoils .................................................. 79
St7SetBeamStringGroup1 ............................................. 270
St7SetBeamStyle............................................................ 76
St7SetBeamSupport2 ................................................... 266
St7SetBeamTaper2 ...................................................... 265
St7SetBeamTempGradient2 ......................................... 271
St7SetBeamTRelease3 ................................................. 267
St7SetBrickAddBubbleFunction ..................................... 525
St7SetBrickAnisotropicMaterial ..................................... 510
St7SetBrickCavityFluid.................................................. 362
St7SetBrickColours ......................................................... 99
St7SetBrickConvection2 ............................................... 355
St7SetBrickConvectionTables ....................................... 356
St7SetBrickCreepLoadingAge1 ..................................... 361
St7SetBrickDrawAxes ................................................... 100
St7SetBrickFaceAttachment1 ........................................ 361
St7SetBrickFill ................................................................ 98
St7SetBrickFluidMaterial ............................................... 524
St7SetBrickFlux1 .......................................................... 358
St7SetBrickFluxTables .................................................. 358
St7SetBrickGlobalPressure3 ......................................... 354
St7SetBrickHeatSource1............................................... 359
St7SetBrickHeatSourceTables ...................................... 359
St7SetBrickID ............................................................... 351
St7SetBrickIntegrationPoints ......................................... 526
St7SetBrickIsotropicMaterial ......................................... 507
St7SetBrickLabelStyle..................................................... 98
St7SetBrickLighting......................................................... 99
St7SetBrickLineThickness ............................................... 98
St7SetBrickLocalAxes1 ................................................. 351
St7SetBrickMCDPMaterial ............................................ 513
St7SetBrickNonlinearType ............................................ 506
St7SetBrickNormalPressure1 ........................................ 353
St7SetBrickNSMass5ID ................................................ 355
St7SetBrickOrthotropicMaterial ..................................... 508
St7SetBrickOutline .......................................................... 98
St7SetBrickOutlineMode ............................................... 100
St7SetBrickPointForce6 ................................................ 352
St7SetBrickPreLoad3 .................................................... 352
St7SetBrickPropertyType .............................................. 505
St7SetBrickRadiation2 .................................................. 357
St7SetBrickRadiationTables .......................................... 357

St7SetBrickResponse ................................................... 360
St7SetBrickResultDisplay ................................................ 56
St7SetBrickRubberMaterial ........................................... 512
St7SetBrickSelectState ................................................... 29
St7SetBrickShear2 ........................................................ 354
St7SetBrickShrink ......................................................... 100
St7SetBrickSoilCCMaterial ............................................ 517
St7SetBrickSoilDCMaterial ............................................ 515
St7SetBrickSoilDPMaterial ............................................ 521
St7SetBrickSoilLSMaterial ............................................. 522
St7SetBrickSoilMCMaterial............................................ 519
St7SetBrickSoilRatio2 ................................................... 360
St7SetBrickSoilStress2 ................................................. 359
St7SetBrickSupport4 ..................................................... 351
St7SetBrickWireframeAll ............................................... 101
St7SetCableData .......................................................... 463
St7SetCableDroopDirection........................................... 160
St7SetCavityFluidConstBulk .......................................... 588
St7SetCavityFluidIdealGas ............................................ 587
St7SetCavityFluidName ................................................ 586
St7SetCavityFluidPreLoad ............................................ 589
St7SetCleanGeometryOptions....................................... 949
St7SetCleanMeshOptions ............................................. 947
St7SetCombinationEnvelopeCase ................................. 776
St7SetCombinationEnvelopeData .................................. 777
St7SetCombinedLSACombinationFactor ....................... 765
St7SetCombinedLSACombinationName ........................ 763
St7SetCombinedLSACombinationState ......................... 763
St7SetComment ........................................................... 162
St7SetConnectionData .................................................. 468
St7SetConnectionThermalData ..................................... 473
St7SetCopyFlags .......................................................... 827
St7SetCouplingLink....................................................... 217
St7SetCreepBasicData ................................................. 546
St7SetCreepConcreteCementCuringData ...................... 562
St7SetCreepConcreteFunctionType .............................. 556
St7SetCreepConcreteHyperbolicData ............................ 551
St7SetCreepConcreteLoadingAge ................................. 556
St7SetCreepConcreteLoadingTimeUnit ......................... 557
St7SetCreepConcreteShrinkageFormulaData ................ 559
St7SetCreepConcreteShrinkageTableData .................... 560
St7SetCreepConcreteShrinkageType ............................ 558
St7SetCreepConcreteTemperatureData ........................ 560
St7SetCreepConcreteUserTableData ............................ 555
St7SetCreepConcreteViscoChainData ........................... 552
St7SetCreepDefinitionName .......................................... 545
St7SetCreepHardeningType .......................................... 549
St7SetCreepLaw ........................................................... 545
St7SetCreepTemperatureInclude .................................. 551
St7SetCreepTimeUnit ................................................... 550
St7SetCreepUserTableData .......................................... 548
St7SetCutoffBarData ..................................................... 465
St7SetDampingType ..................................................... 695
St7SetDefaultGroupID................................................... 196
St7SetDisplacementScale ............................................. 142
St7SetDisplayOptionsPath .............................................. 18
St7SetDynamicRestartFile ............................................ 708
St7SetElementConnection ............................................ 213
St7SetElementProperty ................................................. 434
St7SetElementPropertySwitch ....................................... 434
St7SetEntityContourFile ................................................ 134
St7SetEntityContourIndex ............................................. 135
St7SetEntityContourSettingsLegend .............................. 139
St7SetEntityContourSettingsLegendFont ....................... 140
St7SetEntityContourSettingsLimits ................................ 137

Strand7 Function Index

St7SetEntityContourSettingsLimitsString ....................... 138
St7SetEntityContourSettingsStyle ................................. 135
St7SetEntityFont ............................................................. 60
St7SetEntityGroup ........................................................ 436
St7SetEntityResult ........................................................ 702
St7SetEntitySelectState .................................................. 28
St7SetEntitySelectStateByEntitySet ................................ 31
St7SetEntitySelectStateByGroup..................................... 31
St7SetEntitySelectStateByProperty ................................. 30
St7SetEntitySetName ................................................... 203
St7SetEnvelopeAdditionalBeamSlices ........................... 774
St7SetEnvelopeAveragingOrder .................................... 774
St7SetExtrudeFlags ...................................................... 828
St7SetExtrudeTargets ................................................... 828
St7SetFaceColours ....................................................... 115
St7SetFaceControlPoints .............................................. 117
St7SetFaceFill .............................................................. 114
St7SetFaceFillStyle....................................................... 114
St7SetFaceLabelStyle................................................... 114
St7SetFaceLighting....................................................... 115
St7SetFaceLineThickness ............................................. 116
St7SetFaceNIEdges ..................................................... 117
St7SetFaceNormals ...................................................... 117
St7SetFaceNormalsSize ............................................... 117
St7SetFaceOutline ........................................................ 114
St7SetFaceWireDensity ................................................ 116
St7SetFaceWireThickness ............................................ 116
St7SetFactorsEnvelopeCaseData ................................. 781
St7SetFactorsEnvelopeData ......................................... 779
St7SetFactorsEnvelopeSetData .................................... 783
St7SetFreedomCaseDefaults ........................................ 181
St7SetFreedomCaseName ........................................... 178
St7SetFreedomCaseRigidMotion .................................. 186
St7SetFreedomCaseType ............................................. 184
St7SetFreeNodes ........................................................... 72
St7SetFreeVertices ....................................................... 110
St7SetFrequencyPeriodTableType ................................ 606
St7SetFrequencyPeriodTableUnits ................................ 607
St7SetGeometryCoedgeAttachment1 ............................ 408
St7SetGeometryCoedgeConvection2 ............................ 405
St7SetGeometryCoedgeConvectionTables .................... 406
St7SetGeometryCoedgeFlux1 ....................................... 407
St7SetGeometryCoedgeFluxTables .............................. 408
St7SetGeometryCoedgePressure1................................ 404
St7SetGeometryCoedgePressure3................................ 404
St7SetGeometryCoedgeRadiation2 ............................... 406
St7SetGeometryCoedgeRadiationTables ...................... 407
St7SetGeometryCoedgeRelease1 ................................. 403
St7SetGeometryCoedgeShear1 .................................... 404
St7SetGeometryCoedgeSupport4 ................................. 403
St7SetGeometryCoedgeTransverseShear1 ................... 405
St7SetGeometryEdgeBeamProperty ............................. 399
St7SetGeometryEdgeCluster ........................................ 400
St7SetGeometryEdgeMinDivisions ................................ 399
St7SetGeometryEdgeType............................................ 399
St7SetGeometryFaceAttachment1 ................................ 424
St7SetGeometryFaceConvection2 ................................ 421
St7SetGeometryFaceConvectionTables ........................ 421
St7SetGeometryFaceGlobalPressure3S ........................ 420
St7SetGeometryFaceHeatSource1................................ 423
St7SetGeometryFaceHeatSourceTables ....................... 423
St7SetGeometryFaceID ................................................ 417
St7SetGeometryFaceNormalPressure2 ......................... 419
St7SetGeometryFaceNSMass5ID ................................. 420
St7SetGeometryFaceOffset1 ........................................ 418

St7SetGeometryFaceProperty ....................................... 417
St7SetGeometryFaceRadiation2 ................................... 422
St7SetGeometryFaceRadiationTables ........................... 422
St7SetGeometryFaceSupport4 ...................................... 418
St7SetGeometryFaceTempGradient1 ............................ 419
St7SetGeometryFaceThickness2 .................................. 417
St7SetGroupColour ....................................................... 195
St7SetGroupIDName .................................................... 192
St7SetHardeningType ................................................... 445
St7SetHRABaseCombinationFactor .............................. 767
St7SetHRABaseVector ................................................. 638
St7SetHRACaseCombinationFactor .............................. 768
St7SetHRACombinationFactorLSA ................................ 769
St7SetHRACombinationLSAName ................................ 767
St7SetHRALoadCase.................................................... 639
St7SetHRALoadType .................................................... 637
St7SetHRAMode........................................................... 637
St7SetHRARange ......................................................... 636
St7SetIconSize ............................................................... 13
St7SetInfluenceCombinationOptions ............................. 799
St7SetInfluenceFileName .............................................. 791
St7SetInfluenceGroupState ........................................... 797
St7SetInfluenceMaxVariableState ................................. 793
St7SetInfluenceMinVariableState .................................. 792
St7SetInfluenceMultiVariableName................................ 796
St7SetInfluenceMultiVariableState ................................. 794
St7SetInfluenceMultiVariableType ................................. 795
St7SetInfluencePropertyState........................................ 798
St7SetInitialPCGFile ..................................................... 706
St7SetInterpolatedMultiPointLink ................................... 227
St7SetInterpolatedMultiPointLinkAttributes..................... 376
St7SetKeepSelect ......................................................... 827
St7SetLaminateData ..................................................... 535
St7SetLaminateName ................................................... 532
St7SetLaminatePly ....................................................... 533
St7SetLBAInitial ............................................................ 614
St7SetLBANumModes .................................................. 615
St7SetLBAShift ............................................................. 615
St7SetLibraryPath ......................................................... 591
St7SetLicenceOptions ..................................................... 14
St7SetLimitEnvelopeData .............................................. 773
St7SetLinkColours ........................................................ 106
St7SetLinkDashes ........................................................ 106
St7SetLinkID ................................................................. 376
St7SetLinkLabelStyle .................................................... 105
St7SetLinkLineThickness .............................................. 105
St7SetLinkOutline ......................................................... 105
St7SetLinkResultDisplay ................................................. 57
St7SetLoadCaseDefaults .............................................. 179
St7SetLoadCaseGravity ................................................ 183
St7SetLoadCaseGravityDir............................................ 183
St7SetLoadCaseMassOption ........................................ 185
St7SetLoadCaseName .................................................. 177
St7SetLoadCaseType ................................................... 182
St7SetLoadPath ............................................................ 243
St7SetLoadPathTemplateCentrifugalData ...................... 583
St7SetLoadPathTemplateDistributedForceData ............. 577
St7SetLoadPathTemplateHeatSourceData .................... 581
St7SetLoadPathTemplateLaneFactor ............................ 567
St7SetLoadPathTemplateName .................................... 565
St7SetLoadPathTemplateParameters ............................ 565
St7SetLoadPathTemplatePointForceData ...................... 574
St7SetLoadPathTemplateVehicleData ........................... 570
St7SetLoadPathTemplateVehicleName ......................... 568
St7SetLoadPathTemplateVehicleSet ............................. 582

Strand7 API Manual

St7SetLSACombinationFactor ....................................... 761
St7SetLSACombinationName ....................................... 758
St7SetLSACombinationSRAName ................................ 759
St7SetLSACombinationState ........................................ 760
St7SetLTAInitial ............................................................ 655
St7SetLTAMethod ........................................................ 655
St7SetLTASolutionType ................................................ 656
St7SetMarker ............................................................... 130
St7SetMasterSlaveLink ................................................. 215
St7SetMasterSlaveMultiPointLink .................................. 228
St7SetMasterSlaveMultiPointLinkAttributes ................... 376
St7SetMaterialName ..................................................... 444
St7SetModalSuperpositionFile ...................................... 660
St7SetModeDampingRatio ............................................ 662
St7SetModelDefaults .................................................... 169
St7SetModelWindowParent............................................. 34
St7SetModelWindowRefresh ........................................... 45
St7SetMomentRotationTableUnits ................................. 609
St7SetMovingLoadAutoDivisions ................................... 688
St7SetMovingLoadTimeTable ....................................... 688
St7SetNFAFileOpenMinMass .......................................... 25
St7SetNFAInitial ........................................................... 632
St7SetNFAModeParticipationCalculate .......................... 634
St7SetNFAModeParticipationVectors ............................ 634
St7SetNFANumModes .................................................. 632
St7SetNFAShift ............................................................ 633
St7SetNLAFreedomIncrementFactor ............................. 623
St7SetNLAInitial ........................................................... 629
St7SetNLALoadIncrementFactor ................................... 622
St7SetNLAPseudoTime ................................................ 628
St7SetNLAResetAtIncrement ........................................ 624
St7SetNLAStagedAnalysis ............................................ 619
St7SetNodeAcceleration3 ............................................. 252
St7SetNodeColours ........................................................ 73
St7SetNodeForce3 ....................................................... 246
St7SetNodeHeatSource1 .............................................. 251
St7SetNodeHeatSourceTables ...................................... 251
St7SetNodeHistoryFile .................................................. 710
St7SetNodeID .............................................................. 245
St7SetNodeInitialVelocity3 ............................................ 252
St7SetNodeKDamping3F .............................................. 250
St7SetNodeKRotation3F ............................................... 248
St7SetNodeKTranslation3F ........................................... 248
St7SetNodeLabelStyle .................................................... 73
St7SetNodeMoment3 .................................................... 246
St7SetNodeNSMass5ID ................................................ 250
St7SetNodeResponse................................................... 253
St7SetNodeRestraint6 .................................................. 245
St7SetNodeRMass3 ..................................................... 249
St7SetNodeShowHideSelected ....................................... 72
St7SetNodeSize ............................................................. 72
St7SetNodeStyle ............................................................ 72
St7SetNodeTemperature1 ............................................ 246
St7SetNodeTemperatureTable ...................................... 247
St7SetNodeTemperatureType1 ..................................... 247
St7SetNodeTMass1 ...................................................... 249
St7SetNodeTMass3 ...................................................... 249
St7SetNodeUCS ........................................................... 212
St7SetNodeXYZ ........................................................... 212
St7SetNTAInitial ........................................................... 657
St7SetNumericOptions.................................................... 59
St7SetNumTimeStepRows ............................................ 684
St7SetPasteOptions...................................................... 817
St7SetPathColours ....................................................... 124
St7SetPathDivisions ..................................................... 125

St7SetPathFill ............................................................... 123
St7SetPathLabelStyle ................................................... 123
St7SetPathLighting ....................................................... 124
St7SetPathLineThickness ............................................. 124
St7SetPathOutline ........................................................ 123
St7SetPinnedLink ......................................................... 218
St7SetPinnedMultiPointLink .......................................... 229
St7SetPipeData ............................................................ 467
St7SetPipePressure2AF................................................ 269
St7SetPipeTemperature2OT ......................................... 269
St7SetPlateAddBubbleFunction ..................................... 503
St7SetPlateAnisotropicMaterial ..................................... 485
St7SetPlateAverageNormals ........................................... 87
St7SetPlateAverageNormalsAngle .................................. 87
St7SetPlateAxisLayer...................................................... 91
St7SetPlateCavityFluid .................................................. 325
St7SetPlateColours ......................................................... 89
St7SetPlateCreepLoadingAge1 ..................................... 324
St7SetPlateDrawAxes ..................................................... 90
St7SetPlateEdgeAttachment1 ....................................... 324
St7SetPlateEdgeConvection2........................................ 315
St7SetPlateEdgeConvectionTables ............................... 316
St7SetPlateEdgePressure1 ........................................... 311
St7SetPlateEdgePressure3 ........................................... 313
St7SetPlateEdgeRadiation2 .......................................... 317
St7SetPlateEdgeRadiationTables .................................. 317
St7SetPlateEdgeRelease1 ............................................ 307
St7SetPlateEdgeShear1................................................ 312
St7SetPlateEdgeSupport4 ............................................. 306
St7SetPlateEdgeTransverseShear1 .............................. 312
St7SetPlateFaceAttachment1 ........................................ 325
St7SetPlateFaceConvection2 ........................................ 319
St7SetPlateFaceConvectionTables................................ 319
St7SetPlateFaceNodes ................................................... 91
St7SetPlateFaceRadiation2........................................... 320
St7SetPlateFaceRadiationTables .................................. 320
St7SetPlateFaceSupport4 ............................................. 307
St7SetPlateFill ................................................................ 87
St7SetPlateFluidMaterial ............................................... 501
St7SetPlateFlux1 .......................................................... 318
St7SetPlateFluxTables .................................................. 318
St7SetPlateGlobalPressure3S ....................................... 314
St7SetPlateHeatSource1............................................... 321
St7SetPlateHeatSourceTables ...................................... 321
St7SetPlateID ............................................................... 305
St7SetPlateIsotropicMaterial ......................................... 480
St7SetPlateLabelStyle..................................................... 88
St7SetPlateLaminateMaterial ........................................ 487
St7SetPlateLayers ........................................................ 503
St7SetPlateLighting......................................................... 89
St7SetPlateLineThickness ............................................... 88
St7SetPlateLoadPatch4 ................................................ 323
St7SetPlateMCDPMaterial ............................................ 490
St7SetPlateMoveToOffset ............................................... 90
St7SetPlateNonlinearType ............................................ 478
St7SetPlateNormalPressure2 ........................................ 313
St7SetPlateNSMass5ID ................................................ 315
St7SetPlateOffset1 ....................................................... 306
St7SetPlateOffsetNodes.................................................. 90
St7SetPlateOrthotropicMaterial ..................................... 481
St7SetPlateOutline .......................................................... 88
St7SetPlateOutlineMode ................................................. 91
St7SetPlatePatchTol ..................................................... 504
St7SetPlatePointForce6 ................................................ 310
St7SetPlatePointMoment6 ............................................ 311

Strand7 Function Index

St7SetPlatePreCurvature2 ............................................ 309
St7SetPlatePreLoad3 ................................................... 309
St7SetPlatePropertyType .............................................. 477
St7SetPlateReinforcement2 .......................................... 323
St7SetPlateResponse ................................................... 322
St7SetPlateResultDisplay ............................................... 56
St7SetPlateResultMaxJunctionAngle ............................. 741
St7SetPlateRubberMaterial ........................................... 483
St7SetPlateSectionFactor10 ......................................... 308
St7SetPlateShear2 ....................................................... 314
St7SetPlateShrink........................................................... 90
St7SetPlateSoilCCMaterial............................................ 494
St7SetPlateSoilDCMaterial............................................ 491
St7SetPlateSoilDPMaterial ............................................ 497
St7SetPlateSoilLSMaterial ............................................ 499
St7SetPlateSoilMCMaterial ........................................... 496
St7SetPlateSoilRatio2 ................................................... 322
St7SetPlateSoilStress2 ................................................. 322
St7SetPlateStyle ............................................................. 87
St7SetPlateTempGradient1........................................... 310
St7SetPlateThickness ................................................... 479
St7SetPlateThickness2 ................................................. 305
St7SetPlateUserDefinedMaterial ................................... 488
St7SetPlateUseReducedInt ........................................... 502
St7SetPlateXAngle1 ..................................................... 305
St7SetPLTarget ............................................................ 829
St7SetPlyMaterial ......................................................... 528
St7SetPointContactData ............................................... 466
St7SetPointContactThermalData ................................... 471
St7SetProjectDirectionAsConical................................... 825
St7SetProjectDirectionAsParallel................................... 825
St7SetProjectDirectionAsSource ................................... 825
St7SetProjectDirectionAsTarget .................................... 825
St7SetPropertyColour ................................................... 442
St7SetPropertyCreepID ................................................ 443
St7SetPropertyIncrement .............................................. 827
St7SetPropertyName .................................................... 441
St7SetPropertyRayleighFactors .................................... 447
St7SetPropertyTable ..................................................... 442
St7SetQSAInitial ........................................................... 631
St7SetQuasiStaticRestartFile ........................................ 709
St7SetRayleighFactors ................................................. 696
St7SetRCUnits ............................................................. 208
St7SetReactionMultiPointLink ....................................... 225
St7SetReactionMultiPointLinkAttributes ......................... 377
St7SetReferenceDisplacement ...................................... 731
St7SetReinforcementData ............................................. 539
St7SetReinforcementName ........................................... 539
St7SetResFileBeamReleaseResult ............................... 812
St7SetResFileBeamResult ............................................ 811
St7SetResFileBeamStations ......................................... 810
St7SetResFileBrickResult ............................................. 815
St7SetResFileCaseName ............................................. 802
St7SetResFileDescription ............................................. 801
St7SetResFileFreedomCase ......................................... 804
St7SetResFileMode ...................................................... 805
St7SetResFileNodeResult ............................................. 809
St7SetResFileNumCases.............................................. 802
St7SetResFilePlatePressureResult ............................... 814
St7SetResFilePlateResult ............................................. 813
St7SetResFileQuantity .................................................. 807
St7SetResFileTime ....................................................... 806
St7SetResFileTimeUnit ................................................. 806
St7SetResultFileCombCaseData................................... 787
St7SetResultFileCombCaseName ................................. 788

St7SetResultFileCombFileName ................................... 786
St7SetResultFileCombTargetFileName.......................... 785
St7SetResultFileName .................................................. 707
St7SetResultFileOpenFlag .............................................. 24
St7SetResultLogFileName ............................................ 708
St7SetResultOptions ..................................................... 950
St7SetResultSettingsDiagram ......................................... 69
St7SetResultSettingsDiagramColours.............................. 70
St7SetResultSettingsLegend ........................................... 66
St7SetResultSettingsLegendFont .................................... 67
St7SetResultSettingsLimits ............................................. 64
St7SetResultSettingsLimitsString .................................... 65
St7SetResultSettingsStyle ............................................... 62
St7SetResultUserEquation ............................................ 751
St7SetRigidLink ............................................................ 219
St7SetRigidMultiPointLink ............................................. 230
St7SetRigidMultiPointLinkAttributes ............................... 377
St7SetSectorSymmetryLink ........................................... 216
St7SetSeismicCaseDefaults .......................................... 180
St7SetSeismicCaseDynamicNSMassState .................... 186
St7SetShrinkLink .......................................................... 220
St7SetSoilAutoDrained .................................................. 698
St7SetSoilFluidOptions ................................................. 697
St7SetSolverActiveStage .............................................. 691
St7SetSolverCreep ....................................................... 701
St7SetSolverDefaultsDouble ......................................... 713
St7SetSolverDefaultsInteger ......................................... 712
St7SetSolverDefaultsLogical ......................................... 711
St7SetSolverFontName ................................................. 717
St7SetSolverFreedomCase ........................................... 695
St7SetSolverHeatNonlinear ........................................... 682
St7SetSolverIncludeKG ................................................. 701
St7SetSolverLoadCaseCableInertia ............................... 693
St7SetSolverLoadCaseCablePreLoad ........................... 694
St7SetSolverLoadCaseTemperatureDependence .......... 693
St7SetSolverNonlinearGeometry ................................... 699
St7SetSolverNonlinearMaterial ...................................... 700
St7SetSolverNumCPU .................................................. 717
St7SetSolverScheme .................................................... 690
St7SetSolverSort .......................................................... 690
St7SetSolverStressStiffening ......................................... 702
St7SetSolverTemperatureDependence .......................... 692
St7SetSolverTreeStartNumber ...................................... 691
St7SetSolverWindowPos............................................... 715
St7SetSourceAction ...................................................... 829
St7SetSpringDamperData ............................................. 462
St7SetSpringDamperThermalData................................. 471
St7SetSRABaseCaseFactors ........................................ 649
St7SetSRABaseCaseName .......................................... 650
St7SetSRABaseCaseTable ........................................... 648
St7SetSRABaseCaseType ............................................ 649
St7SetSRABaseExcitation ............................................. 641
St7SetSRALoadCaseName........................................... 645
St7SetSRALoadCaseTable ........................................... 644
St7SetSRALoadExcitation ............................................. 641
St7SetSRAResultCQC .................................................. 651
St7SetSRAResultSRSS ................................................ 651
St7SetSRAResultsSign ................................................. 653
St7SetSRAType ............................................................ 652
St7SetStageData .......................................................... 199
St7SetStageFluidLevel .................................................. 200
St7SetStageName ........................................................ 198
St7SetStaticRestartFile ................................................. 708
St7SetStoredResultUserEquation .................................. 754
St7SetSturmCheck........................................................ 699

Strand7 API Manual

St7SetTableTypeData ................................................... 605
St7SetTableTypeName ................................................. 604
St7SetTHAInitial ........................................................... 658
St7SetTHAInitialAttributeOverride ................................. 659
St7SetTHATemperatureLoadCase ................................ 658
St7SetTimeDependentModType.................................... 446
St7SetTimeStepData .................................................... 684
St7SetTimeStepUnit ..................................................... 685
St7SetTimeTableUnits .................................................. 608
St7SetTitle .................................................................... 161
St7SetToolOptions ........................................................ 945
St7SetTransientBaseAcceleration ................................. 667
St7SetTransientBaseDisplacement ............................... 668
St7SetTransientBaseExcitation ..................................... 664
St7SetTransientBaseTables .......................................... 669
St7SetTransientBaseVector .......................................... 666
St7SetTransientBaseVelocity ........................................ 668
St7SetTransientFreedomPositionTable ......................... 675
St7SetTransientFreedomTimeTable .............................. 679
St7SetTransientHeatFile ............................................... 673
St7SetTransientInitialConditionsNodalVelocity ............... 665
St7SetTransientInitialConditionsType ............................ 664
St7SetTransientInitialConditionsVectors ........................ 665
St7SetTransientLoadPositionTable................................ 674
St7SetTransientLoadTimeTable .................................... 678
St7SetTransientNodeHistoryCaseData .......................... 671
St7SetTransientTemperatureInputType ......................... 673
St7SetTrussData .......................................................... 464
St7SetTwoPointLink...................................................... 222
St7SetUCS ................................................................... 189
St7SetUCSName .......................................................... 190
St7SetUnits .................................................................. 207
St7SetUserBeamData ................................................... 470
St7SetUserBeamThermalData ...................................... 472
St7SetUserDefinedMultiPointLink .................................. 232
St7SetUseSolverDLL .................................................... 716
St7SetVertexColours .................................................... 111
St7SetVertexForce3...................................................... 383
St7SetVertexHeatSource1 ............................................ 389
St7SetVertexHeatSourceTables .................................... 389
St7SetVertexID ............................................................. 382
St7SetVertexKDamping3F ............................................ 388
St7SetVertexKRotation3F ............................................. 386
St7SetVertexKTranslation3F ......................................... 385
St7SetVertexLabelStyle ................................................ 111
St7SetVertexMeshSize1 ............................................... 382
St7SetVertexMoment3 .................................................. 384
St7SetVertexNSMass5ID .............................................. 388
St7SetVertexRestraint6 ................................................. 383
St7SetVertexRMass3 .................................................... 387
St7SetVertexShowHideSelected ................................... 110
St7SetVertexSize.......................................................... 110
St7SetVertexStyle......................................................... 110

St7SetVertexTemperature1 ........................................... 384
St7SetVertexTemperatureTable .................................... 385
St7SetVertexTemperatureType1 ................................... 385
St7SetVertexTMass1 .................................................... 386
St7SetVertexTMass3 .................................................... 387
St7SetVertexType ......................................................... 382
St7SetWindowBackgroundMode ..................................... 35
St7SetWindowColours .................................................... 35
St7SetWindowFreedomCase........................................... 58
St7SetWindowImageFile ................................................. 36
St7SetWindowImageLocation .......................................... 37
St7SetWindowImageSize ................................................ 38
St7SetWindowLoadCase................................................. 58
St7SetWindowResultCase .............................................. 58
St7SetWindowStatusBarRefreshMode ............................. 40
St7SetWindowUCSCase ................................................. 59
St7ShowEntity ................................................................ 47
St7ShowEntityAttributes .................................................. 49
St7ShowEntitySet ........................................................... 53
St7ShowGroup ............................................................... 53
St7ShowMarker ............................................................ 132
St7ShowModelWindow ................................................... 34
St7ShowPointAttributes ................................................... 48
St7ShowProperty ............................................................ 51
St7ShowWindowCaption ................................................. 42
St7ShowWindowCombos ................................................ 39
St7ShowWindowEntityPanel ........................................... 39
St7ShowWindowResultsToolbar ...................................... 43
St7ShowWindowSelectionToolbar ................................... 41
St7ShowWindowShowHideToolbar.................................. 43
St7ShowWindowStatusBar .............................................. 40
St7ShowWindowViewToolbar .......................................... 42
St7SliceOnPlane ........................................................... 880
St7SmoothPlates .......................................................... 918
St7SolidTetMesh........................................................... 871
St7SplitBeams .............................................................. 877
St7SplitFaceByPlane .................................................... 863
St7SplitFaceByVertices ................................................. 863
St7StopSolverProcess .................................................. 715
St7StoreResultUserEquation ......................................... 752
St7Subdivide ................................................................ 874
St7SubdivideBeams ...................................................... 878
St7SubdivideEdges ....................................................... 862
St7SurfaceMesh ........................................................... 870
St7TransformToUCS ..................................................... 931
St7TransformToXYZ ..................................................... 931
St7TrimMultiPointLinks .................................................. 920
St7UpdateElementPropertyData ...................................... 38
St7ValidateResultFile ...................................................... 23
St7VectorTransformToUCS ........................................... 931
St7VectorTransformToXYZ ........................................... 932
St7Version ...................................................................... 15
St7ZoomModel ............................................................... 46

Strand7 Function Index

Strand7 Finite Element Analysis

Suite 1, Level 5, 65 York Street
Sydney NSW 2000 Australia
Tel +61 2 9264 2977
info@strand7.com
www.strand7.com

www.strand7.com
