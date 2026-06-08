# St7ConvertElementResultNodeToGaussPoint

Converts element nodal results to Gauss point results via interpolation. It is important to specify the un-averaged
nodal quantities in order to capture the true element Gauss point values.

long St7ConvertElementResultNodeToGaussPoint(long Entity, long NumNodes,

long NumColumns, double* NodeDoubles, long* NumGauss, double* GaussDoubles)

Input Parameters
Entity

Either tyPLATE or tyBRICK.

NumNodes

Number of nodes in the element.

NumColumns

Number of result quantities contained in the NodeDoubles array.

NodeDoubles[0..NumNodes*NumColumns-1]

An array containing the nodal result quantities, arranged in NumNodes blocks of length NumColumns.
The start of the ith block, relating to the ith node in the element’s definition, is at
NodeDoubles[(i-1)*NumColumns].

Output Parameters
NumGauss

Number of result Gauss points for the element; a maximum of 9 for tyPLATE, or 27 for tyBRICK.

GaussDoubles[0..NumGauss*NumColumns-1]

An array containing the interpolated Gauss point result quantities, arranged in NumGauss blocks of
length NumColumns. The start of the ith block, relating to the ith Gauss point in the element’s definition,
is at GaussDoubles[(i-1)*NumColumns].

Strand7 API Manual

Type Definitions

Strand7 API functions all pass either base types (e.g. single byte booleans, four byte integers, eight byte floats,
etc.), or arrays of these base types. The base types are defined (at some level) by all programming languages. The
array types must be defined explicitly for languages such as Pascal. For other languages, a C-style pointer to the
array is sufficient, provided that the array is of the same base type and is at least as long as the Pascal types
indicated below. If the array allocates less space than these types, an access violation can occur in the Strand7 API
function call.

Note that by default, both C and Pascal array indices are zero-based – this convention is followed below, where
constants are defined to indicate array length. Frequently, the array size is defined by other constants.

Pascal Type

Array2Doubles

Array2Longint

Array3Doubles

Array3Longint

Array4Doubles

Array6Doubles

Array6Longint

Array10Doubles

Array12Doubles

Array60Doubles

AttributeDoublesArray

AttributeLogicalsArray

AttributeLongintArray

BeamDispArray

BeamGeometryArrayBGL

BeamReleasedArray

BeamReleaseDoublesArray

BeamResultArray

BeamSectionArray

BrickResultArray

CharString

ConnectionArray

EntityStateArray

EntityTotalsArray

FreedomCaseDefaultsArray

LoadCaseDefaultsArray

Base Type

Double

Longint

Double

Longint

Double

Double

Longint

Double

Double

Double

Double

Boolean

Longint

Double

Double

Boolean

Double

Double

Double

Double

Range

[0..1]

[0..1]

[0..2]

[0..2]

[0..3]

[0..5]

[0..5]

[0..9]

[0..11]

[0..59]

[0..kMaxAttributeDoubles-1]

[0..kMaxAttributeLogicals-1]

[0..kMaxAttributeLongint-1]

[0..kMaxDisp-1]

[0..kMaxBGLDimensions-1]

[0..kMaxBeamRelease-1]

[0..kMaxBeamRelease-1]

[0..kMaxBeamResult-1]

[0..kNumBeamSectionData-1]

[0..kMaxBrickResult-1]

AnsiChar

[0..kMaxStrLen]

Longint

Longint

Longint

Longint

Double

[0..kMaxElementNode]

[0..kMaxEntity-1]

[0..kMaxEntityTotals-1]

[0..5]

[0..12]

Type Definitions

MaterialArray

ModalResultsArray

NodeResultArray

NodeResultExArray

PlateResultArray

SeismicCaseDefaultsArray

UCSDoublesArray

UnitsArray

Double

Double

Double

Double

Double

Double

Double

[0..kNumMaterialData-1]

[0..15]

[0..5]

[0..13]

[0..kMaxPlateResult-1]

[0..9]

[0..kMaxUCSDoubles-1]

Longint

[0..kLastUnit-1]

Strand7 API Manual

Error Codes

The following lists the error codes that may be encountered when using the Strand7 API. The error codes are of
three varieties:

•  Non-solver error codes, prefixed by ERR7_ and interrogated by St7GetAPIErrorString.

•  These error codes are returned by general function calls.

•  Solver setup error codes generated during the solver initialisation phase, prefixed by SE_ and interrogated by
St7GetSolverErrorString.  These error codes are returned by calls to St7RunSolver or St7RunSolverProcess.

•  Solver termination error codes.  If the .dll version of the solver is in use these can be accessed after a solve has

terminated abnormally using St7GetGlobalIntegerValue with Index=ivSolverTerminationCode.

Non-solver error codes

Error Code

ERR7_AnimationDimensionsTooLarge

ERR7_AnimationDimensionsTooSmall

ERR7_AnimationHandleOutOfRange

ERR7_AnimationNotRunning

ERR7_APIAlreadyInitialised

Additional Information

Returned by functions that must be called before
St7Init. An example is the function St7SetIconSize.

ERR7_APINotInitialised

St7Init has not been called successfully.

ERR7_APIModuleNotLicensed

ERR7_AutoMesherModuleNotLicensed

ERR7_BeamIsNotBXS

ERR7_CannotCalculateBXSData

ERR7_CannotCombResFiles

ERR7_CannotCommunicate

ERR7_CannotEditSolverFiles

ERR7_CannotFindNetworkLock

ERR7_CannotFindStandaloneLock

ERR7_CannotInitialiseDirectX

ERR7_CannotMakeBXS

Returned when Strand7 is running in NETWORK mode
but cannot communicate with the NetHASP licence
manager.

The specified result file was created by the solver, and
cannot be edited.

Returned by St7Init when Strand7 is running in
NETWORK mode but cannot find the NETWORK
hardware lock.

Returned by St7Init when Strand7 is running in
STANDALONE mode but cannot find the STANDALONE
hardware lock.

Windowing function cannot initialise the DirectX
graphics engine.

Error Codes

ERR7_CannotMorphEdges

ERR7_CannotOpenResultFile

ERR7_CannotReadBXS

ERR7_CannotReadFile

ERR7_CannotReadImportFile

ERR7_CannotSaveFile

ERR7_CannotSaveImageFile

ERR7_CannotSaveIniFile

An I/O error occurred reading the file.

Could not save user configuration settings .ini file.

ERR7_CannotSetWindowParent

Cannot set the specified model window parent.

ERR7_CannotWriteExportFile

ERR7_CantDoWithModalWindows

ERR7_CantGenerateFillet

ERR7_CaseNameAlreadyExists

ERR7_CavityFluidNotConstBulk

ERR7_CavityFluidNotIdealGas

ERR7_CombinationDoesNotExist

ERR7_CommentDoesNotExist

ERR7_CompositesModuleNotLicensed

ERR7_ContourFileNotLoaded

ERR7_CouldNotCreateModelWindow

ERR7_CouldNotDestroyModelWindow

ERR7_CouldNotSaveAnimationFile

ERR7_CouldNotShowModelWindow

ERR7_CreepIDAlreadyExists

ERR7_DataNotFound

ERR7_DynamicsSolverModuleNotLicensed

ERR7_EquationDoesNotExist

ERR7_ErrorCreatingImage

ERR7_ExceededMaxNumColumns

ERR7_ExceededMaxNumCombEnvelopes

ERR7_ExceededMaxNumCombResFiles

Operation cannot be performed when modal dialogs
are open.

Case names must uniquely identify load and freedom
cases.

The requested output (e.g. attribute information)
does not exist.

Unable to create image, for example, due to
insufficient RAM.

The maximum number of results files for combination
is exceeded.

Strand7 API Manual

ERR7_ExceededMaxNumEnvelopeSets

ERR7_ExceededMaxNumFactorsEnvelopes

ERR7_ExceededMaxNumLimitEnvelopes

ERR7_ExceededMaxNumLoadPathTemplates

ERR7_ExceededMaxNumLoadPathVehicles

ERR7_ExceededMaxNumNodeHistory

ERR7_ExceededMaxNumPlies

ERR7_ExceededMaxNumRows

ERR7_ExceededMaxNumSpectralCases

ERR7_ExceededMaxNumStages

ERR7_ExceededResultCase

ERR7_ExceededTotal

ERR7_FileAlreadyOpen

ERR7_FileIsNewer

ERR7_FileIsProtected

ERR7_FileNotFound

ERR7_FileNotOpen

ERR7_FileNotSt7

ERR7_FilesStillOpen

ERR7_FreeEdgesFound

The result case input exceeds the total number of
result cases.

The entity number input exceeds the total number of
such entities.

The file that St7OpenFile has attempted to open was
created by a later version of Strand7 than the loaded
Strand7 API.

The Strand7 file identified by uID is not open.

ERR7_FunctionalityNotAvailable

ERR7_FunctionNotSupported

ERR7_GroupIdDoesNotExist

ERR7_IncompatibleCriterionCombination

ERR7_IncompatibleMaterialCombination

ERR7_IncompatibleResultFile

ERR7_IncompatibleSections

The requested function is not available in this
instance of the API.

The requested function has been retired in the loaded
version of the API, and has no effect on its arguments
or the state of the API (with the exception of re-
setting St7GetLastError).

The combination of elastic/plastic behaviour with this
stress criterion is unsupported.

The specified material is not supported by this plate
type.

The opened result file does not support the requested
result.

Error Codes

ERR7_IncompatibleTableType

The specified property does not set this table type.

ERR7_IncrementDoesNotExist

ERR7_InsituCalculationFailed

Returned by St7InsituStress.

ERR7_InsufficientFrames

ERR7_IntersectionNotFound

ERR7_InvalidAlphaTempType

ERR7_InvalidAnimationFile

ERR7_InvalidAnimationMode

ERR7_InvalidAnimationType

ERR7_InvalidAnsysArrayStatus

ERR7_InvalidAnsysEndReleaseOption

ERR7_InvalidAnsysExportFormat

ERR7_InvalidAnsysExportUnits

ERR7_InvalidAnsysImportFormat

ERR7_InvalidArcLength

ERR7_InvalidAttachConnectionType

ERR7_InvalidAttachmentDirection

ERR7_InvalidAttachmentType

ERR7_InvalidAttachPartsParams

ERR7_InvalidAttributeSetting

ERR7_InvalidAttributeType

ERR7_InvalidAveragingOption

ERR7_InvalidAxis

ERR7_InvalidAxisSystem

ERR7_InvalidBackgroundMode

ERR7_InvalidBaseExcitationType

ERR7_InvalidBeamAxisType

ERR7_InvalidBeamDir

ERR7_InvalidBeamEnd

ERR7_InvalidBeamExtrudeTarget

ERR7_InvalidBeamLoadType

ERR7_InvalidBeamPosition

ERR7_InvalidBeamSectionType

ERR7_InvalidBeamType

ERR7_InvalidBGLData

The position indicated on the beam is invalid.

Strand7 API Manual

ERR7_InvalidBrickFace

ERR7_InvalidBrickIntegrationPoints

ERR7_InvalidCementHardeningType

ERR7_InvalidCollectionID

ERR7_InvalidCombEnvelope

ERR7_InvalidCombEnvelopeAccType

ERR7_InvalidCombEnvelopeType

ERR7_InvalidCombinationCaseNumber

ERR7_InvalidCombResFile

ERR7_InvalidComponent

ERR7_InvalidConnectionType

ERR7_InvalidContactSubType

ERR7_InvalidContactType

ERR7_InvalidContactYieldType

ERR7_InvalidContourFileIndex

ERR7_InvalidContourIndex

ERR7_InvalidCoupleType

The number of Gauss points specified in a given
direction is invalid (maximum of 3).

The specified combination envelope is not valid.

The combination envelope accumulation type is not
valid.

The specified result file for combination is invalid.

The specified couple type for the coupling/multi-point
link is invalid.

ERR7_InvalidCreepFunctionType

The specified creep function/chain type is not valid.

ERR7_InvalidCreepHardeningLaw

ERR7_InvalidCreepID

ERR7_InvalidCreepLaw

ERR7_InvalidCreepShrinkageType

ERR7_InvalidCreepViscoChainRow

ERR7_InvalidCurvedPipesAsOption

ERR7_InvalidCutoffType

ERR7_InvalidDampingType

ERR7_InvalidDefaultsMode

ERR7_InvalidDetachMode

ERR7_InvalidDiagramAxis

ERR7_InvalidDigits

ERR7_InvalidDirection

ERR7_InvalidDirectionVector

ERR7_InvalidDisplayOptionsPath

The configuration file folder is not valid.

Error Codes

ERR7_InvalidDivisionParameters

ERR7_InvalidDivisions

ERR7_InvalidDivisionTargets

ERR7_InvalidDLLsPresent

SlvPanel.dll and/or St6List.dll are incompatible with
St7API.dll.

ERR7_InvalidDrawParameters

Invalid entity display parameters.

ERR7_InvalidDuplicateFaceType

ERR7_InvalidDXFBeamOption

ERR7_InvalidDXFPlateOption

ERR7_InvalidEdgeTolerance

ERR7_InvalidEntity

The specified entity type is invalid.

ERR7_InvalidEntityContourFileType

ERR7_InvalidEntityID

ERR7_InvalidEntityNodes

The number of nodes specified for the entity is
invalid.

ERR7_InvalidEntityNumber

The entity number is not in the correct range.

ERR7_InvalidEntitySet

ERR7_InvalidEnvelopeSet

ERR7_InvalidEnvelopeSetType

ERR7_InvalidErrorCode

ERR7_InvalidExponentFormat

ERR7_InvalidExportParameters

ERR7_InvalidFaceFromBeamPolygonParameters

ERR7_InvalidFaceSurface

ERR7_InvalidFactorsEnvelope

ERR7_InvalidFactorsEnvelopeType

ERR7_InvalidFileName

ERR7_InvalidFilePath

ERR7_InvalidFileUnit

ERR7_InvalidFontName

ERR7_InvalidFreedomCase

ERR7_InvalidFreedomCaseType

ERR7_InvalidFrequencyType

ERR7_InvalidGeometryAsOption

An invalid error code was passed to
St7GetAPIErrorString or St7GetSolverErrorString.

The Strand7 file uID is invalid. The valid range is 1 to
32 inclusive.

Strand7 API Manual

ERR7_InvalidGeometryCavityLoop

ERR7_InvalidGeometryEdgeType

ERR7_InvalidGeometryFormatProtocol

ERR7_InvalidGradeRatio

ERR7_InvalidGradeType

ERR7_InvalidGravityDirection

ERR7_InvalidHardeningType

ERR7_InvalidHarmonicLoadType

ERR7_InvalidHRAMode

ERR7_InvalidImageDimensions

ERR7_InvalidImageType

ERR7_InvalidImportExportMode

ERR7_InvalidIndex

ERR7_InvalidInfluenceFile

ERR7_InvalidInitialCaseNumber

The result case number is not valid for this result file.

ERR7_InvalidInitialConditionsType

ERR7_InvalidInitialFile

The specified result file for initial conditions is invalid.

ERR7_InvalidInsituRunMode

Returned by St7InsituStress.

ERR7_InvalidIterationNumber

ERR7_InvalidK0Expression

ERR7_InvalidK1Expression

ERR7_InvalidLaminateID

ERR7_InvalidLayoutID

ERR7_InvalidLength

ERR7_InvalidLibraryID

ERR7_InvalidLibraryItemID

ERR7_InvalidLibraryItemName

ERR7_InvalidLibraryName

ERR7_InvalidLibraryPath

ERR7_InvalidLibraryType

ERR7_InvalidLimitEnvelope

ERR7_InvalidLimitEnvelopeType

ERR7_InvalidLineDefinition

ERR7_InvalidLineID

ERR7_InvalidLinePoints

Error Codes

ERR7_InvalidLinkData

ERR7_InvalidLinkTarget

ERR7_InvalidLinkType

ERR7_InvalidLoadCase

ERR7_InvalidLoadCaseFilePath

The ANSYS load case file folder is not valid.

ERR7_InvalidLoadCaseType

ERR7_InvalidLoadID

ERR7_InvalidLoadPath

ERR7_InvalidLoadPathID

ERR7_InvalidLoadPathLane

ERR7_InvalidLoadPathLaneFactorType

ERR7_InvalidLoadPathShape

ERR7_InvalidLoadPathSurface

ERR7_InvalidLoadPathTemplateID

ERR7_InvalidLoadPathVehicle

ERR7_InvalidLoadPathVehicleInstance

ERR7_InvalidLTAMethod

The specified linear transient solver method is invalid.

ERR7_InvalidLTASolutionType

ERR7_InvalidMarkerLineThickness

ERR7_InvalidMarkerSize

ERR7_InvalidMarkerStyle

ERR7_InvalidMarkerType

ERR7_InvalidMaterialType

ERR7_InvalidMatrixType

ERR7_InvalidMeshPositionOnUCS

ERR7_InvalidMirrorOption

ERR7_InvalidMobilityType

ERR7_InvalidModalFile

ERR7_InvalidModalLoadType

ERR7_InvalidModalNodeReactType

ERR7_InvalidModeNumber

ERR7_InvalidModType

ERR7_InvalidMultiPointLink

ERR7_InvalidMultiPointType

ERR7_InvalidMultiVariableCaseID

The specified modal results file is invalid.

The specified time-dependent modulus type is invalid.

Strand7 API Manual

ERR7_InvalidMultiVariableType

ERR7_InvalidName

The specified name is not valid.

ERR7_InvalidNodeCoordinateKeepType

ERR7_InvalidNodeExtrudeTarget

ERR7_InvalidNumBeamStations

ERR7_InvalidNumberOfEntries

The specified number of table entries is invalid.

The number of plate integration layers is invalid (less
than 1 or greater than 100).

One or more parameters passed to the function are
invalid.

The specified load patch type is invalid.

The specified plate does not support this load patch
type.

ERR7_InvalidNumCopies

ERR7_InvalidNumCutFaces

ERR7_InvalidNumericStyle

ERR7_InvalidNumLayers

ERR7_InvalidNumMeshingLoops

ERR7_InvalidNumModes

ERR7_InvalidNumPathDivs

ERR7_InvalidNumRepeats

ERR7_InvalidNumSteps

ERR7_InvalidOption

ERR7_InvalidOriginMethod

ERR7_InvalidP1P2

ERR7_InvalidP1P2P3

ERR7_InvalidP1P2P3P4

ERR7_InvalidParameters

ERR7_InvalidPasteOption

ERR7_InvalidPatchType

ERR7_InvalidPatchTypeForPlate

ERR7_InvalidPathDefinition

ERR7_InvalidPlane

ERR7_InvalidPlaneID

ERR7_InvalidPlanePoints

ERR7_InvalidPlateEdge

ERR7_InvalidPlateSurface

ERR7_InvalidPlateType

ERR7_InvalidPLTarget

Error Codes

ERR7_InvalidPositionTableAxis

The specified axis for use with a Factor vs Position
table is invalid.

The projection type relating to the application of
global pressure attributes is invalid. It should be one
of ppNone, ppProjResultant or ppProjComponents.

The system settings under Region and Language are
invalid.

ERR7_InvalidPositionType

ERR7_InvalidPreLoadType

ERR7_InvalidProcessingMode

ERR7_InvalidProjectFlag

ERR7_InvalidProjectionDirection

ERR7_InvalidPropertyNumber

ERR7_InvalidPseudoTime

ERR7_InvalidQuadraticAsOption

ERR7_InvalidR1R2

ERR7_InvalidR2

ERR7_InvalidRadius

ERR7_InvalidRayleighMode

ERR7_InvalidRCLayers

ERR7_InvalidReferenceNode

ERR7_InvalidRegionalSettings

ERR7_InvalidResOptsBaseMode

ERR7_InvalidResOptsNFADisp

ERR7_InvalidResOptsReactionLinkGNL

ERR7_InvalidResOptsRotationUnit

ERR7_InvalidResOptsStrainUnit

ERR7_InvalidResponseType

ERR7_InvalidResponseVariable

ERR7_InvalidResultCase

ERR7_InvalidResultFile

ERR7_InvalidResultQuantity

ERR7_InvalidResultsSign

The specified results sign for spectral results is invalid.

ERR7_InvalidResultSubQuantity

ERR7_InvalidResultType

ERR7_InvalidRigidPlane

ERR7_InvalidRubberModel

The specified plane of action for the rigid link is
invalid.

The specified position does not lie on the beam cross
section.

The solver storage scheme is not valid.

The specified solver is either unknown or not valid.

Strand7 API Manual

ERR7_InvalidScaleAbout

ERR7_InvalidScratchPath

ERR7_InvalidSectionParameters

ERR7_InvalidSectionPosition

ERR7_InvalidSectionProperties

ERR7_InvalidSegmentsPerCircle

ERR7_InvalidSeismicCase

ERR7_InvalidSelectionEndEdgeFace

ERR7_InvalidSolverMode

ERR7_InvalidSolverParameter

ERR7_InvalidSolverPath

ERR7_InvalidSolverScheme

ERR7_InvalidSolverType

ERR7_InvalidSortMethod

ERR7_InvalidSortOption

ERR7_InvalidSourceAction

ERR7_InvalidSpectralCase

ERR7_InvalidSpectrumType

ERR7_InvalidSplitData

ERR7_InvalidSplitRatio

ERR7_InvalidSt7ExportFormat

ERR7_InvalidStaadCountryCodeOption

ERR7_InvalidStaadForceUnit

ERR7_InvalidStaadLengthUnit

ERR7_InvalidStartEndTimes

ERR7_InvalidSTLBeamOption

ERR7_InvalidSTLFileFormat

ERR7_InvalidSTLGroupingOption

ERR7_InvalidSTLPlateOption

ERR7_InvalidStringID

The specified string group ID is invalid.

ERR7_InvalidSurfaceMeshTargetType

ERR7_InvalidTableID

ERR7_InvalidTableName

ERR7_InvalidTableRow

Error Codes

ERR7_InvalidTableSetting

ERR7_InvalidTableType

ERR7_InvalidTaperAxis

ERR7_InvalidTaperRatio

ERR7_InvalidTaperType

ERR7_InvalidTempDependenceType

The setting for property temperature dependence is
invalid.

ERR7_InvalidTemperatureType

ERR7_InvalidTimeRow

ERR7_InvalidTimeUnit

ERR7_InvalidTolerance

ERR7_InvalidToleranceType

ERR7_InvalidToolOptsCopyOptions

ERR7_InvalidToolOptsSubdivideOptions

ERR7_InvalidToolOptsZipOptions

ERR7_InvalidTransientTempType

The transient temperature specification is invalid.

ERR7_InvalidTrigType

ERR7_InvalidUCSID

ERR7_InvalidUCSIndex

ERR7_InvalidUCSType

ERR7_InvalidUnits

ERR7_InvalidUserEquation

ERR7_InvalidUVPos

ERR7_InvalidVectorComponents

ERR7_InvalidVertexMeshSize

ERR7_InvalidVertexType

ERR7_InvalidWindowDimensions

ERR7_InvalidWindowMode

ERR7_LaminateIDAlreadyExists

ERR7_LaminateNameAlreadyExists

Laminate names must be unique.

ERR7_LayoutIDAlreadyExists

ERR7_LinkNotAttachment

ERR7_LinkNotCoupling

ERR7_LinkNotMasterSlave

ERR7_LinkNotMultiPoint

Strand7 API Manual

ERR7_LinkNotPinned

ERR7_LinkNotRigid

ERR7_LinkNotSectorSymmetry

ERR7_LinkNotShrink

ERR7_LinkNotTwoPoint

ERR7_LoadPathIDAlreadyExists

ERR7_LoadPathTemplateIDAlreadyExists

ERR7_LoginExceeded

ERR7_MarkerNotFound

ERR7_MaterialIsUserDefined

ERR7_MaterialNotAnisotropic

ERR7_MaterialNotFluid

ERR7_MaterialNotIsotropic

ERR7_MaterialNotLaminate

ERR7_MaterialNotOrthotropic

ERR7_MaterialNotRubber

ERR7_MaterialNotSoil

ERR7_MaterialNotUserDefined

ERR7_MeshingErrors

ERR7_ModelMixesAxiNonAxi

ERR7_ModelWindowWasNotCreated

ERR7_ModelWindowWasNotShowing

ERR7_MovingLoadModuleNotLicensed

Returned by St7Init when the maximum number of
licences are in use.

Data is set/get that is irrelevant for the user-defined
beam type.

The automesher has generated an error.

The function requires a model window be opened by
St7CreateModelWindow.

ERR7_NoActiveResponseVariables

Returned by St7GenerateInfluenceCases.

ERR7_NodeHistoryDoesNotExist

ERR7_NoElementsOnLoadPaths

Returned by St7GenerateInfluenceCases.

ERR7_NoError

No error occurred in the API call. ERR7_NoError = 0.

ERR7_NoInfluenceCombinationsDefined

Returned by St7GenerateInfluenceCases.

ERR7_NoLoadPathsFound

Returned by St7GenerateInfluenceCases.

ERR7_NoMultiVariableInfluenceCases

ERR7_NonlinearSolverModuleNotLicensed

ERR7_NoPlateElements

The model contains no plate elements, which are
necessary to define a BXS.

Error Codes

ERR7_NoResponsesFound

Returned by St7GenerateInfluenceCases.

ERR7_NoSoilElementsFound

Returned by St7InsituStress.

ERR7_NotFrequencyTable

ERR7_NothingSelected

ERR7_OnlyOneFreedomCase

ERR7_OnlyOneLoadCase

ERR7_OperationFailed

A model must contain at least one freedom case, it
cannot be deleted.

A model must contain at least one load case, it cannot
be deleted.

ERR7_OperationUserTerminated

Returned by St7InsituStress.

ERR7_PlateDoesNotHaveLayers

ERR7_PlateDoesNotHaveThickness

ERR7_PlyDoesNotExist

ERR7_PropertyAlreadyExists

ERR7_PropertyNotBeam

ERR7_PropertyNotCable

ERR7_PropertyNotConnectionBeam

ERR7_PropertyNotCutOffBar

ERR7_PropertyNotPipe

ERR7_PropertyNotPointContact

ERR7_PropertyNotSpring

ERR7_PropertyNotTruss

ERR7_PropertyNotUserDefinedBeam

ERR7_PseudoTimeNotDefined

ERR7_RayleighNotApplicable

ERR7_RCModuleNotLicensed

ERR7_ReducedAnimation

ERR7_ResFileAlreadyOpen

ERR7_ResFileAssociationNotAllowed

The plate property does not require integration
layers.

The specified beam property type is not a flexural
beam.

Insufficient memory for complete animation.

Custom result file is already open.

Load and freedom case association is not supported
by this custom result file type.

ERR7_ResFileCantClearQuantity

Cannot clear the custom result quantity.

ERR7_ResFileCantSave

Cannot save the custom result file.

ERR7_ResFileContainsNoElements

The custom result file contains no elements.

ERR7_ResFileContainsNoNodes

The custom result file contains no nodes.

Strand7 API Manual

ERR7_ResFileDoesNotHaveEntity

ERR7_ResFileIncompatibleQuantity

No such entity on which to define the specified
custom result exists.

The specified quantity is not compatible with the
custom result file.

ERR7_ResFileInvalidCase

The case number is invalid for the custom result file.

ERR7_ResFileInvalidNumCases

ERR7_ResFileInvalidQuantity

ERR7_ResFileNotOpen

Custom result file is not open.

ERR7_ResFileQuantityNotExist

ERR7_ResFileUnsupportedType

Custom result file type is unsupported.

Result files must be closed with St7CloseResultFile for
legitimate usage.

A result file must be opened with St7OpenResultFile
for legitimate usage.

The requested result was not calculated or stored in
the open result file.

The specified soil type of the property is not Cam-
Clay.

The specified soil type of the property is not Duncan-
Chang.

The specified property type does not use a Drucker-
Prager soil material model.

The specified property does not use a linear elastic
soil material model.

The specified property does not use a Mohr-Coulomb
soil material model.

ERR7_ResultCaseNotInertiaRelief

ERR7_ResultFileIsOpen

ERR7_ResultFileNotOpen

ERR7_ResultIsNotAvailable

ERR7_ResultQuantityNotAvailable

ERR7_SectionCannotBeMirrored

ERR7_SectionNotBGL

ERR7_SoilTypeNotCC

ERR7_SoilTypeNotDC

ERR7_SoilTypeNotDP

ERR7_SoilTypeNotLS

ERR7_SoilTypeNotMC

ERR7_SolverStillRunning

ERR7_SparseSolverModuleNotLicensed

ERR7_StageDoesNotExist

ERR7_TableDoesNotExist

ERR7_TableNameAlreadyExists

ERR7_TableTypeIsNotTimeBased

ERR7_TJunctionsFound

ERR7_TooManyAnimations

Error Codes

ERR7_TooManyBeamStations

ERR7_UCSIDAlreadyExists

ERR7_UCSMustBeDifferent

ERR7_UnexpectedSolverTermination

ERR7_UnknownError

ERR7_UnknownFileType

ERR7_UnknownProperty

ERR7_UnknownResultLocation

The solve was not able to run to expected
completion. If the .dll solver is in use (that is,
St7SetUseSolverDLL has been called with
UseDLL=True), St7GetGlobalIntegerValue can be used
with ivSolverTerminationCode to access the specific
solver error code.

The input argument indicating position or location on
the element is not recognised.

ERR7_UnknownResultType

The input argument ResultType is not recognised.

ERR7_UnknownSolverProcess

ERR7_UnknownSubType

The input argument ResultSubType is not recognised.

ERR7_UnknownSurfaceLocation

ERR7_UnknownTitle

ERR7_YieldNotMCDP

Solver error codes

Error Code

The input argument Surface, for plates, is not
recognised.

The input argument TitleType is not recognised.

The yield criterion is not Mohr Coulomb or Drucker
Prager.

Additional Information

SE_ActiveStageHasNoIncrements

At least one load increment must be defined for every active stage.

SE_AttachmentsInWrongGroup

One or more attachment links are active in stages where their
targets are inactive.

SE_BadTaperData

SE_BeamPoissonOutOfRange

SE_BeamPropertiesMayHaveChanged

SE_BeamRequiresPoisson

SE_CableRequiresGNL

SE_CableRequiresNonlinearSolver

SE_CannotAppendToFile

SE_CannotConvertAttachmentLink

Attachment link is not valid as it generates a singular matrix.

SE_CannotConvertInterpMultiPoint

Multi-point link generated a singular matrix.

Strand7 API Manual

SE_CannotFindSolver

SE_CannotOverwriteFile

SE_CannotReadRestartFile

SE_CannotReadWriteScratchPath

SE_CannotWriteToLogFile

SE_CannotWriteToResultFile

SE_CompositesModuleNotLicensed

SE_ConcreteCreepMNL

SE_CQCRequiresDamping

SE_CreepTimeTooShort

SE_DuplicateLinks

SE_ElementUsesInvalidProperty

SE_HarmonicFactorsAllZero

SE_HaveLinearCables

SE_InactiveCavityControlCase

SE_IncompatibleRestartFile

SE_IncompatibleRestartUnits

SE_InitialConditionsNotValid

SE_InitialSolutionFileIsBad

SE_InsufficientRestartFileSteps

SE_InvalidBrickCohesionValue

SE_InvalidBrickShrinkageDefinition

SE_InvalidCavityFluidDefinition

SE_InvalidDirectionVector

SE_InvalidElement

SE_InvalidElements

SE_InvalidFrequencyRange

SE_InvalidGravityCase

SE_InvalidInitialFile

SE_InvalidInitialTemperatureFile

SE_InvalidLaminateID

SE_InvalidLink

The scratch path does not have sufficient read/write access to allow
the solver to run.

Concrete creep and material stress-strain tables cannot be
considered together.

The restart file contains fewer result cases than the requested
restart case.

The load case selected as the soil/fluid gravity case is not valid.

Error Codes

SE_InvalidMaterialNonlinearString

For material nonlinearity, all elements in a string group must use the
same property set.

SE_InvalidPlateCohesionValue

SE_InvalidPlateShrinkageDefinition

SE_InvalidPlateVariableRequested

Plate(s) have one or more invalid response variables assigned.

SE_InvalidPreTensionOnString

A string group with variable pre-tension was found.

SE_InvalidRayleighFactors

SE_InvalidRestartFile

SE_InvalidSolverResultFile

SE_InvalidStringGroupDefinition

SE_InvalidTimeStep

SE_InvalidUserBrickCreepDefinition

SE_InvalidUserPlateCreepDefinition

SE_LinksHaveNoFreedomCase

SE_LoadIncrementsNotDefined

SE_MissingInsituStress

SE_ModelMixesAxiNonAxi

SE_MoreLoadIncrementsNeeded

SE_MovingLoadModuleNotLicensed

SE_NeedElementNodeForce

SE_NeedNodeTempNTASolver

SE_NeedNonlinearHeatSolver

SE_NeedTemperatureDependence

SE_NeedTemperatureTables

SE_NoBeamProperties

SE_NoBrickProperties

The model mixes axisymmetric elements with non-axisymmetric
elements.

Table Type nodal temperatures are not supported by the linear
transient dynamic solver.

The model contains temperature dependent creep data, but
temperature dependence has not been set.

The model contains temperature dependent material properties,
which are ignored by the current solver settings.

SE_NoFreedomCaseInIncrements

No freedom case is set in the load increments tables.

SE_NoFreedomCaseSelected

SE_NoLoadCaseSelected

SE_NoLoadTablesDefined

SE_NoModesIncluded

SE_NoMovingLoadPathsInCases

No load paths were found in the selected load cases.

Strand7 API Manual

SE_NonlinearSolverRequired

SE_NoNodes

SE_NoPlateProperties

SE_NoResponseVariablesDefined

SE_NoSpectralResultsSelected

SE_NoTimeStepsSaved

SE_NoVelocityDataInInitialFile

SE_RubberRequiresGNL

SE_ShearPanelMustBeQuad4

SE_SingleShotRestartFile

The restart file contains only the last saved result case.

The Skyline scheme usually works best with the Tree and Geometry
node orderings.

The file used in the initial staged analysis cannot be found or is
invalid.

Stage definitions in the initial file are not compatible with the
current stage definitions in the model.

The string elements defined in the model are not compatible with
those in the restart file.

SE_SingularBrickMatrix

SE_SingularPlateMatrix

SE_SkylineUsesBadSort

SE_SoilRequiresMNL
SE_SpectralBaseExcitationsAllZero
SE_SpectralCasesNotDefined
SE_SpectralExcitationsAllZero

SE_SpectralLoadExcitationsAllZero

SE_StagedSolutionFileNotFound

SE_StagingHasChanged

SE_StringOrderHasChanged

SE_TableNotFound

SE_TemperatureDependenceCaseNotSet

SE_TensileInsituBrickStress

SE_TensileInsituPlateStress

SE_UnknownException

SE_ZeroLengthRigidLinkGenerated

Solver termination error codes

If the .dll solver is used (that is, St7SetUseSolverDLL has been called with UseDLL=True) and the solver terminates
unexpectedly, St7GetGlobalIntegerValue with Index=ivSolverTerminationCode can be used to access an error
code.  Possible error codes related to the finite element problem are listed in the help topic Solver Messages:

Error Codes

Error Messages.  For example, a solver termination code of 4 corresponds to “*ERROR[  4]:Global
stiffness matrix is singular”, which also appears in the solver log file.

The following additional termination codes can also be returned.  These are related to the platform on which
Strand7 is running or other causes unrelated to the specific finite element problem.

Error Code

Additional Information

ST_Abnormal  The solver terminated due to an unknown error.

ST_CreateLog  The log file cannot be created for a new analysis.

ST_Internal  The solver terminated due to an internal error – please forward the model and solver log file

to support@strand7.com for assistance if this is encountered.

ST_MemError  A request for memory allocation has failed – this usually means that although the requested

amount of memory is available, a contiguous block of the requested size is not.

ST_NoDisk

Insufficient disk space is available to run or continue running the analysis.  Under normal
conditions this error will not occur because a lack of disk space produces an alert message to
the user, to enable the clearing of additional space to continue the analysis.

ST_NoError

The solver completed without error.

ST_NoLicence  The solver terminated due to loss of licence.

ST_NoRam

Insufficient memory is available to run or continue running the analysis.

ST_OpenLog

The log file cannot be opened for an analysis that is appending to existing results.

ST_Scratch

The solver reads and writes a number of temporary (scratch) files during the execution, until
the end of the analysis when the model result file (e.g. .LSA for linear static analysis) is
generated and all the scratch files are automatically deleted.  If one of the scratch files is
inaccessible at the start or becomes inaccessible part way through an analysis, this error will
be generated.  Under normal conditions, this should never happen because all scratch files
required for an analysis are locked as soon as the solver starts and remain locked until solver
completion.  However, this error could occur when launching the batch solver – the scratch
files for the batch solver are usually prepared well before the solver is launched, and
therefore there is no guarantee that they will all still exist, intact, at the time the batch solver
runs.

ST_UserStop  The solve was stopped by the user.

ST_WriteLog  Cannot write to the log file – usually this is because the log file size has reached a limit for a

text file on the system (typically 2 GB).

Strand7 API Manual

Coordinate System Conventions

All coordinate systems in Strand7 define a right-hand set of locally orthogonal axes, i1, i2 and i3, with reference to
the global XYZ system.

•  The translational degrees of freedom in these directions are generically termed the 123 degrees of freedom

(DoF) and are always listed in the same order.

•  Rotational degrees of freedom are defined by the right-hand rule about the i1, i2 and i3 axes. These degrees of
freedom are listed in this order after the 123 components – collectively they are referred to as the 123456
DoF.

When a Coordinate System ID is passed by the Strand7 API, the global XYZ system is always identified as ID = 1.
Subsequent indices ID > 1 then identify User Coordinate Systems (UCS) that have been defined. Note that the ID
numbers need not be contiguous and may be retrieved by their index using St7GetUCSID.

UCS Types

Strand7 supports four UCS (User Coordinate System) types: Cartesian, cylindrical, spherical and toroidal. The
integer values and types (as defined in the include and header files) are shown below.

Cartesian coordinate system

csCartesian

Coordinate System Conventions

Cylindrical coordinate system

csCylindrical

Spherical coordinate system

csSpherical

Toroidal coordinate system

csToroidal

Z

R

T

R

P

T

T

R

P

Strand7 API Manual

UCS Doubles Array

The UCSDoublesArray vector contains the definition of the UCS, including the origin point, and two points defining
a plane. In the case of a toroidal system, an additional value defines the major radius of the torus. The following
includes the positional information for the UCSDoublesArray vector.

[0..2]

Origin point in global XYZ coordinates.

[3..5]

First plane point in global XYZ coordinates.

[6..8]

Second plane point in global XYZ coordinates.

[9]

Toroidal radius.

Element Connections

Element Connections

The ConnectionArray vector is used to determine the nodal connections of an element. It is used for all
element types ranging from Beam2 to Brick20 elements.

The first position in the ConnectionArray vector, ConnectionArray[0], holds the number of nodes in the
element. Positions thereafter hold the ordered nodal connections. For a Beam2 element,
ConnectionArray[0..2] is filled, with ConnectionArray[0] = 2, ConnectionArray[1] = Node1 and
ConnectionArray[2] = Node2 respectively. A Brick20 element will use the entire vector in a similar fashion.

Refer to Beam Local Coordinates, Plate Local Coordinates and Brick Local Coordinates for element node
connection sequences for all element types.

Beam Local Coordinates

Each beam element in Strand7 possesses a node numbering scheme that defines the default orientation of the
principal coordinate system of the beam, denoted 1-2-3. The principal coordinate system is a right-handed
coordinate system defined by the beam properties such that over the cross section S in the 1-2 plane

.

Note that this is generally a rotation away from the native x-y directions in which the beam cross section is
defined. The x-y directions (with a z-direction completing the right-hand coordinate system) define the local beam
axis system.

The default orientation for Beam2 elements is defined by:

•

•

•

i3 – is the unit vector directed from Node 1 to Node 2.

i2 – is the unit vector arising from i2 = Z × i3 where Z is the unit vector in the global Z-direction

i1 – completes the right handed system such that i1 × i2 = i3

The default orientation for Beam3 elements is defined by:

•

•

i3 – is the unit vector directed from Node 1 to Node 2.

i2 – is the unit vector perpendicular to i3, lying in the plane defined by Nodes 1, 2 and 3, directed towards
Node 3.

•

i1 – completes the right handed system such that i1 × i2 = i3

The principal axes (hence the beam itself) may be rotated about the 3-axis from the default orientation using
St7SetBeamReferenceAngle1.

The principal axes can be interrogated using St7GetBeamAxisSystemInitial, St7GetBeamAxisSystemBirth and
St7GetBeamAxisSystemGNL.

Beam End Numbering

Attributes may also be applied to a particular end of a beam element. End 1 is defined as the end occurring at
Node 1, and End 2 is defined as the end occurring at Node 2. Where l is the distance in the 3-direction from Node
1 along the beam, and L is the length of the beam, the relative length position is defined as l/L.

02112==dAxxIS
Strand7 API Manual

Plate Local Coordinates

Intrinsic Coordinate System

Each plate element in Strand7 possesses a node and edge numbering scheme, and a set of intrinsic coordinates uv
that parameterise its extent in the global XYZ system. The intrinsic coordinates are defined by the node
numbering scheme, summarised in the table below. They may be queried using St7GetPlateUV.

Element Type

Nodal Intrinsic Coordinates

Edges

Node 1: (0, 0)
Node 2: (1, 0)

Node 3: (0, 1)

Edge 1: 1-2
Edge 2: 2-3

Edge 3: 3-1

Tri3

Quad4

Tri6

Quad8

Edge 1: 1-2
Edge 2: 2-3

Edge 3: 3-4
Edge 4: 4-1

Edge 1: 1-4-2
Edge 2: 2-5-3
Edge 3: 3-6-1

Edge 1: 1-5-2
Edge 2: 2-6-3

Edge 3: 3-7-4
Edge 4: 4-8-1

Node 1: (-1, -1)
Node 2: (1, -1)

Node 3: (1, 1)
Node 4: (-1, 1)

Node 1: (0, 0)
Node 2: (1, 0)
Node 3: (0, 1)

Node 4: (0.5, 0)
Node 5: (0.5, 0.5)

Node 6: (0, 0.5)

Node 1: (-1, -1)
Node 2: (1, -1)

Node 3: (1, 1)
Node 4: (-1, 1)

Node 5: (0, -1)
Node 6: (1, 0)

Node 7: (0, 1)
Node 8: (-1, 0)

Element Connections

Quad9

Local Axis System

Edge 1: 1-5-2
Edge 2: 2-6-3
Edge 3: 3-7-4

Edge 4: 4-8-1

Node 1: (-1, -1)
Node 2: (1, -1)
Node 3: (1, 1)

Node 4: (-1, 1)
Node 5: (0, -1)

Node 6: (1, 0)
Node 7: (0, 1)

Node 8: (-1, 0)
Node 9: (0, 0)

The intrinsic coordinate system is generally curvilinear and non-orthogonal. An orthogonal local axis system is also
defined for plates for the purpose of applying directional attributes and material properties.

The local axis system is a right-handed coordinate system defined such that the x-y plane lies in the median plane
of the plate. The median plane of the plate is that plane that minimises the sum of squared perpendicular
distances to it (calculated by a principal components analysis).

By default the local axis system is aligned relative to the plate nodes such that for triangular elements:

x

x

y

and for quadrilateral elements:

y

y

y

x

x

The local x-y axes may be rotated about the local z axis using St7SetPlateXAngle1. The local z axis is invariant, and
completes the right-hand coordinate system.

Strand7 API Manual

The axis system for a plate element can be interrogated using St7GetPlateAxisSystemInitial,
St7GetPlateAxisSystemBirth and St7GetPlateAxisSystemGNL.

Brick Local Coordinates

Intrinsic Coordinate System

Each brick element in Strand7 possesses a node and face numbering scheme, and a set of intrinsic coordinates
uvw that parameterise its extent in the global XYZ system. The intrinsic coordinates are defined by the node
numbering scheme, summarised in the table below. They may be queried using St7GetBrickUVW.

Element Type

Nodal Intrinsic Coordinates

Faces

Node 1: (0, 0, 0)
Node 2: (1, 0, 0)

Node 3: (0, 1, 0)
Node 4: (0, 0, 1)

Node 1: (-1, -1, 0)
Node 2: (1, -1, 0)

Node 3: (1, 1, 0)
Node 4: (-1, 1, 0)
Node 5: (0, 0, 1)

Node 1: (0, 0, -1)
Node 2: (1, 0, -1)

Node 3: (0, 1, -1)
Node 4: (0, 0, 1)

Node 5: (1, 0, 1)
Node 6: (0, 1, 1)

Node 1: (-1, -1, -1)
Node 2: (1, -1, -1)
Node 3: (1, 1, -1)
Node 4: (-1, 1, -1)

Node 5: (-1, -1, 1)
Node 6: (1, -1, 1)
Node 7: (1, 1, 1)
Node 8: (-1, 1, 1)

Face 1: 1-2-3
Face 2: 4-1-3

Face 3: 4-2-1
Face 4: 4-3-2

Face 1: 1-2-3-4
Face 2: 5-1-4

Face 3: 5-2-1
Face 4: 5-3-2
Face 5: 5-4-3

Face 1: 1-2-3
Face 2: 5-2-1-4

Face 3: 4-6-5
Face 4: 4-1-3-6

Face 5: 6-3-2-5

Face 1: 1-2-3-4
Face 2: 7-3-2-6
Face 3: 6-5-8-7
Face 4: 5-1-4-8

Face 5: 8-4-3-7
Face 6: 6-2-1-5

Tet4

Pyra5

Wedge6

Hex8

Element Connections

Tet10

Pyra13

Wedge15

Face 1: 1-5-2-6-3-7
Face 2: 4-8-1-7-3-10
Face 3: 4-9-2-5-1-8

Face 4: 4-10-3-6-2-9

Face 1: 1-6-2-7-3-8-4-9
Face 2: 5-10-1-9-4-13
Face 3: 5-11-2-6-1-10

Face 4: 5-12-3-7-2-11
Face 5: 5-13-4-8-3-12

Face 1: 1-7-2-8-3-9
Face 2: 5-11-2-7-1-10-4-13

Face 3: 4-15-6-14-5-13
Face 4: 4-10-1-9-3-12-6-15

Face 5: 6-12-3-8-2-11-5-14

Node 1: (0, 0, 0)
Node 2: (1, 0, 0)
Node 3: (0, 1, 0)

Node 4: (0, 0, 1)
Node 5: (0.5, 0, 0)

Node 6: (0.5, 0.5, 0)
Node 7: (0, 0.5, 0)

Node 8: (0, 0, 0.5)
Node 9: (0.5, 0, 0.5)
Node 10: (0, 0.5, 0.5)

Node 1: (-1, -1, 0)
Node 2: (1, -1, 0)
Node 3: (1, 1, 0)

Node 4: (-1, 1, 0)
Node 5: (0, 0, 1)

Node 6: (0, -1, 0)
Node 7: (1, 0, 0)

Node 8: (0, 1, 0)
Node 9: (-1, 0, 0)
Node 10: (-0.5, -0.5, 0.5)

Node 11: (0.5, -0.5, 0.5)
Node 12: (0.5, 0.5, 0.5)

Node 13: (-0.5, 0.5, 0.5)

Node 1: (0, 0, -1)
Node 2: (1, 0, -1)

Node 3: (0, 1, -1)
Node 4: (0, 0, 1)

Node 5: (1, 0, 1)
Node 6: (0, 1, 1)

Node 7: (0.5, 0, -1)
Node 8: (0.5, 0.5, -1)
Node 9: (0, 0.5, -1)

Node 10: (0, 0, 0)
Node 11: (1, 0, 0)

Node 12: (0, 1, 0)
Node 13: (0.5, 0, 1)

Node 14: (0.5, 0.5, 1)
Node 15: (0, 0.5, 1)

Strand7 API Manual

Hex16

Hex20

Face 1: 1-9-2-10-3-11-4-12
Face 2: 7-3-10-2-6-14
Face 3: 6-13-5-16-8-15-7-14

Face 4: 5-1-12-4-8-16
Face 5: 8-4-11-3-7-15

Face 6: 6-2-9-1-5-13

Face 1: 1-9-2-10-3-11-4-12
Face 2: 7-15-3-10-2-14-6-18
Face 3: 6-17-5-20-8-19-7-18
Face 4: 5-13-1-12-4-16-8-20

Face 5: 8-16-4-11-3-15-7-19
Face 6: 6-14-2-9-1-13-5-17

Node 1: (-1, -1, -1)
Node 2: (1, -1, -1)
Node 3: (1, 1, -1)

Node 4: (-1, 1, -1)
Node 5: (-1, -1, 1)

Node 6: (1, -1, 1)
Node 7: (1, 1, 1)

Node 8: (-1, 1, 1)
Node 9: (0, -1, -1)
Node 10: (1, 0, -1)

Node 11: (0, 1, -1)
Node 12: (-1, 0, -1)

Node 13: (0, -1, 1)
Node 14: (1, 0, 1)

Node 15: (0, 1, 1)
Node 16: (-1, 0, 1)

Node 1: (-1, -1, -1)
Node 2: (1, -1, -1)
Node 3: (1, 1, -1)
Node 4: (-1, 1, -1)

Node 5: (-1, -1, 1)
Node 6: (1, -1, 1)

Node 7: (1, 1, 1)
Node 8: (-1, 1, 1)

Node 9: (0, -1, -1)
Node 10: (1, 0, -1)

Node 11: (0, 1, -1)
Node 12: (-1, 0, -1)

Node 13: (-1, -1, 0)
Node 14: (1, -1, 0)
Node 15: (1, 1, 0)

Node 16: (-1, 1, 0)
Node 17: (0, -1, 1)

Node 18: (1, 0, 1)
Node 19: (0, 1, 1)

Node 20: (-1, 0, 1)

Local Axis System

The intrinsic coordinate system is generally curvilinear and non-orthogonal. An orthogonal local axis system is also
defined for bricks for the purpose of applying directional attributes and material properties.

Element Connections

By default the local axis system is aligned with the global XYZ system, but may be realigned to any other UCS using
St7SetBrickLocalAxes1.

Face Axis System

Some attributes are defined with reference to a coordinate system defined on a given face of a brick. The face axis
system is oriented with respect to the nodes in the face’s definition (listed above) such that it coincides with the
default local axis system of a plate element with the same nodal definition.

The face axis system for a face on a particular brick element can be interrogated using
St7GetBrickFaceAxisSystemInitial, St7GetBrickFaceAxisSystemBirth and St7GetBrickFaceAxisSystemGNL.

Strand7 API Manual

User Defined Material Matrix

User defined material matrices are supplied and returned with the translation, rotation and coupling matrices in a
single array.  The format applies to the functions St7SetUserBeamData, St7GetUserBeamData,
St7SetPlateUserDefinedMaterial and St7GetPlateUserDefinedMaterial.

𝐓𝐫𝐚𝐧𝐬𝐥𝐚𝐭𝐢𝐨𝐧 𝐂𝐨𝐮𝐩𝐥𝐢𝐧𝐠
[
𝐑𝐨𝐭𝐚𝐭𝐢𝐨𝐧

]

The indices into the array Doubles[] are as follows:

12 13 14

[

15 16 17
18 19
20]

Attribute Types

Attribute Types

Attribute types are identified by an integer constant as defined in the header files. Individual functions are
provided to set and get attribute data, the St7DeleteAttribute function can be used to delete attributes, and the
St7SetAttributeDisplay and St7GetAttributeDisplay functions control the display of attributes in the model
window.

Attribute instances are uniquely identified by the arguments Entity, EntityNum, AttributeType, LocalID, Axis,
CaseNum, and ID. The entity type, element number and attribute type arguments are required for all attributes.
The local ID, axis, case number and ID arguments are dependent on the attribute type. When these arguments are
not required they are ignored.

Node Attributes

Attribute

Constant

ipAttrLocal

ipAttrAxis

ipAttrCase

ipAttrID

Acceleration

aoNodeAcceleration

Damping

Force

aoDamping

aoForce

Heat Source

aoNodeHeatSource

Initial Velocity

aoNodeVelocity

Moment

aoMoment

Non-Structural Mass

aoNSMass

Load Case

Freedom Case

Load Case

Load Case

Load Case

Load Case

Load Case

ID (1 - 192)

Response Variable

aoNodeInfluence

rvNodeDisplacement

Load Case

or rvNodeReaction

Restraint

aoRestraint

Rotational Mass

aoMRotation

Rotational Stiffness

aoKRotation

Temperature

aoTemperature

Translational Mass

aoMTranslation

Translational Stiffness

aoKTranslation

Freedom Case

Freedom Case

Load Case

Freedom Case

Strand7 API Manual

Beam Attributes

Attribute

Angle

Constant

ipAttrLocal

ipAttrAxis

ipAttrCase

ipAttrID

aoBeamAngle

Cable Free-Length

aoCableFreeLength

Connection UCS

aoBeamConnectionUCS

End (1 - 2)

Convection

aoBeamConvection

End (1 - 2)

Load Case

Creep Loading Age

aoBeamCreepLoadingAge

End Attachment

aoBeamEndAttachment

End (1 - 2)

Global Distributed Force

aoBeamDLG

Global Point Force

aoBeamCFG

Global Point Moment

aoBeamCMG

Heat Flux

Heat Source

aoBeamFlux

End (1 - 2)

aoBeamHeatSource

Local Axis (1 - 3)

Load Case

ID (1 - 192)

Load Case

ID (1 - 192)

Load Case

ID (1 - 192)

Load Case

Load Case

Non-Structural Mass

aoBeamNSMass

Load Case

ID (1 - 192)

Offset

Pipe Pressure

Pipe Radius

aoBeamOffset

aoPipePressure

aoBeamRadius

Pipe Temperature

aoPipeTemperature

Pre-Curvature

aoBeamPreCurvature

Pre-Load

aoBeamPreTension

Principal Distributed Force  aoBeamDLL

Principal Distributed
Moment

aoBeamDML

Principal Point Force

aoBeamCFL

Principal Point Moment

aoBeamCML

Radiation

aoBeamRadiation

Response Variable

aoBeamInfluence

End (1 - 2)

End (1 - 2)

Rotational End Release

aoBeamREndRelease

End (1 - 2)

Side Attachment

aoBeamSideAttachment

End (1 - 2)

Stage Property

aoBeamStageProperty

Stiffness/Mass Factor

aoBeamSectionFactor

String Group

Support

aoBeamStringGroup

aoBeamSupport

Taper

aoBeamTaper

Load Case

Load Case

Load Case

Load Case

Local Axis (1 - 3)

Load Case

ID (1 - 192)

Local Axis (1 - 3)

Load Case

ID (1 - 192)

Load Case

ID (1 - 192)

Load Case

ID (1 - 192)

Load Case

Load Case

adPlus1, adPlus2,
adMinus1 or
adMinus2

Stage ID, or 0
for all stages.

Freedom Case

adPlus1, adPlus2,
adMinus1 or
adMinus2

axLocalX or axLocalY

Temperature Gradient

aoBeamTempGradient

Load Case

Attribute Types

Translational End Release

aoBeamTEndRelease

End (1 - 2)

Plate Attributes

Attribute

Axis Angle

Constant

aoPlateAngle

Cavity Fluid Layout

aoPlateCavity

ipAttrLocal

ipAttrAxis

ipAttrCase

ipAttrID

psPlateMinusZ
or psPlatePlusZ

Concrete Reinforcement
Layout

aoPlateReinforcement

Creep Loading Age

aoPlateCreepLoadingAge

Edge Attachment

aoPlateEdgeAttachment

Edge (1 - 4)

Edge Convection

aoPlateEdgeConvection

Edge (1 - 4)

Edge Global Pressure

aoPlateEdgeGlobalPressure

Edge (1 - 4)

Edge Normal Pressure

aoPlateEdgeNormalPressure

Edge (1 - 4)

Edge Radiation

Edge Release

aoPlateEdgeRadiation

aoPlateEdgeRelease

Edge Shear Stress

aoPlateEdgeShear

Edge Support

aoPlateEdgeSupport

Edge (1 - 4)

Edge (1 - 4)

Edge (1 - 4)

Edge (1 - 4)

Edge Transverse Shear
Stress

aoPlateEdgeTransverseShear  Edge (1 - 4)

adPlanar,
adPlusZ or
adMinusZ

psPlateMinusZ
or psPlatePlusZ

psPlateMinusZ
or psPlatePlusZ

psPlateMinusZ
or psPlatePlusZ

psPlateMinusZ
or psPlatePlusZ

psPlateMinusZ
or psPlatePlusZ

Edge (1 - 4)

Face Attachment

aoPlateFaceAttachment

Face Convection

aoPlateFaceConvection

Face Radiation

aoPlateFaceRadiation

Face Support

aoPlateFaceSupport

Global Pressure

aoPlateGlobalPressure

Heat Flux

Heat Source

Load Patch

aoPlateFlux

aoPlateHeatSource

aoLoadPatch

Non-Structural Mass

aoPlateNSMass

Normal Pressure

aoPlateFacePressure

aoPlateOffset

aoPlatePointForce

aoPlatePointMoment

aoPlatePreCurvature

Offset

Point Force

Point Moment

Pre-Curvature

Load Case

Load Case

Load Case

Load Case

Load Case

Freedom Case

Load Case

Load Case

Load Case

Freedom Case

Load Case

Load Case

Load Case

Load Case

ID (1 - 192)

Load Case

Load Case

ID (1 - 192)

Load Case

ID (1 - 192)

Load Case

Strand7 API Manual

Pre-Load

aoPlatePreLoad

Response Variable

aoPlateInfluence

Shear Stress

aoPlateFaceShear

Soil In-situ Ratio

aoPlateSoilRatio

Soil In-situ Stress

aoPlateSoilStress

Stage Property

aoPlateStageProperty

Stiffness/Mass Factor

aoPlateSectionFactor

Temperature Gradient

aoPlateTempGradient

Thickness

aoPlateThickness

Brick Attributes

rvPlateForce or
rvPlateMoment

Load Case

Load Case

Load Case

Stage ID, or
0 for all
stages.

Load Case

Attribute

Constant

ipAttrLocal

ipAttrAxis

ipAttrCase

ipAttrID

Cavity Fluid Layout

aoBrickCavity

Convection

aoBrickConvection

Face (1 - 6)

Face (1 - 6)

Creep Loading Age

aoBrickCreepLoadingAge

Face Attachment

aoBrickFaceAttachment

Face (1 - 6)

Face Global Pressure

aoBrickGlobalPressure

Face (1 - 6)

Face Normal Pressure

aoBrickPressure

Face Shear Stress

aoBrickShear

Face (1 - 6)

Face (1 - 6)

Face Support

Heat Flux

Heat Source

Local Axes

aoBrickFaceFoundation

Face (1 - 6)

aoBrickFlux

Face (1 - 6)

aoBrickHeatSource

aoBrickLocalAxes

Load Case

Load Case

Load Case

Load Case

Freedom Case

Load Case

Load Case

Non-Structural Mass

aoBrickNSMass

Point Force

Pre-Load

Radiation

aoBrickPointForce

aoBrickPreLoad

aoBrickRadiation

Face (1 - 6)

Face (1 - 6)

Face (1 - 6)

Load Case

ID (1 - 192)

Load Case

ID (1 - 192)

Response Variable

aoBrickInfluence

Soil In-situ Ratio

aoBrickSoilRatio

Soil In-situ Stress

aoBrickSoilStress

Stage Property

aoBrickStageProperty

Load Case

Load Case

Load Case

Stage ID, or 0
for all stages.

Attribute Types

Path Attributes

Attribute

Constant

ipAttrLocal

ipAttrAxis

ipAttrCase

ipAttrID

Distributed Force

aoPathDistributedForce

Heat Source

Point Force

aoPathHeatSource

aoPathPointForce

Vertex Attributes

Attribute

Constant

ipAttrLocal

ipAttrAxis

ipAttrCase

ipAttrID

Damping

Force

aoDamping

aoForce

Heat Source

aoNodeHeatSource

Mesh Size

Moment

aoVertexMeshSize

aoMoment

Non-Structural Mass

aoNSMass

Restraint

aoRestraint

Rotational Mass

aoMRotation

Rotational Stiffness

aoKRotation

Temperature

aoTemperature

Translational Mass

aoMTranslation

Translational Stiffness

aoKTranslation

Coedge Attributes

Freedom Case

Load Case

Load Case

Load Case

Load Case

ID (1 - 192)

Freedom Case

Freedom Case

Load Case

Freedom Case

Attribute

Constant

ipAttrLocal

ipAttrAxis

ipAttrCase

ipAttrID

Edge Attachment

aoPlateEdgeAttachment

Edge Convection

aoPlateEdgeConvection

Edge Global Pressure

aoPlateEdgeGlobalPressure

Edge Heat Flux

aoPlateFlux

Edge Normal Pressure

aoPlateEdgeNormalPressure

Edge Radiation

aoPlateEdgeRadiation

Edge Release

aoPlateEdgeRelease

Edge Shear Stress

aoPlateEdgeShear

Edge Support

aoPlateEdgeSupport

Edge Transverse Shear
Stress

aoPlateEdgeTransverseShear

adPlanar,
adPlusZ or
adMinusZ

Load Case

Load Case

Load Case

Load Case

Load Case

Load Case

Freedom Case

Load Case

Strand7 API Manual

Face Attributes

Attribute

Constant

ipAttrLocal

ipAttrAxis

ipAttrCase

ipAttrID

psPlateMinusZ
or psPlatePlusZ

psPlateMinusZ
or psPlatePlusZ

psPlateMinusZ
or psPlatePlusZ

psPlateMinusZ
or psPlatePlusZ

psPlateMinusZ
or psPlatePlusZ

Face Attachment

aoPlateFaceAttachment

Face Convection

aoPlateFaceConvection

Face Radiation

aoPlateFaceRadiation

Face Support

aoPlateFaceSupport

Global Pressure

aoPlateGlobalPressure

Heat Source

aoPlateHeatSource

Non-Structural Mass

aoPlateNSMass

Normal Pressure

aoPlateFacePressure

Offset

aoPlateOffset

Temperature Gradient

aoPlateTempGradient

Thickness

aoPlateThickness

Load Case

Load Case

Freedom Case

Load Case

Load Case

Load Case

ID (1 - 192)

Load Case

Load Case

Beam Cross Section Shapes

Beam Cross Section Shapes

Beam cross section shape parameters (dimensions) for standard sections are manipulated through the arrays of
doubles for St7SetBeamSectionGeometry and St7GetBeamSectionGeometry, as well as the index positions ipD1 to
ipT3 on St7GetBeamPropertyData. The interpretation of these values depends on the cross section type, as
presented in the table below. Not all indices are relevant to all section types – blank entries are set as 0.0.

Standard Cross Section

D1

D2

D3

T1

T2

T3

Shape

bsCircularHollow

bsCircularSolid

bsCruciform

D

D

B

T

D

T1

T2

bsISection

B1

B2

bsLipChannel

bsLSection

bsSquareHollow

bsSquareSolid

bsTopHatChannel

B

B

B

B

B

D

D

D

D

D

bsTrapezoidHollow

B1

B2

bsTrapezoidSolid

B1

B2

D

L

L

D

D

T1

T2

T3

T1

T2

T3

T1

T2

T1

T2

T1

T2

T3

T1

T2

Strand7 API Manual

bsTriangleHollow

bsTriangleSolid

bsTSection

B

B

B

D

D

D

bsZSection

B1

B2

T1

T2

L

D

T1

T2

T3

T1

T2

T3

Additionally, the section can be bsBXSSection, bsBGLSection or bsNullSection (when it has not been defined).

Beam Cross Section Mirror Options

Beam Cross Section Mirror Options

The standard beam cross section shapes, as defined in Beam Cross Section Shape, with the exception of
bsCircularHollow  and bsCircularSolid, support the mirror options defined in the table below.

MirrorType

Number of Sections

Illustration

mtNone

mtTop

mtBot

mtLeft

mtRight

mtLeftTopOnly

mtLeftBotOnly

mtRightTopOnly

mtRightBotOnly

mtLeftAndTop

Strand7 API Manual

mtLeftAndBot

mtRightAndTop

mtRightAndBot

Beam Geometry Library (BGL) Cross Section Shapes

Beam Geometry Library (BGL) Cross Section Shapes

Beam cross section shape parameters (dimensions) for BGL cross sections are available from the individual beam
property data via St7GetBeamSectionGeometryBGL, and from the BGL libraries via
St7GetLibraryBeamSectionGeometryBGL.

The dimensions are returned in the array of doubles Dimensions[0..kMaxBGLDimensions-1]. The
interpretation of the values in the array depends on the cross section type as presented in the table below.
Lengths are in the length unit of the model.  Angles are in degrees.  Not all values are relevant to all section types
– blank entries are set to 0.0.

Name
Constant

Array Index

I Section

T Section

Channel

Angle

Hollow Rectangle

Bulb Flat

bgISection

bgTSection

bgChannel

bgAngle

bgRectangularHollow

bgBulbFlat

D

B

tw

tf

Ri

Ro

D

B

t

Rr

Rh

Rt1

Rt2

Rt3

α

D

B

tw

tf

Rr

Rt1

Rt2

Rt3

α1

α2

D

B1

B2

tw

tf1

tf2

Rr1

Rr2

Rt1

Rt2

Rt3

Rt4

α1

α2

Dimension

D

B

tw

tf

Rr

Rh

Rt1

Rt2

Rt3

Rt4

α1

α2

D

B1

B2

tw

tf1

tf2

Rr1

Rr2

Rh1

Rh2

Rt1

Rt2

Rt3

Rt4

α1

α2

The following table illustrates the dimensions for each cross section type.

Strand7 API Manual

bgISection

bgTSection

bgChannel

Beam Geometry Library (BGL) Cross Section Shapes

bgAngle

bgRectangularHollow

bgBulbFlat

Strand7 API Manual

Beam Distributed Load Types

There are six beam distribution types in Strand7, used by the following API functions:

•  St7SetBeamDistributedForcePrincipal6ID
•  St7SetBeamDistributedForceGlobal6ID
•  St7SetBeamDistributedMomentPrincipal6ID
•  St7SetBeamNSMass10ID
•  St7GetBeamDistributedForcePrincipal6ID
•  St7GetBeamDistributedForceGlobal6ID
•  St7GetBeamDistributedMomentPrincipal6ID
•  St7GetBeamNSMass10ID.

In these functions, the distribution type is specified by the parameter DLType, which may set one of the constants
listed below.

DLType

Distribution

dlConstant

dlLinear

dlThreePoint0

dlThreePoint1

dlTriangular

dlTrapezoidal

The above schematics are for the distributed force attribute, but the layout also applies to the distributed
moment and distributed mass attributes.

Beam Distributed Load Types

A Doubles array is also passed to these functions, in which the variables identifed in the schematics are set.

The values PA, PB, P1, P2, a and b are found at:

Doubles[0] = PA
Doubles[1] = PB
Doubles[2] = P1
Doubles[3] = P2
Doubles[4] = a
Doubles[5] = b

Strand7 API Manual

Link Types

Strand7 defines a number of different link types, and they are identified in the API by the following constants,
denoted as LinkType in the function parameters.

LinkType

Description

ltAttachmentLink

ltCouplingLink

Attachment link – attaches a node to an element by constraining the
degrees of freedom of the node to the degrees of freedom of the
nodes of the element, according to the shape functions of the element.

Coupling link – constrains the degrees of freedom of a node as a linear
combination of the degrees of freedom of two other nodes.

ltInterpolatedMultiPointLink  Interpolated MPL – constrains the degrees of freedom of a node to be

ltMasterSlaveLink

a combination of the degrees of freedom of a cluster of other nodes,
using a least squares interpolation.

Master-slave link – constrains any of the degrees of freedom at two
nodes to act as one.

ltMasterSlaveMultiPointLink  Master-slave MPL - constrains any of the degrees of freedom at a

ltPinnedLink

ltPinnedMultiPointLink

ltReactionMultiPointLink

ltRigidLink

ltRigidMultiPointLink

ltSectorSymmetryLink

ltShrinkLink

cluster of nodes to act as one.

Pinned link – for the structural solvers, enforces no relative axial
movement between the two nodes on the link; for the heat solvers
constrains both nodes to have the same temperature.

Pinned MPL – for the structural solvers, enforces no relative axial
movement between a nominated slave node and all nodes in a cluster
of connected nodes; for the heat solvers constrains all nodes in the
cluster to have the same temperature as the slave node.

Reaction MPL – a special link used to produce reaction summations
(forces/moments in the structural solvers and flux in the heat solvers)
at a point in space from the reactions at nodes/elements in the cluster.

Rigid link – for the structural solvers, enforces no relative movement
between the two nodes on the link except for a rigid body movement;
for the heat solvers constrains both nodes to have the same
temperature.

Rigid MPL – for the structural solvers, enforces no relative movement
between all nodes in a cluster except for a rigid body movement of the
cluster as a whole; for the heat solvers constrains all nodes in the
cluster to have the same temperature as the slave node.

Sector-symmetry link – for the structural solvers, enforces rotational
symmetry between two nodes on respective planes according to a
cylindrical axis system; for the heat solvers constrains both nodes to
have the same temperature.

Shrink link – for the structural solvers, enforces displacements such
that the sum of all the displacements at the two nodes equal zero; for
the heat solvers constrains both nodes to have the same temperature.

Link Types

ltTwoPointLink

Two-point link – allows for any user-defined linear relationship
between the degrees of freedom at two nodes.

ltUserDefinedMultiPointLink

User-defined MPL – allows for any user-defined linear relationship
between the degrees of freedom at any number of nodes.

Strand7 API Manual

Load Patch Types

There are six load patch types in Strand7. These are referenced via the PatchType parameter in the API functions
St7SetPlateLoadPatch4 and St7GetPlateLoadPatch4.

The parameter PatchType in these functions specifies the load patch type, as illustrated below.

PatchType

Load Distribution

Description

ptAngleSplit

Quadrilateral plates apply triangular load to two
adjacent edges.

ptAuto1

ptAuto2

ptAuto3

ptAuto4

ptManual*
*factors F in
Doubles array

In the images:

Quadrilateral plates apply rectangular load to one
edge.

Triangular plates apply triangular load to one edge.

Quadrilateral plates apply rectangular load to two
opposite edges.
Triangular plates apply triangular load to two
opposite edges.

Quadrilateral plates apply trapezoidal load to two
opposite edges and triangular load to the
intermediate edge.

Quadrilateral plates apply trapezoidal load on the
long edges and triangular load on the short edges.
For a square quadrilateral, all loads are triangular.
Triangular plates apply triangular load to all edges.

Both quadrilateral and triangular plates apply
scaled rectangular load to the selected edges.

-
-
-

the whilte lines indicate the edges of the plate element to be selected to apply the specified type;
the red lines indicate the edges where beam elements are required to receive the load;
the black lines indicate the approximate shape of the load distribution applied to beam elements on the
edges.

Load Patch Types

The type ptManual requires a set of weights specified by the parameter Doubles:

Doubles[0] = Edge 1 weight
Doubles[1] = Edge 2 weight
Doubles[2] = Edge 3 weight
Doubles[3] = Edge 4 weight

All types except ptAuto4 require the specification of edges via the parameter EdgeBits to define the distribution,
or in the case of ptManual, to define the edges on which to apply the weights. The four least significant bits in the
four byte integer EdgeBits correspond to the four (possible) edges of the load patch.

Writing EdgeBits in binary form it is seen that:

Edge 1 : b’00000000 00000000 00000000 00000001’ = 1
Edge 2 : b’00000000 00000000 00000000 00000010’ = 2
Edge 3 : b’00000000 00000000 00000000 00000100’ = 4
Edge 4 : b’00000000 00000000 00000000 00001000’ = 8

To define two or more edges, the binary values are combined using a ‘logical or’ operation.  For example, to
define edges 2 and 3, the following two binary values are combined using a logical or operation:

b’00000000 00000000 00000000 00000010’
b’00000000 00000000 00000000 00000100’

which produces the following binary value:

b’00000000 00000000 00000000 00000110’ = 6.

That is, EdgeBits=6 selects edge 2 and edge 3 at the same time.

Strand7 API Manual

Grade Types

The GradeType parameter provided to St7Grade determines grade applied to the selected plates and bricks.
Either whole elements, edges or brick faces should be selected as shown in the following table.

GradeType

Grade  GradeRatio Applies

Selected Plates

Selected Bricks

gt1x2Grade

gt1x2TriGrade

gt1x3Grade

gt2x3Grade

gt2x3TriGrade

gtQuadTriGrade1

gtQuadCutOut

True

gtTriGrade1

gtTriGrade2

gtTriGrade3

gt2x4Grade

gtQuarterQuadGrade

gtFullQuarterCircleGrade

gtQuarterCircleCut

gtFullQuarterCircleCut

True

True

Edge

Edge

Edge

Edge

Edge

Edge

Plate

Edge

Edge

Plate

Edge

Edge

Edge

Edge

Edge

Edge

Edge

Edge

Edge

Edge

Edge

Face

Edge

Edge

Face

Edge

Edge

Edge

Edge

Edge

Grade Types

gtQuarterAnnulusCut

True

gtQuadGradeTri

gtBrickCornerGrade

gtTriGrade4

gtTriGrade5

Edge

Plate

Plate

Plate

Edge

Face

Edge

Face

Face

Strand7 API Manual

Table Types

Strand7 defines a number of different table types, for use in different contexts. In the GUI these are defined under
LAYOUTS/Tables, and they are identified in the API by the following constants.

TableType

Table Description

ttAccVsTime

Acceleration vs time

ttDispVsTime

Displacement vs time

ttForceDisplacement

Force vs displacement

ttForceVelocity

Force vs velocity

ttMomentCurvature

Moment vs curvature

ttMomentRotation

Moment vs rotation

ttStrainTime

Strain vs time

ttStressStrain

Stress vs strain

ttTemperatureVsTime

Temperature vs time

ttVelVsTime

Velocity vs time

ttVsFrequency

Factor vs frequency/period

ttVsPosition

Factor vs position

ttVsTemperature

Factor vs temperature

ttVsTime

Factor vs time

ttVsVelocity

Factor vs velocity

The functions
