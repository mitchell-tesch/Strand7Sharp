using System;
using System.Runtime.InteropServices;
using System.Text;

namespace St7API
{
    public static class St7
    {

        public const int lmMessageBox = 0;
        public const int lmWaitRetry = 1;
        public const int lmAbort = 2;
        public const int kMaxStrLen = 255;

        // Array Limits
        public const int kMaxEntityTotals = 4;
        public const int kMaxElementNode = 20;
        public const int kMaxEntity = 10;
        public const int kMaxBeamResult = 4096;
        public const int kNumBeamSectionData = 20;
        public const int kNumMaterialData = 4;
        public const int kMaxAttributeDoubles = 12;
        public const int kMaxAttributeLogicals = 6;
        public const int kMaxAttributeLongint = 6;
        public const int kLastUnit = 6;
        public const int kMaxBGLDimensions = 16;

        // Selection States
        public const int ssSelected = 1;
        public const int ssUnselected = 2;

        // Unit Positions
        public const int ipLENGTHU = 0;
        public const int ipFORCEU = 1;
        public const int ipSTRESSU = 2;
        public const int ipMASSU = 3;
        public const int ipTEMPERU = 4;
        public const int ipENERGYU = 5;

        // Unit Types - LENGTH
        public const int luMETRE = 0;
        public const int luCENTIMETRE = 1;
        public const int luMILLIMETRE = 2;
        public const int luFOOT = 3;
        public const int luINCH = 4;

        // Unit Types - FORCE
        public const int fuNEWTON = 0;
        public const int fuKILONEWTON = 1;
        public const int fuMEGANEWTON = 2;
        public const int fuKILOFORCE = 3;
        public const int fuPOUNDFORCE = 4;
        public const int fuTONNEFORCE = 5;
        public const int fuKIPFORCE = 6;

        // Unit Types - STRESS
        public const int suPASCAL = 0;
        public const int suKILOPASCAL = 1;
        public const int suMEGAPASCAL = 2;
        public const int suKSCm = 3;
        public const int suPSI = 4;
        public const int suKSI = 5;
        public const int suPSF = 6;

        // Unit Types - MASS
        public const int muKILOGRAM = 0;
        public const int muTONNE = 1;
        public const int muGRAM = 2;
        public const int muPOUND = 3;
        public const int muSLUG = 4;

        // Unit Types - TEMPERATURE
        public const int tuCELSIUS = 0;
        public const int tuFAHRENHEIT = 1;
        public const int tuKELVIN = 2;
        public const int tuRANKINE = 3;

        // Unit Types - ENERGY
        public const int euJOULE = 0;
        public const int euBTU = 1;
        public const int euFTLBF = 2;
        public const int euCALORIE = 3;
        public const int euKILOJOULE = 4;

        // Unit Types - TIME
        public const int tuMilliSec = 0;
        public const int tuSec = 1;
        public const int tuMin = 2;
        public const int tuHour = 3;
        public const int tuDay = 4;

        // Entity Types
        public const int tyNODE = 0;
        public const int tyBEAM = 1;
        public const int tyPLATE = 2;
        public const int tyBRICK = 3;
        public const int tyLINK = 4;
        public const int tyVERTEX = 5;
        public const int tyGEOMETRYEDGE = 6;
        public const int tyGEOMETRYFACE = 7;
        public const int tyLOADPATH = 8;
        public const int tyGEOMETRYCOEDGE = 9;
        public const int tyGEOMETRYLOOP = 10;

        // Link Types
        public const int ltMasterSlaveLink = 1;
        public const int ltSectorSymmetryLink = 2;
        public const int ltCouplingLink = 3;
        public const int ltPinnedLink = 4;
        public const int ltRigidLink = 5;
        public const int ltShrinkLink = 6;
        public const int ltTwoPointLink = 7;
        public const int ltAttachmentLink = 8;
        public const int ltInterpolatedMultiPointLink = 9;
        public const int ltReactionMultiPointLink = 10;
        public const int ltRigidMultiPointLink = 11;
        public const int ltPinnedMultiPointLink = 12;
        public const int ltMasterSlaveMultiPointLink = 13;
        public const int ltUserDefinedMultiPointLink = 14;

        // Master-Slave Link
        public const int msFree = 0;
        public const int msFix = 1;
        public const int msFixNegate = -1;

        // Coupling, Attachment and Multi-Point Links
        public const int cpTranslational = 1;
        public const int cpRotational = 2;
        public const int cpBoth = 3;

        // Rigid Link
        public const int rlPlaneXYZ = 0;
        public const int rlPlaneXY = 1;
        public const int rlPlaneYZ = 2;
        public const int rlPlaneZX = 3;

        // 2-Point Link
        public const int ipTwoPointDOF1 = 0;
        public const int ipTwoPointDOF2 = 1;
        public const int ipTwoPointUCS1 = 2;
        public const int ipTwoPointUCS2 = 3;
        public const int ipTwoPointFC = 4;
        public const int ipTwoPointC1 = 0;
        public const int ipTwoPointC2 = 1;
        public const int ipTwoPointConst = 2;

        // Attachment Link
        public const int ipAttachmentElType = 0;
        public const int ipAttachmentElNum = 1;
        public const int ipAttachmentBrickFaceNum = 2;
        public const int ipAttachmentCouple = 3;

        // Node Temperature Types
        public const int ntReferenceTemperature = 0;
        public const int ntFixedTemperature = 1;
        public const int ntInitialTemperature = 2;
        public const int ntTableTemperature = 3;

        // Beam End Release Constants
        public const int brReleased = 0;
        public const int brFixed = 1;
        public const int brPartial = 2;

        // Plate Edge Release Constants
        public const int prReleased = 0;
        public const int prFixed = 1;

        // Property Types
        public const int ptBEAMPROP = 1;
        public const int ptPLATEPROP = 2;
        public const int ptBRICKPROP = 3;
        public const int ptPLYPROP = 4;

        // Property Totals
        public const int ipBeamPropTotal = 0;
        public const int ipPlatePropTotal = 1;
        public const int ipBrickPropTotal = 2;
        public const int ipPlyPropTotal = 3;

        // Alpha Temperature Types
        public const int atIntegrated = 0;
        public const int atInstantaneous = 1;

        // Sampling Positions
        public const int spCentroid = 0;
        public const int spGaussPoints = 1;
        public const int spNodesAverageNever = 2;
        public const int spNodesAverageAll = 3;
        public const int spNodesAverageSame = 4;

        // Limit Envelope Averaging
        public const int aoAverageThenEnvelope = 0;
        public const int aoEnvelopeThenAverage = 1;

        // Beam Types
        public const int btNull = 0;
        public const int btSpring = 1;
        public const int btCable = 2;
        public const int btTruss = 3;
        public const int btCutoff = 4;
        public const int btContact = 5;
        public const int btBeam = 6;
        public const int btUser = 7;
        public const int btPipe = 8;
        public const int btConnection = 9;

        // Contact Types
        public const int ctZeroGap = 0;
        public const int ctNormal = 1;
        public const int ctTension = 2;
        public const int ctTakeup = 3;

        // Takeup Contact Sub Types
        public const int tuTension = 0;
        public const int tuCompression = 1;

        // Cutoff Bar Types
        public const int cbBrittle = 0;
        public const int cbDuctile = 1;

        // Contact Parameters Positions - Integers
        public const int ipContactType = 0;
        public const int ipDynamicStiffness = 1;
        public const int ipUpdateDirection = 2;
        public const int ipContactSubType = 3;
        public const int ipFrictionYieldType = 4;
        public const int ipFrictionModel = 5;
        public const int ipTensionLateralStiffness = 6;

        // Contact Parameters Positions - Doubles
        public const int ipContactAxialStiffness = 0;
        public const int ipFrictionC1 = 1;
        public const int ipFrictionC2 = 2;
        public const int ipContactMaxTension = 3;
        public const int ipContactLateralStiffness = 4;
        public const int ipContactStrainTol = 5;

        // CutoffBar Parameter Positions
        public const int ipCutoffType = 0;
        public const int ipKeepMass = 1;

        // Library Types
        public const int lbMaterial = 0;
        public const int lbBeamSection = 1;
        public const int lbComposite = 2;
        public const int lbReinforcementLayout = 3;
        public const int lbCreepDefinition = 4;
        public const int lbLoadPathTemplate = 5;
        public const int lbSectionGeometry = 6;

        // Beam Section Types
        public const int bsNullSection = 0;
        public const int bsCircularSolid = 1;
        public const int bsCircularHollow = 2;
        public const int bsSquareSolid = 3;
        public const int bsSquareHollow = 4;
        public const int bsLipChannel = 5;
        public const int bsTopHatChannel = 6;
        public const int bsISection = 7;
        public const int bsTSection = 8;
        public const int bsLSection = 9;
        public const int bsZSection = 10;
        public const int bsBXSSection = 11;
        public const int bsTrapezoidSolid = 12;
        public const int bsTrapezoidHollow = 13;
        public const int bsTriangleSolid = 14;
        public const int bsTriangleHollow = 15;
        public const int bsCruciform = 16;
        public const int bsBGLSection = 17;

        // Beam Geometry Section Types
        public const int bgNullSection = 0;
        public const int bgRectangularHollow = 1;
        public const int bgISection = 2;
        public const int bgChannel = 3;
        public const int bgTSection = 4;
        public const int bgAngle = 5;
        public const int bgBulbFlat = 6;

        // Beam Mirror Types
        public const int mtNone = 0;
        public const int mtTop = 1;
        public const int mtBot = 2;
        public const int mtLeft = 3;
        public const int mtRight = 4;
        public const int mtLeftAndTop = 5;
        public const int mtLeftAndBot = 6;
        public const int mtRightAndTop = 7;
        public const int mtRightAndBot = 8;
        public const int mtLeftTopOnly = 9;
        public const int mtLeftBotOnly = 10;
        public const int mtRightTopOnly = 11;
        public const int mtRightBotOnly = 12;

        // Beam Section Positions
        public const int ipAREA = 0;
        public const int ipI11 = 1;
        public const int ipI22 = 2;
        public const int ipJ = 3;
        public const int ipSL1 = 4;
        public const int ipSL2 = 5;
        public const int ipSA1 = 6;
        public const int ipSA2 = 7;
        public const int ipXBAR = 8;
        public const int ipYBAR = 9;
        public const int ipANGLE = 10;
        public const int ipD1 = 11;
        public const int ipD2 = 12;
        public const int ipD3 = 13;
        public const int ipT1 = 14;
        public const int ipT2 = 15;
        public const int ipT3 = 16;
        public const int ipGapA = 17;
        public const int ipGapB = 18;

        // Beam Load Types
        public const int dlConstant = 0;
        public const int dlLinear = 1;
        public const int dlTriangular = 2;
        public const int dlThreePoint0 = 3;
        public const int dlThreePoint1 = 4;
        public const int dlTrapezoidal = 5;

        // Plate Load Patch Types
        public const int ptAuto4 = 0;
        public const int ptAuto3 = 1;
        public const int ptAuto2 = 2;
        public const int ptAuto1 = 3;
        public const int ptAngleSplit = 4;
        public const int ptManual = 5;

        // Plate Types
        public const int ptNull = 0;
        public const int ptPlaneStress = 1;
        public const int ptPlaneStrain = 2;
        public const int ptAxisymmetric = 3;
        public const int ptPlateShell = 4;
        public const int ptShearPanel = 5;
        public const int ptMembrane = 6;
        public const int ptLoadPatch = 7;

        // Geometry Surface Types
        public const int suNull = -1;
        public const int suPlane = 0;
        public const int suSphere = 1;
        public const int suTorus = 2;
        public const int suCone = 3;
        public const int suBSpline = 4;
        public const int suRotSur = 5;
        public const int suPipeSur = 6;
        public const int suSumSur = 7;
        public const int suTabCyl = 8;
        public const int suRuleSur = 9;
        public const int suCubicSpline = 10;

        // Material Types
        public const int mtNull = 0;
        public const int mtIsotropic = 1;
        public const int mtOrthotropic = 2;
        public const int mtAnisotropic = 3;
        public const int mtRubber = 4;
        public const int mtSoil = 5;
        public const int mtLaminate = 6;
        public const int mtUserDefined = 7;
        public const int mtFluid = 10;

        // Soil Types
        public const int stDuncanChang = 0;
        public const int stModifiedCamClay = 1;
        public const int stMohrCoulomb = 2;
        public const int stDruckerPrager = 3;
        public const int stLinearElastic = 4;

        // Yield Criteria - beams
        public const int ycBeamFibre = 0;
        public const int ycBeamTresca = 1;
        public const int ycBeamVonMises = 2;

        // Yield Criteria - plates and bricks
        public const int ycTresca = 0;
        public const int ycVonMises = 1;
        public const int ycMaxStress = 2;
        public const int ycMohrCoulomb = 3;
        public const int ycDruckerPrager = 4;

        // Nonlinear Types
        public const int ntNonlinElastic = 0;
        public const int ntElastoPlastic = 1;

        // Rubber Types
        public const int rtNeoHookean = 1;
        public const int rtMooneyRivlin = 2;
        public const int rtGeneralisedMooneyRivlin = 3;
        public const int rtOgden = 4;

        // Material Positions
        public const int ipModulus = 0;
        public const int ipPoisson = 1;
        public const int ipDensity = 2;
        public const int ipShearModulus = 3;

        // Element Result State
        public const int ipResStateActive = 0;
        public const int ipResStateResults = 1;
        public const int ipResStateBirthStage = 2;

        // Node Result Types
        public const int rtNodeDisp = 1;
        public const int rtNodeVel = 2;
        public const int rtNodeAcc = 3;
        public const int rtNodePhase = 4;
        public const int rtNodeReact = 5;
        public const int rtNodeTemp = 6;
        public const int rtNodeFlux = 7;
        public const int rtNodeInertia = 8;
        public const int rtNodeInfluence = 1;

        // Beam Result Types
        public const int rtBeamForce = 1;
        public const int rtBeamAllStrain = 2;
        public const int rtBeamAllStress = 3;
        public const int rtBeamCableXYZ = 6;
        public const int rtBeamFlux = 8;
        public const int rtBeamGradient = 9;
        public const int rtBeamCreepStrain = 10;
        public const int rtBeamEnergy = 11;
        public const int rtBeamDisp = 12;
        public const int rtBeamNodeReact = 13;
        public const int rtBeamBirthDisp = 14;
        public const int rtBeamNodeFlux = 15;
        public const int rtBeamAxialStress = 16;
        public const int rtBeamBendingStress = 17;
        public const int rtBeamFibreStress = 18;
        public const int rtBeamAvShearStress = 19;
        public const int rtBeamShearStress = 20;
        public const int rtBeamCombinedStress = 21;
        public const int rtPipeHoopStress = 22;
        public const int rtBeamYieldAreaRatio = 23;
        public const int rtBeamUser = 24;
        public const int rtBeamAllTotalStrain = 25;
        public const int rtBeamExtraResults = 99;

        // Beam Result Quantities - BEAMFORCE - Principal
        public const int ipBeamSF1 = 0;
        public const int ipBeamBM1 = 1;
        public const int ipBeamSF2 = 2;
        public const int ipBeamBM2 = 3;

        // Beam Result Quantities - BEAMFORCE - Local
        public const int ipBeamSFx = 0;
        public const int ipBeamBMx = 1;
        public const int ipBeamSFy = 2;
        public const int ipBeamBMy = 3;

        // Beam Result Quantities - BEAMFORCE - Local and Principal
        public const int ipBeamAxialF = 4;
        public const int ipBeamTorque = 5;

        // Beam Result Quantities - BEAMFORCE - Global
        public const int ipBeamFX = 0;
        public const int ipBeamMX = 1;
        public const int ipBeamFY = 2;
        public const int ipBeamMY = 3;
        public const int ipBeamFZ = 4;
        public const int ipBeamMZ = 5;

        // Beam Result Quantities - BEAMSTRESS
        public const int ipMinFibreStress = 0;
        public const int ipMaxFibreStress = 1;
        public const int ipMaxShearStress1 = 2;
        public const int ipMaxShearStress2 = 3;
        public const int ipShearF1MeanShearStress = 4;
        public const int ipShearF2MeanShearStress = 5;
        public const int ipShearStressMag = 6;
        public const int ipMinPrincipalStress = 7;
        public const int ipMaxPrincipalStress = 8;
        public const int ipMinPipeHoopStress = 9;
        public const int ipMaxPipeHoopStress = 10;
        public const int ipMinAxialStress = 11;
        public const int ipMaxAxialStress = 12;
        public const int ipMinBendingStress1 = 13;
        public const int ipMaxBendingStress1 = 14;
        public const int ipMinBendingStress2 = 15;
        public const int ipMaxBendingStress2 = 16;
        public const int ipYieldAreaRatio = 17;
        public const int ipVonMisesStress = 18;
        public const int ipTrescaStress = 19;
        public const int ipTorqueShearStress = 20;
        public const int ipShearF1ShearStress = 21;
        public const int ipShearF2ShearStress = 22;

        // Beam Result Quantities - BEAMSTRAIN
        public const int ipAxialStrain = 0;
        public const int ipCurvature1 = 1;
        public const int ipCurvature2 = 2;
        public const int ipTwist = 3;
        public const int ipMinFibreStrain = 4;
        public const int ipMaxFibreStrain = 5;

        // Beam Result Quantities - BEAMCREEPSTRAIN
        public const int ipMinFibreCreepStrain = 0;
        public const int ipMaxFibreCreepStrain = 1;
        public const int ipMinFibreCreepStrainRate = 2;
        public const int ipMaxFibreCreepStrainRate = 3;
        public const int ipShrinkageStrain = 4;

        // Beam Result Quantities - BEAMRELEASE
        public const int ipRelEnd1Dir1 = 0;
        public const int ipRelEnd1Dir2 = 1;
        public const int ipRelEnd1Dir3 = 2;
        public const int ipRelEnd1Dir4 = 3;
        public const int ipRelEnd1Dir5 = 4;
        public const int ipRelEnd1Dir6 = 5;
        public const int ipRelEnd2Dir1 = 6;
        public const int ipRelEnd2Dir2 = 7;
        public const int ipRelEnd2Dir3 = 8;
        public const int ipRelEnd2Dir4 = 9;
        public const int ipRelEnd2Dir5 = 10;
        public const int ipRelEnd2Dir6 = 11;

        // Beam Result Quantities - BEAMENERGY
        public const int ipBeamEnergyStored = 0;
        public const int ipBeamEnergySpent = 1;

        // Beam Section Result Types
        public const int rtBeamSectionStress = 1;
        public const int rtBeamSectionStrain = 2;
        public const int rtBeamSectionCreepStrain = 3;
        public const int rtBeamSectionTotalStrain = 4;

        // Beam Section Result Quantities
        public const int ipFibreStressXY = 0;
        public const int ipShearStress1XY = 1;
        public const int ipShearStress2XY = 2;
        public const int ipMinPrincipalStressXY = 3;
        public const int ipMaxPrincipalStressXY = 4;
        public const int ipAxialStressXY = 5;
        public const int ipBendingStress1XY = 6;
        public const int ipBendingStress2XY = 7;
        public const int ipVonMisesStressXY = 8;
        public const int ipTrescaStressXY = 9;
        public const int ipTorqueStressXY = 10;
        public const int ipShearF1ShearStressXY = 11;
        public const int ipShearF2ShearStressXY = 12;

        // Plate Result Types
        public const int rtPlateStress = 1;
        public const int rtPlateStrain = 2;
        public const int rtPlateEnergyDensity = 3;
        public const int rtPlateForce = 4;
        public const int rtPlateMoment = 5;
        public const int rtPlateCurvature = 6;
        public const int rtPlatePlyStress = 7;
        public const int rtPlatePlyStrain = 8;
        public const int rtPlatePlyReserve = 9;
        public const int rtPlateFlux = 10;
        public const int rtPlateGradient = 11;
        public const int rtPlateRCDesign = 12;
        public const int rtPlateCreepStrain = 13;
        public const int rtPlateSoil = 14;
        public const int rtPlateUser = 15;
        public const int rtPlateNodeReact = 16;
        public const int rtPlateNodeDisp = 17;
        public const int rtPlateNodeBirthDisp = 18;
        public const int rtPlateEffectiveStress = 19;
        public const int rtPlateEffectiveForce = 20;
        public const int rtPlateNodeFlux = 21;
        public const int rtPlateTotalStrain = 22;
        public const int rtPlateTotalCurvature = 23;
        public const int rtPlateEnergyIntegral = 24;

        // Plate Surface Definition
        public const int psPlateMidPlane = 0;
        public const int psPlateMinusZ = 1;
        public const int psPlatePlusZ = 2;

        // Brick Result Types
        public const int rtBrickStress = 1;
        public const int rtBrickStrain = 2;
        public const int rtBrickEnergyDensity = 3;
        public const int rtBrickFlux = 4;
        public const int rtBrickGradient = 5;
        public const int rtBrickCreepStrain = 6;
        public const int rtBrickSoil = 7;
        public const int rtBrickUser = 8;
        public const int rtBrickNodeReact = 9;
        public const int rtBrickNodeDisp = 10;
        public const int rtBrickNodeBirthDisp = 11;
        public const int rtBrickEffectiveStress = 12;
        public const int rtBrickNodeFlux = 13;
        public const int rtBrickTotalStrain = 14;
        public const int rtBrickEnergyIntegral = 15;

        // Link Result Types
        public const int rtLinkNodeDisp = 0;
        public const int rtLinkNodeReact = 1;
        public const int rtLinkNodeFlux = 2;
        public const int rtLinkNodeBirthDisp = 3;

        // Beam Result Sub Types
        public const int stBeamLocal = 0;
        public const int stBeamPrincipal = -1;
        public const int stBeamGlobal = -2;

        // Plate Result Sub Types
        public const int stPlateLocal = 0;
        public const int stPlateGlobal = -1;
        public const int stPlateCombined = -2;
        public const int stPlateSupport = -3;
        public const int stPlateDevLocal = -4;
        public const int stPlateDevGlobal = -5;
        public const int stPlateDevCombined = -6;
        public const int stPlateCavity = -7;

        // Brick Result Sub Types
        public const int stBrickLocal = 0;
        public const int stBrickGlobal = -1;
        public const int stBrickCombined = -2;
        public const int stBrickSupport = -3;
        public const int stBrickDevLocal = -4;
        public const int stBrickDevGlobal = -5;
        public const int stBrickDevCombined = -6;
        public const int stBrickCavity = -7;

        // Link Result Sub Types
        public const int stLinkGlobal = 1;

        // PLATESTRESS, PLATESTRAIN, PLATECREEPSTRAIN, PLATEMOMENT, PLATECURVATURE, PLATEFORCE results for STLOCAL
        public const int ipPlateLocalxx = 0;
        public const int ipPlateLocalyy = 1;
        public const int ipPlateLocalzz = 2;
        public const int ipPlateLocalxy = 3;
        public const int ipPlateLocalyz = 4;
        public const int ipPlateLocalzx = 5;
        public const int ipPlateLocalxz = 5;
        public const int ipPlateLocalMean = 0;
        public const int ipPlateLocalDevxx = 1;
        public const int ipPlateLocalDevyy = 2;
        public const int ipPlateEdgeSupport = 0;
        public const int ipPlateFaceSupport = 1;

        // PLATESTRESS, PLATESTRAIN, PLATECREEPSTRAIN, PLATEMOMENT, PLATECURVATURE, PLATEFORCE results for STGLOBAL (NOT AXISYMMETRIC)
        public const int ipPlateGlobalXX = 0;
        public const int ipPlateGlobalYY = 1;
        public const int ipPlateGlobalZZ = 2;
        public const int ipPlateGlobalXY = 3;
        public const int ipPlateGlobalYZ = 4;
        public const int ipPlateGlobalZX = 5;
        public const int ipPlateGlobalMean = 0;
        public const int ipPlateGlobalDevXX = 1;
        public const int ipPlateGlobalDevYY = 2;
        public const int ipPlateGlobalDevZZ = 3;

        // PLATESTRESS, PLATESTRAIN, PLATECREEPSTRAIN, PLATEMOMENT, PLATECURVATURE, PLATEFORCE results for STUCS
        public const int ipPlateUCSXX = 0;
        public const int ipPlateUCSYY = 1;
        public const int ipPlateUCSZZ = 2;
        public const int ipPlateUCSXY = 3;
        public const int ipPlateUCSYZ = 4;
        public const int ipPlateUCSZX = 5;

        // PLATESTRESS, PLATESTRAIN, PLATECREEPSTRAIN, PLATEFORCE, PLATEMOMENT, PLATECURVATURE results for STCOMBINED (NOT AXISYMMETRIC)
        public const int ipPlateCombPrincipal11 = 0;
        public const int ipPlateCombPrincipal22 = 1;
        public const int ipPlateCombPrincipalAngle = 3;
        public const int ipPlateCombVonMises = 4;
        public const int ipPlateCombTresca = 5;
        public const int ipPlateCombMohrCoulomb = 6;
        public const int ipPlateCombDruckerPrager = 7;
        public const int ipPlateCombMagnitude = 9;
        public const int ipPlateCombPlasticStrain = 6;
        public const int ipPlateCombCreepEffRate = 6;
        public const int ipPlateCombCreepShrinkage = 7;
        public const int ipPlateCombYieldIndex = 8;
        public const int ipPlateCombMean = 0;
        public const int ipPlateCombDev11 = 1;
        public const int ipPlateCombDev22 = 2;

        // PLATESTRESS, PLATESTRAIN, PLATECREEPSTRAIN results for STGLOBAL (AXISYMMETRIC)
        public const int ipPlateAxiGlobalRR = 0;
        public const int ipPlateAxiGlobalZZ = 1;
        public const int ipPlateAxiGlobalTT = 2;
        public const int ipPlateAxiGlobalRZ = 3;
        public const int ipPlateAxiGlobalMean = 0;
        public const int ipPlateAxiGlobalDevRR = 1;
        public const int ipPlateAxiGlobalDevZZ = 2;
        public const int ipPlateAxiGlobalDevTT = 3;

        // PLATESTRESS, PLATESTRAIN, PLATECREEPSTRAIN results for STCOMBINED (AXISYMMETRIC)
        public const int ipPlateAxiCombPrincipal11 = 0;
        public const int ipPlateAxiCombPrincipal22 = 1;
        public const int ipPlateAxiCombPrincipal33 = 2;
        public const int ipPlateAxiCombVonMises = 4;
        public const int ipPlateAxiCombTresca = 5;
        public const int ipPlateAxiCombMohrCoulomb = 6;
        public const int ipPlateAxiCombDruckerPrager = 7;
        public const int ipPlateAxiCombMagnitude = 9;
        public const int ipPlateAxiCombPlasticStrain = 6;
        public const int ipPlateAxiCombCreepEffRate = 6;
        public const int ipPlateAxiCombCreepShrinkage = 7;
        public const int ipPlateAxiCombYieldIndex = 8;
        public const int ipPlateAxiCombMean = 0;
        public const int ipPlateAxiCombDev11 = 1;
        public const int ipPlateAxiCombDev22 = 2;
        public const int ipPlateAxiCombDev33 = 3;

        // PLATEPLYSTRESS
        public const int ipPlyStress11 = 0;
        public const int ipPlyStress22 = 1;
        public const int ipPlyStress12 = 3;
        public const int ipPlyILSx = 4;
        public const int ipPlyILSy = 5;
        public const int ipPlyStressPrincipal11 = 6;
        public const int ipPlyStressPrincipal22 = 7;
        public const int ipPlyStressVonMises = 8;
        public const int ipPlyStressTresca = 9;

        // PLATEPLYSTRAIN
        public const int ipPlyStrain11 = 0;
        public const int ipPlyStrain22 = 1;
        public const int ipPlyStrain12 = 3;
        public const int ipPlyStrainPrincipal11 = 6;
        public const int ipPlyStrainPrincipal22 = 7;

        // PLATEPLYRESERVE
        public const int ipPlyMaxStress = 0;
        public const int ipPlyMaxStrain = 1;
        public const int ipPlyTsaiHill = 2;
        public const int ipPlyModTsaiWu = 3;
        public const int ipPlyHoffman = 4;
        public const int ipPlyInterlam = 5;

        // PLATESOIL
        public const int ipPlateSoilTotalPorePressure = 0;
        public const int ipPlateSoilExcessPorePressure = 1;
        public const int ipPlateSoilOCRIndex = 2;
        public const int ipPlateSoilStateIndex = 3;
        public const int ipPlateSoilVoidRatio = 4;

        // PLATEFLUX, PLATEGRADIENT results for STLOCAL
        public const int ipPlateFluxLocalx = 0;
        public const int ipPlateFluxLocaly = 1;
        public const int ipPlateFluxLocalMagxy = 2;

        // PLATEFLUX, PLATEGRADIENT results for STGLOBAL
        public const int ipPlateFluxGlobalX = 0;
        public const int ipPlateFluxGlobalY = 1;
        public const int ipPlateFluxGlobalZ = 2;
        public const int ipPlateFluxGlobalMagXY = 3;
        public const int ipPlateFluxGlobalMagYZ = 4;
        public const int ipPlateFluxGlobalMagZX = 5;
        public const int ipPlateFluxGlobalMagXYZ = 6;

        // PLATEFLUX, PLATEGRADIENT results for STUCS
        public const int ipPlateFluxUCSX = 0;
        public const int ipPlateFluxUCSY = 1;
        public const int ipPlateFluxUCSZ = 2;
        public const int ipPlateFluxUCSMagXY = 3;
        public const int ipPlateFluxUCSMagYZ = 4;
        public const int ipPlateFluxUCSMagZX = 5;
        public const int ipPlateFluxUCSMagXYZ = 6;

        // PLATERCDESIGN
        public const int ipPlateRCWoodArmerMoment = 0;
        public const int ipPlateRCWoodArmerForce = 1;
        public const int ipPlateRCSteelArea = 2;
        public const int ipPlateRCConcreteStrain = 3;
        public const int ipPlateRCSteelAreaLessBase = 4;
        public const int ipPlateRCUserSteelStress = 5;
        public const int ipPlateRCUserConcreteStrain = 6;
        public const int ipPlateRCBlockRatio = 7;

        // PLATEENERGY
        public const int ipPlateEnergyStored = 0;
        public const int ipPlateEnergySpent = 1;

        // BRICKSTRESS, BRICKSTRAIN, BRICKCREEPSTRAIN results for STLOCAL
        public const int ipBrickLocalxx = 0;
        public const int ipBrickLocalyy = 1;
        public const int ipBrickLocalzz = 2;
        public const int ipBrickLocalxy = 3;
        public const int ipBrickLocalyz = 4;
        public const int ipBrickLocalzx = 5;
        public const int ipBrickLocalMean = 0;
        public const int ipBrickLocalDevxx = 1;
        public const int ipBrickLocalDevyy = 2;
        public const int ipBrickLocalDevzz = 3;
        public const int ipBrickFaceSupport = 0;

        // BRICKSTRESS, BRICKSTRAIN, BRICKCREEPSTRAIN results for STGLOBAL
        public const int ipBrickGlobalXX = 0;
        public const int ipBrickGlobalYY = 1;
        public const int ipBrickGlobalZZ = 2;
        public const int ipBrickGlobalXY = 3;
        public const int ipBrickGlobalYZ = 4;
        public const int ipBrickGlobalZX = 5;
        public const int ipBrickGlobalMean = 0;
        public const int ipBrickGlobalDevXX = 1;
        public const int ipBrickGlobalDevYY = 2;
        public const int ipBrickGlobalDevZZ = 3;

        // BRICKSTRESS, BRICKSTRAIN, BRICKCREEPSTRAIN results for STUCS
        public const int ipBrickUCSXX = 0;
        public const int ipBrickUCSYY = 1;
        public const int ipBrickUCSZZ = 2;
        public const int ipBrickUCSXY = 3;
        public const int ipBrickUCSYZ = 4;
        public const int ipBrickUCSZX = 5;

        // BRICKSTRESS, BRICKSTRAIN, BRICKCREEPSTRAIN results for STCOMBINED
        public const int ipBrickCombPrincipal11 = 0;
        public const int ipBrickCombPrincipal22 = 1;
        public const int ipBrickCombPrincipal33 = 2;
        public const int ipBrickCombVonMises = 3;
        public const int ipBrickCombTresca = 4;
        public const int ipBrickCombMohrCoulomb = 5;
        public const int ipBrickCombDruckerPrager = 6;
        public const int ipBrickCombPlasticStrain = 6;
        public const int ipBrickCombCreepEffRate = 6;
        public const int ipBrickCombCreepShrinkage = 7;
        public const int ipBrickCombMean = 7;
        public const int ipBrickCombYieldIndex = 8;
        public const int ipBrickCombMagnitude = 9;
        public const int ipBrickCombDevMean = 0;
        public const int ipBrickCombDev11 = 1;
        public const int ipBrickCombDev22 = 2;
        public const int ipBrickCombDev33 = 3;

        // BRICKSOIL
        public const int ipBrickSoilTotalPorePressure = 0;
        public const int ipBrickSoilExcessPorePressure = 1;
        public const int ipBrickSoilOCRIndex = 2;
        public const int ipBrickSoilStateIndex = 3;
        public const int ipBrickSoilVoidRatio = 4;

        // BRICKFLUX, BRICKGRADIENT results for STLOCAL
        public const int ipBrickFluxLocalx = 0;
        public const int ipBrickFluxLocaly = 1;
        public const int ipBrickFluxLocalz = 2;
        public const int ipBrickFluxLocalMagxy = 3;
        public const int ipBrickFluxLocalMagyz = 4;
        public const int ipBrickFluxLocalMagzx = 5;
        public const int ipBrickFluxLocalMagxyz = 6;

        // BRICKFLUX, BRICKGRADIENT results for STGLOBAL
        public const int ipBrickFluxGlobalX = 0;
        public const int ipBrickFluxGlobalY = 1;
        public const int ipBrickFluxGlobalZ = 2;
        public const int ipBrickFluxGlobalMagXY = 3;
        public const int ipBrickFluxGlobalMagYZ = 4;
        public const int ipBrickFluxGlobalMagZX = 5;
        public const int ipBrickFluxGlobalMagXYZ = 6;

        // BRICKFLUX, BRICKGRADIENT results for STUCS
        public const int ipBrickFluxUCSX = 0;
        public const int ipBrickFluxUCSY = 1;
        public const int ipBrickFluxUCSZ = 2;
        public const int ipBrickFluxUCSMagXY = 3;
        public const int ipBrickFluxUCSMagYZ = 4;
        public const int ipBrickFluxUCSMagZX = 5;
        public const int ipBrickFluxUCSMagXYZ = 6;

        // BRICKENERGY
        public const int ipBrickEnergyStored = 0;
        public const int ipBrickEnergySpent = 1;

        // MODAL RESULTS NFA
        public const int ipFrequencyNFA = 0;
        public const int ipModalMassNFA = 1;
        public const int ipModalStiffNFA = 2;
        public const int ipModalDampNFA = 3;
        public const int ipModalTMassP1 = 4;
        public const int ipModalTMassP2 = 5;
        public const int ipModalTMassP3 = 6;
        public const int ipModalRMassP1 = 7;
        public const int ipModalRMassP2 = 8;
        public const int ipModalRMassP3 = 9;
        public const int ipModalModeD1 = 10;
        public const int ipModalModeD2 = 11;
        public const int ipModalModeD3 = 12;
        public const int ipModalModeR1 = 13;
        public const int ipModalModeR2 = 14;
        public const int ipModalModeR3 = 15;

        // MODAL RESULTS HRA
        public const int ipFrequencyHRA = 0;
        public const int ipDampRatioHRA = 1;
        public const int ipAmplitudeHRA = 2;
        public const int ipPhaseAngleHRA = 3;
        public const int ipMassPartHRA = 4;

        // MODAL RESULTS SRA
        public const int ipFrequencySRA = 0;
        public const int ipSpectralValueSRA = 1;
        public const int ipDampRatioSRA = 2;
        public const int ipAmplitudeSRA = 3;
        public const int ipExcitationSRA = 4;
        public const int ipMassPartSRA = 5;

        // INERTIA RELIEF RESULTS
        public const int ipMassXIRA = 0;
        public const int ipMassYIRA = 1;
        public const int ipMassZIRA = 2;
        public const int ipXcIRA = 3;
        public const int ipYcIRA = 4;
        public const int ipZcIRA = 5;
        public const int ipAccXIRA = 6;
        public const int ipAccYIRA = 7;
        public const int ipAccZIRA = 8;
        public const int ipAngAccXIRA = 9;
        public const int ipAngAccYIRA = 10;
        public const int ipAngAccZIRA = 11;

        // LOAD INFLUENCE RESULT CASE VARIABLE
        public const int ipLIAVarLoadCaseNum = 0;
        public const int ipLIAVarFreedomCaseNum = 1;
        public const int ipLIAVarEntity = 2;
        public const int ipLIAVarEntityNum = 3;
        public const int ipLIAVarUCSId = 4;
        public const int ipLIAVarType = 5;
        public const int ipLIAVarComponent = 6;

        // CONTOUR FILE EXTRAPOLATION
        public const int eoCentroid = 0;
        public const int eoNode = 1;
        public const int eoGaussPoint = 2;

        // CONTOUR FILE AVERAGING
        public const int aoAlways = 0;
        public const int aoNever = 1;
        public const int aoSameProp = 2;
        public const int aoJumps = 3;
        public const int aoJumpsN = 4;
        public const int aoRange = 5;
        public const int aoSamePropAndStage = 6;

        // CONTOUR FILE INDEXES
        public const int ipQuantityRF = 0;
        public const int ipSystemRF = 1;
        public const int ipComponentRF = 2;
        public const int ipLayerRF = 3;
        public const int ipExtrapolateRF = 4;
        public const int ipAverageRF = 5;
        public const int ipAbsoluteRF = 6;
        public const int ipSubtractSupportRF = 7;

        // Coordinate System Types
        public const int csCartesian = 0;
        public const int csCylindrical = 1;
        public const int csSpherical = 2;
        public const int csToroidal = 3;

        // Matrix Types
        public const int mtCompliance = 1;
        public const int mtStiffness = 2;

        // Vertex Types
        public const int vtFree = 1;
        public const int vtFixed = 2;

        // Beam Distributed Load Projection Options
        public const int bpNone = 0;
        public const int bpProjected = 1;

        // Edge Types
        public const int etInterpolated = 0;
        public const int etNonInterpolated = 1;

        // Edge Cluster Origin Types
        public const int coAutoClusterOrigin = 0;
        public const int coManualClusterOrigin = 1;

        // Plate/Face Global Pressure Projection Options
        public const int ppNone = 0;
        public const int ppProjResultant = 1;
        public const int ppProjComponents = 2;

        // Node/Vertex Attribute Types
        public const int aoRestraint = 1;
        public const int aoForce = 2;
        public const int aoMoment = 3;
        public const int aoTemperature = 4;
        public const int aoMTranslation = 5;
        public const int aoMRotation = 6;
        public const int aoKTranslation = 7;
        public const int aoKRotation = 8;
        public const int aoDamping = 9;
        public const int aoNSMass = 10;
        public const int aoNodeInfluence = 11;
        public const int aoNodeHeatSource = 12;
        public const int aoNodeVelocity = 13;
        public const int aoNodeAcceleration = 14;
        public const int aoVertexMeshSize = 20;

        // Beam Attribute Types
        public const int aoBeamAngle = 21;
        public const int aoBeamOffset = 22;
        public const int aoBeamTEndRelease = 23;
        public const int aoBeamREndRelease = 24;
        public const int aoBeamSupport = 25;
        public const int aoBeamPreTension = 26;
        public const int aoCableFreeLength = 27;
        public const int aoBeamDLL = 28;
        public const int aoBeamDLG = 29;
        public const int aoBeamCFL = 30;
        public const int aoBeamCFG = 31;
        public const int aoBeamCML = 32;
        public const int aoBeamCMG = 33;
        public const int aoBeamTempGradient = 34;
        public const int aoBeamConvection = 35;
        public const int aoBeamRadiation = 36;
        public const int aoBeamFlux = 37;
        public const int aoBeamHeatSource = 38;
        public const int aoBeamRadius = 39;
        public const int aoPipePressure = 40;
        public const int aoBeamNSMass = 41;
        public const int aoPipeTemperature = 42;
        public const int aoBeamDML = 44;
        public const int aoBeamStringGroup = 45;
        public const int aoBeamPreCurvature = 46;
        public const int aoBeamTaper = 92;
        public const int aoBeamInfluence = 93;
        public const int aoBeamSectionFactor = 94;
        public const int aoBeamCreepLoadingAge = 95;
        public const int aoBeamEndAttachment = 96;
        public const int aoBeamConnectionUCS = 97;
        public const int aoBeamStageProperty = 98;
        public const int aoBeamSideAttachment = 120;

        // Plate/Edge/Face Attribute Types
        public const int aoPlateAngle = 51;
        public const int aoPlateOffset = 52;
        public const int aoPlatePreLoad = 53;
        public const int aoPlateFacePressure = 54;
        public const int aoPlateFaceShear = 55;
        public const int aoPlateEdgeNormalPressure = 56;
        public const int aoPlateEdgeShear = 57;
        public const int aoPlateEdgeTransverseShear = 58;
        public const int aoPlateTempGradient = 59;
        public const int aoPlateEdgeSupport = 60;
        public const int aoPlateFaceSupport = 61;
        public const int aoPlateEdgeConvection = 62;
        public const int aoPlateEdgeRadiation = 63;
        public const int aoPlateFlux = 64;
        public const int aoPlateHeatSource = 65;
        public const int aoPlateGlobalPressure = 66;
        public const int aoPlateEdgeRelease = 67;
        public const int aoPlateReinforcement = 68;
        public const int aoPlateThickness = 69;
        public const int aoPlateNSMass = 70;
        public const int aoLoadPatch = 71;
        public const int aoPlateEdgeGlobalPressure = 72;
        public const int aoPlatePreCurvature = 73;
        public const int aoPlatePointForce = 99;
        public const int aoPlatePointMoment = 100;
        public const int aoPlateFaceConvection = 101;
        public const int aoPlateFaceRadiation = 102;
        public const int aoPlateInfluence = 103;
        public const int aoPlateSoilStress = 104;
        public const int aoPlateSoilRatio = 105;
        public const int aoPlateCreepLoadingAge = 106;
        public const int aoPlateEdgeAttachment = 107;
        public const int aoPlateFaceAttachment = 108;
        public const int aoPlateStageProperty = 109;
        public const int aoPlateSectionFactor = 121;
        public const int aoPlateCavity = 122;

        // Brick Attribute Types
        public const int aoBrickPressure = 81;
        public const int aoBrickShear = 82;
        public const int aoBrickFaceFoundation = 83;
        public const int aoBrickConvection = 84;
        public const int aoBrickRadiation = 85;
        public const int aoBrickFlux = 86;
        public const int aoBrickHeatSource = 87;
        public const int aoBrickGlobalPressure = 88;
        public const int aoBrickNSMass = 89;
        public const int aoBrickLocalAxes = 90;
        public const int aoBrickPreLoad = 91;
        public const int aoBrickPointForce = 110;
        public const int aoBrickInfluence = 111;
        public const int aoBrickSoilStress = 112;
        public const int aoBrickSoilRatio = 113;
        public const int aoBrickCreepLoadingAge = 114;
        public const int aoBrickFaceAttachment = 115;
        public const int aoBrickStageProperty = 116;
        public const int aoBrickCavity = 123;

        // Path Attribute Types
        public const int aoPathPointForce = 117;
        public const int aoPathDistributedForce = 118;
        public const int aoPathHeatSource = 119;

        // Attribute Deletion and AttributeSequence Indexes
        public const int ipAttrLocal = 0;
        public const int ipAttrAxis = 1;
        public const int ipAttrCase = 2;
        public const int ipAttrID = 3;

        // Marker Types
        public const int mtCircleMarker = 0;
        public const int mtSquareMarker = 1;
        public const int mtTriangleMarker = 2;
        public const int mtRectangleMarker = 3;
        public const int mtEntityHighlight = 4;
        public const int mtBanner = 5;

        // Marker Styles
        public const int msFilled = 0;
        public const int msOutlined = 1;
        public const int msFilledOutlined = 2;

        // Marker Definition Integers Indexes
        public const int ipMarkerType = 0;
        public const int ipMarkerStyle = 1;
        public const int ipMarkerFillColour = 2;
        public const int ipMarkerLineColour = 3;
        public const int ipMarkerLineThickness = 4;
        public const int ipMarkerSize = 5;
        public const int ipMarkerHeight = 6;
        public const int ipMarkerAnchorX = 7;
        public const int ipMarkerAnchorY = 8;
        public const int ipMarkerVisible = 9;
        public const int ipMarkerNumber = 10;
        public const int ipMarkerLabelled = 11;

        // Title Block
        public const int tbTitle = 0;
        public const int tbProject = 1;
        public const int tbReference = 2;
        public const int tbAuthor = 3;
        public const int tbCreated = 4;
        public const int tbModified = 5;

        // Table Types
        public const int ttVsTime = 1;
        public const int ttVsTemperature = 2;
        public const int ttVsFrequency = 3;
        public const int ttStressStrain = 4;
        public const int ttForceDisplacement = 5;
        public const int ttMomentCurvature = 6;
        public const int ttMomentRotation = 8;
        public const int ttAccVsTime = 9;
        public const int ttForceVelocity = 10;
        public const int ttVsPosition = 11;
        public const int ttStrainTime = 12;
        public const int ttDispVsTime = 13;
        public const int ttVelVsTime = 14;
        public const int ttVsVelocity = 15;
        public const int ttTemperatureVsTime = 16;

        // Acceleration Time Table Types
        public const int atModelUnits = 0;
        public const int atGravityUnits = 1;

        // Frequency Table Types
        public const int ftPeriod = 0;
        public const int ftFrequency = 1;

        // Beam Prop Table Entries
        public const int ptBeamStiffModVsTemp = 1001;
        public const int ptBeamAlphaVsTemp = 1002;
        public const int ptBeamConductVsTemp = 1003;
        public const int ptBeamCpVsTemp = 1004;
        public const int ptBeamStiffModVsTime = 1005;
        public const int ptBeamConductVsTime = 1006;
        public const int ptSpringAxialVsDisp = 1007;
        public const int ptSpringTorqueVsTwist = 1008;
        public const int ptSpringAxialVsVelocity = 1009;
        public const int ptBeamStressVsStrain = 1011;
        public const int ptBeamMomentK1 = 1012;
        public const int ptBeamMomentK2 = 1013;
        public const int ptConnectionShear1 = 1014;
        public const int ptConnectionShear2 = 1015;
        public const int ptConnectionAxial = 1016;
        public const int ptConnectionBend1 = 1017;
        public const int ptConnectionBend2 = 1018;
        public const int ptConnectionTorque = 1019;
        public const int ptBeamYieldVsTemp = 1020;

        // Plate Prop Table Entries
        public const int ptPlateModVsTemp = 2001;
        public const int ptPlateAlphaVsTemp = 2002;
        public const int ptPlateConductVsTemp = 2003;
        public const int ptPlateCpVsTemp = 2004;
        public const int ptPlateModVsTime = 2005;
        public const int ptPlateConductVsTime = 2006;
        public const int ptPlateStressVsStrain = 2007;
        public const int ptPlateYieldVsTemp = 2008;

        // Brick Prop Table Entries
        public const int ptBrickModVsTemp = 3001;
        public const int ptBrickAlphaVsTemp = 3002;
        public const int ptBrickConductVsTemp = 3003;
        public const int ptBrickCpVsTemp = 3004;
        public const int ptBrickModVsTime = 3005;
        public const int ptBrickConductVsTime = 3006;
        public const int ptBrickStressVsStrain = 3007;
        public const int ptBrickYieldVsTemp = 3008;

        // Creep Laws
        public const int clConcreteHyperbolic = 0;
        public const int clConcreteViscoChain = 1;
        public const int clConcreteUserDefined = 2;
        public const int clPrimaryPower = 3;
        public const int clSecondaryPower = 4;
        public const int clPrimarySecondaryPower = 5;
        public const int clSecondaryHyperbolic = 6;
        public const int clSecondaryExponential = 7;
        public const int clThetaProjection = 8;
        public const int clGenGraham = 9;
        public const int clGenBlackburn = 10;
        public const int clUserDefined = 11;

        // Load Case Types
        public const int lcNoInertia = 0;
        public const int lcGravity = 1;
        public const int lcAccelerations = 2;
        public const int lcSeismic = 3;

        // Freedom Case Types
        public const int fcNormalFreedom = 0;
        public const int fcFreeBodyInertiaRelief = 1;
        public const int fcSingleSymmetryInertiaXY = 2;
        public const int fcSingleSymmetryInertiaYZ = 3;
        public const int fcSingleSymmetryInertiaZX = 4;
        public const int fcDoubleSymmetryInertiaX = 5;
        public const int fcDoubleSymmetryInertiaY = 6;
        public const int fcDoubleSymmetryInertiaZ = 7;

        // Linear Combination Options
        public const int kNoCombinations = 0;
        public const int kGenerateNewCombinations = 1;
        public const int kUseExistingCombinations = 2;

        // Influence Case Types
        public const int icInfluenceMin = 0;
        public const int icInfluenceMax = 1;

        // Influence Combination Options
        public const int ipInfCaseLabel = 0;
        public const int ipInfCaseVariable = 1;
        public const int ipInfCaseLoadCase = 2;
        public const int ipInfCaseFreedomCase = 3;
        public const int ipInfCaseResponseType = 4;

        // Influence Warning Codes
        public const int wcInfluenceNoWarning = 0;
        public const int wcInfluenceUserTerminated = 1;
        public const int wcInfluenceRanOutOfAttributeID = 2;

        // Harmonic Combination Warning Codes
        public const int wcHarmonicCombineNoWarning = 0;
        public const int wcHarmonicCombineInvalidLSA = 1;

        // Global Load Case
        public const int ipLoadCaseRefTemp = 0;
        public const int ipLoadCaseOrigX = 1;
        public const int ipLoadCaseOrigY = 2;
        public const int ipLoadCaseOrigZ = 3;
        public const int ipLoadCaseAccX = 4;
        public const int ipLoadCaseAccY = 5;
        public const int ipLoadCaseAccZ = 6;
        public const int ipLoadCaseAngVelX = 7;
        public const int ipLoadCaseAngVelY = 8;
        public const int ipLoadCaseAngVelZ = 9;
        public const int ipLoadCaseAngAccX = 10;
        public const int ipLoadCaseAngAccY = 11;
        public const int ipLoadCaseAngAccZ = 12;

        // Global Seismic Load Case
        public const int ipSeismicCaseRefTemp = 0;
        public const int ipSeismicCaseAlpha = 1;
        public const int ipSeismicCasePhi = 2;
        public const int ipSeismicCaseBeta = 3;
        public const int ipSeismicCaseK = 4;
        public const int ipSeismicCaseh0 = 5;
        public const int ipSeismicCaseDir = 6;
        public const int ipSeismicCaseLinAcc = 7;
        public const int ipSeismicCaseV1 = 8;
        public const int ipSeismicCaseV2 = 9;

        // Damping Types
        public const int dtNoDamping = 0;
        public const int dtRayleighDamping = 1;
        public const int dtModalDamping = 2;
        public const int dtPropertyDamping = 3;

        // Rayleigh Modes
        public const int rmSetFrequencies = 0;
        public const int rmSetAlphaBeta = 1;

        // Rayleigh Damping Factors
        public const int ipRayleighF1 = 0;
        public const int ipRayleighF2 = 1;
        public const int ipRayleighR1 = 2;
        public const int ipRayleighR2 = 3;
        public const int ipRayleighAlpha = 0;
        public const int ipRayleighBeta = 1;
        public const int ipRayleighDisplayF1 = 4;
        public const int ipRayleighDisplayF2 = 5;

        // Entity Solver Result Types - HEAT
        public const int hrNodeFlux = 1;
        public const int hrBeamFlux = 2;
        public const int hrPlateFlux = 3;
        public const int hrBrickFlux = 4;
        public const int hrLinkFlux = 22;

        // Entity Solver Result Types - FREQUENCY
        public const int frBeamForcePattern = 5;
        public const int frBeamStrainPattern = 6;
        public const int frPlateStressPattern = 7;
        public const int frPlateStrainPattern = 8;
        public const int frBrickStressPattern = 9;
        public const int frBrickStrainPattern = 10;

        // Entity Solver Result Types - STRUCTURAL
        public const int srNodeReaction = 11;
        public const int srNodeVelocity = 12;
        public const int srNodeAcceleration = 13;
        public const int srBeamForce = 14;
        public const int srBeamMNLStress = 15;
        public const int srBeamStrain = 16;
        public const int srPlateStress = 17;
        public const int srPlateStrain = 18;
        public const int srBrickStress = 19;
        public const int srBrickStrain = 20;
        public const int srElementNodeForce = 21;
        public const int srLinkForce = 23;
        public const int srNodeInertia = 24;

        // Solver Defaults - LOGICALS
        public const int spDoSturm = 1;
        public const int spNonlinearMaterial = 2;
        public const int spUnusedL3 = 3;
        public const int spNonlinearGeometry = 4;
        public const int spUnusedL5 = 5;
        public const int spAddKg = 6;
        public const int spUnusedL7 = 7;
        public const int spCalcDampingRatios = 8;
        public const int spIncludeLinkReactions = 9;
        public const int spFullSystemTransient = 10;
        public const int spNonlinearHeat = 11;
        public const int spLumpedLoadBeam = 12;
        public const int spLumpedLoadPlate = 13;
        public const int spUnusedL14 = 14;
        public const int spLumpedMassBeam = 15;
        public const int spLumpedMassPlate = 16;
        public const int spLumpedMassBrick = 17;
        public const int spForceSingularityCheck = 18;
        public const int spUnusedL19 = 19;
        public const int spSaveRestartFile = 20;
        public const int spSaveIntermediate = 21;
        public const int spExcludeMassX = 22;
        public const int spExcludeMassY = 23;
        public const int spExcludeMassZ = 24;
        public const int spSaveSRSSSpectral = 25;
        public const int spSaveCQCSpectral = 26;
        public const int spDoResidualsCheck = 27;
        public const int spSuppressAllSingularities = 28;
        public const int spAutoPCGIterations = 29;
        public const int spUnusedL30 = 30;
        public const int spReducedLogFile = 31;
        public const int spIncludeRotationalMass = 32;
        public const int spIgnoreCompressiveBeamKg = 33;
        public const int spAutoScaleKg = 34;
        public const int spUnusedL35 = 35;
        public const int spScaleSupports = 36;
        public const int spAutoShift = 37;
        public const int spSaveTableInsertedSteps = 38;
        public const int spSaveLastRestartStep = 39;
        public const int spUnusedL40 = 40;
        public const int spDoInstantNTA = 41;
        public const int spAllowExtraIterations = 42;
        public const int spPredictImpact = 43;
        public const int spAutoWorkingSet = 44;
        public const int spDampingForce = 45;
        public const int spLimitDisplacementNLA = 46;
        public const int spLimitRotationNLA = 47;
        public const int spSaveFinalSubStep = 48;
        public const int spCablesAsMultiCase = 49;
        public const int spShowMessages = 50;
        public const int spShowProgress = 51;
        public const int spShowConvergenceGraph = 52;
        public const int spUnusedL53 = 53;
        public const int spSpectralBaseExcitation = 54;
        public const int spSpectralLoadExcitation = 55;
        public const int spLegacyMaxStress = 56;
        public const int spCheckEigenvector = 57;
        public const int spAppendRemainingTime = 58;
        public const int spIncludeFollowerLoadKG = 59;
        public const int spInertiaForce = 60;
        public const int spSolverGeneratesCombinations = 61;
        public const int spAutoNewmarkAlpha = 62;

        // Solver Defaults - INTEGERS
        public const int spTreeStartNumber = 1;
        public const int spNumFrequency = 2;
        public const int spNumBucklingModes = 3;
        public const int spMaxIterationEig = 4;
        public const int spMaxIterationNonlin = 5;
        public const int spNumBeamSlicesModal = 6;
        public const int spMaxConjugateGradientIter = 7;
        public const int spMaxNumRepeatedMessages = 8;
        public const int spFiniteStrainDefinition = 9;
        public const int spBeamLength = 10;
        public const int spFormStiffMatrix = 11;
        public const int spMaxUpdateInterval = 12;
        public const int spFormNonlinHeatStiffMatrix = 13;
        public const int spExpandWorkingSet = 14;
        public const int spMinNumViscoUnits = 15;
        public const int spMaxNumViscoUnits = 16;
        public const int spCurveFitTimeUnit = 17;
        public const int spStaticAutoStepping = 18;
        public const int spBeamKgType = 19;
        public const int spDynamicAutoStepping = 20;
        public const int spMaxIterationHeat = 21;

        // Solver Defaults - DOUBLES
        public const int spEigenTolerance = 1;
        public const int spFrequencyShift = 2;
        public const int spBucklingShift = 3;
        public const int spNonlinDispTolerance = 4;
        public const int spNonlinResidualTolerance = 5;
        public const int spTransientReferenceTemperature = 6;
        public const int spRelaxationFactor = 7;
        public const int spNonlinHeatTolerance = 8;
        public const int spMinimumTimeStep = 9;
        public const int spWilsonTheta = 10;
        public const int spNewmarkBeta = 11;
        public const int spGlobalZeroDiagonal = 12;
        public const int spConjugateGradientTol = 13;
        public const int spMinimumDimension = 14;
        public const int spMinimumInternalAngle = 15;
        public const int spZeroForce = 16;
        public const int spZeroDiagonal = 17;
        public const int spZeroContactFactor = 18;
        public const int spUnusedD19 = 19;
        public const int spZeroTranslation = 20;
        public const int spZeroRotation = 21;
        public const int spDrillStiffFactorQ8 = 22;
        public const int spUnusedD23 = 23;
        public const int spMaxNormalsAngle = 24;
        public const int spUnusedD25 = 25;
        public const int spMaximumRotation = 26;
        public const int spZeroDisplacement = 27;
        public const int spMaximumDispRatio = 28;
        public const int spMinimumLoadReductionFactor = 29;
        public const int spMaxDispChange = 30;
        public const int spMaxResidualChange = 31;
        public const int spZeroFrequency = 32;
        public const int spZeroBucklingEigen = 33;
        public const int spCurveFitTime = 34;
        public const int spSpacingBias = 35;
        public const int spTimeStepParam = 36;
        public const int spUnusedD37 = 37;
        public const int spMNLTangentRatio = 38;
        public const int spUnusedD39 = 39;
        public const int spMinArcLengthFactor = 40;
        public const int spMaxFibreStrainInc = 41;
        public const int spMaxDisplacementNLA = 42;
        public const int spMaxRotationNLA = 43;
        public const int spClusterZeroDiagonal = 44;
        public const int spUpdateDirContactCheckPoint = 45;
        public const int spFrictionModulusRatio = 46;
        public const int spNewmarkAlpha = 47;
        public const int spDrillStiffFactorQ4 = 48;
        public const int spDrillStiffFactorT3 = 49;
        public const int spCavityVolumeAveraging = 50;
        public const int spMaxDynamicPointContactFactor = 51;
        public const int spMaxEigenRatio = 52;
        public const int spZeroModalDisp = 53;
        public const int spSupportUpdate = 54;

        // Solver Parameters Constants - spBeamKgType
        public const int scSimplifiedBeamKg = 0;
        public const int scCompleteBeamKg = 1;

        // Solver Parameters Constants - spBeamLength
        public const int scInitialBeamLength = 0;
        public const int scUpdatedBeamLength = 1;

        // Solver Parameters Constants - spStaticAutoStepping
        public const int scStaticAutoStepNone = 0;
        public const int scStaticAutoStepLoad = 1;
        public const int scStaticAutoStepDispLoad = 2;
        public const int scStaticAutoStepDispDisp = 3;
        public const int scStaticAutoStepDispArc = 4;

        // Solver Parameters Constants - spDynamicAutoStepping
        public const int scDynamicAutoStepNone = 0;
        public const int scDynamicAutoStepTime = 1;
        public const int scDynamicAutoStepDispTime = 2;
        public const int scDynamicAutoStepDispDisp = 3;

        // Solver Parameters Constants - spFiniteStrainDefinition
        public const int scFiniteStrainNominal = 0;
        public const int scFiniteStrainEng = 1;
        public const int scFiniteStrainGreen = 2;

        // Solver Parameters Constants - spFormNonlinHeatStiffMatrix
        public const int scHeatMatrixEveryRow = 0;
        public const int scHeatMatrixSavedStep = 1;
        public const int scHeatMatrixEveryStep = 2;

        // Solver Parameters Constants - spFormStiffMatrix
        public const int scStiffnessMatrixEveryIteration = 0;
        public const int scStiffnessMatrixTwoIterations = 1;
        public const int scStiffnessMatrixOneIteration = 2;
        public const int scStiffnessMatrixAutomatic = 3;

        // Spectral Base Load Types
        public const int slBaseAcc = 0;
        public const int slBaseVel = 1;
        public const int slBaseDisp = 2;
        public const int slAppliedLoad = 3;

        // Harmonic Load Types
        public const int hlBaseAcc = 0;
        public const int hlBaseVel = 1;
        public const int hlBaseDisp = 2;
        public const int hlAppliedLoad = 3;

        // Transient Base Excitation Types
        public const int beNone = 0;
        public const int beAcceleration = 1;
        public const int beVelocity = 2;
        public const int beDisplacement = 3;

        // Harmonic Modes
        public const int hmVsFrequency = 0;
        public const int hmVsTime = 1;

        // Solver Matrix Schemes
        public const int stSkyline = 0;
        public const int stSparse = 1;
        public const int stIterativePCG = 3;

        // Solver Temperature Dependence Types
        public const int tdNone = 0;
        public const int tdCombined = 1;

        // Result File Open Indexes
        public const int ipHideUnconvergedLBA = 1;
        public const int ipHideNegativeLBA = 2;
        public const int ipHideUnconvergedNFA = 3;
        public const int ipHideZeroNFA = 4;
        public const int ipHideModalSRA = 5;
        public const int ipHideUnconvergedNLA = 6;
        public const int ipHideSubStepNLA = 7;
        public const int ipHideUnconvergedNTA = 8;
        public const int ipHideSubStepNTA = 9;
        public const int ipHideUnconvergedQSA = 10;
        public const int ipHideSubStepQSA = 11;

        // Sort Types
        public const int rnNone = 0;
        public const int rnTree = 1;
        public const int rnGeometry = 2;
        public const int rnAMD = 3;

        // Utility
        public const int ztAbsolute = 0;
        public const int ztRelative = 1;

        // Boolean Types
        public const int btFalse = 0;
        public const int btTrue = 1;

        // Error Codes
        public const int ERR7_APIAlreadyInitialised = -12;
        public const int ERR7_LoginExceeded = -11;
        public const int ERR7_CannotCommunicate = -10;
        public const int ERR7_CannotFindNetworkLock = -9;
        public const int ERR7_CannotFindStandaloneLock = -8;
        public const int ERR7_CannotInitialiseDirectX = -7;
        public const int ERR7_InvalidRegionalSettings = -6;
        public const int ERR7_InvalidDLLsPresent = -5;
        public const int ERR7_APINotInitialised = -4;
        public const int ERR7_InvalidErrorCode = -3;
        public const int ERR7_APIModuleNotLicensed = -2;
        public const int ERR7_UnknownError = -1;
        public const int ERR7_NoError = 0;
        public const int ERR7_FileAlreadyOpen = 1;
        public const int ERR7_FileNotFound = 2;
        public const int ERR7_FileNotSt7 = 3;
        public const int ERR7_InvalidFileName = 4;
        public const int ERR7_FileIsNewer = 5;
        public const int ERR7_CannotReadFile = 6;
        public const int ERR7_InvalidScratchPath = 7;
        public const int ERR7_FileNotOpen = 8;
        public const int ERR7_ExceededTotal = 9;
        public const int ERR7_DataNotFound = 10;
        public const int ERR7_InvalidResultFile = 11;
        public const int ERR7_ResultFileNotOpen = 12;
        public const int ERR7_ExceededResultCase = 13;
        public const int ERR7_UnknownResultType = 14;
        public const int ERR7_UnknownResultLocation = 15;
        public const int ERR7_UnknownSurfaceLocation = 16;
        public const int ERR7_UnknownProperty = 17;
        public const int ERR7_InvalidEntity = 18;
        public const int ERR7_InvalidBeamPosition = 19;
        public const int ERR7_InvalidLoadCase = 20;
        public const int ERR7_InvalidFreedomCase = 21;
        public const int ERR7_UnknownTitle = 22;
        public const int ERR7_InvalidResOptsNFADisp = 23;
        public const int ERR7_TooManyBeamStations = 24;
        public const int ERR7_UnknownSubType = 25;
        public const int ERR7_GroupIdDoesNotExist = 26;
        public const int ERR7_InvalidFileUnit = 27;
        public const int ERR7_CannotSaveFile = 28;
        public const int ERR7_ResultFileIsOpen = 29;
        public const int ERR7_InvalidUnits = 30;
        public const int ERR7_InvalidEntityNodes = 31;
        public const int ERR7_InvalidUCSType = 32;
        public const int ERR7_InvalidUCSId = 33;
        public const int ERR7_UCSIdAlreadyExists = 34;
        public const int ERR7_CaseNameAlreadyExists = 35;
        public const int ERR7_InvalidEntityNumber = 36;
        public const int ERR7_InvalidBeamEnd = 37;
        public const int ERR7_InvalidBeamDir = 38;
        public const int ERR7_InvalidPlateEdge = 39;
        public const int ERR7_InvalidBrickFace = 40;
        public const int ERR7_InvalidBeamType = 41;
        public const int ERR7_InvalidPlateType = 42;
        public const int ERR7_InvalidMaterialType = 43;
        public const int ERR7_PropertyAlreadyExists = 44;
        public const int ERR7_InvalidBeamSectionType = 45;
        public const int ERR7_PropertyNotSpring = 46;
        public const int ERR7_PropertyNotCable = 47;
        public const int ERR7_PropertyNotTruss = 48;
        public const int ERR7_PropertyNotCutOffBar = 49;
        public const int ERR7_PropertyNotPointContact = 50;
        public const int ERR7_PropertyNotBeam = 51;
        public const int ERR7_PropertyNotPipe = 52;
        public const int ERR7_PropertyNotConnectionBeam = 53;
        public const int ERR7_InvalidSectionParameters = 54;
        public const int ERR7_PropertyNotUserDefinedBeam = 55;
        public const int ERR7_MaterialIsUserDefined = 56;
        public const int ERR7_MaterialNotIsotropic = 57;
        public const int ERR7_MaterialNotOrthotropic = 58;
        public const int ERR7_InvalidRubberModel = 59;
        public const int ERR7_MaterialNotRubber = 60;
        public const int ERR7_InvalidSectionProperties = 61;
        public const int ERR7_PlateDoesNotHaveThickness = 62;
        public const int ERR7_IncompatibleMaterialCombination = 63;
        public const int ERR7_InvalidSolverType = 64;
        public const int ERR7_InvalidSolverMode = 65;
        public const int ERR7_InvalidMirrorOption = 66;
        public const int ERR7_SectionCannotBeMirrored = 67;
        public const int ERR7_InvalidTableType = 68;
        public const int ERR7_InvalidTableName = 69;
        public const int ERR7_TableNameAlreadyExists = 70;
        public const int ERR7_InvalidNumberOfEntries = 71;
        public const int ERR7_InvalidToleranceType = 72;
        public const int ERR7_TableDoesNotExist = 73;
        public const int ERR7_NotFrequencyTable = 74;
        public const int ERR7_InvalidFrequencyType = 75;
        public const int ERR7_InvalidTableSetting = 76;
        public const int ERR7_IncompatibleTableType = 77;
        public const int ERR7_IncompatibleCriterionCombination = 78;
        public const int ERR7_InvalidModalFile = 79;
        public const int ERR7_InvalidCombinationCaseNumber = 80;
        public const int ERR7_InvalidInitialCaseNumber = 81;
        public const int ERR7_InvalidInitialFile = 82;
        public const int ERR7_InvalidModeNumber = 83;
        public const int ERR7_BeamIsNotBXS = 84;
        public const int ERR7_InvalidDampingType = 85;
        public const int ERR7_InvalidRayleighMode = 86;
        public const int ERR7_CannotReadBXS = 87;
        public const int ERR7_InvalidResultType = 88;
        public const int ERR7_InvalidSolverParameter = 89;
        public const int ERR7_InvalidModalLoadType = 90;
        public const int ERR7_InvalidTimeRow = 91;
        public const int ERR7_SparseSolverModuleNotLicensed = 92;
        public const int ERR7_InvalidSolverScheme = 93;
        public const int ERR7_InvalidSortOption = 94;
        public const int ERR7_IncompatibleResultFile = 95;
        public const int ERR7_InvalidLinkType = 96;
        public const int ERR7_InvalidLinkData = 97;
        public const int ERR7_OnlyOneLoadCase = 98;
        public const int ERR7_OnlyOneFreedomCase = 99;
        public const int ERR7_InvalidLoadID = 100;
        public const int ERR7_InvalidBeamLoadType = 101;
        public const int ERR7_InvalidStringID = 102;
        public const int ERR7_InvalidPatchType = 103;
        public const int ERR7_IncrementDoesNotExist = 104;
        public const int ERR7_InvalidLoadCaseType = 105;
        public const int ERR7_InvalidFreedomCaseType = 106;
        public const int ERR7_InvalidHarmonicLoadType = 107;
        public const int ERR7_InvalidTemperatureType = 108;
        public const int ERR7_InvalidPatchTypeForPlate = 109;
        public const int ERR7_InvalidAttributeType = 110;
        public const int ERR7_MaterialNotAnisotropic = 111;
        public const int ERR7_InvalidMatrixType = 112;
        public const int ERR7_MaterialNotUserDefined = 113;
        public const int ERR7_InvalidIndex = 114;
        public const int ERR7_InvalidContactType = 115;
        public const int ERR7_InvalidContactSubType = 116;
        public const int ERR7_InvalidCutoffType = 117;
        public const int ERR7_ResultQuantityNotAvailable = 118;
        public const int ERR7_YieldNotMCDP = 119;
        public const int ERR7_CombinationDoesNotExist = 120;
        public const int ERR7_InvalidSeismicCase = 121;
        public const int ERR7_InvalidImportExportMode = 122;
        public const int ERR7_CannotReadImportFile = 123;
        public const int ERR7_InvalidAnsysImportFormat = 124;
        public const int ERR7_InvalidAnsysArrayStatus = 125;
        public const int ERR7_CannotWriteExportFile = 126;
        public const int ERR7_InvalidAnsysExportFormat = 127;
        public const int ERR7_InvalidAnsysEndReleaseOption = 128;
        public const int ERR7_InvalidAnsysExportUnits = 129;
        public const int ERR7_InvalidSt7ExportFormat = 130;
        public const int ERR7_InvalidUVPos = 131;
        public const int ERR7_InvalidResponseType = 132;
        public const int ERR7_InvalidLayoutID = 133;
        public const int ERR7_InvalidPlateSurface = 134;
        public const int ERR7_MeshingErrors = 135;
        public const int ERR7_InvalidTolerance = 136;
        public const int ERR7_InvalidTaperAxis = 137;
        public const int ERR7_InvalidTaperType = 138;
        public const int ERR7_InvalidTaperRatio = 139;
        public const int ERR7_InvalidPositionType = 140;
        public const int ERR7_InvalidPreLoadType = 141;
        public const int ERR7_InvalidVertexType = 142;
        public const int ERR7_InvalidVertexMeshSize = 143;
        public const int ERR7_InvalidGeometryEdgeType = 144;
        public const int ERR7_InvalidPropertyNumber = 145;
        public const int ERR7_InvalidFaceSurface = 146;
        public const int ERR7_InvalidModType = 147;
        public const int ERR7_MaterialNotSoil = 148;
        public const int ERR7_MaterialNotFluid = 149;
        public const int ERR7_SoilTypeNotDC = 150;
        public const int ERR7_SoilTypeNotCC = 151;
        public const int ERR7_MaterialNotLaminate = 152;
        public const int ERR7_InvalidLaminateID = 153;
        public const int ERR7_LaminateNameAlreadyExists = 154;
        public const int ERR7_LaminateIDAlreadyExists = 155;
        public const int ERR7_PlyDoesNotExist = 156;
        public const int ERR7_ExceededMaxNumPlies = 157;
        public const int ERR7_LayoutIDAlreadyExists = 158;
        public const int ERR7_InvalidNumModes = 159;
        public const int ERR7_InvalidLTAMethod = 160;
        public const int ERR7_InvalidLTASolutionType = 161;
        public const int ERR7_ExceededMaxNumStages = 162;
        public const int ERR7_StageDoesNotExist = 163;
        public const int ERR7_ExceededMaxNumSpectralCases = 164;
        public const int ERR7_InvalidSpectralCase = 165;
        public const int ERR7_InvalidSpectrumType = 166;
        public const int ERR7_InvalidResultsSign = 167;
        public const int ERR7_InvalidPositionTableAxis = 168;
        public const int ERR7_InvalidInitialConditionsType = 169;
        public const int ERR7_ExceededMaxNumNodeHistory = 170;
        public const int ERR7_NodeHistoryDoesNotExist = 171;
        public const int ERR7_InvalidTransientTempType = 172;
        public const int ERR7_InvalidTimeUnit = 173;
        public const int ERR7_InvalidLoadPath = 174;
        public const int ERR7_InvalidTempDependenceType = 175;
        public const int ERR7_InvalidTrigType = 176;
        public const int ERR7_InvalidUserEquation = 177;
        public const int ERR7_InvalidCreepID = 178;
        public const int ERR7_CreepIDAlreadyExists = 179;
        public const int ERR7_InvalidCreepLaw = 180;
        public const int ERR7_InvalidCreepHardeningLaw = 181;
        public const int ERR7_InvalidCreepViscoChainRow = 182;
        public const int ERR7_InvalidCreepFunctionType = 183;
        public const int ERR7_InvalidCreepShrinkageType = 184;
        public const int ERR7_InvalidTableRow = 185;
        public const int ERR7_ExceededMaxNumRows = 186;
        public const int ERR7_InvalidLoadPathTemplateID = 187;
        public const int ERR7_LoadPathTemplateIDAlreadyExists = 188;
        public const int ERR7_InvalidLoadPathLane = 189;
        public const int ERR7_ExceededMaxNumLoadPathTemplates = 190;
        public const int ERR7_ExceededMaxNumLoadPathVehicles = 191;
        public const int ERR7_InvalidLoadPathVehicle = 192;
        public const int ERR7_InvalidMobilityType = 193;
        public const int ERR7_InvalidAxisSystem = 194;
        public const int ERR7_InvalidLoadPathID = 195;
        public const int ERR7_LoadPathIDAlreadyExists = 196;
        public const int ERR7_InvalidPathDefinition = 197;
        public const int ERR7_InvalidLoadPathShape = 198;
        public const int ERR7_InvalidLoadPathSurface = 199;
        public const int ERR7_InvalidNumPathDivs = 200;
        public const int ERR7_InvalidGeometryCavityLoop = 201;
        public const int ERR7_InvalidLimitEnvelope = 202;
        public const int ERR7_ExceededMaxNumLimitEnvelopes = 203;
        public const int ERR7_InvalidCombEnvelope = 204;
        public const int ERR7_ExceededMaxNumCombEnvelopes = 205;
        public const int ERR7_InvalidFactorsEnvelope = 206;
        public const int ERR7_ExceededMaxNumFactorsEnvelopes = 207;
        public const int ERR7_InvalidLimitEnvelopeType = 208;
        public const int ERR7_InvalidCombEnvelopeType = 209;
        public const int ERR7_InvalidFactorsEnvelopeType = 210;
        public const int ERR7_InvalidCombEnvelopeAccType = 211;
        public const int ERR7_InvalidEnvelopeSet = 212;
        public const int ERR7_ExceededMaxNumEnvelopeSets = 213;
        public const int ERR7_InvalidEnvelopeSetType = 214;
        public const int ERR7_InvalidCombResFile = 215;
        public const int ERR7_ExceededMaxNumCombResFiles = 216;
        public const int ERR7_CannotCombResFiles = 217;
        public const int ERR7_InvalidStartEndTimes = 218;
        public const int ERR7_InvalidNumSteps = 219;
        public const int ERR7_InvalidLibraryPath = 220;
        public const int ERR7_InvalidLibraryType = 221;
        public const int ERR7_InvalidLibraryID = 222;
        public const int ERR7_InvalidLibraryName = 223;
        public const int ERR7_InvalidLibraryItemID = 224;
        public const int ERR7_InvalidLibraryItemName = 225;
        public const int ERR7_InvalidDisplayOptionsPath = 226;
        public const int ERR7_InvalidSolverPath = 227;
        public const int ERR7_InvalidCementHardeningType = 228;
        public const int ERR7_NoPlateElements = 229;
        public const int ERR7_CannotMakeBXS = 230;
        public const int ERR7_CannotCalculateBXSData = 231;
        public const int ERR7_InvalidSurfaceMeshTargetType = 232;
        public const int ERR7_InvalidModalNodeReactType = 233;
        public const int ERR7_InvalidAxis = 234;
        public const int ERR7_InvalidBeamAxisType = 235;
        public const int ERR7_InvalidStaadCountryCodeOption = 236;
        public const int ERR7_InvalidGeometryFormatProtocol = 237;
        public const int ERR7_InvalidDXFBeamOption = 238;
        public const int ERR7_InvalidDXFPlateOption = 239;
        public const int ERR7_InvalidLoadPathLaneFactorType = 240;
        public const int ERR7_InvalidLoadPathVehicleInstance = 241;
        public const int ERR7_InvalidNumBeamStations = 242;
        public const int ERR7_ResFileUnsupportedType = 243;
        public const int ERR7_ResFileAlreadyOpen = 244;
        public const int ERR7_ResFileInvalidNumCases = 245;
        public const int ERR7_ResFileNotOpen = 246;
        public const int ERR7_ResFileInvalidCase = 247;
        public const int ERR7_ResFileDoesNotHaveEntity = 248;
        public const int ERR7_ResFileInvalidQuantity = 249;
        public const int ERR7_ResFileQuantityNotExist = 250;
        public const int ERR7_ResFileCantSave = 251;
        public const int ERR7_ResFileCantClearQuantity = 252;
        public const int ERR7_ResFileContainsNoElements = 253;
        public const int ERR7_ResFileContainsNoNodes = 254;
        public const int ERR7_InvalidName = 255;
        public const int ERR7_ResFileAssociationNotAllowed = 256;
        public const int ERR7_ResFileIncompatibleQuantity = 257;
        public const int ERR7_CannotEditSolverFiles = 258;
        public const int ERR7_CannotOpenResultFile = 259;
        public const int ERR7_CouldNotShowModelWindow = 260;
        public const int ERR7_ModelWindowWasNotShowing = 261;
        public const int ERR7_CantDoWithModalWindows = 262;
        public const int ERR7_InvalidSelectionEndEdgeFace = 263;
        public const int ERR7_CouldNotCreateModelWindow = 264;
        public const int ERR7_ModelWindowWasNotCreated = 265;
        public const int ERR7_InvalidImageType = 266;
        public const int ERR7_InvalidImageDimensions = 267;
        public const int ERR7_ErrorCreatingImage = 268;
        public const int ERR7_CannotSaveImageFile = 269;
        public const int ERR7_InvalidWindowDimensions = 270;
        public const int ERR7_InvalidResultQuantity = 271;
        public const int ERR7_InvalidResultSubQuantity = 272;
        public const int ERR7_InvalidComponent = 273;
        public const int ERR7_ResultIsNotAvailable = 274;
        public const int ERR7_InvalidUCSIndex = 275;
        public const int ERR7_InvalidDiagramAxis = 276;
        public const int ERR7_InvalidVectorComponents = 277;
        public const int ERR7_TableTypeIsNotTimeBased = 278;
        public const int ERR7_InvalidTableID = 279;
        public const int ERR7_LinkNotMasterSlave = 280;
        public const int ERR7_LinkNotSectorSymmetry = 281;
        public const int ERR7_LinkNotCoupling = 282;
        public const int ERR7_LinkNotPinned = 283;
        public const int ERR7_LinkNotRigid = 284;
        public const int ERR7_LinkNotShrink = 285;
        public const int ERR7_LinkNotTwoPoint = 286;
        public const int ERR7_LinkNotAttachment = 287;
        public const int ERR7_LinkNotMultiPoint = 288;
        public const int ERR7_InvalidCoupleType = 289;
        public const int ERR7_InvalidRigidPlane = 290;
        public const int ERR7_InvalidMultiPointType = 291;
        public const int ERR7_InvalidMultiPointLink = 292;
        public const int ERR7_InvalidAttachmentType = 293;
        public const int ERR7_ExceededMaxNumColumns = 294;
        public const int ERR7_CouldNotDestroyModelWindow = 295;
        public const int ERR7_CannotSetWindowParent = 296;
        public const int ERR7_InvalidLoadCaseFilePath = 297;
        public const int ERR7_InvalidStaadLengthUnit = 298;
        public const int ERR7_InvalidStaadForceUnit = 299;
        public const int ERR7_InvalidDuplicateFaceType = 300;
        public const int ERR7_InvalidNodeCoordinateKeepType = 301;
        public const int ERR7_CommentDoesNotExist = 302;
        public const int ERR7_InvalidFilePath = 303;
        public const int ERR7_InvalidContactYieldType = 304;
        public const int ERR7_InvalidNumMeshingLoops = 305;
        public const int ERR7_InvalidMeshPositionOnUCS = 306;
        public const int ERR7_InvalidK0Expression = 307;
        public const int ERR7_InvalidK1Expression = 308;
        public const int ERR7_InvalidNumCopies = 309;
        public const int ERR7_InvalidCurvedPipesAsOption = 310;
        public const int ERR7_InvalidResOptsRotationUnit = 311;
        public const int ERR7_RayleighNotApplicable = 312;
        public const int ERR7_InvalidAttributeSetting = 313;
        public const int ERR7_InvalidToolOptsZipOptions = 314;
        public const int ERR7_InvalidToolOptsSubdivideOptions = 315;
        public const int ERR7_InvalidToolOptsCopyOptions = 316;
        public const int ERR7_InvalidBackgroundMode = 317;
        public const int ERR7_InvalidAttachPartsParams = 318;
        public const int ERR7_InvalidDrawParameters = 319;
        public const int ERR7_FilesStillOpen = 320;
        public const int ERR7_SolverStillRunning = 321;
        public const int ERR7_InvalidFaceFromBeamPolygonParameters = 322;
        public const int ERR7_InvalidResOptsStrainUnit = 323;
        public const int ERR7_FunctionNotSupported = 324;
        public const int ERR7_SoilTypeNotMC = 325;
        public const int ERR7_SoilTypeNotDP = 326;
        public const int ERR7_TooManyAnimations = 327;
        public const int ERR7_InvalidAnimationFile = 328;
        public const int ERR7_InvalidAnimationMode = 329;
        public const int ERR7_InsufficientFrames = 330;
        public const int ERR7_AnimationDimensionsTooSmall = 331;
        public const int ERR7_AnimationDimensionsTooLarge = 332;
        public const int ERR7_ReducedAnimation = 333;
        public const int ERR7_InvalidAnimationType = 334;
        public const int ERR7_InvalidEntityID = 335;
        public const int ERR7_CouldNotSaveAnimationFile = 336;
        public const int ERR7_AnimationHandleOutOfRange = 337;
        public const int ERR7_AnimationNotRunning = 338;
        public const int ERR7_SoilTypeNotLS = 339;
        public const int ERR7_InvalidPlane = 340;
        public const int ERR7_InvalidAlphaTempType = 341;
        public const int ERR7_InvalidGravityDirection = 342;
        public const int ERR7_InvalidAttachmentDirection = 343;
        public const int ERR7_InvalidHardeningType = 344;
        public const int ERR7_ResultCaseNotInertiaRelief = 345;
        public const int ERR7_InvalidNumLayers = 346;
        public const int ERR7_PlateDoesNotHaveLayers = 347;
        public const int ERR7_OperationFailed = 348;
        public const int ERR7_InvalidEntityContourFileType = 349;
        public const int ERR7_InvalidBrickIntegrationPoints = 350;
        public const int ERR7_InvalidDirection = 351;
        public const int ERR7_InvalidAttachConnectionType = 352;
        public const int ERR7_CannotSaveIniFile = 353;
        public const int ERR7_InvalidDivisionParameters = 354;
        public const int ERR7_InvalidContourIndex = 355;
        public const int ERR7_InvalidProjectFlag = 356;
        public const int ERR7_InvalidSegmentsPerCircle = 357;
        public const int ERR7_InvalidArcLength = 358;
        public const int ERR7_InvalidDivisionTargets = 359;
        public const int ERR7_InvalidProcessingMode = 360;
        public const int ERR7_InvalidDigits = 361;
        public const int ERR7_InvalidNumericStyle = 362;
        public const int ERR7_InvalidExponentFormat = 363;
        public const int ERR7_InvalidExportParameters = 364;
        public const int ERR7_InsituCalculationFailed = 365;
        public const int ERR7_ModelMixesAxiNonAxi = 366;
        public const int ERR7_InvalidInsituRunMode = 367;
        public const int ERR7_InvalidGradeType = 368;
        public const int ERR7_InvalidGradeRatio = 369;
        public const int ERR7_InvalidSplitData = 370;
        public const int ERR7_CannotMorphEdges = 371;
        public const int ERR7_TJunctionsFound = 372;
        public const int ERR7_FreeEdgesFound = 373;
        public const int ERR7_InvalidSTLFileFormat = 374;
        public const int ERR7_InvalidSTLGroupingOption = 375;
        public const int ERR7_InvalidSTLBeamOption = 376;
        public const int ERR7_InvalidSTLPlateOption = 377;
        public const int ERR7_InvalidNodeExtrudeTarget = 378;
        public const int ERR7_InvalidBeamExtrudeTarget = 379;
        public const int ERR7_InvalidLinkTarget = 380;
        public const int ERR7_InvalidSourceAction = 381;
        public const int ERR7_InvalidLinePoints = 382;
        public const int ERR7_InvalidLineID = 383;
        public const int ERR7_InvalidPlanePoints = 384;
        public const int ERR7_InvalidPlaneID = 385;
        public const int ERR7_InvalidSortMethod = 386;
        public const int ERR7_InvalidDirectionVector = 387;
        public const int ERR7_InvalidRCLayers = 388;
        public const int ERR7_InvalidConnectionType = 389;
        public const int ERR7_InvalidQuadraticAsOption = 390;
        public const int ERR7_InvalidGeometryAsOption = 391;
        public const int ERR7_InvalidSplitRatio = 392;
        public const int ERR7_InvalidLength = 393;
        public const int ERR7_InvalidEdgeTolerance = 394;
        public const int ERR7_InvalidRadius = 395;
        public const int ERR7_IncompatibleSections = 396;
        public const int ERR7_UCSMustBeDifferent = 397;
        public const int ERR7_InvalidNumCutFaces = 398;
        public const int ERR7_InvalidNumRepeats = 399;
        public const int ERR7_InvalidP1P2 = 400;
        public const int ERR7_InvalidP1P2P3 = 401;
        public const int ERR7_InvalidP1P2P3P4 = 402;
        public const int ERR7_IntersectionNotFound = 403;
        public const int ERR7_CantGenerateFillet = 404;
        public const int ERR7_InvalidR1R2 = 405;
        public const int ERR7_InvalidR2 = 406;
        public const int ERR7_InvalidPLTarget = 407;
        public const int ERR7_InvalidScaleAbout = 408;
        public const int ERR7_InvalidProjectionDirection = 409;
        public const int ERR7_InvalidCollectionID = 410;
        public const int ERR7_InvalidDivisions = 411;
        public const int ERR7_InvalidLineDefinition = 412;
        public const int ERR7_InvalidOriginMethod = 413;
        public const int ERR7_InvalidInfluenceFile = 414;
        public const int ERR7_InvalidResponseVariable = 415;
        public const int ERR7_NoMultiVariableInfluenceCases = 416;
        public const int ERR7_InvalidMultiVariableCaseID = 417;
        public const int ERR7_InvalidMultiVariableType = 418;
        public const int ERR7_NoInfluenceCombinationsDefined = 419;
        public const int ERR7_NothingSelected = 420;
        public const int ERR7_InvalidPasteOption = 421;
        public const int ERR7_InvalidResultCase = 422;
        public const int ERR7_InvalidEntitySet = 423;
        public const int ERR7_InvalidResOptsReactionLinkGNL = 424;
        public const int ERR7_FileIsProtected = 425;
        public const int ERR7_InvalidHRAMode = 426;
        public const int ERR7_InvalidBGLData = 427;
        public const int ERR7_InvalidWindowMode = 428;
        public const int ERR7_UnexpectedSolverTermination = 429;
        public const int ERR7_InvalidReferenceNode = 430;
        public const int ERR7_InvalidDetachMode = 431;
        public const int ERR7_InvalidResOptsBaseMode = 432;
        public const int ERR7_InvalidMarkerType = 433;
        public const int ERR7_InvalidMarkerStyle = 434;
        public const int ERR7_InvalidMarkerLineThickness = 435;
        public const int ERR7_InvalidMarkerSize = 436;
        public const int ERR7_MarkerNotFound = 437;
        public const int ERR7_PseudoTimeNotDefined = 438;
        public const int ERR7_EquationDoesNotExist = 439;
        public const int ERR7_InvalidOption = 440;
        public const int ERR7_InvalidIterationNumber = 441;
        public const int ERR7_InvalidAveragingOption = 442;
        public const int ERR7_InvalidContourFileIndex = 443;
        public const int ERR7_ContourFileNotLoaded = 444;
        public const int ERR7_NoLoadPathsFound = 445;
        public const int ERR7_NoElementsOnLoadPaths = 446;
        public const int ERR7_NoResponsesFound = 447;
        public const int ERR7_NoActiveResponseVariables = 448;
        public const int ERR7_NoSoilElementsFound = 449;
        public const int ERR7_OperationUserTerminated = 450;
        public const int ERR7_InvalidDefaultsMode = 451;
        public const int ERR7_InvalidFontName = 452;
        public const int ERR7_InvalidBaseExcitationType = 453;
        public const int ERR7_SectionNotBGL = 454;
        public const int ERR7_CavityFluidNotIdealGas = 455;
        public const int ERR7_CavityFluidNotConstBulk = 456;
        public const int ERR7_UnknownFileType = 457;
        public const int ERR7_FunctionalityNotAvailable = 458;
        public const int ERR7_DynamicsSolverModuleNotLicensed = 459;
        public const int ERR7_NonlinearSolverModuleNotLicensed = 460;
        public const int ERR7_MovingLoadModuleNotLicensed = 461;
        public const int ERR7_AutoMesherModuleNotLicensed = 462;
        public const int ERR7_RCModuleNotLicensed = 463;
        public const int ERR7_CompositesModuleNotLicensed = 464;
        public const int ERR7_InvalidPseudoTime = 465;
        public const int ERR7_InvalidSectionPosition = 466;
        public const int ERR7_UnknownSolverProcess = 467;
        public const int ERR7_InvalidParameters = 468;

        // Solver Error Codes
        public const int SE_NoLoadCaseSelected = 1001;
        public const int SE_IncompatibleRestartFile = 1002;
        public const int SE_ElementUsesInvalidProperty = 1003;
        public const int SE_InvalidElement = 1004;
        public const int SE_NeedNonlinearHeatSolver = 1005;
        public const int SE_TableNotFound = 1006;
        public const int SE_InvalidRestartFile = 1007;
        public const int SE_InvalidInitialFile = 1008;
        public const int SE_InvalidSolverResultFile = 1009;
        public const int SE_InvalidLink = 1010;
        public const int SE_InvalidPlateCohesionValue = 1011;
        public const int SE_InvalidBrickCohesionValue = 1012;
        public const int SE_NonlinearSolverRequired = 1013;
        public const int SE_NoLoadTablesDefined = 1014;
        public const int SE_NoVelocityDataInInitialFile = 1015;
        public const int SE_NoModesIncluded = 1016;
        public const int SE_InvalidTimeStep = 1017;
        public const int SE_LoadIncrementsNotDefined = 1018;
        public const int SE_NoFreedomCaseInIncrements = 1019;
        public const int SE_InvalidInitialTemperatureFile = 1020;
        public const int SE_InvalidFrequencyRange = 1021;
        public const int SE_ModelMixesAxiNonAxi = 1022;
        public const int SE_CompositesModuleNotLicensed = 1023;
        public const int SE_CannotFindSolver = 1024;
        public const int SE_UnknownException = 1025;
        public const int SE_DuplicateLinks = 1026;
        public const int SE_CannotAppendToFile = 1027;
        public const int SE_CannotOverwriteFile = 1028;
        public const int SE_CannotWriteToResultFile = 1029;
        public const int SE_CannotWriteToLogFile = 1030;
        public const int SE_CannotReadRestartFile = 1031;
        public const int SE_InitialConditionsNotValid = 1032;
        public const int SE_InvalidRayleighFactors = 1033;
        public const int SE_SpectralExcitationsAllZero = 1034;
        public const int SE_ShearPanelMustBeQuad4 = 1035;
        public const int SE_SingularPlateMatrix = 1036;
        public const int SE_SingularBrickMatrix = 1037;
        public const int SE_NoBeamProperties = 1038;
        public const int SE_NoPlateProperties = 1039;
        public const int SE_NoBrickProperties = 1040;
        public const int SE_MoreLoadIncrementsNeeded = 1041;
        public const int SE_RubberRequiresGNL = 1042;
        public const int SE_NoFreedomCaseSelected = 1043;
        public const int SE_SpectralCasesNotDefined = 1044;
        public const int SE_NoSpectralResultsSelected = 1045;
        public const int SE_SpectralLoadExcitationsAllZero = 1046;
        public const int SE_SpectralBaseExcitationsAllZero = 1047;
        public const int SE_NoTimeStepsSaved = 1048;
        public const int SE_InvalidDirectionVector = 1049;
        public const int SE_HarmonicFactorsAllZero = 1050;
        public const int SE_TemperatureDependenceCaseNotSet = 1051;
        public const int SE_ZeroLengthRigidLinkGenerated = 1052;
        public const int SE_InvalidStringGroupDefinition = 1053;
        public const int SE_InvalidPreTensionOnString = 1054;
        public const int SE_StringOrderHasChanged = 1055;
        public const int SE_BadTaperData = 1056;
        public const int SE_TaperedPlasticBeams = 1057;
        public const int SE_NoMovingLoadPathsInCases = 1058;
        public const int SE_NoResponseVariablesDefined = 1059;
        public const int SE_InvalidPlateVariableRequested = 1060;
        public const int SE_InvalidGravityCase = 1061;
        public const int SE_InvalidUserPlateCreepDefinition = 1062;
        public const int SE_InvalidUserBrickCreepDefinition = 1063;
        public const int SE_InvalidPlateShrinkageDefinition = 1064;
        public const int SE_InvalidBrickShrinkageDefinition = 1065;
        public const int SE_InvalidLaminateID = 1066;
        public const int SE_CannotReadWriteScratchPath = 1067;
        public const int SE_CannotConvertAttachmentLink = 1068;
        public const int SE_SoilRequiresMNL = 1069;
        public const int SE_ActiveStageHasNoIncrements = 1070;
        public const int SE_ConcreteCreepMNL = 1071;
        public const int SE_CannotConvertInterpMultiPoint = 1072;
        public const int SE_MissingInsituStress = 1073;
        public const int SE_InvalidMaterialNonlinearString = 1074;
        public const int SE_TensileInsituPlateStress = 1075;
        public const int SE_TensileInsituBrickStress = 1076;
        public const int SE_IncompatibleRestartUnits = 1077;
        public const int SE_CreepTimeTooShort = 1078;
        public const int SE_InvalidElements = 1079;
        public const int SE_InsufficientRestartFileSteps = 1080;
        public const int SE_NeedNodeTempNTASolver = 1081;
        public const int SE_SingleShotRestartFile = 1082;
        public const int SE_SkylineUsesBadSort = 1083;
        public const int SE_StagedSolutionFileNotFound = 1084;
        public const int SE_NeedTemperatureTables = 1085;
        public const int SE_AttachmentsInWrongGroup = 1086;
        public const int SE_StagingHasChanged = 1087;
        public const int SE_NoNodes = 1088;
        public const int SE_CQCRequiresDamping = 1089;
        public const int SE_HaveLinearCables = 1090;
        public const int SE_CableRequiresGNL = 1091;
        public const int SE_BeamRequiresPoisson = 1092;
        public const int SE_BeamPoissonOutOfRange = 1093;
        public const int SE_CableRequiresNonlinearSolver = 1094;
        public const int SE_InitialSolutionFileIsBad = 1095;
        public const int SE_BeamPropertiesMayHaveChanged = 1096;
        public const int SE_NeedElementNodeForce = 1097;
        public const int SE_LinksHaveNoFreedomCase = 1098;
        public const int SE_InvalidCavityFluidDefinition = 1099;
        public const int SE_InactiveCavityControlCase = 1100;
        public const int SE_MovingLoadModuleNotLicensed = 1101;
        public const int SE_NeedTemperatureDependence = 1102;

        // Solver Termination Error Codes
        public const int ST_NoError = 0;
        public const int ST_Abnormal = -1;
        public const int ST_UserStop = -2;
        public const int ST_Internal = -3;
        public const int ST_NoDisk = -4;
        public const int ST_NoRam = -5;
        public const int ST_OpenLog = -6;
        public const int ST_CreateLog = -7;
        public const int ST_WriteLog = -8;
        public const int ST_MemError = -9;
        public const int ST_Scratch = -10;
        public const int ST_NoLicence = -11;

        // Other Constants
        public const int kMaxPlateResult = 1024;
        public const int kMaxBrickResult = 1024;
        public const int kMaxBeamRelease = 12;
        public const int kMaxDisp = 6;

        // UCS
        public const int kMaxUCSDoubles = 10;

        // Solvers
        public const int stLinearStatic = 1;
        public const int stLinearBuckling = 2;
        public const int stNonlinearStatic = 3;
        public const int stNaturalFrequency = 4;
        public const int stHarmonicResponse = 5;
        public const int stSpectralResponse = 6;
        public const int stLinearTransientDynamic = 7;
        public const int stNonlinearTransientDynamic = 8;
        public const int stSteadyHeat = 9;
        public const int stTransientHeat = 10;
        public const int stLoadInfluence = 11;
        public const int stQuasiStatic = 12;

        // Solver Modes
        public const int smNone = 0;
        public const int smFreqSolution = 1;
        public const int smTimeSolution = 2;
        public const int smTimeMode = 3;

        // Solver Run Modes
        public const int smNormalRun = 1;
        public const int smProgressRun = 2;
        public const int smBackgroundRun = 3;
        public const int smNormalCloseRun = 4;

        // OpenFile/SaveFile Erroc Code Bits
        public const int ibFileNameTooLongOrInvalid = 1;
        public const int ibFileSharingError = 2;
        public const int ibFileCantRead = 3;
        public const int ibFileCantWrite = 4;
        public const int ibFileNotFound = 5;
        public const int ibFileInvalidData = 6;
        public const int ibFileTruncated = 7;
        public const int ibFileIsBXS = 8;
        public const int ibFileIsNotSt7 = 9;
        public const int ibInsufficientFreeSpace = 10;
        public const int ibFileReadOnly = 11;

        // Result File Validation Bits
        public const int ibResFileNotFound = 1;
        public const int ibResFileCannotOpen = 2;
        public const int ibResFileNotResultFile = 3;
        public const int ibResFileOldVersion = 4;
        public const int ibResFileFutureVersion = 5;
        public const int ibResFileWrongNumNodes = 6;
        public const int ibResFileWrongNumBeams = 7;
        public const int ibResFileWrongNumPlates = 8;
        public const int ibResFileWrongNumBricks = 9;
        public const int ibResFileWrongModelID = 10;
        public const int ibResFileUnknownError = 11;
        public const int ibResFileIsCombination = 12;
        public const int ibResFileIsMultiFile = 13;
        public const int ibResFileTruncated = 14;

        // Import/Export Modes
        public const int ieQuietRun = 0;
        public const int ieProgressRun = 1;

        // NASTRAN
        public const int ipNASTRANImportUnits = 0;
        public const int ipNASTRANFreedomCase = 0;
        public const int ipNASTRANLoadCaseNSMass = 1;
        public const int ipNASTRANSolver = 2;
        public const int ipNASTRANExportUnits = 3;
        public const int ipNASTRANBeamStressSections = 4;
        public const int ipNASTRANBeamSectionGeometry = 5;
        public const int ipNASTRANExportHeatTransfer = 6;
        public const int ipNASTRANExportNSMass = 7;
        public const int ipNASTRANExportUnusedProps = 8;
        public const int ipNASTRANTemperatureCase = 9;
        public const int ipNASTRANPreLoadCase = 10;
        public const int ipNASTRANNInc = 11;
        public const int ipNASTRANMaxIter = 12;
        public const int ipNASTRANDoEPSU = 13;
        public const int ipNASTRANDoEPSP = 14;
        public const int ipNASTRANDoEPSW = 15;
        public const int ipNASTRANExportPyramid = 16;
        public const int ipNASTRANExportQuad4 = 17;
        public const int ipNASTRANExportZeroFields = 0;
        public const int ipNASTRANEPSU = 1;
        public const int ipNASTRANEPSP = 2;
        public const int ipNASTRANEPSW = 3;
        public const int ieNASTRANSolverLSA = 0;
        public const int ieNASTRANSolverNFA = 1;
        public const int ieNASTRANSolverLBA = 2;
        public const int ieNASTRANSolverNLA = 3;
        public const int ieNASTRANExportGeometryProps = 0;
        public const int ieNASTRANExportPropsOnly = 1;
        public const int ieNASTRANExportPyramidAsHexa = 0;
        public const int ieNASTRANExportPyramidAsPyram = 1;
        public const int ieNASTRANExportCQUAD4 = 0;
        public const int ieNASTRANExportCQUADR = 1;
        public const int usNASTRAN_kg_N_m = 0;
        public const int usNASTRAN_T_N_mm = 1;
        public const int usNASTRAN_sl_lbf_ft = 2;
        public const int usNASTRAN_lbm_lbf_in = 3;
        public const int usNASTRAN_sl_lbf_in = 4;
        public const int usNASTRAN_None = 5;

        // ANSYS
        public const int ipANSYSImportFormat = 0;
        public const int ipANSYSArrayParameters = 1;
        public const int ipANSYSImportLoadCaseFiles = 2;
        public const int ipANSYSImportIGESEntities = 3;
        public const int ipANSYSFixElementConnectivity = 4;
        public const int ipANSYSRemoveDuplicateProps = 5;
        public const int ipANSYSExportFormat = 0;
        public const int ipANSYSFreedomCase = 1;
        public const int ipANSYSLoadCase = 2;
        public const int ipANSYSUnits = 3;
        public const int ipANSYSEndRelease = 4;
        public const int ipANSYSExportNonlinearMat = 5;
        public const int ipANSYSExportHeatTransfer = 6;
        public const int ipANSYSExportPreLoadNSMass = 7;
        public const int ipANSYSExportTetraOption = 8;
        public const int ipANSYSExportQuad8Option = 9;
        public const int ieANSYSBatchImport = 0;
        public const int ieANSYSCDBImport = 1;
        public const int ieANSYSBatchCDBImport = 2;
        public const int ieANSYSBatch1Export = 0;
        public const int ieANSYSBatch3Export = 1;
        public const int ieANSYSBlockedCDBExport = 2;
        public const int ieANSYSUnblockedCDBExport = 3;
        public const int ieANSYSArrayOverwrite = 0;
        public const int ieANSYSArrayIgnore = 1;
        public const int ieANSYSArrayPrompt = 2;
        public const int ieANSYSEndReleaseFixed = 0;
        public const int ieANSYSEndReleaseFull = 1;
        public const int usANSYS_None = 0;
        public const int usANSYS_kg_m_C = 1;
        public const int usANSYS_g_cm_C = 2;
        public const int usANSYS_T_mm_C = 3;
        public const int usANSYS_sl_ft_F = 4;
        public const int usANSYS_lbm_in_F = 5;

        // STAAD
        public const int ipSTAADCountryType = 0;
        public const int ipSTAADIncludeSectionLibrary = 1;
        public const int ipSTAADStripUnderscore = 2;
        public const int ipSTAADStripSectionSpaces = 3;
        public const int ipSTAADStripCaseQualifiers = 4;
        public const int ipSTAADLengthUnit = 5;
        public const int ipSTAADForceUnit = 6;
        public const int ieSTAADAmericanCode = 0;
        public const int ieSTAADAustralianCode = 1;
        public const int ieSTAADBritishCode = 2;
        public const int luSTAADInch = 0;
        public const int luSTAADFoot = 1;
        public const int luSTAADCentimetre = 2;
        public const int luSTAADMetre = 3;
        public const int luSTAADMillimetre = 4;
        public const int luSTAADDecimetre = 5;
        public const int luSTAADKilometre = 6;
        public const int fuSTAADKip = 0;
        public const int fuSTAADPoundForce = 1;
        public const int fuSTAADKilogramForce = 2;
        public const int fuSTAADMegatonneForce = 3;
        public const int fuSTAADNewton = 4;
        public const int fuSTAADKilonewton = 5;
        public const int fuSTAADMeganewton = 6;
        public const int fuSTAADDecanewton = 7;

        // SAP2000
        public const int ipSAP2000DecimalSeparator = 0;
        public const int ipSAP2000ThousandSeparator = 1;
        public const int ipSAP2000MergeDuplicateFreedomSets = 2;
        public const int ieSAP2000Period = 0;
        public const int ieSAP2000Comma = 1;
        public const int ieSAP2000Space = 2;
        public const int ieSAP2000None = 3;

        // ST7
        public const int ipSt7ImportRemoveCases = 0;
        public const int ipSt7ImportMatchUCSNames = 1;
        public const int ieSt7ExportCurrent = 0;
        public const int ieSt7Export106 = 1;
        public const int ieSt7Export21x = 2;
        public const int ieSt7Export22x = 3;
        public const int ieSt7Export23x = 4;
        public const int ieSt7Export24x = 5;

        // STL
        public const int ipSTLImportProperty = 0;
        public const int ipSTLImportLengthUnit = 1;
        public const int ipSTLExportFormat = 0;
        public const int ipSTLExportGrouping = 1;
        public const int ipSTLExportBeams = 2;
        public const int ipSTLExportPlates = 3;
        public const int ipSTLExportBricks = 4;
        public const int ipSTLExportGeometryFaces = 5;
        public const int ipSTLExportBeamsAs = 6;
        public const int ipSTLExportPlatesAs = 7;
        public const int ipSTLExportBeamOffsets = 8;
        public const int ipSTLExportPlateOffsets = 9;
        public const int ipSTLExportInternalBrickFaces = 10;
        public const int luSTLNone = 0;
        public const int luSTLMillimetre = 1;
        public const int luSTLCentimetre = 2;
        public const int luSTLMetre = 3;
        public const int luSTLInch = 4;
        public const int luSTLFoot = 5;
        public const int ieSTLText = 0;
        public const int ieSTLBinary = 1;
        public const int ieSTLGroupByNone = 0;
        public const int ieSTLGroupByEntityType = 1;
        public const int ieSTLGroupByGroups = 2;
        public const int ieSTLBrickFreeFaces = 0;
        public const int ieSTLBrickAllFaces = 1;
        public const int ieSTLBrickGroupFreeFaces = 2;

        // GEOMETRY
        public const int ipGeomImportProperty = 0;
        public const int ipGeomImportCurvesToBeams = 1;
        public const int ipGeomImportGroupsAs = 2;
        public const int ipGeomImportColourAsProperty = 3;
        public const int ipGeomImportLengthUnit = 4;
        public const int ipGeomImportMatchExistingProperty = 5;
        public const int ipGeomExportColour = 0;
        public const int ipGeomExportGroupsAsLevels = 1;
        public const int ipGeomExportFullGroupPath = 2;
        public const int ipGeomExportFormatProtocol = 3;
        public const int ipGeomExportCurve = 4;
        public const int ipGeomExportPeriodicFace = 5;
        public const int ipGeomExportKeepAnalytic = 6;
        public const int ipGeomImportTol = 0;
        public const int luGeomNone = -1;
        public const int luGeomInch = 0;
        public const int luGeomMillimetre = 1;
        public const int luGeomFoot = 2;
        public const int luGeomMile = 3;
        public const int luGeomMetre = 4;
        public const int luGeomKilometre = 5;
        public const int luGeomMil = 6;
        public const int luGeomMicron = 7;
        public const int luGeomCentimetre = 8;
        public const int luGeomMicroinch = 9;
        public const int luGeomUnspecified = 10;

        // IGES Formats
        public const int ieIGESBoundedSurface = 0;
        public const int ieIGESTrimmedParametricSurface = 1;
        public const int ieIGESOpenShell = 2;
        public const int ieIGESManifoldSolidBRep = 3;

        // STEP Protocols
        public const int ieSTEPConfigControlDesign = 0;
        public const int ieSTEPAutomotiveDesign = 1;

        // Geometry Export Format Options
        public const int ieGeomModelOnly = 0;
        public const int ieGeomParameterOnly = 1;
        public const int ieGeomModelPreferred = 2;
        public const int ieGeomParameterPreferred = 3;
        public const int ieGeomSeamOnlyAsRequired = 0;
        public const int ieGeomSplitOnFaceBoundary = 1;
        public const int ieGeomSplitIntoHalves = 2;
        public const int ieGeomColourNone = 0;
        public const int ieGeomFaceColour = 1;
        public const int ieGeomGroupColour = 2;
        public const int ieGeomPropertyColour = 3;

        // DXF Options
        public const int ipDXFImportFrozenLayers = 0;
        public const int ipDXFImportLayersAsGroups = 1;
        public const int ipDXFImportColoursAsProps = 2;
        public const int ipDXFImportPolylineAsPlates = 3;
        public const int ipDXFImportPolygonAsBricks = 4;
        public const int ipDXFImportSegmentsPerCircle = 5;
        public const int ipDXFImportUseSegmentsPerCircle = 6;
        public const int ipDXFImportLengthUnit = 7;
        public const int ipDXFImportProperty = 8;
        public const int ipDXFImportMatchExistingProperty = 9;
        public const int ipDXFImportAcisBodiesAsGroups = 10;
        public const int ipDXFImportCurvesToBeams = 11;
        public const int ipDXFExportPlatesBricks3DFaces = 0;
        public const int ipDXFExportGroupsAsLayers = 1;
        public const int ipDXFExportPropColoursAsEntityColours = 2;
        public const int ipDXFExportBeamsAs = 3;
        public const int ipDXFExportPlatesAs = 4;
        public const int ipDXFExportBeamOffsets = 5;
        public const int ipDXFExportPlateOffsets = 6;
        public const int ipDXFExportInternalBrickFaces = 7;
        public const int ipDXFImportArcLength = 0;
        public const int ipDXFImportAcisTol = 1;

        // DXF and STL
        public const int ieBeamAsLine = 0;
        public const int ieBeamAsSection = 1;
        public const int ieBeamAsSolid = 2;
        public const int iePlateAsSurface = 0;
        public const int iePlateAsSolid = 1;

        // Geometry Groups
        public const int ggNone = 0;
        public const int ggAuto = 1;
        public const int ggSubfigures = 2;
        public const int ggLevels = 3;
        public const int ggAssemblies = 1;
        public const int ggBlocks = 2;
        public const int ggLayers = 3;
        public const int ggBodies = 1;

        // BXS
        public const int ipBXSXBar = 0;
        public const int ipBXSYBar = 1;
        public const int ipBXSArea = 2;
        public const int ipBXSI11 = 3;
        public const int ipBXSI22 = 4;
        public const int ipBXSAngle = 5;
        public const int ipBXSZ11Plus = 6;
        public const int ipBXSZ11Minus = 7;
        public const int ipBXSZ22Plus = 8;
        public const int ipBXSZ22Minus = 9;
        public const int ipBXSS11 = 10;
        public const int ipBXSS22 = 11;
        public const int ipBXSr1 = 12;
        public const int ipBXSr2 = 13;
        public const int ipBXSSA1 = 14;
        public const int ipBXSSA2 = 15;
        public const int ipBXSSL1 = 16;
        public const int ipBXSSL2 = 17;
        public const int ipBXSIXX = 18;
        public const int ipBXSIYY = 19;
        public const int ipBXSIXY = 20;
        public const int ipBXSIxxL = 21;
        public const int ipBXSIyyL = 22;
        public const int ipBXSIxyL = 23;
        public const int ipBXSZxxPlus = 24;
        public const int ipBXSZxxMinus = 25;
        public const int ipBXSZyyPlus = 26;
        public const int ipBXSZyyMinus = 27;
        public const int ipBXSSxx = 28;
        public const int ipBXSSyy = 29;
        public const int ipBXSrx = 30;
        public const int ipBXSry = 31;
        public const int ipBXSJ = 32;
        public const int ipBXSIw = 33;
        public const int ipBXSrdA = 34;
        public const int ipBXSPC1 = 35;
        public const int ipBXSPC2 = 36;
        public const int ipBXSPCx = 37;
        public const int ipBXSPCy = 38;

        // BXS Loop Types
        public const int ltUnknown = 0;
        public const int ltOuter = 1;
        public const int ltInner = 2;

        // Geometry Clean - Doubles
        public const int ipGeometryFeatureLength = 0;
        public const int ipGeometryEdgeMergeAngle = 1;

        // Geometry Clean - Integers
        public const int ipGeometryFeatureType = 0;
        public const int ipGeometryActOnWholeModel = 1;
        public const int ipGeometryFreeEdgesOnly = 2;
        public const int ipGeometryDuplicateFaces = 3;
        public const int ipGeometryWithinGroups = 4;
        public const int dfLeaveAll = 0;
        public const int dfLeaveOne = 1;
        public const int dfLeaveNone = 2;

        // Mesh Clean - Doubles
        public const int ipMeshTolerance = 0;

        // Mesh Clean - Integers
        public const int ipMeshToleranceType = 0;
        public const int ipZipNodes = 1;
        public const int ipRemoveDuplicateElements = 2;
        public const int ipFixElementConnectivity = 3;
        public const int ipDeleteFreeNodes = 4;
        public const int ipDoBeams = 5;
        public const int ipDoPlates = 6;
        public const int ipDoBricks = 7;
        public const int ipDoLinks = 8;
        public const int ipZeroLengthLinks = 9;
        public const int ipZeroLengthBeams = 10;
        public const int ipNodeAttributeKeep = 11;
        public const int ipNodeCoordinates = 12;
        public const int ipAllowDifferentProps = 13;
        public const int ipActOnWholeModel = 14;
        public const int ipAllowDifferentGroups = 15;
        public const int ipPackStringGroupIDs = 16;
        public const int ipAllowDifferentBeamOffset = 17;
        public const int ipAllowDifferentPlateOffset = 18;
        public const int ipDeleteInvalidElements = 19;

        // Attribute keep
        public const int naLower = 0;
        public const int naHigher = 1;
        public const int naAccumulate = 2;

        // Node coordinates
        public const int ncAverage = 0;
        public const int ncLowerNode = 1;
        public const int ncHigherNode = 2;
        public const int ncSelectedNode = 3;

        // Surface Meshing - Integers
        public const int ipSurfaceMeshMode = 0;
        public const int ipSurfaceMeshSizeMode = 1;
        public const int ipSurfaceMeshTargetNodes = 2;
        public const int ipSurfaceMeshTargetPropertyID = 3;
        public const int ipSurfaceMeshAutoCreateProperties = 4;
        public const int ipSurfaceMeshMinEdgesPerCircle = 5;
        public const int ipSurfaceMeshApplyTransitioning = 6;
        public const int ipSurfaceMeshAllowUserStop = 7;
        public const int ipSurfaceMeshConsiderNearVertex = 8;
        public const int ipSurfaceMeshSelectedFaces = 9;
        public const int ipSurfaceMeshApplySurfaceCurvature = 10;
        public const int mmAuto = 0;
        public const int mmCustom = 1;
        public const int smPercentage = 0;
        public const int smAbsolute = 1;

        // Surface Meshing - Doubles
        public const int ipSurfaceMeshSize = 0;
        public const int ipSurfaceMeshLengthRatio = 1;
        public const int ipSurfaceMeshMaximumIncrease = 2;
        public const int ipSurfaceMeshOnEdgesLongerThan = 3;
        public const int tmAutoZipMultipleSolids = 0;
        public const int tmUserZipMultipleSolids = 1;
        public const int tmDontZipMultipleSolids = 2;

        // Tetra Meshing
        public const int ipTetraMeshSize = 0;
        public const int ipTetraMeshProperty = 1;
        public const int ipTetraMeshInc = 2;
        public const int ipTetraMesh10 = 3;
        public const int ipTetraMeshGroupsAsSolids = 4;
        public const int ipTetraMeshSmooth = 5;
        public const int ipTetraMeshAutoCreateProperties = 7;
        public const int ipTetraMeshDeletePlates = 8;
        public const int ipTetraMeshAllowUserStop = 10;
        public const int ipTetraMeshCheckSelfIntersect = 11;
        public const int ipTetraMeshZipOption = 12;

        // Direct Tetra Meshing
        public const int ipDirectTetraMeshMode = 0;
        public const int ipDirectTetraMeshSizeMode = 1;
        public const int ipDirectTetraMinEdgesPerCircle = 2;
        public const int ipDirectTetraApplyTransitioning = 3;
        public const int ipDirectTetraApplySurfaceCurvature = 4;
        public const int ipDirectTetraAllowUserStop = 5;
        public const int ipDirectTetraConsiderNearVertex = 6;
        public const int ipDirectTetraMeshSelectedGroups = 7;
        public const int ipDirectTetraMeshSize = 8;
        public const int ipDirectTetraMesh10 = 9;
        public const int ipDirectTetraMeshSmooth = 10;
        public const int ipDirectTetraAutoCreateProperties = 11;
        public const int ipDirectTetraZipOption = 12;
        public const int msFine = 1;
        public const int msMedium = 2;
        public const int msCoarse = 3;

        // Polygon Meshing
        public const int ipMeshTargetNodes = 0;
        public const int ipMeshTargetPropertyID = 1;
        public const int ipMeshUCSId = 2;
        public const int ipMeshGroupID = 3;
        public const int ipMeshPositionUCS = 0;

        // Image Types
        public const int itBitmap8Bit = 1;
        public const int itBitmap16Bit = 2;
        public const int itBitmap24Bit = 3;
        public const int itJPEG = 4;
        public const int itPNG = 5;

        // Window State
        public const int wsModelWindowNotCreated = 0;
        public const int wsModelWindowVisible = 1;
        public const int wsModelWindowMaximised = 2;
        public const int wsModelWindowMinimised = 3;
        public const int wsModelWindowHidden = 4;

        // Window Refresh Modes
        public const int wrAutoRefresh = 0;
        public const int wrPauseClear = 1;
        public const int wrPauseNoClear = 2;

        // DISPLAY SETTINGS DEFAULTS

        // Defaults Mode
        public const int mdFactoryDefaults = 0;
        public const int mdUserDefaults = 1;

        // Model Defaults
        public const int mdViewOptions = 0;
        public const int mdEntityOptions = 1;
        public const int mdBeamPreContourOptions = 2;
        public const int mdPlatePreContourOptions = 3;
        public const int mdBrickPreContourOptions = 4;
        public const int mdAttributeOptions = 5;
        public const int mdResultOptions = 6;
        public const int mdBeamResultContourOptions = 7;
        public const int mdPlateResultContourOptions = 8;
        public const int mdBrickResultContourOptions = 9;
        public const int mdLinkResultContourOptions = 10;
        public const int mdPrintOptions = 11;

        // mdViewOptions
        public const int ipDefBackgroundTab = 0;
        public const int ipDefAxisTab = 1;
        public const int ipDefRotationTab = 2;
        public const int ipDefDrawingTab = 3;
        public const int ipDefPreNumbersTab = 4;
        public const int ipDefFreeEdgeTab = 5;
        public const int ipDefSelectionTab = 6;

        // mdEntityOptions
        public const int ipDefNodeTab = 0;
        public const int ipDefBeamTab = 1;
        public const int ipDefPlateTab = 2;
        public const int ipDefBrickTab = 3;
        public const int ipDefLinkTab = 4;
        public const int ipDefPathTab = 5;
        public const int ipDefVertexTab = 6;
        public const int ipDefFaceTab = 7;

        // mdPreContourOptions, mdResultContourOptions
        public const int ipDefContourStyleTab = 0;
        public const int ipDefContourLimitsTab = 1;
        public const int ipDefContourLegendTab = 2;
        public const int ipDefContourDiagramTab = 3;

        // mdAttributeOptions
        public const int ipDefNodeAttribTab = 0;
        public const int ipDefBeamAttribTab = 1;
        public const int ipDefPlateAttribTab = 2;
        public const int ipDefBrickAttribTab = 3;
        public const int ipDefPathAttribTab = 4;

        // mdResultOptions
        public const int ipDefResShowHideTab = 0;
        public const int ipDefResPostNumbersTab = 1;
        public const int ipDefResCombinationsTab = 2;
        public const int ipDefResEnvelopesTab = 3;
        public const int ipDefResOtherTab = 4;

        // mdPrintOptions
        public const int ipHeaderFooterTab = 0;
        public const int ipPageSetupTab = 1;
        public const int ipFontsTab = 2;

        // ENTITY DISPLAY SETTINGS

        // Label Style
        public const int lsNone = 0;
        public const int lsEntityNumber = 1;
        public const int lsIDNumber = 2;
        public const int lsPropertyNumber = 3;
        public const int lsPropertyName = 4;
        public const int lsPropertyType = 5;
        public const int lsLinkType = 3;
        public const int lsLaneNumber = 2;

        // Line Thickness Limits
        public const int kMinThickness = 1;
        public const int kMaxThickness = 5;

        // Element Outline Style
        public const int omEdge = 0;
        public const int omPropertyBoundary = 1;
        public const int omGroupBoundary = 2;
        public const int omFacetAngle = 3;
        public const int omFacetProperty = 4;
        public const int omFacetGroup = 5;

        // Shrink Limits
        public const int kMinShrink = 0;
        public const int kMaxShrink = 95;

        // Point Styles
        public const int psCircle = 0;
        public const int psSquare = 1;

        // Point Size Limits
        public const int kMinPointSize = 0;
        public const int kMaxPointSize = 5;

        // NODE ENTITY DISPLAY

        // Node Show
        public const int nsFreeNodeAll = 0;
        public const int nsFreeNodeNone = 1;
        public const int nsFreeNodeGroup = 2;
        public const int nsFreeNodeGroupFree = 3;

        // Node Colour Indexes
        public const int clNodeUnselected = 0;
        public const int clNodeSelected = 1;

        // BEAM ENTITY DISPLAY

        // Beam Display Style
        public const int bsLine = 0;
        public const int bsSection = 1;
        public const int bsSolid = 2;
        public const int bsSlice = 3;

        // Beam Fill Colour Type
        public const int bfNone = 0;
        public const int bfProperty = 1;
        public const int bfGroup = 2;
        public const int bfColour = 3;
        public const int bfOrientation = 4;
        public const int bfContour = 5;

        // Beam Outline Colour Type
        public const int blNone = 0;
        public const int blProperty = 1;
        public const int blGroup = 2;
        public const int blColour = 3;
        public const int blOrientation = 4;
        public const int blContour = 5;

        // Beam Colour Indexes
        public const int ipBeamFillColour = 0;
        public const int ipBeamLineColour = 1;
        public const int ipBeamOrientation1Colour = 2;
        public const int ipBeamOrientation2Colour = 3;
        public const int ipBeamNRefColour = 4;

        // Beam Spring Coil Limits
        public const int kMinSpringCoils = 5;
        public const int kMaxSpringCoils = 30;
        public const int kMinSpringAspect = 5;
        public const int kMaxSpringAspect = 50;

        // Beam Round Facets Limits
        public const int kMinFacets = 8;
        public const int kMaxFacets = 32;
        public const int kMinSlices = 4;
        public const int kMaxSlices = 20;

        // PLATE ENTITY DISPLAY

        // Plate Display Style
        public const int psSurface = 0;
        public const int psSolid = 1;

        // Plate Fill Colour Type
        public const int pfNone = 0;
        public const int pfProperty = 1;
        public const int pfGroup = 2;
        public const int pfColour = 3;
        public const int pfOrientation = 4;
        public const int pfContour = 5;

        // Plate Outline Colour Type
        public const int plNone = 0;
        public const int plProperty = 1;
        public const int plGroup = 2;
        public const int plColour = 3;

        // Plate Colour Indexes
        public const int ipPlateFillColour = 0;
        public const int ipPlateLineColour = 1;
        public const int ipPlateOrientation1Colour = 2;
        public const int ipPlateOrientation2Colour = 3;
        public const int ipPlateOrientation3Colour = 4;
        public const int ipPlateOffsetColour = 5;

        // BRICK ENTITY DISPLAY

        // Brick Fill Colour Type
        public const int kfNone = 0;
        public const int kfProperty = 1;
        public const int kfGroup = 2;
        public const int kfColour = 3;
        public const int kfContour = 4;

        // Brick Outline Colour Type
        public const int klNone = 0;
        public const int klProperty = 1;
        public const int klGroup = 2;
        public const int klColour = 3;

        // Brick Colour Indexes
        public const int ipBrickFillColour = 0;
        public const int ipBrickLineColour = 1;

        // LINK ENTITY DISPLAY

        // Link Outline Colour Type
        public const int llType = 0;
        public const int llGroup = 1;
        public const int llGlobal = 2;

        // Link Colour Indexes
        public const int ipLinkColour = 0;
        public const int ipMasterSlaveColour = 1;
        public const int ipSectorSymmetryColour = 2;
        public const int ipCouplingColour = 3;
        public const int ipPinnedColour = 4;
        public const int ipRigidColour = 5;
        public const int ipShrinkColour = 6;
        public const int ipTwoPointColour = 7;
        public const int ipAttachmentColour = 8;
        public const int ipInterpolatedMPLColour = 9;
        public const int ipMasterSlaveMPLColour = 10;
        public const int ipPinnedMPLColour = 11;
        public const int ipRigidMPLColour = 12;
        public const int ipUserMPLColour = 13;
        public const int ipReactionMPLColour = 14;

        // VERTEX ENTITY DISPLAY

        // Vertex Show
        public const int vsFreeVertexAll = 0;
        public const int vsFreeVertexNone = 1;
        public const int vsFreeVertexGroup = 2;

        // Vertex Colours Indexes
        public const int ipVertexFreeColour = 0;
        public const int ipVertexFixedColour = 1;
        public const int ipVertexSelectedColour = 2;

        // FACE ENTITY DISPLAY

        // Face Fill Style
        public const int fdNone = 0;
        public const int fdWireframe = 1;
        public const int fdSolid = 2;

        // Face Fill Colour Type
        public const int ffProperty = 0;
        public const int ffGroup = 1;
        public const int ffFaceNumber = 2;
        public const int ffColour = 3;
        public const int ffOrientation = 4;
        public const int ffFaceID = 5;

        // Face Line Colour Type
        public const int flNone = 0;
        public const int flProperty = 1;
        public const int flGroup = 2;
        public const int flFaceNumber = 3;
        public const int flColour = 4;
        public const int flFaceID = 5;

        // Face Colour Indexes
        public const int ipFaceFillColour = 0;
        public const int ipFaceLineColour = 1;
        public const int ipFaceOrientation1Colour = 2;
        public const int ipFaceOrientation2Colour = 3;
        public const int ipFaceNIEdgesColour = 4;
        public const int ipFaceCPuColour = 5;
        public const int ipFaceCPvColour = 6;
        public const int ipFaceNormalsColour = 7;

        // PATH ENTITY DISPLAY

        // Path Fill Colour Type
        public const int tfNone = 0;
        public const int tfTemplate = 1;
        public const int tfGroup = 2;
        public const int tfPathNumber = 3;
        public const int tfColour = 4;
        public const int tfOrientation = 5;

        // Path Outline Colour Type
        public const int tlNone = 0;
        public const int tlTemplate = 1;
        public const int tlGroup = 2;
        public const int tlPathNumber = 3;
        public const int tlColour = 4;

        // Path Colour Indexes
        public const int ipPathFillColour = 0;
        public const int ipPathLineColour = 1;
        public const int ipPathOrientation1Colour = 2;
        public const int ipPathOrientation2Colour = 3;

        // ATTRIBUTE DISPLAY
        public const int ipAttribDisplayShow = 0;
        public const int ipAttribDisplayLabel = 1;
        public const int ipAttribDisplayResultant = 2;
        public const int ipAttribDisplayAnchorTail = 3;
        public const int ipAttribDisplayScaled = 4;
        public const int ipAttribDisplaySize = 5;
        public const int ipAttribDisplayThickness = 6;
        public const int ipAttribDisplayCol1 = 7;
        public const int ipAttribDisplayCol2 = 8;
        public const int ipAttribDisplayCol3 = 9;

        // Window Background Modes
        public const int bgSolid = 0;
        public const int bgImage = 1;
        public const int bgGradient = 2;
        public const int bgImageGradient = 3;

        // Window Image Locations
        public const int ilCentre = 0;
        public const int ilTile = 1;
        public const int ilStretch = 2;
        public const int ilTopLeft = 3;
        public const int ilTopRight = 4;
        public const int ilBottomLeft = 5;
        public const int ilBottomRight = 6;

        // Window Display Modes
        public const int wmPreProcessing = 0;
        public const int wmPostProcessing = 1;

        // Numeric Modes
        public const int nmPreProcessing = 0;
        public const int nmPostProcessing = 1;

        // Numeric Styles
        public const int nsFixed = 0;
        public const int nsEngineering = 1;
        public const int nsScientific = 2;
        public const int nsAuto = 3;

        // Exponent formats
        public const int efLowered = 0;
        public const int efRaised = 1;

        // Entity Display Settings - Beam Contour Types
        public const int ctBeamNone = 0;
        public const int ctBeamLength = 1;
        public const int ctBeamAxis1 = 2;
        public const int ctBeamAxis2 = 3;
        public const int ctBeamAxis3 = 4;
        public const int ctBeamEA = 5;
        public const int ctBeamEI11 = 6;
        public const int ctBeamEI22 = 7;
        public const int ctBeamGJ = 8;
        public const int ctBeamEAFactor = 9;
        public const int ctBeamEI11Factor = 10;
        public const int ctBeamEI22Factor = 11;
        public const int ctBeamGJFactor = 12;
        public const int ctBeamOffset1 = 13;
        public const int ctBeamOffset2 = 14;
        public const int ctBeamStiffnessFactor1 = 15;
        public const int ctBeamStiffnessFactor2 = 16;
        public const int ctBeamStiffnessFactor3 = 17;
        public const int ctBeamStiffnessFactor4 = 18;
        public const int ctBeamStiffnessFactor5 = 19;
        public const int ctBeamStiffnessFactor6 = 20;
        public const int ctBeamMassFactor = 21;
        public const int ctBeamSupportM1 = 22;
        public const int ctBeamSupportP1 = 23;
        public const int ctBeamSupportM2 = 24;
        public const int ctBeamSupportP2 = 25;
        public const int ctBeamSupportGapM1 = 26;
        public const int ctBeamSupportGapP1 = 27;
        public const int ctBeamSupportGapM2 = 28;
        public const int ctBeamSupportGapP2 = 29;
        public const int ctBeamTemperature = 30;
        public const int ctBeamTempGradient1 = 31;
        public const int ctBeamTempGradient2 = 32;
        public const int ctBeamPreTension = 33;
        public const int ctBeamPreStrain = 34;
        public const int ctBeamPreCurvature1 = 35;
        public const int ctBeamPreCurvature2 = 36;
        public const int ctBeamPipePressureIn = 37;
        public const int ctBeamPipePressureOut = 38;
        public const int ctBeamPipeTempIn = 39;
        public const int ctBeamPipeTempOut = 40;
        public const int ctBeamConvectionCoeff = 41;
        public const int ctBeamConvectionAmbient = 42;
        public const int ctBeamRadiationCoeff = 43;
        public const int ctBeamRadiationAmbient = 44;
        public const int ctBeamHeatFlux = 45;
        public const int ctBeamHeatSource = 46;
        public const int ctBeamAgeAtFirstLoading = 47;
        public const int ctBeamPropertyName = 48;
        public const int ctBeamMaterialName = 49;
        public const int ctBeamSectionName = 50;
        public const int ctBeamEntityID = 51;

        // Entity Display Settings - Plate Contour Types
        public const int ctPlateNone = 0;
        public const int ctPlateAspectRatioMin = 1;
        public const int ctPlateAspectRatioMax = 2;
        public const int ctPlateWarping = 3;
        public const int ctPlateInternalAngle = 4;
        public const int ctPlateInternalAngleRatio = 5;
        public const int ctPlateArea = 6;
        public const int ctPlateAxis1 = 7;
        public const int ctPlateAxis2 = 8;
        public const int ctPlateAxis3 = 9;
        public const int ctPlateDiscreteThicknessM = 10;
        public const int ctPlateContinuousThicknessM = 11;
        public const int ctPlateDiscreteThicknessB = 12;
        public const int ctPlateContinuousThicknessB = 13;
        public const int ctPlateOffset = 14;
        public const int ctPlateStiffnessFactor1 = 15;
        public const int ctPlateStiffnessFactor2 = 16;
        public const int ctPlateStiffnessFactor3 = 17;
        public const int ctPlateStiffnessFactor4 = 18;
        public const int ctPlateStiffnessFactor5 = 19;
        public const int ctPlateStiffnessFactor6 = 20;
        public const int ctPlateStiffnessFactor7 = 21;
        public const int ctPlateStiffnessFactor8 = 22;
        public const int ctPlateStiffnessFactor9 = 23;
        public const int ctPlateMassFactor = 24;
        public const int ctPlateEdgeNormalSupport = 25;
        public const int ctPlateEdgeLateralSupport = 26;
        public const int ctPlateEdgeSupportGap = 27;
        public const int ctPlateFaceNormalSupportMinusZ = 28;
        public const int ctPlateFaceNormalSupportPlusZ = 29;
        public const int ctPlateFaceLateralSupportMinusZ = 30;
        public const int ctPlateFaceLateralSupportPlusZ = 31;
        public const int ctPlateFaceSupportGapMinusZ = 32;
        public const int ctPlateFaceSupportGapPlusZ = 33;
        public const int ctPlateTemperature = 34;
        public const int ctPlateTempGradient = 35;
        public const int ctPlatePreStressX = 36;
        public const int ctPlatePreStressY = 37;
        public const int ctPlatePreStressZ = 38;
        public const int ctPlatePreStressMagnitude = 39;
        public const int ctPlatePreStrainX = 40;
        public const int ctPlatePreStrainY = 41;
        public const int ctPlatePreStrainZ = 42;
        public const int ctPlatePreStrainMagnitude = 43;
        public const int ctPlatePreCurvatureX = 44;
        public const int ctPlatePreCurvatureY = 45;
        public const int ctPlatePreCurvatureMagnitude = 46;
        public const int ctPlateEdgeNormalPressure = 47;
        public const int ctPlateEdgeShear = 48;
        public const int ctPlateEdgeTransverseShear = 49;
        public const int ctPlateEdgeGlobalPressureX = 50;
        public const int ctPlateEdgeGlobalPressureY = 51;
        public const int ctPlateEdgeGlobalPressureZ = 52;
        public const int ctPlateEdgeGlobalPressure = 53;
        public const int ctPlateNormalPressureMinusZ = 54;
        public const int ctPlateNormalPressurePlusZ = 55;
        public const int ctPlateGlobalPressureXMinusZ = 56;
        public const int ctPlateGlobalPressureYMinusZ = 57;
        public const int ctPlateGlobalPressureZMinusZ = 58;
        public const int ctPlateGlobalPressureMinusZ = 59;
        public const int ctPlateGlobalPressureXPlusZ = 60;
        public const int ctPlateGlobalPressureYPlusZ = 61;
        public const int ctPlateGlobalPressureZPlusZ = 62;
        public const int ctPlateGlobalPressurePlusZ = 63;
        public const int ctPlateFaceShearX = 64;
        public const int ctPlateFaceShearY = 65;
        public const int ctPlateFaceShearMagnitude = 66;
        public const int ctPlateNSMass = 67;
        public const int ctPlateDynamicFactor = 68;
        public const int ctPlateConvectionCoeff = 69;
        public const int ctPlateConvectionAmbient = 70;
        public const int ctPlateRadiationCoeff = 71;
        public const int ctPlateRadiationAmbient = 72;
        public const int ctPlateHeatFlux = 73;
        public const int ctPlateConvectionCoeffPlusZ = 74;
        public const int ctPlateConvectionCoeffMinusZ = 75;
        public const int ctPlateConvectionAmbientPlusZ = 76;
        public const int ctPlateConvectionAmbientMinusZ = 77;
        public const int ctPlateRadiationCoeffPlusZ = 78;
        public const int ctPlateRadiationCoeffMinusZ = 79;
        public const int ctPlateRadiationAmbientPlusZ = 80;
        public const int ctPlateRadiationAmbientMinusZ = 81;
        public const int ctPlateHeatSource = 82;
        public const int ctPlateSoilStressSV = 83;
        public const int ctPlateSoilStressK0 = 84;
        public const int ctPlateSoilStressSH = 85;
        public const int ctPlateSoilRatioOCR = 86;
        public const int ctPlateSoilRatioE0 = 87;
        public const int ctPlateSoilFluidLevel = 88;
        public const int ctPlateAgeAtFirstLoading = 89;
        public const int ctPlatePropertyName = 90;
        public const int ctPlateMaterialName = 91;
        public const int ctPlateEntityID = 92;

        // Entity Display Settings - Brick Contour Types
        public const int ctBrickNone = 0;
        public const int ctBrickAspectRatioMin = 1;
        public const int ctBrickAspectRatioMax = 2;
        public const int ctBrickDeterminant = 3;
        public const int ctBrickInternalAngle = 4;
        public const int ctBrickMixedProduct = 5;
        public const int ctBrickDihedral = 6;
        public const int ctBrickVolume = 7;
        public const int ctBrickAxis1 = 8;
        public const int ctBrickAxis2 = 9;
        public const int ctBrickAxis3 = 10;
        public const int ctBrickNormalSupport = 11;
        public const int ctBrickLateralSupport = 12;
        public const int ctBrickSupportGap = 13;
        public const int ctBrickTemperature = 14;
        public const int ctBrickPreStressX = 15;
        public const int ctBrickPreStressY = 16;
        public const int ctBrickPreStressZ = 17;
        public const int ctBrickPreStressMagnitude = 18;
        public const int ctBrickPreStrainX = 19;
        public const int ctBrickPreStrainY = 20;
        public const int ctBrickPreStrainZ = 21;
        public const int ctBrickPreStrainMagnitude = 22;
        public const int ctBrickNormalPressure = 23;
        public const int ctBrickGlobalPressureX = 24;
        public const int ctBrickGlobalPressureY = 25;
        public const int ctBrickGlobalPressureZ = 26;
        public const int ctBrickGlobalPressureMagnitude = 27;
        public const int ctBrickShearX = 28;
        public const int ctBrickShearY = 29;
        public const int ctBrickShearMagnitude = 30;
        public const int ctBrickNSMass = 31;
        public const int ctBrickDynamicFactor = 32;
        public const int ctBrickConvectionCoeff = 33;
        public const int ctBrickConvectionAmbient = 34;
        public const int ctBrickRadiationCoeff = 35;
        public const int ctBrickRadiationAmbient = 36;
        public const int ctBrickHeatFlux = 37;
        public const int ctBrickHeatSource = 38;
        public const int ctBrickSoilStressSV = 39;
        public const int ctBrickSoilStressK0 = 40;
        public const int ctBrickSoilStressSH = 41;
        public const int ctBrickSoilRatioOCR = 42;
        public const int ctBrickSoilRatioE0 = 43;
        public const int ctBrickSoilFluidLevel = 44;
        public const int ctBrickAgeAtFirstLoading = 45;
        public const int ctBrickPropertyName = 46;
        public const int ctBrickMaterialName = 47;
        public const int ctBrickEntityID = 48;

        // Beam/Plate/Brick/Link Result Display Type - INDEXED BY ipResultType
        public const int rtAsNone = 0;
        public const int rtAsContour = 1;
        public const int rtAsDiagram = 2;
        public const int rtAsVector = 3;

        // Node Output Display Quantity - Indexed by ipResultQuantity
        public const int rqDispC = 101;
        public const int rqInfluenceC = 101;
        public const int rqVelC = 102;
        public const int rqAccC = 103;
        public const int rqPhaseC = 104;
        public const int rqReactC = 105;
        public const int rqTempC = 106;
        public const int rqNodeForceC = 107;
        public const int rqNodeFluxC = 108;
        public const int rqNodeInertiaC = 109;

        // Beam Output Display Quantity - Indexed by ipResultQuantity
        public const int rqBeamForceC = 201;
        public const int rqBeamStrainC = 202;
        public const int rqBeamStressC = 203;
        public const int rqBeamCreepStrainC = 204;
        public const int rqBeamEnergyC = 205;
        public const int rqBeamFluxC = 206;
        public const int rqBeamTGradC = 207;
        public const int rqBeamTotalStrainC = 208;
        public const int rqBeamUserC = 299;

        // Plate Output Display Quantity - Indexed by ipResultQuantity
        public const int rqPlateForceC = 301;
        public const int rqPlateMomentC = 302;
        public const int rqPlateStressC = 303;
        public const int rqPlateStrainC = 304;
        public const int rqPlateCurvatureC = 305;
        public const int rqPlateCreepStrainC = 306;
        public const int rqPlateEnergyC = 307;
        public const int rqPlateFluxC = 308;
        public const int rqPlateTGradC = 309;
        public const int rqPlateRCDesignC = 310;
        public const int rqPlatePlyStressC = 311;
        public const int rqPlatePlyStrainC = 312;
        public const int rqPlatePlyReserveC = 313;
        public const int rqPlateSoilC = 314;
        public const int rqPlateTotalStrainC = 315;
        public const int rqPlateTotalCurvatureC = 316;
        public const int rqPlateUserC = 399;

        // Brick Output Display Quantity - Indexed by ipResultQuantity
        public const int rqBrickStressC = 401;
        public const int rqBrickStrainC = 402;
        public const int rqBrickCreepStrainC = 403;
        public const int rqBrickEnergyC = 404;
        public const int rqBrickFluxC = 405;
        public const int rqBrickTGradC = 406;
        public const int rqBrickSoilC = 407;
        public const int rqBrickTotalStrainC = 408;
        public const int rqBrickUserC = 499;

        // Link Output Display Quantity - Indexed by ipResultQuantity
        public const int rqLinkForceC = 501;
        public const int rqLinkFluxC = 502;
        public const int rqLinkMPLReactionC = 503;

        // Plate RC Output Display Sub-quantity - Indexed by ipResultComponent
        public const int rcWoodArmerMoment = 0;
        public const int rcWoodArmerForce = 1;
        public const int rcSteelRequirementMin = 2;
        public const int rcConcreteStrain = 3;
        public const int rcSteelRequirementLessBase = 4;
        public const int rcUserSteelStress = 5;
        public const int rcUserConcreteStrain = 6;
        public const int rcBlockRatio = 7;

        // Plate RC Area Output Display Sub-quantity - Indexed by ipResultSystem
        public const int rsAreaPerLength = 0;
        public const int rsBarSpacing = 1;
        public const int rsBarDiameter = 2;
        public const int rsAreaPerAreaSlab = 3;
        public const int rsAreaPerAreaBase = 4;

        // Plate Composite Output Display Sub-quantity - Indexed by ipResultSystem
        public const int rsPlyMinValue = -1;
        public const int rsPlyMaxValue = -2;
        public const int rsPlyMaxMag = -3;
        public const int rsPlyMinValueActivePlies = -4;
        public const int rsPlyMaxValueActivePlies = -5;
        public const int rsPlyMaxMagActivePlies = -6;

        // Vector Styles - Indexed by ipVectorStyle
        public const int vtVectorTranslationMag = 1;
        public const int vtVectorRotationMag = 2;
        public const int vtVectorTranslationComponents = 3;
        public const int vtVectorRotationComponents = 4;

        // Result Display Indexes
        public const int ipResultType = 0;
        public const int ipResultQuantity = 1;
        public const int ipResultSystem = 2;
        public const int ipResultComponent = 3;
        public const int ipResultSurface = 4;
        public const int ipVectorStyle = 5;
        public const int ipReferenceNode = 6;
        public const int ipAbsoluteValue = 7;
        public const int ipDiagram1 = 7;
        public const int ipDiagram2 = 8;
        public const int ipDiagram3 = 9;
        public const int ipDiagram4 = 10;
        public const int ipDiagram5 = 11;
        public const int ipDiagram6 = 12;
        public const int ipVector1 = 7;
        public const int ipVector2 = 8;
        public const int ipVector3 = 9;
        public const int ipVector4 = 10;
        public const int ipVector5 = 11;
        public const int ipVector6 = 12;

        // Contour Settings - Style Constants
        public const int csRainbow = 0;
        public const int csRainbowEnds = 1;
        public const int csMono = 2;
        public const int csLines = 3;
        public const int csBands = 4;

        // Vector Settings - Constants
        public const int vaTail = 0;
        public const int vaHead = 1;
        public const int vaBoth = 2;

        // Contour Settings - Style Indexes
        public const int ipContourStyle = 0;
        public const int ipReverse = 1;
        public const int ipSeparator = 2;
        public const int ipBand1Colour = 3;
        public const int ipBand2Colour = 4;
        public const int ipSeparatorColour = 5;
        public const int ipLineBackColour = 6;
        public const int ipMonoColour = 7;
        public const int ipMinColour = 8;
        public const int ipMaxColour = 9;
        public const int ipLimitMin = 10;
        public const int ipLimitMax = 11;
        public const int ipVectorThickness = 12;
        public const int ipVectorLength = 13;
        public const int ipVectorAnchor = 14;

        // Contour Settings - Limits Constants
        public const int clDefault = 0;
        public const int clUserRange = 1;
        public const int clRounded = 2;
        public const int clUserSpecified = 3;
        public const int cmContinuous = 0;
        public const int cmDiscrete = 1;

        // Contour Settings - Limits Indexes
        public const int ipContourLimit = 0;
        public const int ipContourMode = 1;
        public const int ipNumContours = 2;
        public const int ipSetMinLimit = 3;
        public const int ipSetMaxLimit = 4;
        public const int ipMinLimit = 0;
        public const int ipMaxLimit = 1;

        // Contour Settings - Legend Constants
        public const int lpNone = 0;
        public const int lpTopLeft = 1;
        public const int lpTopRight = 2;
        public const int lpBottomLeft = 3;
        public const int lpBottomRight = 4;
        public const int lpFloating = 5;

        // Contour Settings - Legend Indexes
        public const int ipLegendPosition = 0;
        public const int ipOpaqueLegend = 1;
        public const int ipShowMinMax = 2;
        public const int ipHistogram = 3;
        public const int ipLegendWidth = 4;
        public const int ipLegendHeight = 5;

        // Contour Settings - Diagram Constants
        public const int dsSingleLine = 0;
        public const int dsHatched = 1;

        // Beam Moment Side
        public const int bmTensionSide = 0;
        public const int bmCompressionSide = 1;

        // Contour Settings - Diagram Indexes
        public const int ipDiagramStyle = 0;
        public const int ipDiagramAxialDir = 1;
        public const int ipDiagramTorqueDir = 2;
        public const int ipDiagramRelativeLength = 3;
        public const int ipDiagramThickness = 4;
        public const int ipDiagramMomentSide = 5;

        // Font Settings
        public const int ipFontSize = 0;
        public const int ipFontColour = 1;
        public const int ipFontStyleBold = 2;
        public const int ipFontStyleItalic = 3;
        public const int ipFontStyleUnderline = 4;

        // Displacement Scales
        public const int dsPercent = 0;
        public const int dsAbsolute = 1;

        // Reference Displacement Modes
        public const int rdNone = 0;
        public const int rdPreviousCase = -1;

        // User Contour File Types
        public const int ucNode = 0;
        public const int ucElement = 1;

        // Utility
        public const int auRadian = 0;
        public const int auDegree = 1;

        // Transient Base Modes
        public const int bmRelative = 0;
        public const int bmTotal = 1;

        // Beam Position Modes
        public const int bpLength = 0;
        public const int bpParam = 1;

        // Result Options
        public const int ipResOptsRotationUnit = 0;
        public const int ipResOptsStrainUnit = 1;
        public const int ipResOptsAddGNLDisp = 2;
        public const int ipResOptsOffsetDisp = 3;
        public const int ipResOptsNFADisp = 4;
        public const int ipResOptsReactionLinkGNL = 5;
        public const int ipResOptsBaseDisp = 6;
        public const int ipResOptsBaseVel = 7;
        public const int ipResOptsBaseAcc = 8;

        // Result Options - Strain Units
        public const int suUnit = 0;
        public const int suPercent = 1;
        public const int suMicro = 2;

        // Result Options - NFA Displacement Modes
        public const int dmUnitModalMass = 0;
        public const int dmEngModalMass = 1;

        // Tool Options - Doubles
        public const int ipToolOptsElementTol = 0;
        public const int ipToolOptsGeometryAccuracy = 1;
        public const int ipToolOptsGeometryFeatureLength = 2;

        // Tool Options - Integers
        public const int ipToolOptsElementTolType = 0;
        public const int ipToolOptsGeometryAccuracyType = 1;
        public const int ipToolOptsGeometryFeatureType = 2;
        public const int ipToolOptsZipMesh = 3;
        public const int ipToolOptsNodeCoordinate = 4;
        public const int ipToolOptsNodeAttributeKeep = 5;
        public const int ipToolOptsAllowZeroLengthLinks = 6;
        public const int ipToolOptsAllowZeroLengthBeams = 7;
        public const int ipToolOptsSubdivideBeams = 10;
        public const int ipToolOptsInterpSideAttachments = 11;
        public const int ipToolOptsCompatibleTriangle = 12;
        public const int ipToolOptsAdjustMidsideNodes = 13;
        public const int ipToolOptsEvaluateFormulas = 14;
        public const int ipToolOptsPlateAxisAlign = 15;
        public const int ipToolOptsWedgeSubdivision = 16;
        public const int ipToolOptsCopyMode = 17;
        public const int ipToolOptsAutoCreateProperties = 18;
        public const int ipToolOptsInsertMPLNodes = 19;
        public const int ipToolOptsConsiderDroopedCables = 20;
        public const int ipToolOptsConsiderBeam3 = 21;

        // Tool Options - Copy Flags
        public const int ipCopyNodeVertexAttributes = 0;
        public const int ipCopyElementFaceAttributes = 1;
        public const int ipIncrementStringID = 2;
        public const int ipCreateNewGroup = 3;
        public const int ipIncrementClusterID = 4;
        public const int ipCopyAxisUCS = 5;

        // Tool Options - Extrude Flags
        public const int ipExtrudePlateEdgeAttributes = 0;

        // Tool Options - Extrude Targets
        public const int ipExtrudeNodeTarget = 0;
        public const int ipExtrudeNodeTargetOption = 1;
        public const int ipExtrudeNodeTargetUCS = 2;
        public const int ipExtrudeBeamTarget = 3;
        public const int ipExtrudeShrinkFreedomCase = 4;
        public const int ipExtrudeLinksAsMPL = 5;
        public const int ipExtrudePlateTarget = 6;

        // Tool Options - Mesh Zipping
        public const int zmAsNeeded = 0;
        public const int zmOnSave = 1;
        public const int zmOnRequest = 2;

        // Tool Options - Copy Mode
        public const int cmRoot = 0;
        public const int cmSibling = 1;

        // Tool Options - Axis Alignment
        public const int paCentroid = 0;
        public const int paCurvilinear = 1;

        // Tool Options - Wedge Subdivision
        public const int wsUseAB = 0;
        public const int wsUseAC = 1;

        // Tool Options - Source Action
        public const int saLeave = 0;
        public const int saDelete = 1;
        public const int saCopy = 2;
        public const int saMove = 3;

        // Tool Options - Extrude Target - Node
        public const int etBeam2 = 0;
        public const int etBeam3 = 1;
        public const int etMasterSlaveLink = 2;
        public const int etPinnedLink = 3;
        public const int etRigidLink = 4;
        public const int etShrinkLink = 5;

        // Tool Options - Scale by UCS - Scale About
        public const int saMiddle = 0;
        public const int saOrigin = 1;
        public const int saPoint = 2;

        // Tool Options - Extrude Target - Beam
        public const int etPlateQuad4 = 0;
        public const int etPlateQuad8 = 1;
        public const int etPlateQuad9 = 2;

        // Tool Options - Extrude Target - Plate
        public const int ptFaceAsBrick = 0;
        public const int ptEdgeAsPlate = 1;

        // Tool Options - Detach Elements - Connection Type
        public const int ctNone = 0;
        public const int ctMasterSlaveLink = 1;
        public const int ctBeam2 = 2;

        // Tool Options - Points and Lines - Target
        public const int plNode = 0;
        public const int plBeam2 = 1;
        public const int plBeam3 = 2;

        // Tool Options - Subdivide Target - Plate
        public const int stPlateTri3 = 0;
        public const int stPlateTri6 = 1;
        public const int stPlateQuad4 = 2;
        public const int stPlateQuad8 = 3;
        public const int stPlateQuad9 = 4;
        public const int stPlateSource = 5;
        public const int stPlateTri = 6;
        public const int stPlateQuad = 7;

        // Tool Options - Subdivide Target - Brick
        public const int stBrickTetra4 = 0;
        public const int stBrickTetra10 = 1;
        public const int stBrickWedge6 = 2;
        public const int stBrickWedge15 = 3;
        public const int stBrickHexa8 = 4;
        public const int stBrickHexa16 = 5;
        public const int stBrickHexa20 = 6;
        public const int stBrickSource = 7;
        public const int stBrickTetra = 8;
        public const int stBrickWedge = 9;
        public const int stBrickHexa = 10;

        // Tool Options - Grade Type
        public const int gt1x2Grade = 0;
        public const int gt1x2TriGrade = 1;
        public const int gt1x3Grade = 2;
        public const int gt2x3Grade = 3;
        public const int gt2x3TriGrade = 4;
        public const int gtQuarterQuadGrade = 5;
        public const int gtQuarterCircleCut = 6;
        public const int gtQuarterAnnulusCut = 7;
        public const int gtFullQuarterCircleCut = 8;
        public const int gtTriGrade2 = 9;
        public const int gtTriGrade1 = 10;
        public const int gtTriGrade3 = 11;
        public const int gt2x4Grade = 12;
        public const int gtBrickCornerGrade = 13;
        public const int gtQuadTriGrade1 = 14;
        public const int gtTriGrade5 = 15;
        public const int gtQuadCutOut = 16;
        public const int gtTriGrade4 = 17;
        public const int gtFullQuarterCircleGrade = 18;
        public const int gtQuadGradeTri = 19;

        // Tool Options - Beams on Edges
        public const int eeSplit = 0;
        public const int eeIgnoreMid = 1;
        public const int eeBeam3 = 2;
        public const int geBeam2 = 0;
        public const int geBeam3 = 1;

        // Tool Options - Create Entity UCS
        public const int puCylindrical = 0;
        public const int puCartesian = 1;

        // Tool Options - Create Entity UCS
        public const int buPrincipal = 0;
        public const int buLocal = 1;

        // Tool Options - Create Entity UCS
        public const int ulAtMin = 0;
        public const int ulAtMax = 1;
        public const int ulAtMean = 2;

        // Tools Options - Align Beam Offsets - Sections
        public const int ipCircularSection = 0;
        public const int ipSquareSection = 1;
        public const int ipCSection = 2;
        public const int ipISection = 3;
        public const int ipTSection = 4;
        public const int ipLSection = 5;
        public const int ipZSection = 6;
        public const int ipBXSSection = 7;
        public const int ipTrapezoidalSection = 8;
        public const int ipTriangularSection = 9;
        public const int ipCruciformSection = 10;
        public const int ipUndefinedSection = 11;

        // Tools Options - Align Beam Offsets - Section Offsets
        public const int soNoChange = 0;
        public const int soTopLeft = 1;
        public const int soTopMid = 2;
        public const int soTopRight = 3;
        public const int soMidLeft = 4;
        public const int soGeometricCenter = 5;
        public const int soMidRight = 6;
        public const int soBottomLeft = 7;
        public const int soBottomMid = 8;
        public const int soBottomRight = 9;
        public const int soCentroid = 10;
        public const int soShearCenter = 11;

        // Tools Options - Merge Line of Beams
        public const int mbStatic = 0;
        public const int mbDynamic = 1;

        // Tool Options - Reinforcement Alignment
        public const int raLayer13 = 1;
        public const int raLayer24 = 2;

        // Tool Options - Extrude by Line Direction
        public const int ldAuto = 0;
        public const int ldReversed = 1;

        // Tool Options - Create Beams on Element Edges
        public const int beBasedOnModel = 0;
        public const int beBasedOnSelected = 1;

        // Tool Options - ReactionMPL at specified origin
        public const int ocUseOrigin = -1;
        public const int ocUseNodeAverage = 0;

        // Tool Options - Geometry Detach modes
        public const int dmDetachIndividual = 0;
        public const int dmDetachAsCluster = 1;
        public const int dmDetachGroups = 2;

        // Copy-Paste - Constants
        public const int poCasesInOrder = 0;
        public const int poCasesMatchNames = 1;
        public const int poCasesNewData = 2;
        public const int poPropertiesUsePropertyID = 0;
        public const int poPropertiesMatchExisting = 1;
        public const int poPropertiesCreateNew = 2;
        public const int poLoadPathUseTemplateID = 0;
        public const int poLoadPathCreateNew = 1;

        // Detach Elements - Indexes
        public const int ipDetachConnectionType = 0;
        public const int ipDetachUCSId = 1;
        public const int ipDetachDoFBits = 2;
        public const int ipDetachPropNum = 3;
        public const int ipDetachUseElementGroup = 4;
        public const int ipDetachDetectCorners = 5;

        // Copy-Paste - Indexes
        public const int ipPasteCases = 0;
        public const int ipPasteProperties = 1;
        public const int ipPasteLoadPaths = 2;
        public const int ipPasteAttributes = 3;
        public const int ipPasteGroups = 4;
        public const int ipPasteGlobals = 5;
        public const int ipPasteTables = 6;
        public const int ipPasteSets = 7;

        // Adjacency - Indexes
        public const int ipAdjIncludeBeams = 0;
        public const int ipAdjIncludePlates = 1;
        public const int ipAdjIncludeBricks = 2;
        public const int ipAdjIncludeLinks = 3;
        public const int ipAdjIncludeSelected = 4;
        public const int ipAdjIncludeUnselected = 5;
        public const int ipAdjIgnoreBeamRefN = 6;

        // Insitu Parameters
        public const int ipInsituGravityCase = 0;
        public const int ipInsituFreedomCase = 1;
        public const int ipInsituStageIndex = 2;
        public const int ipInsituUseExisting = 3;
        public const int ipInsituReplaceK0 = 4;
        public const int ipInsituMaxIterations = 5;
        public const int ipInsituAllowIterations = 6;
        public const int ipInsituSolverScheme = 7;
        public const int ipInsituMatrixSort = 8;
        public const int ipInsituDefaultFluidLevel = 0;
        public const int ipInsituDefaultFluidDensity = 1;

        // Insitu Warning Codes
        public const int wcInsituNoWarning = 0;
        public const int wcInsituUnconverged = 1;
        public const int wcInsituTensileStress = 2;

        // LSA Combinations Warning Codes
        public const int wcLSACombineNoWarning = 0;
        public const int wcLSACombineInvalidSRA = 1;

        // Axis Definitions
        public const int axLocalX = 1;
        public const int axLocalY = 2;
        public const int axPrincipal1 = 1;
        public const int axPrincipal2 = 2;
        public const int axBeamPrincipal = 0;
        public const int axBeamLocal = 1;

        // Beam Taper
        public const int btSymm = 0;
        public const int btTop = 1;
        public const int btBottom = 2;

        // Pre-load
        public const int plBeamPreTension = 0;
        public const int plBeamPreStrain = 1;
        public const int plPlatePreStress = 0;
        public const int plPlatePreStrain = 1;
        public const int plBrickPreStress = 0;
        public const int plBrickPreStrain = 1;
        public const int plCavityPreStress = 0;
        public const int plCavityPreStrain = 1;

        // Attachment Attribute
        public const int alRigid = 0;
        public const int alFlexible = 1;
        public const int alDirect = 2;
        public const int alMoment = 0;
        public const int alPinned = 1;

        // LTA Methods
        public const int ltWilson = 0;
        public const int ltNewmark = 1;

        // Spectral
        public const int stResponse = 0;
        public const int stPSD = 1;

        // Spectral Results Sign
        public const int rsAuto = 0;
        public const int rsAbsolute = 1;

        // LTA
        public const int stFullSystem = 0;
        public const int stSuperposition = 1;

        // Create Attachments - Brick Target
        public const int ktFreeFaces = 0;
        public const int ktAllFaces = 1;
        public const int ktInsideBricks = 2;

        // Transient Initial Conditions
        public const int icNone = 0;
        public const int icAppliedVectors = 1;
        public const int icNodalVelocity = 2;
        public const int icFromFile = 3;

        // Transient and QuasiStatic Temperature
        public const int ttNodalTemp = 0;
        public const int ttFromFile = 1;

        // Envelopes
        public const int etLimitEnvelopeAbs = 0;
        public const int etLimitEnvelopeMin = 1;
        public const int etLimitEnvelopeMax = 2;
        public const int etLimitEnvelopeMag = 3;
        public const int etCombEnvelopeMin = 0;
        public const int etCombEnvelopeMax = 1;
        public const int etFactEnvelopeMin = 0;
        public const int etFactEnvelopeMax = 1;
        public const int esCombEnvelopeOn = 0;
        public const int esCombEnvelopeOff = 1;
        public const int esCombEnvelopeCheck = 2;
        public const int stExclusiveOR = 0;
        public const int stExclusiveAND = 1;

        // Frequency Table Units
        public const int fuNone = 0;
        public const int fuDispResponse = 1;
        public const int fuVelResponse = 2;
        public const int fuAccelResponse = 3;
        public const int fuDispPSD = 4;
        public const int fuVelPSD = 5;
        public const int fuAccelPSD = 6;
        public const int fuAccelResponseG = 7;
        public const int fuAccelPSDG = 8;

        // Temp/Time Types
        public const int mtElastic = 0;
        public const int mtPlastic = 1;

        // Material Hardening Types
        public const int htIsotropic = 0;
        public const int htKinematic = 1;
        public const int htTakeda = 2;

        // Spring-damper
        public const int ipSpringAxialStiff = 0;
        public const int ipSpringLateralStiff = 1;
        public const int ipSpringTorsionStiff = 2;
        public const int ipSpringAxialDamp = 3;
        public const int ipSpringLateralDamp = 4;
        public const int ipSpringTorsionDamp = 5;
        public const int ipSpringMass = 6;

        // Truss
        public const int ipTrussIncludeTorsion = 0;

        // Cable - Integers
        public const int ipCablePreStrainScalesMass = 0;

        // Cable - Doubles
        public const int ipCableDiameter = 0;

        // Cutoff Bar
        public const int ipCutoffTension = 0;
        public const int ipCutoffCompression = 1;

        // Contact
        public const int cfElastic = 0;
        public const int cfPlastic = 1;
        public const int cyRectangular = 0;
        public const int cyElliptical = 1;

        // Thermal data
        public const int ipThermalArea = 0;
        public const int ipThermalMass = 1;

        // Ply Material - Integers
        public const int ipPlyWeaveType = 0;
        public const int wtPlyUniDirectional = 0;
        public const int wtPlyBiDirectional = 1;
        public const int wtPlyTriDirectional = 2;
        public const int wtPlyQuasiIsotropic = 3;

        // Ply Material - Doubles
        public const int ipPlyModulus1 = 0;
        public const int ipPlyModulus2 = 1;
        public const int ipPlyPoisson = 2;
        public const int ipPlyShear12 = 3;
        public const int ipPlyShear13 = 4;
        public const int ipPlyShear23 = 5;
        public const int ipPlyAlpha1 = 6;
        public const int ipPlyAlpha2 = 7;
        public const int ipPlyDensity = 8;
        public const int ipPlyThickness = 9;
        public const int ipPlyS1Tension = 10;
        public const int ipPlyS2Tension = 11;
        public const int ipPlyS1Compression = 12;
        public const int ipPlyS2Compression = 13;
        public const int ipPlySShear = 14;
        public const int ipPlyE1Tension = 15;
        public const int ipPlyE2Tension = 16;
        public const int ipPlyE1Compression = 17;
        public const int ipPlyE2Compression = 18;
        public const int ipPlyEShear = 19;
        public const int ipPlyInterLaminaShear = 20;

        // Laminate Material
        public const int ipLaminateViscosity = 0;
        public const int ipLaminateDampingRatio = 1;
        public const int ipLaminateConductivity1 = 2;
        public const int ipLaminateConductivity2 = 3;
        public const int ipLaminateSpecificHeat = 4;
        public const int ipLaminateDensity = 5;
        public const int ipLaminateAlphax = 6;
        public const int ipLaminateAlphay = 7;
        public const int ipLaminateAlphaxy = 8;
        public const int ipLaminateBetax = 9;
        public const int ipLaminateBetay = 10;
        public const int ipLaminateBetaxy = 11;
        public const int ipLaminateModulusx = 12;
        public const int ipLaminateModulusy = 13;
        public const int ipLaminateShearxy = 14;
        public const int ipLaminatePoissonxy = 15;
        public const int ipLaminatePoissonyx = 16;
        public const int ipLaminateThickness = 17;

        // Laminate Plies
        public const int ipLaminatePlyAngle = 0;
        public const int ipLaminatePlyThickness = 1;

        // Laminate Matrices
        public const int ipLaminateIgnoreCoupling = 0;
        public const int ipLaminateAutoTransverseShear = 1;
        public const int ipLaminateSingularMatrix = 2;

        // Concrete Reinforcement Layouts - Integers
        public const int ipRCLayoutType = 0;
        public const int ipRCColour13 = 1;
        public const int ipRCColour24 = 2;
        public const int ipRCCalcMethod = 3;
        public const int ipRCConsiderMembrane = 4;
        public const int ipRCAllowCompressionReo = 5;
        public const int ipRCCode = 6;
        public const int ipRCLimitConcreteStrain = 7;
        public const int ipRCUseMembraneThickness = 8;
        public const int ipRCWoodArmerForce = 9;
        public const int crEC2 = 0;
        public const int crAS3600 = 1;
        public const int crACI318 = 2;
        public const int crRCSymmetric = 0;
        public const int crRCAntiSymmetric = 1;
        public const int crRCSimplified = 0;
        public const int crRCElastoPlasticIter = 1;
        public const int crRCWoodArmerShearForceMag = 0;
        public const int crRCWoodArmerShearForceSign = 1;
        public const int crRCWoodArmerShearForceNone = 2;

        // Concrete Reinforcement Layouts - Doubles
        public const int ipRCDiam1 = 0;
        public const int ipRCDiam2 = 1;
        public const int ipRCDiam3 = 2;
        public const int ipRCDiam4 = 3;
        public const int ipRCCover1 = 4;
        public const int ipRCCover2 = 5;
        public const int ipRCSpacing1 = 6;
        public const int ipRCSpacing2 = 7;
        public const int ipRCSpacing3 = 8;
        public const int ipRCSpacing4 = 9;
        public const int ipRCConcreteModulus = 10;
        public const int ipRCConcreteStrain = 11;
        public const int ipRCConcreteStress = 12;
        public const int ipRCConcreteAlpha = 13;
        public const int ipRCConcreteGamma = 14;
        public const int ipRCSteelModulus = 15;
        public const int ipRCSteelStress = 16;
        public const int ipRCSteelGamma = 17;
        public const int ipRCSteelMinArea = 18;
        public const int ipRCReduction = 19;
        public const int ipRCConcreteEta = 20;

        // Cavity Fluid Layout Types
        public const int ftIdealGas = 0;
        public const int ftConstantBulkModulus = 1;

        // Cavity Fluid Stiffness Options
        public const int cfNoK = 0;
        public const int cfApproximateK = 1;
        public const int cfCompleteK = 2;

        // Cavity Fluid Layouts - Integers
        public const int ipCFColour = 0;
        public const int ipCFMultipleAsOne = 1;
        public const int ipCFConsiderTemperature = 2;
        public const int ipCFPressureControlCase = 3;
        public const int ipCFAssembleStiffness = 4;

        // Cavity Fluid Layouts - Ideal Gas Doubles
        public const int ipCFInitialPressure = 0;
        public const int ipCFInitialTemperature = 1;

        // Cavity Fluid Layouts - Constant Bulk Modulus Doubles
        public const int ipCFBulkModulus = 0;
        public const int ipCFAlpha = 1;

        // Creep Hardening
        public const int ipCreepHardeningType = 0;
        public const int ipCreepHardeningCyclic = 1;
        public const int crHardeningTime = 0;
        public const int crHardeningStrain = 1;

        // Hyperbolic Creep - Doubles
        public const int ipCreepHyberbolicAlpha = 0;
        public const int ipCreepHyperbolicBeta = 1;
        public const int ipCreepHyperbolicDelta = 2;
        public const int ipCreepHyperbolicPhi = 3;

        // Hyperbolic Creep - Integers
        public const int ipCreepHyperbolicTimeTable = 0;
        public const int ipCreepHyperbolicConstModulus = 1;

        // Visco-elastic Creep - Integers
        public const int ipCreepViscoTimeTable = 0;
        public const int ipCreepViscoTempTable = 1;

        // Visco-elastic Creep - Doubles
        public const int ipCreepViscoDamper = 0;
        public const int ipCreepViscoStiffness = 1;

        // Creep Concrete Functions
        public const int crCreepFunction = 0;
        public const int crRelaxationFunction = 1;

        // Creep Shrinkage
        public const int crCreepShrinkageTable = 0;
        public const int crCreepShrinkageFormula = 1;
        public const int ipCreepShrinkageAlpha = 0;
        public const int ipCreepShrinkageBeta = 1;
        public const int ipCreepShrinkageDelta = 2;
        public const int ipCreepShrinkageStrain = 3;

        // Creep Temperature - Integers
        public const int ipIncludeCreepTemperature = 0;
        public const int ipIncludeRateTemperature = 1;
        public const int ipIncludeShrinkageTemperature = 2;

        // Creep Temperature - Doubles
        public const int ipCreepCAAge = 0;
        public const int ipCreepTRefAge = 1;
        public const int ipCreepCCCreep = 2;
        public const int ipCreepTRefCreep = 3;
        public const int ipCreepCAShrink = 4;
        public const int ipCreepTRefShrink = 5;

        // Cement Curing - Integers
        public const int ipCreepIncludeCuring = 0;
        public const int ipCreepCuringTimeTable = 1;
        public const int ipCreepCuringType = 2;
        public const int crCementCuringRapid = 0;
        public const int crCementCuringNormal = 1;
        public const int crCementCuringSlow = 2;

        // Cement Curing - Doubles
        public const int ipCreepCuringCT = 0;
        public const int ipCreepCuringTRef = 1;
        public const int ipCreepCuringT0 = 2;

        // Stage Data
        public const int ipStageMorph = 0;
        public const int ipStageMoveFixedNodes = 1;
        public const int ipStageRotateClusters = 2;
        public const int ipStageSetFluidLevel = 3;
        public const int ipStageReset = 4;

        // Node Response Variables
        public const int rvNodeDisplacement = 0;
        public const int rvNodeReaction = 1;

        // Beam Response Variables
        public const int ipBeamResponseSF1 = 0;
        public const int ipBeamResponseSF2 = 1;
        public const int ipBeamResponseAxial = 2;
        public const int ipBeamResponseBM1 = 3;
        public const int ipBeamResponseBM2 = 4;
        public const int ipBeamResponseTorque = 5;

        // Plate Response Variables
        public const int rvPlateForce = 0;
        public const int rvPlateMoment = 1;

        // Pipe Properties
        public const int ipPipeFlexibility = 0;
        public const int ipPipeFluidDensity = 1;
        public const int ipPipeOuterDiameter = 2;
        public const int ipPipeThickness = 3;

        // Connection Properties
        public const int ipConnectionShear1 = 0;
        public const int ipConnectionShear2 = 1;
        public const int ipConnectionAxial = 2;
        public const int ipConnectionBend1 = 3;
        public const int ipConnectionBend2 = 4;
        public const int ipConnectionTorque = 5;

        // Beam Materials
        public const int ipBeamModulus = 0;
        public const int ipBeamShear = 1;
        public const int ipBeamPoisson = 2;
        public const int ipBeamDensity = 3;
        public const int ipBeamAlpha = 4;
        public const int ipBeamViscosity = 5;
        public const int ipBeamDampingRatio = 6;
        public const int ipBeamConductivity = 7;
        public const int ipBeamSpecificHeat = 8;

        // Plate Isotropic Materials
        public const int ipPlateIsoModulus = 0;
        public const int ipPlateIsoPoisson = 1;
        public const int ipPlateIsoDensity = 2;
        public const int ipPlateIsoAlpha = 3;
        public const int ipPlateIsoViscosity = 4;
        public const int ipPlateIsoDampingRatio = 5;
        public const int ipPlateIsoConductivity = 6;
        public const int ipPlateIsoSpecificHeat = 7;

        // Brick Isotropic Materials
        public const int ipBrickIsoModulus = 0;
        public const int ipBrickIsoPoisson = 1;
        public const int ipBrickIsoDensity = 2;
        public const int ipBrickIsoAlpha = 3;
        public const int ipBrickIsoViscosity = 4;
        public const int ipBrickIsoDampingRatio = 5;
        public const int ipBrickIsoConductivity = 6;
        public const int ipBrickIsoSpecificHeat = 7;

        // Plate Orthotropic Materials
        public const int ipPlateOrthoModulus1 = 0;
        public const int ipPlateOrthoModulus2 = 1;
        public const int ipPlateOrthoModulus3 = 2;
        public const int ipPlateOrthoShear12 = 3;
        public const int ipPlateOrthoShear23 = 4;
        public const int ipPlateOrthoShear31 = 5;
        public const int ipPlateOrthoPoisson12 = 6;
        public const int ipPlateOrthoPoisson23 = 7;
        public const int ipPlateOrthoPoisson31 = 8;
        public const int ipPlateOrthoDensity = 9;
        public const int ipPlateOrthoAlpha1 = 10;
        public const int ipPlateOrthoAlpha2 = 11;
        public const int ipPlateOrthoAlpha3 = 12;
        public const int ipPlateOrthoViscosity = 13;
        public const int ipPlateOrthoDampingRatio = 14;
        public const int ipPlateOrthoConductivity1 = 15;
        public const int ipPlateOrthoConductivity2 = 16;
        public const int ipPlateOrthoSpecificHeat = 17;

        // Brick Orthotropic Materials
        public const int ipBrickOrthoModulus1 = 0;
        public const int ipBrickOrthoModulus2 = 1;
        public const int ipBrickOrthoModulus3 = 2;
        public const int ipBrickOrthoShear12 = 3;
        public const int ipBrickOrthoShear23 = 4;
        public const int ipBrickOrthoShear31 = 5;
        public const int ipBrickOrthoPoisson12 = 6;
        public const int ipBrickOrthoPoisson23 = 7;
        public const int ipBrickOrthoPoisson31 = 8;
        public const int ipBrickOrthoDensity = 9;
        public const int ipBrickOrthoAlpha1 = 10;
        public const int ipBrickOrthoAlpha2 = 11;
        public const int ipBrickOrthoAlpha3 = 12;
        public const int ipBrickOrthoViscosity = 13;
        public const int ipBrickOrthoDampingRatio = 14;
        public const int ipBrickOrthoConductivity1 = 15;
        public const int ipBrickOrthoConductivity2 = 16;
        public const int ipBrickOrthoConductivity3 = 17;
        public const int ipBrickOrthoSpecificHeat = 18;

        // Plate Anisotropic Materials

        // 0..9 ansi matrix
        public const int ipPlateAnisoTransShear1 = 10;
        public const int ipPlateAnisoTransShear2 = 11;
        public const int ipPlateAnisoTransShear3 = 12;
        public const int ipPlateAnisoDensity = 13;
        public const int ipPlateAnisoAlpha1 = 14;
        public const int ipPlateAnisoAlpha2 = 15;
        public const int ipPlateAnisoAlpha3 = 16;
        public const int ipPlateAnisoAlpha12 = 17;
        public const int ipPlateAnisoViscosity = 18;
        public const int ipPlateAnisoDampingRatio = 19;
        public const int ipPlateAnisoConductivity1 = 20;
        public const int ipPlateAnisoConductivity2 = 21;
        public const int ipPlateAnisoSpecificHeat = 22;

        // Plate User Defined Materials

        // 0..20 user matrix
        public const int ipPlateUserTransShearxz = 21;
        public const int ipPlateUserTransShearyz = 22;
        public const int ipPlateUserTransShearcz = 23;
        public const int ipPlateUserDensity = 24;
        public const int ipPlateUserAlphax = 25;
        public const int ipPlateUserAlphay = 26;
        public const int ipPlateUserAlphaxy = 27;
        public const int ipPlateUserBetax = 28;
        public const int ipPlateUserBetay = 29;
        public const int ipPlateUserBetaxy = 30;
        public const int ipPlateUserViscosity = 31;
        public const int ipPlateUserDampingRatio = 32;
        public const int ipPlateUserConductivity1 = 33;
        public const int ipPlateUserConductivity2 = 34;
        public const int ipPlateUserSpecificHeat = 35;

        // Brick Anisotropic Materials

        // 0..20 user matrix
        public const int ipBrickAnisoDensity = 21;
        public const int ipBrickAnisoAlpha1 = 22;
        public const int ipBrickAnisoAlpha2 = 23;
        public const int ipBrickAnisoAlpha3 = 24;
        public const int ipBrickAnisoAlpha12 = 25;
        public const int ipBrickAnisoAlpha23 = 26;
        public const int ipBrickAnisoAlpha31 = 27;
        public const int ipBrickAnisoViscosity = 28;
        public const int ipBrickAnisoDampingRatio = 29;
        public const int ipBrickAnisoConductivity1 = 30;
        public const int ipBrickAnisoConductivity2 = 31;
        public const int ipBrickAnisoConductivity3 = 32;
        public const int ipBrickAnisoSpecificHeat = 33;

        // Duncan-Chang Soil Materials - Integers
        public const int ipSoilDCUseBulkModulus = 0;
        public const int ipSoilDCSetPropLevel = 1;
        public const int ipSoilDCDrainedState = 2;

        // Duncan-Chang Soil Materials - Doubles
        public const int ipSoilDCModulusK = 0;
        public const int ipSoilDCModulusKUR = 1;
        public const int ipSoilDCModulusN = 2;
        public const int ipSoilDCPoisson = 3;
        public const int ipSoilDCBulkK = 4;
        public const int ipSoilDCBulkM = 5;
        public const int ipSoilDCFrictionAngle = 6;
        public const int ipSoilDCDeltaAngle = 7;
        public const int ipSoilDCCohesion = 8;
        public const int ipSoilDCFailureRatio = 9;
        public const int ipSoilDCFailureMod = 10;
        public const int ipSoilDCReferenceP = 11;
        public const int ipSoilDCDensity = 12;
        public const int ipSoilDCHorizontalRatio = 13;
        public const int ipSoilDCER = 14;
        public const int ipSoilDCConductivity = 15;
        public const int ipSoilDCSpecificHeat = 16;
        public const int ipSoilDCFluidLevel = 17;
        public const int ipSoilDCViscosity = 18;
        public const int ipSoilDCDampingRatio = 19;

        // Cam-Clay Soil Materials - Integers
        public const int ipSoilCCUsePoisson = 0;
        public const int ipSoilCCDrainedState = 1;
        public const int ipSoilCCUseOCR = 2;
        public const int ipSoilCCSetPropLevel = 3;

        // Cam-Clay Soil Materials - Doubles
        public const int ipSoilCCCriticalStateLine = 0;
        public const int ipSoilCCConsolidationLine = 1;
        public const int ipSoilCCSwellingLine = 2;
        public const int ipSoilCCDensity = 3;
        public const int ipSoilCCPoisson = 4;
        public const int ipSoilCCModulusGa = 5;
        public const int ipSoilCCModulusGb = 6;
        public const int ipSoilCCHorizontalRatio = 7;
        public const int ipSoilCCER = 8;
        public const int ipSoilCCPR = 9;
        public const int ipSoilCCPC0 = 10;
        public const int ipSoilCCOCR = 11;
        public const int ipSoilCCConductivity = 12;
        public const int ipSoilCCSpecificHeat = 13;
        public const int ipSoilCCFluidLevel = 14;
        public const int ipSoilCCViscosity = 15;
        public const int ipSoilCCDampingRatio = 16;

        // Mohr-Coulomb Soil Materials - Integers
        public const int ipSoilMCSetPropLevel = 0;
        public const int ipSoilMCDrainedState = 1;

        // Mohr-Coulomb Soil Materials - Doubles
        public const int ipSoilMCModulus = 0;
        public const int ipSoilMCPoisson = 1;
        public const int ipSoilMCDensity = 2;
        public const int ipSoilMCHorizontalRatio = 3;
        public const int ipSoilMCER = 4;
        public const int ipSoilMCFluidLevel = 5;
        public const int ipSoilMCConductivity = 6;
        public const int ipSoilMCSpecificHeat = 7;
        public const int ipSoilMCViscosity = 8;
        public const int ipSoilMCDampingRatio = 9;
        public const int ipSoilMCCohesion = 10;
        public const int ipSoilMCFrictionAngle = 11;

        // Drucker-Prager Soil Materials - Integers
        public const int ipSoilDPSetPropLevel = 0;
        public const int ipSoilDPDrainedState = 1;

        // Drucker-Prager Soil Materials - Doubles
        public const int ipSoilDPModulus = 0;
        public const int ipSoilDPPoisson = 1;
        public const int ipSoilDPDensity = 2;
        public const int ipSoilDPHorizontalRatio = 3;
        public const int ipSoilDPER = 4;
        public const int ipSoilDPFluidLevel = 5;
        public const int ipSoilDPConductivity = 6;
        public const int ipSoilDPSpecificHeat = 7;
        public const int ipSoilDPViscosity = 8;
        public const int ipSoilDPDampingRatio = 9;
        public const int ipSoilDPCohesion = 10;
        public const int ipSoilDPFrictionAngle = 11;

        // Linear Elastic Soil Materials - Integers
        public const int ipSoilLSSetPropLevel = 0;
        public const int ipSoilLSDrainedState = 1;

        // Linear Elastic Soil Materials - Doubles
        public const int ipSoilLSModulus = 0;
        public const int ipSoilLSPoisson = 1;
        public const int ipSoilLSDensity = 2;
        public const int ipSoilLSHorizontalRatio = 3;
        public const int ipSoilLSER = 4;
        public const int ipSoilLSFluidLevel = 5;
        public const int ipSoilLSConductivity = 6;
        public const int ipSoilLSSpecificHeat = 7;
        public const int ipSoilLSViscosity = 8;
        public const int ipSoilLSDampingRatio = 9;

        // Fluid Materials
        public const int ipFluidModulus = 0;
        public const int ipFluidPenaltyParam = 1;
        public const int ipFluidDensity = 2;
        public const int ipFluidAlpha = 3;
        public const int ipFluidViscosity = 4;
        public const int ipFluidDampingRatio = 5;
        public const int ipFluidConductivity = 6;
        public const int ipFluidSpecificHeat = 7;

        // Mohr-Coulomb, Drucker-Prager
        public const int ipFrictionAngle = 0;
        public const int ipCohesion = 1;

        // Rubber Materials
        public const int ipRubberBulk = 0;
        public const int ipRubberDensity = 1;
        public const int ipRubberAlpha = 2;
        public const int ipRubberViscosity = 3;
        public const int ipRubberDampingRatio = 4;
        public const int ipRubberConductivity = 5;
        public const int ipRubberSpecificHeat = 6;
        public const int ipRubberConstC1 = 7;

        // Load Case Types
        public const int ltLoadCase = 0;
        public const int ltSpectralCase = 2;

        // Beam Property
        public const int ipBeamPropBeamType = 0;
        public const int ipBeamPropUsePoisson = 1;
        public const int ipBeamPropSectionType = 2;
        public const int ipBeamPropMirrorType = 3;
        public const int ipBeamPropCompatibleTwist = 4;

        // Beam Property Shear Modulus Modes
        public const int smUsePoissonsRatio = 0;
        public const int smUseShearModulus = 1;

        // Beam Property Nonlinear Modes
        public const int nmUseFibreStress = 0;
        public const int nmUseMomentCurvature = 1;

        // Element Axis Types
        public const int axUCS = 0;
        public const int axLocal = 1;

        // Load Path Template - Integers
        public const int ipLPTColour = 0;
        public const int ipLPTNumLanes = 1;
        public const int ipLPTMultiLaneType = 2;
        public const int ipLPTTransitionLoad = 3;
        public const int ipLPTBeamLateralTolerance = 4;
        public const int lpAllSameFactors = 0;
        public const int lpAllDifferentFactors = 1;

        // Load Path Template - Doubles
        public const int ipLPTTolerance = 0;
        public const int ipLPTMinLaneWidth = 1;

        // Load Path Template Vehicle - Integers
        public const int ipLPTVehicleInstance = 0;
        public const int ipLPTVehicleDirection = 1;
        public const int lpVehicleSingleLane = 0;
        public const int lpVehicleDoubleLane = 1;
        public const int lpVehicleForward = 0;
        public const int lpVehicleBackward = 1;

        // Load Path Template Vehicle - Doubles
        public const int ipLPTVehicleVelocity = 0;
        public const int ipLPTVehicleStartTime = 1;

        // Load Path Template Forces - Integers
        public const int ipLPTMobility = 0;
        public const int ipLPTAxisSystem = 1;
        public const int ipLPTAdjacency = 2;
        public const int ipLPTCentrifugal = 3;
        public const int lpPointForceMobilityGrouped = 0;
        public const int lpPointForceMobilityFloating = 1;
        public const int lpDistrForceMobilityGrouped = 0;
        public const int lpDistrForceMobilityLeading = 1;
        public const int lpDistrForceMobilityTrailing = 2;
        public const int lpDistrForceMobilityFullLength = 3;
        public const int lpDistrForceMobilityFloating = 4;
        public const int lpAxisLocal = 0;
        public const int lpAxisGlobal = 1;

        // Load Path Templates - Integers
        public const int ipLPTLimitK1 = 0;
        public const int ipLPTLengthUnit = 1;
        public const int ipLPTForceUnit = 2;

        // Load Path Templates - Doubles
        public const int ipLPTMinK1 = 0;
        public const int ipLPTMaxK1 = 1;

        // Combined Result Files
        public const int rfCombFactors = 0;
        public const int rfCombSRSS = 1;

        // Load Path
        public const int ipLoadPathCase = 0;
        public const int ipLoadPathTemplate = 1;
        public const int ipLoadPathShape = 2;
        public const int ipLoadPathSurface = 3;
        public const int ipLoadPathTarget = 4;
        public const int ipLoadPathDivisions = 5;
        public const int ipLoadPathSet = 6;
        public const int lpShapeStraight = 0;
        public const int lpShapeCurved = 1;
        public const int lpShapeQuadratic = 2;
        public const int lpSurfaceFlat = 0;
        public const int lpSurfaceCurved = 1;
        public const int lpAnyEntity = 0;
        public const int lpEntitySet = 1;
        public const int lpBeamElement = 2;
        public const int lpPlateElement = 3;
        public const int lpBrickElement = 4;

        // Animation
        public const int ipAniCase = 0;
        public const int ipNumFrames = 1;
        public const int ipAniWidth = 2;
        public const int ipAniHeight = 3;
        public const int ipAniType = 4;
        public const int afAniSAF = 0;
        public const int afAniEXE = 1;
        public const int afAniAVI = 2;

        // Custom Result Files - NODEDISP, NODEREACT
        public const int ipNodeResFileDX = 0;
        public const int ipNodeResFileDY = 1;
        public const int ipNodeResFileDZ = 2;
        public const int ipNodeResFileRX = 3;
        public const int ipNodeResFileRY = 4;
        public const int ipNodeResFileRZ = 5;

        // Custom Result Files - NODETEMP, NODEFLUX
        public const int ipNodeResTempFlux = 0;

        // Custom Result Files - BEAMFORCE
        public const int ipBeamResFileSF1 = 0;
        public const int ipBeamResFileSF2 = 1;
        public const int ipBeamResFileAxial = 2;
        public const int ipBeamResFileBM1 = 3;
        public const int ipBeamResFileBM2 = 4;
        public const int ipBeamResFileTorque = 5;
        public const int kBeamResFileForceSize = 6;

        // Custom Result Files - BEAMSTRAIN
        public const int ipBeamResFileAxialStrain = 2;
        public const int ipBeamResFileCurvature1 = 3;
        public const int ipBeamResFileCurvature2 = 4;
        public const int ipBeamResFileTwist = 5;
        public const int kBeamResFileStrainSize = 6;

        // Custom Result Files - BEAMNODEREACT
        public const int ipBeamResFileFX = 0;
        public const int ipBeamResFileFY = 1;
        public const int ipBeamResFileFZ = 2;
        public const int ipBeamResFileMX = 3;
        public const int ipBeamResFileMY = 4;
        public const int ipBeamResFileMZ = 5;
        public const int kBeamResFileReactSize = 6;

        // Custom Result Files - BEAMFLUX
        public const int ipBeamResFileF = 0;
        public const int ipBeamResFileG = 1;
        public const int kBeamResFileFluxSize = 2;

        // Custom Result Files - PLATESTRESS for PlateShell - Local system
        public const int ipPlateShellResFileNxx = 0;
        public const int ipPlateShellResFileNyy = 1;
        public const int ipPlateShellResFileNxy = 2;
        public const int ipPlateShellResFileMxx = 3;
        public const int ipPlateShellResFileMyy = 4;
        public const int ipPlateShellResFileMxy = 5;
        public const int ipPlateShellResFileQxz = 6;
        public const int ipPlateShellResFileQyz = 7;
        public const int ipPlateShellResFileSxxMinusZ = 8;
        public const int ipPlateShellResFileSyyMinusZ = 9;
        public const int ipPlateShellResFileSxyMinusZ = 10;
        public const int ipPlateShellResFileSxxMidPlane = 11;
        public const int ipPlateShellResFileSyyMidPlane = 12;
        public const int ipPlateShellResFileSxyMidPlane = 13;
        public const int ipPlateShellResFileSxxPlusZ = 14;
        public const int ipPlateShellResFileSyyPlusZ = 15;
        public const int ipPlateShellResFileSxyPlusZ = 16;
        public const int kPlateShellResFileStressSize = 17;

        // Custom Result Files - PLATESTRAIN for PlateShell - Local system
        public const int ipPlateShellResFileExx = 0;
        public const int ipPlateShellResFileEyy = 1;
        public const int ipPlateShellResFileExy = 2;
        public const int ipPlateShellResFileEzz = 3;
        public const int ipPlateShellResFileKxx = 4;
        public const int ipPlateShellResFileKyy = 5;
        public const int ipPlateShellResFileKxy = 6;
        public const int ipPlateShellResFileTxz = 7;
        public const int ipPlateShellResFileTyz = 8;
        public const int ipPlateShellResFileStoredE = 9;
        public const int ipPlateShellResFileSpentE = 10;
        public const int kPlateShellResFileStrainSize = 11;

        // Custom Result Files - PLATESTRESS for 3D Membrane - Local system
        public const int ipPlateMembraneResFileSXX = 0;
        public const int ipPlateMembraneResFileSYY = 1;
        public const int ipPlateMembraneResFileSXY = 2;
        public const int kPlateMembraneResFileStressSize = 3;

        // Custom Result Files - PLATESTRAIN for 3D Membrane - Local system
        public const int ipPlateMembraneResFileExx = 0;
        public const int ipPlateMembraneResFileEyy = 1;
        public const int ipPlateMembraneResFileExy = 2;
        public const int ipPlateMembraneResFileEzz = 3;
        public const int ipPlateMembraneResFileStoredE = 4;
        public const int ipPlateMembraneResFileSpentE = 5;
        public const int kPlateMembraneResFileStrainSize = 6;

        // Custom Result Files - PLATESTRESS for 2D Plates - Global system
        public const int ipPlate2DResFileSXX = 0;
        public const int ipPlate2DResFileSYY = 1;
        public const int ipPlate2DResFileSXY = 2;
        public const int ipPlate2DResFileSZZ = 3;
        public const int kPlate2DResFileStressSize = 4;

        // Custom Result Files - PLATESTRAIN for 2D Plates - Global system
        public const int ipPlate2DResFileEXX = 0;
        public const int ipPlate2DResFileEYY = 1;
        public const int ipPlate2DResFileEXY = 2;
        public const int ipPlate2DResFileEZZ = 3;
        public const int ipPlate2DResFileStoredE = 4;
        public const int ipPlate2DResFileSpentE = 5;
        public const int kPlate2DResFileStrainSize = 6;

        // Custom Result Files - PLATESTRESS for Axi Plates - Axisymmetric system
        public const int ipPlateAxiResFileSRR = 0;
        public const int ipPlateAxiResFileSTT = 1;
        public const int ipPlateAxiResFileSZZ = 2;
        public const int ipPlateAxiResFileSRZ = 3;
        public const int kPlateAxiResFileStressSize = 4;

        // Custom Result Files - PLATESTRAIN for Axi Plates - Axisymmetric system
        public const int ipPlateAxiResFileERR = 0;
        public const int ipPlateAxiResFileETT = 1;
        public const int ipPlateAxiResFileEZZ = 2;
        public const int ipPlateAxiResFileERZ = 3;
        public const int ipPlateAxiResFileStoredE = 4;
        public const int ipPlateAxiResFileSpentE = 5;
        public const int kPlateAxiResFileStrainSize = 6;

        // Custom Result Files - PLATESTRESS for Shear Panel - Local system
        public const int ipPlateShearPanelResFileNxy = 0;
        public const int kPlateShearPanelResFileStressSize = 1;

        // Custom Result Files - PLATESTRAIN for Shear Panel - Local system
        public const int ipPlateShearPanelResFileExy = 0;
        public const int ipPlateShearPanelResFileStoredE = 1;
        public const int ipPlateShearPanelResFileSpentE = 2;
        public const int kPlateShearPanelResFileStrainSize = 3;

        // Custom Result Files - PLATENODEREACT
        public const int ipPlateResFileFX = 0;
        public const int ipPlateResFileFY = 1;
        public const int ipPlateResFileFZ = 2;
        public const int ipPlateResFileMX = 3;
        public const int ipPlateResFileMY = 4;
        public const int ipPlateResFileMZ = 5;
        public const int kPlateResFileReactSize = 6;

        // Custom Result Files - PLATEFLUX
        public const int ipPlateResFileFxx = 0;
        public const int ipPlateResFileFyy = 1;
        public const int ipPlateResFileGxx = 2;
        public const int ipPlateResFileGyy = 3;
        public const int kPlateResFileFluxSize = 4;

        // Custom Result Files - BRICKSTRESS
        public const int ipBrickResFileSXX = 0;
        public const int ipBrickResFileSYY = 1;
        public const int ipBrickResFileSZZ = 2;
        public const int ipBrickResFileSXY = 3;
        public const int ipBrickResFileSYZ = 4;
        public const int ipBrickResFileSZX = 5;
        public const int kBrickResFileStressSize = 6;

        // Custom Result Files - BRICKSTRAIN
        public const int ipBrickResFileExx = 0;
        public const int ipBrickResFileEyy = 1;
        public const int ipBrickResFileEzz = 2;
        public const int ipBrickResFileExy = 3;
        public const int ipBrickResFileEyz = 4;
        public const int ipBrickResFileEzx = 5;
        public const int ipBrickResFileStoredE = 6;
        public const int ipBrickResFileSpentE = 7;
        public const int kBrickResFileStrainSize = 8;

        // Custom Result Files - BRICKNODEREACT
        public const int ipBrickResFileFX = 0;
        public const int ipBrickResFileFY = 1;
        public const int ipBrickResFileFZ = 2;
        public const int kBrickResFileReactSize = 3;

        // Custom Result Files - BRICKFLUX
        public const int ipBrickResFileFXX = 0;
        public const int ipBrickResFileFYY = 1;
        public const int ipBrickResFileFZZ = 2;
        public const int ipBrickResFileGXX = 3;
        public const int ipBrickResFileGYY = 4;
        public const int ipBrickResFileGZZ = 5;
        public const int kBrickResFileFluxSize = 6;

        // Plate Edge Attachment Direction
        public const int adPlanar = 0;
        public const int adMinusZ = 1;
        public const int adPlusZ = 2;

        // Beam Side Direction
        public const int adMinus1 = 0;
        public const int adPlus1 = 1;
        public const int adMinus2 = 2;
        public const int adPlus2 = 3;

        // GLOBAL INTEGERS
        public const int ivTessellationsFailed = 1;
        public const int ivSeamsAdded = 2;
        public const int ivIntersectionsFound = 3;
        public const int ivPlateEdgesAssigned = 4;
        public const int ivPlateEdgesNotFullyAssigned = 5;
        public const int ivAttachmentsCreated = 6;
        public const int ivAttachmentsFailed = 7;
        public const int ivNodesCreated = 8;
        public const int ivNodesDeleted = 9;
        public const int ivNodesMoved = 10;
        public const int ivBeamsChanged = 11;
        public const int ivBeamsCollapsed = 12;
        public const int ivBeamsCreated = 13;
        public const int ivBeamsDeleted = 14;
        public const int ivBeamsFailed = 15;
        public const int ivBeamsMoved = 16;
        public const int ivBeamsSplit = 17;
        public const int ivBeamsSubdivided = 18;
        public const int ivPlatesChanged = 19;
        public const int ivPlatesCollapsed = 20;
        public const int ivPlatesCreated = 21;
        public const int ivPlatesDeleted = 22;
        public const int ivPlatesFailed = 23;
        public const int ivPlatesGraded = 24;
        public const int ivPlatesMoved = 25;
        public const int ivPlatesSplit = 26;
        public const int ivPlatesSubdivided = 27;
        public const int ivBricksChanged = 28;
        public const int ivBricksCollapsed = 29;
        public const int ivBricksCreated = 30;
        public const int ivBricksDeleted = 31;
        public const int ivBricksFailed = 32;
        public const int ivBricksGraded = 33;
        public const int ivBricksMoved = 34;
        public const int ivBricksSplit = 35;
        public const int ivBricksSubdivided = 36;
        public const int ivLinksChanged = 37;
        public const int ivLinksCollapsed = 38;
        public const int ivLinksCreated = 39;
        public const int ivLinksDeleted = 40;
        public const int ivLinksMoved = 41;
        public const int ivLoadPathsChanged = 42;
        public const int ivLoadPathsCreated = 43;
        public const int ivLoadPathsMoved = 44;
        public const int ivFacesChanged = 45;
        public const int ivFacesCreated = 46;
        public const int ivFacesDeleted = 47;
        public const int ivFacesFailed = 48;
        public const int ivFacesMoved = 49;
        public const int ivEdgesMorphed = 50;
        public const int ivEdgesSubdivided = 51;
        public const int ivLoopsDeleted = 52;
        public const int ivAttributesApplied = 53;
        public const int ivUCSCreated = 54;
        public const int ivPatchPlatesCreated = 55;
        public const int ivLoadCasesCreated = 56;
        public const int ivFilletsCreated = 57;
        public const int ivFilletsFailed = 58;
        public const int ivLoftSeriesFound = 59;
        public const int ivDuplicateBeamsDeleted = 60;
        public const int ivDuplicatePlatesDeleted = 61;
        public const int ivDuplicateBricksDeleted = 62;
        public const int ivDuplicateLinksDeleted = 63;
        public const int ivStringGroupsPacked = 64;
        public const int ivClipboardNodes = 65;
        public const int ivClipboardBeams = 66;
        public const int ivClipboardPlates = 67;
        public const int ivClipboardBricks = 68;
        public const int ivClipboardLinks = 69;
        public const int ivClipboardLoadPaths = 70;
        public const int ivClipboardFaces = 71;
        public const int ivClipboardVertices = 72;
        public const int ivFacesMeshed = 73;
        public const int ivFacesPartiallyMeshed = 74;
        public const int ivFacesNotMeshed = 75;
        public const int ivSolverTerminationCode = 76;
        public const int ivSolidsMeshed = 77;
        public const int ivSolidsPartiallyMeshed = 78;
        public const int ivSolidsNotMeshed = 79;

        // GLOBAL LOGICALS
        public const int lvFormulaParseError = 1;

        // GLOBAL STRINGS
        public const int svInfluenceCombinationLog = 1;

        // SAVING VIEW-ONLY FILE
        public const int ipVoShowCoordinates = 0;
        public const int ipVoShowTEXT = 1;
        public const int ipVoShowCASES = 2;
        public const int ipVoAllowSave = 3;
        public const int ipVoShowTables = 4;
        public const int ipVoShowPlies = 5;
        public const int ipVoShowLaminates = 6;
        public const int ipVoShowPlateRC = 7;
        public const int ipVoShowCreep = 8;
        public const int ipVoShowPaths = 9;
        public const int ipVoShowCavities = 10;
        public const int ipVoShowProperties = 11;
        public const int ipVoShowLISTINGS = 12;
        public const int ipVoShowAttribSummary = 13;
        public const int ipVoShowPropSummary = 14;
        public const int ipVoShowModelSummary = 15;

        /// <summary>
        /// Sets how the API responds when it suffers a loss of licence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLicenceOptions(int Mode, int MaxRetry, int RetryPause);
        /// <summary>
        /// Returns how the API responds when it suffers a loss of licence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLicenceOptions(ref int Mode, ref int MaxRetry, ref int RetryPause);
        /// <summary>
        /// Initialises the Strand7 API DLL. This function must be called before calls are made to any API functions other than St7SetIconSize, St7GetIconSize, St7GetAPIPath, St7SetLicenceOptions, St7GetLicenceOptions, St7Version, St7BuildString, St7GetListSeparatorCode, St7GetDecimalSeparatorCode or St7GetMaxModelFileID.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7Init();
        /// <summary>
        /// Releases the Strand7 API DLL and unloads the Strand7 licence manager freeing any active licences. St7Init must again be called before API functions can be executed again (other than St7SetIconSize, St7GetIconSize, St7GetAPIPath, St7SetLicenceOptions, St7GetLicenceOptions, St7Version, St7BuildString, St7GetListSeparatorCode, St7GetDecimalSeparatorCode or St7GetMaxModelFileID).
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7Release();
        /// <summary>
        /// Returns the version information for the Strand7 API DLL that is currently loaded.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7Version(ref int Major, ref int Minor, ref int Point);
        /// <summary>
        /// Returns the build information for the Strand7 API DLL that is currently loaded.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7BuildString(StringBuilder BuildString, int MaxStringLen);
        /// <summary>
        /// Returns the maximum model file ID. All of the functions that operate on a model file, reference the model file via the uID parameter in the function’s parameter list. Multiple model files can be open simultaneously, each one referenced by a different model file ID (for example, see St7OpenFile).
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetMaxModelFileID(ref int MaxID);
        /// <summary>
        /// Returns the ASCII code for the system’s list delimiter character.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetListSeparatorCode(ref int Code);
        /// <summary>
        /// Returns the ASCII code for the system’s decimal character.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetDecimalSeparatorCode(ref int Code);
        /// <summary>
        /// Sets the size of the icons to be used in the model and solver windows. This function must be called before St7Init, otherwise it will return an error code.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetIconSize(int IconSize);
        /// <summary>
        /// Returns the size of the icons used in the model and solver windows.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetIconSize(ref int IconSize);
        /// <summary>
        /// Returns the version of Strand7 used to save the specified file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7FileVersion(string FileName, ref int Major, ref int Minor, ref int Point);
        /// <summary>
        /// Opens an existing Strand7 model file with an exclusive lock. This call is required before any data can be read from, or written to, a Strand7 model file. Multiple model files can be opened simultaneously by using a different model file ID for each file (see St7GetMaxModelFileID).
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7OpenFile(int uID, string FileName, string ScratchPath);
        /// <summary>
        /// Opens a Strand7 model file in read-only mode; the file cannot be modified while open in this mode. This call is required before any data can be read from a Strand7 model file. Multiple model files can be opened simultaneously by using a different model file ID for each file (see St7GetMaxModelFileID).
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7OpenFileReadOnly(int uID, string FileName, string ScratchPath);
        /// <summary>
        /// Closes an open Strand7 model file. All associated scratch files that may have been created are automatically deleted.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CloseFile(int uID);
        /// <summary>
        /// Creates and opens a new Strand7 model file. Multiple model files can be opened simultaneously by using a different model file ID for each file (see St7GetMaxModelFileID). Note that if a file of the same name exists, the existing file will stay open and will not be overwritten until the new file is saved.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewFile(int uID, string FileName, string ScratchPath);
        /// <summary>
        /// Saves a Strand7 model file. The file remains open after the call.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SaveFile(int uID);
        /// <summary>
        /// Saves a copy of a Strand7 model to a new file. The file remains open after the call.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SaveFileCopy(int uID, string FileName);
        /// <summary>
        /// Saves a copy of the Strand7 model as a new View-Only file (.St7V). The function offers controls to allow or restrict access to specific aspects of the model data when subsequently opening the View-Only file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SaveViewOnlyCopy(int uID, string FileName, int[] Integers);
        /// <summary>
        /// Saves a copy of a Strand7 model to a new file with the current node displacements added to the original node coordinates to produce a new model with a deformed shape. The model results file must be open prior to calling this function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SaveDeformedCopy(int uID, string FileName, int ResultCase, double DispScale, int ScaleType);
        /// <summary>
        /// Saves selected entities as a new Strand7 file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SaveSubModel(int uID, string FileName);
        /// <summary>
        /// Checks that a result file associated with the specified Strand7 model may be opened. All supported result file types may be validated.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ValidateResultFile(int uID, string FileName, ref int ValidationCode, ref int Solver);
        /// <summary>
        /// Shows or hides certain types of result cases when opening a result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultFileOpenFlag(int uID, int Index, byte State);
        /// <summary>
        /// Returns show/hide state of certain types of result cases when opening a result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultFileOpenFlag(int uID, int Index, ref byte State);
        /// <summary>
        /// Sets the mass participation threshold for result cases of Natural Frequency results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNFAFileOpenMinMass(int uID, double Mass);
        /// <summary>
        /// Returns the mass participation threshold for result cases of Natural Frequency results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNFAFileOpenMinMass(int uID, ref double Mass);
        /// <summary>
        /// Opens a result file associated with the specified Strand7 model. All supported result file types may be opened.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7OpenResultFile(int uID, string FileName, string SpectralName, int CombinationCode, ref int NumPrimary, ref int NumSecondary);
        /// <summary>
        /// Generate the secondary result cases for the linear load case combinations in a Strand7 model. The result file must be open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GenerateLSACombinations(int uID, ref int NumSecondary, ref int WarningCode);
        /// <summary>
        /// Generate the secondary result cases for the result envelopes specified in the Strand7 model. The result file must be open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GenerateEnvelopes(int uID, ref int NumLimitEnvelopes, ref int NumCombinationEnvelopes, ref int NumFactorsEnvelopes);
        /// <summary>
        /// Closes any open result file associated with the specified Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CloseResultFile(int uID);
        /// <summary>
        /// Sets the full path to the display options file. If only the directory is given, then Settings.cfg3 will be used to control display behaviour. The display options are only used to define settings for model files created subsequently to this call.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetDisplayOptionsPath(string ConfigPath);
        /// <summary>
        /// Returns the full path name of the display options file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetDisplayOptionsPath(StringBuilder ConfigPath, int MaxStringLen);
        /// <summary>
        /// Sets the full path name to the directory containing the Strand7 library files. Any subsequent calls to the libraries will use the files contained in this directory.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLibraryPath(string LibraryPath);
        /// <summary>
        /// Returns the full path name to the directory containing the Strand7 library files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLibraryPath(StringBuilder LibraryPath, int MaxStringLen);
        /// <summary>
        /// Returns the full path name of the directory that contains the Strand7 API that is currently loaded.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetAPIPath(StringBuilder St7Path, int MaxStringLen);
        /// <summary>
        /// Returns the error code generated by the last Strand7 API call.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLastError();
        /// <summary>
        /// Returns the error message corresponding to the specified Strand7 API error code. Error codes corresponding to a Strand7 solver error should be processed using St7GetSolverErrorString.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetAPIErrorString(int iErr, StringBuilder ErrorString, int MaxStringLen);
        /// <summary>
        /// Returns the error message corresponding to the specified Strand7 solver error code. Error codes corresponding to a Strand7 API error should be processed using St7GetAPIErrorString.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverErrorString(int iErr, StringBuilder ErrorString, int MaxStringLen);
        /// <summary>
        /// Returns the error code generated by the last call to St7OpenFile or St7OpenFileReadOnly.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLastOpenFileCode();
        /// <summary>
        /// Returns the error code generated by the last call to St7SaveFile, St7SaveFileCopy, St7SaveDeformedCopy, St7SaveViewOnlyCopy, St7SaveSubModel or St7SaveBeamSectionMesh.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLastSaveFileCode();
        /// <summary>
        /// Transforms a position specified in the global XYZ system to a User Coordinate System (UCS).
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7TransformToUCS(int uID, int UCSId, double[] XYZ);
        /// <summary>
        /// Transforms a position specified in an arbitrary User Coordinate System (UCS) to the global XYZ system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7TransformToXYZ(int uID, int UCSId, double[] XYZ);
        /// <summary>
        /// Transforms a vector specified in the global XYZ system to an arbitrary User Coordinate System (UCS) frame, at a given position in space.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7VectorTransformToUCS(int uID, int UCSId, double[] Position, double[] VXYZ);
        /// <summary>
        /// Transforms a vector specified in a User Coordinate System (UCS) frame to the global XYZ system, at a given position in space.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7VectorTransformToXYZ(int uID, int UCSId, double[] Position, double[] VXYZ);
        /// <summary>
        /// Returns the local plate uv coordinates corresponding to a global XYZ position. The XYZ position should be located approximately on the surface of the element.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateUV(int uID, int PlateNum, double[] XYZ, double[] UV);
        /// <summary>
        /// Returns the local brick uvw coordinates corresponding to a global XYZ position. The XYZ position should be located approximately within the brick.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickUVW(int uID, int BrickNum, double[] XYZ, double[] UVW);
        /// <summary>
        /// Returns the volume enclosed by the selected plates. If multiple enclosed volumes are present in the selection the sum of all volumes is returned. The selected plates must form a closed boundary surface around the region(s) for which the volume is to be calculated.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PlateHullVolume(int uID, int ResultCase, ref double Volume);
        /// <summary>
        /// Returns an index to an adjacency list that can be used to efficiently find the elements connected to a node.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GenerateAdjacencyList(int uID, int[] Integers, ref int AdjacencyIndex);
        /// <summary>
        /// Frees the specified adjacency list.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7FreeAdjacencyList(int uID, int AdjacencyIndex);
        /// <summary>
        /// Returns the number of elements connected to a node, based on a previously generated adjacency list.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumElementsAtNode(int uID, int AdjacencyIndex, int NodeNum, ref int NumElements);
        /// <summary>
        /// Returns the number and type of elements connected to a node based on a previously generated adjacency list.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetElementsAtNode(int uID, int AdjacencyIndex, int NodeNum, int[] EntityNums, int[] EntityTypes, int ArrayDim);
        /// <summary>
        /// Sets the selected state of the specified entity.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntitySelectState(int uID, int Entity, int EntityNum, int EndEdgeFace, byte Selected);
        /// <summary>
        /// Returns the select state of the specified entity.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntitySelectState(int uID, int Entity, int EntityNum, int EndEdgeFace, ref byte Selected);
        /// <summary>
        /// Returns the number entities of the specified type that are selected.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntitySelectCount(int uID, int Entity, ref int NumSelected);
        /// <summary>
        /// Selects or deselects all entities of a given type.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetAllEntitySelectState(int uID, int Entity, byte Selected);
        /// <summary>
        /// Selects or deselects all entities of a given type based on the property number, link type or load path template number.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntitySelectStateByProperty(int uID, int Entity, int PropertyNum, byte Selected);
        /// <summary>
        /// Selects or deselects all entities of a given type in a given group.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntitySelectStateByGroup(int uID, int Entity, int GroupID, byte Selected);
        /// <summary>
        /// Selects or deselects all entities of a given type in a given entity set.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntitySelectStateByEntitySet(int uID, int Entity, int SetNum, byte Selected);
        /// <summary>
        /// Sets the selected state of the specified brick, brick face or edge on a brick face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickSelectState(int uID, int EntityNum, int FaceNum, int EdgeNum, byte Selected);
        /// <summary>
        /// Returns the selected state of the specified brick, brick face or edge on a brick face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickSelectState(int uID, int EntityNum, int FaceNum, int EdgeNum, ref byte Selected);
        /// <summary>
        /// Sets the way the model window responds to actions that invalidate it.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetModelWindowRefresh(int uID, int Mode);
        /// <summary>
        /// Creates the window to display a Strand7 model graphically.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateModelWindow(int uID);
        /// <summary>
        /// Destroys the model window for a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DestroyModelWindow(int uID);
        /// <summary>
        /// Returns the state of the model window for a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetModelWindowState(int uID, ref int State);
        /// <summary>
        /// Returns the windows handle to the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetModelWindowHandle(int uID, ref IntPtr Handle);
        /// <summary>
        /// Sets the parent control for the model window. This function can be used to dock the model window inside another control.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetModelWindowParent(int uID, IntPtr Handle);
        /// <summary>
        /// Returns the current parent control for the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetModelWindowParent(int uID, ref IntPtr Handle);
        /// <summary>
        /// Shows the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowModelWindow(int uID);
        /// <summary>
        /// Hides the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideModelWindow(int uID);
        /// <summary>
        /// Shows the Load Case, Freedom Case and UCS combo boxes on the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowWindowCombos(int uID);
        /// <summary>
        /// Hides the Load Case, Freedom Case and UCS combo boxes from the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideWindowCombos(int uID);
        /// <summary>
        /// Shows the entity panel on the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowWindowEntityPanel(int uID);
        /// <summary>
        /// Hides the entity panel from the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideWindowEntityPanel(int uID);
        /// <summary>
        /// Strand7 API Manual
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowWindowStatusBar(int uID);
        /// <summary>
        /// Hides the status bar from the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideWindowStatusBar(int uID);
        /// <summary>
        /// Enables mouse input for the status bar shown by St7ShowWindowStatusBar in the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableWindowStatusBar(int uID);
        /// <summary>
        /// Disables mouse input for the status bar shown by St7ShowWindowStatusBar in the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableWindowStatusBar(int uID);
        /// <summary>
        /// Sets the way the status bar responds to actions that invalidate it.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetWindowStatusBarRefreshMode(int uID, byte AutoRefresh);
        /// <summary>
        /// Updates the contents of the status bar irrespective of the refresh mode set by St7SetWindowStatusBarRefreshMode.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7RefreshWindowStatusBar(int uID);
        /// <summary>
        /// Enables the entity inspector (shift-mouse-over) in the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableWindowEntityInspector(int uID);
        /// <summary>
        /// Disables the entity inspector (shift-mouse-over) in the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableWindowEntityInspector(int uID);
        /// <summary>
        /// Shows the selection toolbar on the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowWindowSelectionToolbar(int uID);
        /// <summary>
        /// Hides the selection toolbar from the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideWindowSelectionToolbar(int uID);
        /// <summary>
        /// Shows the model caption and window controls at the top of the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowWindowCaption(int uID);
        /// <summary>
        /// Hides the model caption and window controls from the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideWindowCaption(int uID);
        /// <summary>
        /// Shows the view toolbar on the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowWindowViewToolbar(int uID);
        /// <summary>
        /// Hides the view toolbar from the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideWindowViewToolbar(int uID);
        /// <summary>
        /// (if result file is open)
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowWindowResultsToolbar(int uID);
        /// <summary>
        /// Hides the results toolbar from the model window, when a result file is open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideWindowResultsToolbar(int uID);
        /// <summary>
        /// Shows the toolbar, which enables the user to show and hide model entities by Type/Property, Group, Set or Viewport.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowWindowShowHideToolbar(int uID);
        /// <summary>
        /// Hides the toolbar, which enables the user to show and hide model entities by Type/Property, Group, Set or Viewport.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideWindowShowHideToolbar(int uID);
        /// <summary>
        /// Allows resizing of the graphical window by mouse.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableWindowResize(int uID);
        /// <summary>
        /// Prevents resizing of the graphical window by mouse.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableWindowResize(int uID);
        /// <summary>
        /// Allows model window view changes by the application user (for example, clicking and dragging to rotate the model).
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableWindowViewChanges(int uID);
        /// <summary>
        /// Disallows model window view changes by the application user (for example, clicking and dragging to rotate the model). Note that when the view toolbar is showing, the model window view can be changed by the user irrespective of this setting.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableWindowViewChanges(int uID);
        /// <summary>
        /// Clears the graphics within the model window and suspends graphics updates until either St7RedrawModel is called or St7SetModelWindowRefresh is called with wrAutoRefresh.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ClearModelWindow(int uID);
        /// <summary>
        /// Redraws the graphics within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7RedrawModel(int uID, byte Rescale);
        /// <summary>
        /// Sets the view angle for graphical display of the model in the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7RotateModel(int uID, double RX, double RY, double RZ);
        /// <summary>
        /// Zooms the graphical display of the model in the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ZoomModel(int uID, double CentreX, double CentreY, double ZoomScale);
        /// <summary>
        /// Pans the graphical display of the model in the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PanModel(int uID, double PanX, double PanY);
        /// <summary>
        /// Shows all entities of the specified type within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowEntity(int uID, int Entity);
        /// <summary>
        /// Hides all entities of the specified type within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideEntity(int uID, int Entity);
        /// <summary>
        /// Returns the visibility of the entities of the specified type within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityVisibility(int uID, int Entity, ref byte Visible);
        /// <summary>
        /// Shows the node and vertex attributes within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowPointAttributes(int uID);
        /// <summary>
        /// Hides the node and vertex attributes within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HidePointAttributes(int uID);
        /// <summary>
        /// Returns the visibility of point attributes within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPointAttributesVisibility(int uID, ref byte Visible);
        /// <summary>
        /// Shows the element attributes within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowEntityAttributes(int uID);
        /// <summary>
        /// Hides the element attributes within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideEntityAttributes(int uID);
        /// <summary>
        /// Returns the visibility of entity attributes within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityAttributesVisibility(int uID, ref byte Visible);
        /// <summary>
        /// Sets the screen position of the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PositionModelWindow(int uID, int Left, int Top, int Width, int Height);
        /// <summary>
        /// Returns the screen position of the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetModelWindowPosition(int uID, ref int Left, ref int Top, ref int Width, ref int Height);
        /// <summary>
        /// Returns the screen area available for drawing the model graphics within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetDrawAreaSize(int uID, ref int Width, ref int Height);
        /// <summary>
        /// Returns the screen position for drawing the model graphics within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetDrawAreaPosition(int uID, ref int Left, ref int Top, ref int Width, ref int Height);
        /// <summary>
        /// Shows all of the entities of the specified property within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowProperty(int uID, int Entity, int PropNum);
        /// <summary>
        /// Hides all of the entities of the specified property number within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideProperty(int uID, int Entity, int PropNum);
        /// <summary>
        /// Determines the visibility of a property within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPropertyVisibility(int uID, int Entity, int PropNum, ref byte Visible);
        /// <summary>
        /// Shows all entities in the specified group within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowGroup(int uID, int GroupID);
        /// <summary>
        /// Hides all of the entities in the specified group within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideGroup(int uID, int GroupID);
        /// <summary>
        /// Determines the visibility of a group within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGroupVisibility(int uID, int GroupID, ref byte Visible);
        /// <summary>
        /// Resets the display to show all entities and attributes in the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetAllEntitiesOn(int uID);
        /// <summary>
        /// Determines whether or not an entity is visible in the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityNumVisibility(int uID, int Entity, int EntityNum, ref byte Visible);
        /// <summary>
        /// Sets the result case to be displayed within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetWindowResultCase(int uID, int ResultCase);
        /// <summary>
        /// Sets the load case to be displayed within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetWindowLoadCase(int uID, int CaseNum);
        /// <summary>
        /// Sets the freedom case to be displayed within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetWindowFreedomCase(int uID, int CaseNum);
        /// <summary>
        /// Sets the UCS case to be displayed within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetWindowUCSCase(int uID, int CaseNum);
        /// <summary>
        /// Sets the display options for beam results within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamResultDisplay(int uID, int[] Integers);
        /// <summary>
        /// Sets the display options for plate results within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateResultDisplay(int uID, int[] Integers);
        /// <summary>
        /// Sets the display options for the brick results within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickResultDisplay(int uID, int[] Integers);
        /// <summary>
        /// Sets the display options for the link results within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLinkResultDisplay(int uID, int[] Integers);
        /// <summary>
        /// Sets the parameters accessible through Results Settings/Settings…/Style in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultSettingsStyle(int uID, int Solver, int Entity, int Quantity, int[] Integers);
        /// <summary>
        /// Returns the parameters accessible through Results Settings/Settings…/Style in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultSettingsStyle(int uID, int Solver, int Entity, int Quantity, int[] Integers);
        /// <summary>
        /// Sets the parameters accessible through Results Settings/Settings…/Limits in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultSettingsLimits(int uID, int Solver, int Entity, int Quantity, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the parameters accessible through Results Settings/Settings…/Limits in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultSettingsLimits(int uID, int Solver, int Entity, int Quantity, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the parameters accessible through Results Settings/Settings…/Limits in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultSettingsLimitsString(int uID, int Solver, int Entity, int Quantity, string LimitsString);
        /// <summary>
        /// Returns the parameters accessible through Results Settings/Settings…/Limits in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultSettingsLimitsString(int uID, int Solver, int Entity, int Quantity, StringBuilder LimitsString, int MaxStringLen);
        /// <summary>
        /// Sets the parameters accessible through Results Settings/Settings…/Legend in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultSettingsLegend(int uID, int Solver, int Entity, int Quantity, int[] Integers);
        /// <summary>
        /// Returns the parameters accessible through Results Settings/Settings…/Legend in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultSettingsLegend(int uID, int Solver, int Entity, int Quantity, int[] Integers);
        /// <summary>
        /// Sets the parameters accessible through Results Settings/Settings…/Legend in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultSettingsLegendFont(int uID, int Solver, int Entity, int Quantity, string FontName, int[] Integers);
        /// <summary>
        /// Returns the parameters accessible through Results Settings/Settings…/Legend in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultSettingsLegendFont(int uID, int Solver, int Entity, int Quantity, StringBuilder FontName, int MaxStringLen, int[] Integers);
        /// <summary>
        /// Sets the parameters accessible through Results Settings/Settings…/Diagram in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultSettingsDiagram(int uID, int Solver, int[] Integers);
        /// <summary>
        /// Returns the parameters accessible through Results Settings/Settings…/Diagram in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultSettingsDiagram(int uID, int Solver, int[] Integers);
        /// <summary>
        /// Sets the beam diagram colours accessible through Results Settings in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultSettingsDiagramColours(int uID, int Solver, int[] Integers);
        /// <summary>
        /// Returns the beam diagram colours accessible through Results Settings in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultSettingsDiagramColours(int uID, int Solver, int[] Integers);
        /// <summary>
        /// Sets the background colour(s) of the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetWindowColours(int uID, int WindowMode, int SolidColour, int GradientColour);
        /// <summary>
        /// Returns the background colour(s) of the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetWindowColours(int uID, int WindowMode, ref int SolidColour, ref int GradientColour);
        /// <summary>
        /// Sets the background mode of the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetWindowBackgroundMode(int uID, int WindowMode, int BackgroundMode);
        /// <summary>
        /// Returns the background mode of the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetWindowBackgroundMode(int uID, int WindowMode, ref int BackgroundMode);
        /// <summary>
        /// Sets the location of the image used for bgImage and bgImageGradient background modes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetWindowImageLocation(int uID, int ImageLocation);
        /// <summary>
        /// Returns the location of the image used for bgImage and bgImageGradient background modes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetWindowImageLocation(int uID, ref int ImageLocation);
        /// <summary>
        /// Sets the size of the image used for bgImage and bgImageGradient background modes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetWindowImageSize(int uID, int ImageSize);
        /// <summary>
        /// Returns the size of the image used for bgImage and bgImageGradient background modes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetWindowImageSize(int uID, ref int ImageSize);
        /// <summary>
        /// Sets the image file to be used for bgImage and bgImageGradient background modes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetWindowImageFile(int uID, string FileName);
        /// <summary>
        /// Returns the name of the image file used for bgImage and bgImageGradient background modes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetWindowImageFile(int uID, StringBuilder FileName, int MaxStringLen);
        /// <summary>
        /// Sets the display mode of numbers in the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNumericOptions(int uID, int Mode, int Style, int Digits, int Exponent, double Zero);
        /// <summary>
        /// Returns the display mode of numbers in the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumericOptions(int uID, int Mode, ref int Style, ref int Digits, ref int Exponent, ref double Zero);
        /// <summary>
        /// Sets the display symbol for nodes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeStyle(int uID, int Style);
        /// <summary>
        /// Sets whether the display of nodes considers the Show/Hide Selected setting.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeShowHideSelected(int uID, byte UseSettings);
        /// <summary>
        /// Sets the size index of the displayed nodes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeSize(int uID, int Size);
        /// <summary>
        /// Sets the display option for free nodes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFreeNodes(int uID, int Style);
        /// <summary>
        /// Sets the display style for node labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeLabelStyle(int uID, int LabelStyle);
        /// <summary>
        /// Sets the colours used to display nodes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Returns the display symbol for nodes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeStyle(int uID, ref int Style);
        /// <summary>
        /// Returns whether the display of nodes considers the Show/Hide Selected setting.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeShowHideSelected(int uID, ref byte UseSettings);
        /// <summary>
        /// Returns the size index of the displayed nodes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeSize(int uID, ref int Size);
        /// <summary>
        /// Returns the display option for free nodes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFreeNodes(int uID, ref int Style);
        /// <summary>
        /// Returns the display style for node labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeLabelStyle(int uID, ref int LabelStyle);
        /// <summary>
        /// Returns the colours used to display nodes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Sets the display style for beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamStyle(int uID, int Style);
        /// <summary>
        /// Sets the option for cables to ignore the beam style and use bsLine instead.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamCableAsLine(int uID, byte AsLine);
        /// <summary>
        /// Sets the fill colour scheme for beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamFill(int uID, int Fill);
        /// <summary>
        /// Sets the outline colour scheme for beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamOutline(int uID, int Outline);
        /// <summary>
        /// Sets the thickness of beam outlines.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamLineThickness(int uID, int Thickness);
        /// <summary>
        /// Sets the display style for beam labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamLabelStyle(int uID, int LabelStyle);
        /// <summary>
        /// Sets the colours to be used for given beam display types, where such are required.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Sets the state of the Lighting options for beam rendering.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamLighting(int uID, byte FillLighting, byte LineLighting);
        /// <summary>
        /// Sets whether the reference node is shown in the display of beam3 elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamNRef(int uID, byte Show);
        /// <summary>
        /// Sets whether to Show Offset Nodes in the display of beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamOffsetNodes(int uID, byte Show);
        /// <summary>
        /// Sets whether to Move to Offset the display of beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamMoveToOffset(int uID, byte Show);
        /// <summary>
        /// Sets whether to Draw Axes with the display of beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamDrawAxes(int uID, byte Show);
        /// <summary>
        /// Sets the number of coils displayed for spring elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamSpringCoils(int uID, int Coils);
        /// <summary>
        /// Sets the aspect ratio displayed for spring elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamSpringAspect(int uID, int Aspect);
        /// <summary>
        /// Sets the number of circumferential facets used to render circular beam sections and spring elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamRoundFacets(int uID, int Facets);
        /// <summary>
        /// Sets the number of straight line segments used to render curved beam elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamSlices(int uID, int Slices);
        /// <summary>
        /// Sets a percentage by which to shrink the display of beam elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamShrink(int uID, int Shrink);
        /// <summary>
        /// Returns the display style for beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamStyle(int uID, ref int Style);
        /// <summary>
        /// Returns the option for cables to ignore the beam style and use bsLine instead.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamCableAsLine(int uID, ref byte AsLine);
        /// <summary>
        /// Returns the fill colour scheme for beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamFill(int uID, ref int Fill);
        /// <summary>
        /// Returns the outline colour scheme for beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamOutline(int uID, ref int Outline);
        /// <summary>
        /// Returns the thickness of beam outlines.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamLineThickness(int uID, ref int Thickness);
        /// <summary>
        /// Returns the display style for beam labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamLabelStyle(int uID, ref int LabelStyle);
        /// <summary>
        /// Returns the colours to be used for given beam display types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Returns the state of the Lighting options for beam rendering.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamLighting(int uID, ref byte FillLighting, ref byte LineLighting);
        /// <summary>
        /// Returns whether the reference node is shown in the display of beam3 elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamNRef(int uID, ref byte Show);
        /// <summary>
        /// Returns whether to Show Offset Nodes in the display of beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamOffsetNodes(int uID, ref byte Show);
        /// <summary>
        /// Returns whether to Move to Offset the display of beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamMoveToOffset(int uID, ref byte Show);
        /// <summary>
        /// Returns whether to Draw Axes with the display of beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamDrawAxes(int uID, ref byte Show);
        /// <summary>
        /// Returns the number of coils displayed for spring elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamSpringCoils(int uID, ref int Coils);
        /// <summary>
        /// Returns the aspect ratio displayed for spring elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamSpringAspect(int uID, ref int Aspect);
        /// <summary>
        /// Returns the number of circumferential facets used to render circular beam sections and spring elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamRoundFacets(int uID, ref int Facets);
        /// <summary>
        /// Returns the number of straight line segments used to render curved beam elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamSlices(int uID, ref int Slices);
        /// <summary>
        /// Returns a percentage by which to shrink the display of beam elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamShrink(int uID, ref int Shrink);
        /// <summary>
        /// Sets the display style for plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateStyle(int uID, int Style);
        /// <summary>
        /// Sets the fill colour scheme for plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateFill(int uID, int Fill);
        /// <summary>
        /// Sets the outline colour scheme for plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateOutline(int uID, int Outline);
        /// <summary>
        /// Sets the thickness of plate outlines.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateLineThickness(int uID, int Thickness);
        /// <summary>
        /// Sets the display style for plate labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateLabelStyle(int uID, int LabelStyle);
        /// <summary>
        /// Sets the colours to be used for given plate display types, where such are required.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Sets the state of the Lighting options for plate rendering.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateLighting(int uID, byte FillLighting, byte LineLighting);
        /// <summary>
        /// Sets whether to Show Offset Nodes in the display of plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateOffsetNodes(int uID, byte Show);
        /// <summary>
        /// Sets whether to Move to Offset the display of plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateMoveToOffset(int uID, byte Show);
        /// <summary>
        /// Sets whether to Draw Axes with the display of plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateDrawAxes(int uID, byte Show);
        /// <summary>
        /// Sets a percentage by which to shrink the display of plate elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateShrink(int uID, int Shrink);
        /// <summary>
        /// Sets whether to show Face Nodes in the solid render of plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateFaceNodes(int uID, byte Show);
        /// <summary>
        /// For laminate properties, this sets the laminate layer whose material axes are displayed when Draw Axes is set.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateAxisLayer(int uID, int Layer);
        /// <summary>
        /// Sets where outlines are drawn around plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateOutlineMode(int uID, int Mode);
        /// <summary>
        /// Sets whether faceted plates are displayed with averaged normals.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateAverageNormals(int uID, byte AverageNormals);
        /// <summary>
        /// Sets the angle over which plate normal are averaged.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateAverageNormalsAngle(int uID, int Angle);
        /// <summary>
        /// Returns the display style for plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateStyle(int uID, ref int Style);
        /// <summary>
        /// Returns the fill colour scheme for plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateFill(int uID, ref int Fill);
        /// <summary>
        /// Returns the outline colour scheme for plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateOutline(int uID, ref int Outline);
        /// <summary>
        /// Returns the thickness of plate outlines.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateLineThickness(int uID, ref int Thickness);
        /// <summary>
        /// Returns the display style for plate labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateLabelStyle(int uID, ref int LabelStyle);
        /// <summary>
        /// Returns the colours to be used for given plate display types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Returns the state of the Lighting options for plate rendering.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateLighting(int uID, ref byte FillLighting, ref byte LineLighting);
        /// <summary>
        /// Returns whether to Show Offset Nodes in the display of plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateOffsetNodes(int uID, ref byte Show);
        /// <summary>
        /// Returns whether to Move to Offset the display of plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateMoveToOffset(int uID, ref byte Show);
        /// <summary>
        /// Returns whether to Draw Axes with the display of plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateDrawAxes(int uID, ref byte Show);
        /// <summary>
        /// Returns a percentage by which to shrink the display of plate elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateShrink(int uID, ref int Shrink);
        /// <summary>
        /// Returns whether to show Face Nodes in the solid render of plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateFaceNodes(int uID, ref byte Show);
        /// <summary>
        /// For laminate properties, this returns the laminate layer whose material axes are displayed when Draw Axes is set.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateAxisLayer(int uID, ref int Layer);
        /// <summary>
        /// Returns where outlines are drawn around plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateOutlineMode(int uID, ref int Mode);
        /// <summary>
        /// Returns whether faceted plates are displayed with averaged normals.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateAverageNormals(int uID, ref byte AverageNormals);
        /// <summary>
        /// Returns the angle over which plate normal are averaged.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateAverageNormalsAngle(int uID, ref int Angle);
        /// <summary>
        /// Sets the fill colour scheme for bricks.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickFill(int uID, int Fill);
        /// <summary>
        /// Sets the outline colour scheme for bricks.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickOutline(int uID, int Outline);
        /// <summary>
        /// Sets the thickness of the brick outlines.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickLineThickness(int uID, int Thickness);
        /// <summary>
        /// Sets the display style for brick labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickLabelStyle(int uID, int LabelStyle);
        /// <summary>
        /// Sets the colours to be used for given brick display types, where such are required.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Sets the state of the Lighting options for brick rendering.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickLighting(int uID, byte FillLighting, byte LineLighting);
        /// <summary>
        /// Sets whether local brick axes are displayed with bricks.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickDrawAxes(int uID, byte Show1, byte Show2, byte Show3);
        /// <summary>
        /// Sets a percentage by which to shrink the display of brick elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickShrink(int uID, int Shrink);
        /// <summary>
        /// Sets where outlines are drawn around bricks.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickOutlineMode(int uID, int Mode);
        /// <summary>
        /// Sets the state of the Draw all faces when showing wireframes option for brick display.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickWireframeAll(int uID, byte Show);
        /// <summary>
        /// Returns the fill colour scheme for bricks.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickFill(int uID, ref int Fill);
        /// <summary>
        /// Returns the outline colour scheme for bricks.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickOutline(int uID, ref int Outline);
        /// <summary>
        /// Returns the thickness of the brick outlines.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickLineThickness(int uID, ref int Thickness);
        /// <summary>
        /// Returns the display style for brick labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickLabelStyle(int uID, ref int LabelStyle);
        /// <summary>
        /// Returns the colours to be used for given brick display types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Returns the state of the Lighting options for brick rendering.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickLighting(int uID, ref byte FillLighting, ref byte LineLighting);
        /// <summary>
        /// Returns whether local brick axes are displayed with bricks.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickDrawAxes(int uID, ref byte Show1, ref byte Show2, ref byte Show3);
        /// <summary>
        /// Returns a percentage by which to shrink the display of brick elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickShrink(int uID, ref int Shrink);
        /// <summary>
        /// Returns where outlines are drawn around bricks.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickOutlineMode(int uID, ref int Mode);
        /// <summary>
        /// Returns the state of the Draw all faces when showing wireframes option for brick display.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickWireframeAll(int uID, ref byte Show);
        /// <summary>
        /// Sets the colour scheme for links.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLinkOutline(int uID, int Outline);
        /// <summary>
        /// Sets the thickness of the link display.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLinkLineThickness(int uID, int Thickness);
        /// <summary>
        /// Sets the display style for link labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLinkLabelStyle(int uID, int LabelStyle);
        /// <summary>
        /// Sets the colours used for displaying links.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLinkColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Sets whether dashes indicating linked degrees of freedom are drawn at the ends of links.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLinkDashes(int uID, byte Show);
        /// <summary>
        /// Returns the colour scheme for links.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLinkOutline(int uID, ref int Outline);
        /// <summary>
        /// Returns the thickness of the link display.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLinkLineThickness(int uID, ref int Thickness);
        /// <summary>
        /// Returns the display style for link labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLinkLabelStyle(int uID, ref int LabelStyle);
        /// <summary>
        /// Returns the colours used for displaying links.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLinkColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Returns whether dashes indicating linked degrees of freedom are drawn at the ends of links.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLinkDashes(int uID, ref byte Show);
        /// <summary>
        /// Sets the display symbol for vertices.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexStyle(int uID, int Style);
        /// <summary>
        /// Sets whether the display of vertices considers the Show/Hide Selected setting.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexShowHideSelected(int uID, byte UseSettings);
        /// <summary>
        /// Sets the size index of the displayed vertices.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexSize(int uID, int Size);
        /// <summary>
        /// Sets the display style for vertex labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexLabelStyle(int uID, int LabelStyle);
        /// <summary>
        /// Sets the colours used to display vertices.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Sets the display option for free vertices.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFreeVertices(int uID, int Style);
        /// <summary>
        /// Returns the display symbol for vertices.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexStyle(int uID, ref int Style);
        /// <summary>
        /// Returns whether the display of vertices considers the Show/Hide Selected setting.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexShowHideSelected(int uID, ref byte UseSettings);
        /// <summary>
        /// Returns the size index of the displayed vertices.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexSize(int uID, ref int Size);
        /// <summary>
        /// Returns the display style for vertex labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexLabelStyle(int uID, ref int LabelStyle);
        /// <summary>
        /// Returns the colours used to display vertices.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Returns the display option for free vertices.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFreeVertices(int uID, ref int Style);
        /// <summary>
        /// Sets the display style for faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFaceFillStyle(int uID, int Style);
        /// <summary>
        /// Sets the fill colour scheme for faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFaceFill(int uID, int Fill);
        /// <summary>
        /// Sets the outline colour scheme for faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFaceOutline(int uID, int Outline);
        /// <summary>
        /// Sets the display style for face labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFaceLabelStyle(int uID, int LabelStyle);
        /// <summary>
        /// Sets the colours to be used for given face display types, where such are required.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFaceColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Sets the state of the Lighting options for face rendering.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFaceLighting(int uID, byte FillLighting, byte LineLighting);
        /// <summary>
        /// Sets the thickness of the face outlines.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFaceLineThickness(int uID, int Thickness);
        /// <summary>
        /// Sets the thickness of the face wireframes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFaceWireThickness(int uID, int Thickness);
        /// <summary>
        /// Sets the density of the face wireframes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFaceWireDensity(int uID, int Density);
        /// <summary>
        /// Sets the size index of the face normals.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFaceNormalsSize(int uID, int Size);
        /// <summary>
        /// Sets whether to highlight non-interpolated face edges.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFaceNIEdges(int uID, byte Show);
        /// <summary>
        /// Sets whether to Show Control Points on the geometry faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFaceControlPoints(int uID, byte Show);
        /// <summary>
        /// Sets whether to Show Normals on the geometry faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFaceNormals(int uID, byte Show);
        /// <summary>
        /// Returns the display style for faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFaceFillStyle(int uID, ref int Style);
        /// <summary>
        /// Returns the fill colour scheme for faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFaceFill(int uID, ref int Fill);
        /// <summary>
        /// Returns the outline colour scheme for faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFaceOutline(int uID, ref int Outline);
        /// <summary>
        /// Returns the display style for face labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFaceLabelStyle(int uID, ref int LabelStyle);
        /// <summary>
        /// Returns the colours to be used for given face display types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFaceColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Returns the state of the Lighting options for face rendering.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFaceLighting(int uID, ref byte FillLighting, ref byte LineLighting);
        /// <summary>
        /// Returns the thickness of the face outlines.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFaceLineThickness(int uID, ref int Thickness);
        /// <summary>
        /// Returns the thickness of the face wireframes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFaceWireThickness(int uID, ref int Thickness);
        /// <summary>
        /// Returns the density of the face wireframes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFaceWireDensity(int uID, ref int Density);
        /// <summary>
        /// Returns the size index of the face normals.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFaceNormalsSize(int uID, ref int Size);
        /// <summary>
        /// Returns whether to highlight non-interpolated face edges.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFaceNIEdges(int uID, ref byte Show);
        /// <summary>
        /// Returns whether to Show Control Points on the geometry faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFaceControlPoints(int uID, ref byte Show);
        /// <summary>
        /// Returns whether to Show Normals on the geometry faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFaceNormals(int uID, ref byte Show);
        /// <summary>
        /// Sets the fill colour scheme for load paths.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPathFill(int uID, int Fill);
        /// <summary>
        /// Sets the outline colour scheme for load paths.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPathOutline(int uID, int Outline);
        /// <summary>
        /// Sets the display style for load path labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPathLabelStyle(int uID, int LabelStyle);
        /// <summary>
        /// Sets the colours to be used for given load path display types, where such are required.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPathColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Sets the state of the Lighting options for load path rendering.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPathLighting(int uID, byte FillLighting, byte LineLighting);
        /// <summary>
        /// Sets the thickness of the load path outlines.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPathLineThickness(int uID, int Thickness);
        /// <summary>
        /// Sets whether Divisions are shown on load paths.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPathDivisions(int uID, byte Show);
        /// <summary>
        /// Returns the fill colour scheme for load paths.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPathFill(int uID, ref int Fill);
        /// <summary>
        /// Returns the outline colour scheme for load paths.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPathOutline(int uID, ref int Outline);
        /// <summary>
        /// Returns the display style for load path labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPathLabelStyle(int uID, ref int LabelStyle);
        /// <summary>
        /// Returns the colours to be used for given load path display types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPathColours(int uID, int[] Colours, int NumCol);
        /// <summary>
        /// Returns the state of the Lighting options for load path rendering.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPathLighting(int uID, ref byte FillLighting, ref byte LineLighting);
        /// <summary>
        /// Returns the thickness of the load path outlines.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPathLineThickness(int uID, ref int Thickness);
        /// <summary>
        /// Returns whether Divisions are shown on load paths.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPathDivisions(int uID, ref byte Show);
        /// <summary>
        /// Sets options related to the display of attributes in the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetAttributeDisplay(int uID, int AttributeOrd, int[] Integers);
        /// <summary>
        /// Returns options related to the display of attributes in the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetAttributeDisplay(int uID, int AttributeOrd, int[] Integers);
        /// <summary>
        /// Sets the font for displaying entity labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntityFont(int uID, int Entity, string FontName, int[] Integers);
        /// <summary>
        /// Returns the font for displaying entity labels.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityFont(int uID, int Entity, StringBuilder FontName, int MaxStringLen, int[] Integers);
        /// <summary>
        /// Sets a user defined contour file for beam, plate or brick elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntityContourFile(int uID, int Entity, int FileType, string FileName);
        /// <summary>
        /// Returns the user defined contour file specified for beam, plate or brick elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityContourFile(int uID, int Entity, ref int FileType, StringBuilder FileName, int MaxStringLen);
        /// <summary>
        /// Sets a contour type from the combo box menus in Entity Display for beam, plate or brick elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntityContourIndex(int uID, int Entity, int Index);
        /// <summary>
        /// Returns the contour type specified by the combo box menus in Entity Display for beam, plate or brick elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityContourIndex(int uID, int Entity, ref int Index);
        /// <summary>
        /// Sets the parameters accessible through Entity Display/Contour/Settings…/Style in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntityContourSettingsStyle(int uID, int Entity, int[] Integers);
        /// <summary>
        /// Returns the parameters accessible through Entity Display/Contour/Settings…/Style in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityContourSettingsStyle(int uID, int Entity, int[] Integers);
        /// <summary>
        /// Sets the parameters accessible through Entity Display/Contour/Settings…/Limits in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntityContourSettingsLimits(int uID, int Entity, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the parameters accessible through Entity Display/Contour/Settings…/Limits in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityContourSettingsLimits(int uID, int Entity, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the parameters accessible through Entity Display/Contour/Settings…/Limits in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntityContourSettingsLimitsString(int uID, int Entity, string LimitsString);
        /// <summary>
        /// Returns the parameters accessible through Entity Display/Contour/Settings…/Limits in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityContourSettingsLimitsString(int uID, int Entity, StringBuilder LimitsString, int MaxStringLen);
        /// <summary>
        /// Sets the parameters accessible through Entity Display/Contour/Settings…/Legend in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntityContourSettingsLegend(int uID, int Entity, int[] Integers);
        /// <summary>
        /// Returns the parameters accessible through Entity Display/Contour/Settings…/Legend in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityContourSettingsLegend(int uID, int Entity, int[] Integers);
        /// <summary>
        /// Sets the parameters accessible through Entity Display/Contour/Settings…/Legend in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntityContourSettingsLegendFont(int uID, int Entity, string FontName, int[] Integers);
        /// <summary>
        /// Returns the parameters accessible through Entity Display/Contour/Settings…/Legend in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityContourSettingsLegendFont(int uID, int Entity, StringBuilder FontName, int MaxStringLen, int[] Integers);
        /// <summary>
        /// Resets display related parameters in a Strand7 model to default values.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetModelDefaults(int uID, int Options, int Mode, int[] Integers);
        /// <summary>
        /// Sets the Displacement Scale used to draw the deformed model, when an associated model result file is open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetDisplacementScale(int uID, double DispScale, int ScaleType);
        /// <summary>
        /// Returns the Displacement Scale used to draw the deformed model when an associated model result file is open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetDisplacementScale(int uID, ref double DispScale, ref int ScaleType);
        /// <summary>
        /// Deletes all result graphs.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteAllGraphs(int uID);
        /// <summary>
        /// Imports the specified Strand7 text file format model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ImportST7(int uID, string FileName, int[] Integers, int Mode);
        /// <summary>
        /// Imports a geometry file in IGES format.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ImportIGES(int uID, string FileName, int[] Integers, double[] Doubles, int Mode);
        /// <summary>
        /// Imports a geometry file in the ACIS format.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ImportACIS(int uID, string FileName, int[] Integers, double[] Doubles, int Mode);
        /// <summary>
        /// Imports a geometry file in the STEP format.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ImportSTEP(int uID, string FileName, int[] Integers, double[] Doubles, int Mode);
        /// <summary>
        /// Imports a geometry file in the Rhino format.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ImportRhino(int uID, string FileName, int[] Integers, double[] Doubles, int Mode);
        /// <summary>
        /// Imports a geometry file in the DXF format.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ImportDXF(int uID, string FileName, int[] Integers, double[] Doubles, int Mode);
        /// <summary>
        /// Imports a stereo-lithography file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ImportSTL(int uID, string FileName, int[] Integers, int Mode);
        /// <summary>
        /// Imports a NASTRAN model file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ImportNASTRAN(int uID, string FileName, int[] Integers, int Mode);
        /// <summary>
        /// Imports an ANSYS model file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ImportANSYS(int uID, string FileName, string LoadCaseFilePath, int[] Integers, int Mode);
        /// <summary>
        /// Imports a STAAD model file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ImportSTAAD(int uID, string FileName, int[] Integers, int Mode);
        /// <summary>
        /// Imports a SAP2000 model file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ImportSAP2000(int uID, string FileName, int[] Integers, int Mode);
        /// <summary>
        /// Exports the Strand7 graphics as an image file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExportImage(int uID, string FileName, int ImageType, int Width, int Height);
        /// <summary>
        /// Copies the Strand7 graphics to the clipboard.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExportImageToClipboard(int uID, int Width, int Height);
        /// <summary>
        /// Exports the current model in the Strand7 text file format.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExportST7(int uID, string FileName, int Mode, int ExportFormat);
        /// <summary>
        /// Exports the current Strand7 geometry as an IGES format geometry file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExportIGES(int uID, string FileName, int[] Integers, int Mode);
        /// <summary>
        /// Exports the current Strand7 geometry as a STEP format geometry file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExportSTEP(int uID, string FileName, int[] Integers, int Mode);
        /// <summary>
        /// Exports the current Strand7 geometry as a DXF format geometry file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExportDXF(int uID, string FileName, int[] Integers, int Mode);
        /// <summary>
        /// Exports the current Strand7 model as a STL file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExportSTL(int uID, string FileName, int[] Integers, int Mode);
        /// <summary>
        /// Exports the current Strand7 model as a NASTRAN model file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExportNASTRAN(int uID, string FileName, int[] Integers, double[] Doubles, int Mode);
        /// <summary>
        /// Exports the current Strand7 model as an ANSYS model file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExportANSYS(int uID, string FileName, int[] Integers, int Mode);
        /// <summary>
        /// Opens and plays a SAF animation file in an animation window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PlayAnimationFile(string FileName, ref int aHandle);
        /// <summary>
        /// Creates a SAF animation file and plays it in an animation window. The Strand7 model referenced by uID must have a results file open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateAnimation(int uID, int[] Integers, ref int aHandle);
        /// <summary>
        /// Creates a SAF animation embedded in a parent window. The Strand7 model referenced by uID must have a results file open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateAnimationEmbedded(int uID, IntPtr pHandle, int[] Integers, ref int aHandle);
        /// <summary>
        /// Creates an animation file but does not play it.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateAnimationFile(int uID, int[] Integers, string FileName);
        /// <summary>
        /// Closes a SAF animation that is currently running.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CloseAnimation(int aHandle);
        /// <summary>
        /// Sets the state of the specified result case for multi-case animations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetAnimationCase(int uID, int CaseNum, byte Active);
        /// <summary>
        /// Returns the state assigned to the specified result case for multi-case animations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetAnimationCase(int uID, int CaseNum, ref byte Active);
        /// <summary>
        /// Returns the total number of entities of the specified entity type in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTotal(int uID, int Entity, ref int Total);
        /// <summary>
        /// Set the initial droop direction applied to cable elements in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCableDroopDirection(int uID, int Direction);
        /// <summary>
        /// Returns the initial droop direction applied to cable elements in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCableDroopDirection(int uID, ref int Direction);
        /// <summary>
        /// Sets information entered in the NOTES tab for the Strand7 model Title, Project, Reference or Author.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTitle(int uID, int TitleType, string TitleString);
        /// <summary>
        /// Returns the information entered in the NOTES tab for the Strand7 model Title, Project, Reference, Author, creation and last modification date.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTitle(int uID, int TitleType, StringBuilder TitleString, int MaxStringLen);
        /// <summary>
        /// Appends a line of text to the Strand7 model’s notes. Note lines are identified by their index, from one up to the total number of comments.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddComment(int uID, string CommentString);
        /// <summary>
        /// Returns the number of lines of notes in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumComments(int uID, ref int NumComments);
        /// <summary>
        /// Replaces the text in the specified line of a Strand7 model’s notes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetComment(int uID, int Comment, string CommentString);
        /// <summary>
        /// Returns the specified line of a Strand7 model’s notes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetComment(int uID, int Comment, StringBuilder CommentString, int MaxStringLen);
        /// <summary>
        /// Deletes the specified line of a Strand7 model’s notes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteComment(int uID, int Comment);
        /// <summary>
        /// Returns the number of plies in the specified plate element in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateNumPlies(int uID, int PlateNum, ref int NumPlies);
        /// <summary>
        /// Returns the beam axis system for the specified beam element based on the initial node coordinates. See Beam Local Coordinates for additional information.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamAxisSystemInitial(int uID, int BeamNum, double[] Doubles);
        /// <summary>
        /// Returns the beam axis system for the specified beam element based on the node coordinates at the element’s birth stage. The birth stage is determined from the requested result case. See Beam Local Coordinates for additional information.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamAxisSystemBirth(int uID, int BeamNum, int ResultCase, double[] Doubles);
        /// <summary>
        /// Returns the beam axis system for the specified beam element based on the absolute deformed node coordinates at the requested result case for an analysis that considers geometric nonlinearity. See Beam Local Coordinates for additional information.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamAxisSystemGNL(int uID, int BeamNum, int ResultCase, double[] Doubles);
        /// <summary>
        /// Returns the plate axis system for the specified plate element based on the initial node coordinates. See Plate Local Coordinates for additional information.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateAxisSystemInitial(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Returns the plate axis system for the specified plate element based on the node coordinates at the element’s birth stage. The birth stage is determined from the requested result case. See Plate Local Coordinates for additional information.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateAxisSystemBirth(int uID, int PlateNum, int ResultCase, double[] Doubles);
        /// <summary>
        /// Returns the plate axis system for the specified plate element based on the absolute deformed node coordinates at the requested result case for an analysis that considers geometric nonlinearity. See Plate Local Coordinates for additional information.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateAxisSystemGNL(int uID, int PlateNum, int ResultCase, double[] Doubles);
        /// <summary>
        /// Returns the brick face axis system for the specified brick face based on the initial node coordinates. See Brick Local Coordinates for additional information.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickFaceAxisSystemInitial(int uID, int BrickNum, int FaceNum, double[] Doubles);
        /// <summary>
        /// Returns the brick face axis system for the specified brick face based on the node coordinates at the element’s birth stage. The birth stage is determined from the requested result case. See Brick Local Coordinates for additional information.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickFaceAxisSystemBirth(int uID, int BrickNum, int FaceNum, int ResultCase, double[] Doubles);
        /// <summary>
        /// Returns the brick face axis system for the specified brick face based on the absolute deformed node coordinates at the requested result case for an analysis that considers geometric nonlinearity. See Brick Local Coordinates for additional information.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickFaceAxisSystemGNL(int uID, int BrickNum, int FaceNum, int ResultCase, double[] Doubles);
        /// <summary>
        /// Returns the number of loops and plates in the specified BXS.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumBXSLoopsAndPlates(int uID, int PropNum, ref int NumLoops, ref int NumPlates);
        /// <summary>
        /// Returns the number of points contained in the specified loop in a BXS.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumBXSLoopPoints(int uID, int PropNum, int LoopNum, ref int NumPoints);
        /// <summary>
        /// Returns the coordinates of the points in the specified loop of a BXS. The points are always specified in a 2D plane. Use St7GetNumBXSLoopPoints to determine the number of points in a loop.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBXSLoop(int uID, int PropNum, int LoopNum, int MaxPoints, ref int NumPoints, double[] Doubles);
        /// <summary>
        /// Returns the loop type of the specified loop. Each BXS has at least one outer loop. Strand7 supports multi-part BXSs whereby each part has an outer loop.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBXSLoopType(int uID, int PropNum, int LoopNum, ref int LoopType);
        /// <summary>
        /// Using the plate elements in the specified model, calculates and returns the BXS section properties, and saves BXS file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GenerateBXS(int uID, string BXSName, double[] Doubles);
        /// <summary>
        /// Exports a BXS contained in a beam property to the specified file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExportBXS(int uID, int PropNum, string BXSName);
        /// <summary>
        /// Creates a new load case within a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewLoadCase(int uID, string CaseName);
        /// <summary>
        /// Returns the number of load cases in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumLoadCase(int uID, ref int NumCases);
        /// <summary>
        /// Sets the name of the specified load case in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadCaseName(int uID, int CaseNum, string CaseName);
        /// <summary>
        /// Returns the name of the specified load case within a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadCaseName(int uID, int CaseNum, StringBuilder CaseName, int MaxStringLen);
        /// <summary>
        /// Sets the defaults for the specified load case in a Strand7 model; not applicable to seismic load cases.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadCaseDefaults(int uID, int CaseNum, double[] Defaults);
        /// <summary>
        /// Returns the default values for the specified load case within a Strand7 model; not applicable to seismic load cases.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadCaseDefaults(int uID, int CaseNum, double[] Defaults);
        /// <summary>
        /// Sets the type for the specified load case in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadCaseType(int uID, int CaseNum, int CaseType);
        /// <summary>
        /// Returns the type for the specified load case in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadCaseType(int uID, int CaseNum, ref int CaseType);
        /// <summary>
        /// Sets the direction of the gravity vector for the specified load case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadCaseGravityDir(int uID, int CaseNum, int GravDir);
        /// <summary>
        /// Returns the direction of the gravity vector assigned to the specified load case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadCaseGravityDir(int uID, int CaseNum, ref int GravDir);
        /// <summary>
        /// Sets the value of the acceleration due to gravity for the specified load case of type lcGravity.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadCaseGravity(int uID, int CaseNum, double Gravity);
        /// <summary>
        /// Returns the value of the acceleration due to gravity for the specified load case of type lcGravity.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadCaseGravity(int uID, int CaseNum, ref double Gravity);
        /// <summary>
        /// Sets the enabled state of the dynamic factor option for the specified seismic load case in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSeismicCaseDynamicNSMassState(int uID, int CaseNum, byte Enabled);
        /// <summary>
        /// Returns the enabled state of the dynamic factor option for the specified seismic load case in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSeismicCaseDynamicNSMassState(int uID, int CaseNum, ref byte Enabled);
        /// <summary>
        /// Sets the mass options for the specified load case in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadCaseMassOption(int uID, int CaseNum, byte SMass, byte NSMass);
        /// <summary>
        /// Returns the mass options for the specified load case in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadCaseMassOption(int uID, int CaseNum, ref byte SMass, ref byte NSMass);
        /// <summary>
        /// Deletes the specified load case from the Strand7 model. Since load cases use contiguous numbering this will cause all the following load case numbers to shift down by one.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteLoadCase(int uID, int CaseNum);
        /// <summary>
        /// Returns the number of primary load cases in a Strand7 model that are of Seismic type.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumSeismicCase(int uID, ref int NumCases);
        /// <summary>
        /// Sets the defaults for the specified load case of type lcSeismic within a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSeismicCaseDefaults(int uID, int CaseNum, double[] Defaults);
        /// <summary>
        /// Returns the defaults for the specified load case of type lcSeismic within a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSeismicCaseDefaults(int uID, int CaseNum, double[] Defaults);
        /// <summary>
        /// Creates a new freedom case within a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewFreedomCase(int uID, string CaseName);
        /// <summary>
        /// Returns the number of freedom cases in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumFreedomCase(int uID, ref int NumCases);
        /// <summary>
        /// Sets the name of the specified freedom case within a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFreedomCaseName(int uID, int CaseNum, string CaseName);
        /// <summary>
        /// Returns the name of the specified freedom case in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFreedomCaseName(int uID, int CaseNum, StringBuilder CaseName, int MaxStringLen);
        /// <summary>
        /// Sets the defaults for the specified freedom case within a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFreedomCaseDefaults(int uID, int CaseNum, int[] Defaults);
        /// <summary>
        /// Returns the defaults for the specified freedom case in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFreedomCaseDefaults(int uID, int CaseNum, int[] Defaults);
        /// <summary>
        /// Sets the type for the specified freedom case in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFreedomCaseType(int uID, int CaseNum, int CaseType);
        /// <summary>
        /// Returns the type of the specified freedom case with a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFreedomCaseType(int uID, int CaseNum, ref int CaseType);
        /// <summary>
        /// Sets the remove rigid body motion option for freedom cases of type inertia relief.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFreedomCaseRigidMotion(int uID, int CaseNum, byte Remove);
        /// <summary>
        /// Returns the remove rigid body motion option for freedom cases of type inertia relief.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFreedomCaseRigidMotion(int uID, int CaseNum, ref byte Remove);
        /// <summary>
        /// Deletes the specified freedom case in the Strand7 model. Since freedom cases use contiguous numbering this will cause all the following freedom case numbers to shift down by one.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteFreedomCase(int uID, int CaseNum);
        /// <summary>
        /// Sets the data for the specified User Coordinate System (UCS) in a Strand7 model, or creates a UCS if the specified UCSId does not exist.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetUCS(int uID, int UCSId, int UCSType, double[] UCSDoubles);
        /// <summary>
        /// Returns the data for the specified UCS in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetUCS(int uID, int UCSId, ref int UCSType, double[] UCSDoubles);
        /// <summary>
        /// Deletes the specified UCS in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteUCS(int uID, int UCSId);
        /// <summary>
        /// Sets the name of the specified UCS in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetUCSName(int uID, int UCSId, string UCSName);
        /// <summary>
        /// Returns the name of the specified UCS in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetUCSName(int uID, int UCSId, StringBuilder UCSName, int MaxStringLen);
        /// <summary>
        /// Returns the ID number corresponding to the specified UCS index in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetUCSID(int uID, int Index, ref int UCSId);
        /// <summary>
        /// Returns the number of UCSs in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumUCS(int uID, ref int NumUCS);
        /// <summary>
        /// Sets the name of the specified group in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGroupIDName(int uID, int ID, string GName);
        /// <summary>
        /// Returns the name of the specified group in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGroupIDName(int uID, int ID, StringBuilder GName, int MaxStringLen);
        /// <summary>
        /// Returns the number of groups in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumGroups(int uID, ref int NumGroups);
        /// <summary>
        /// Returns the group name and ID number corresponding to the specified index.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGroupByIndex(int uID, int Index, StringBuilder GName, int MaxStringLen, ref int GroupID);
        /// <summary>
        /// Creates a new child group within the specified group parent after its last child.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewChildGroup(int uID, int ParentID, string GName, ref int ChildID);
        /// <summary>
        /// Returns the parent of the specified group. ParentID is -1 if the specified group is the root group.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGroupParent(int uID, int GroupID, ref int ParentID);
        /// <summary>
        /// Returns the first child of the specified group. ChildID is -1 if the specified group has no children.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGroupChild(int uID, int GroupID, ref int ChildID);
        /// <summary>
        /// Returns the next sibling of the specified group. SiblingID is -1 if the specified group has no subsequent siblings.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGroupSibling(int uID, int GroupID, ref int SiblingID);
        /// <summary>
        /// Deletes the specified group. Elements in the group will be reassigned to the Model group.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteGroup(int uID, int GroupID);
        /// <summary>
        /// Sets the colour of the specified group for entity display purposes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGroupColour(int uID, int GroupID, int GroupCol);
        /// <summary>
        /// Returns the colour of the specified group for entity display purposes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGroupColour(int uID, int GroupID, ref int GroupCol);
        /// <summary>
        /// Sets the group for newly created elements where the group cannot be determined from the source.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetDefaultGroupID(int uID, int GroupID);
        /// <summary>
        /// Returns the group that will be assigned to newly created elements where the group cannot be determined from the source.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetDefaultGroupID(int uID, ref int GroupID);
        /// <summary>
        /// Adds a new stage to a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddStage(int uID, string StageName, int[] Integers);
        /// <summary>
        /// Inserts a new stage in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertStage(int uID, int Stage, string StageName, int[] Integers);
        /// <summary>
        /// Deletes a stage from a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteStage(int uID, int Stage);
        /// <summary>
        /// Returns the number of stages in a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumStages(int uID, ref int NumStages);
        /// <summary>
        /// Sets the name of the specified stage.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetStageName(int uID, int Stage, string StageName);
        /// <summary>
        /// Returns the name of the specified stage.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetStageName(int uID, int Stage, StringBuilder StageName, int MaxStringLen);
        /// <summary>
        /// Sets the data for the specified stage.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetStageData(int uID, int Stage, int[] Integers);
        /// <summary>
        /// Returns the data for the specified stage.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetStageData(int uID, int Stage, int[] Integers);
        /// <summary>
        /// Sets the fluid level for soil properties in the specified stage.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetStageFluidLevel(int uID, int Stage, double Level);
        /// <summary>
        /// Returns the fluid level for soil properties in the specified stage.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetStageFluidLevel(int uID, int Stage, ref double Level);
        /// <summary>
        /// Enables the specified group for a given stage. The elements in all groups enabled for a given stage will participate in the solution once the specified stage becomes active.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableStageGroup(int uID, int Stage, int GroupID);
        /// <summary>
        /// Disables the specified group for a given stage. The elements in all groups enabled for a given stage will participate in the solution once the specified stage becomes active.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableStageGroup(int uID, int Stage, int GroupID);
        /// <summary>
        /// Returns whether the specified group is currently enabled for a given stage.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetStageGroupState(int uID, int Stage, int GroupID, ref byte Enabled);
        /// <summary>
        /// Creates a new entity set. Since entity sets are contiguously numbered, the newly created entity set number will be one greater than the previous count.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewEntitySet(int uID, string SetName);
        /// <summary>
        /// Deletes an entity set.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteEntitySet(int uID, int SetNum);
        /// <summary>
        /// Sets the name of the specified entity set.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntitySetName(int uID, int SetNum, string SetName);
        /// <summary>
        /// Returns the name of the specified entity set.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntitySetName(int uID, int SetNum, StringBuilder SetName, int MaxStringLen);
        /// <summary>
        /// Checks whether or not an entity is included in an entity set.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntitySetEntityState(int uID, int Entity, int EntityNum, int SetNum, ref byte Included);
        /// <summary>
        /// Shows all entities in the specified entity set within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowEntitySet(int uID, int SetNum);
        /// <summary>
        /// Hides all entities in the specified entity set within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideEntitySet(int uID, int SetNum);
        /// <summary>
        /// Determines the visibility of an entity set within the model window.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntitySetVisibility(int uID, int SetNum, ref byte Visible);
        /// <summary>
        /// Returns the number of entity sets.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumEntitySets(int uID, ref int NumSets);
        /// <summary>
        /// Adds the selected entities to an entity set.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddSelectedToEntitySet(int uID, int Entity, int SetNum);
        /// <summary>
        /// Removes the selected entities from an entity set.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7RemoveSelectedFromEntitySet(int uID, int Entity, int SetNum);
        /// <summary>
        /// Sets the units used to specify and report measures of length, force, stress, mass, temperature and energy in the specified Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetUnits(int uID, int[] Units);
        /// <summary>
        /// Returns the units used to specify and report measures of length, force, stress, mass, temperature and energy in the specified Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetUnits(int uID, int[] Units);
        /// <summary>
        /// Sets the units used for Plate RC results (in Results Settings). Note that this setting is ignored unless St7EnableModelRCUnit is called.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetRCUnits(int uID, int AreaUnit, int LengthUnit);
        /// <summary>
        /// Returns the units used for Plate RC results (in Results Settings). Note that this setting is ignored unless St7EnableModelRCUnit is called.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetRCUnits(int uID, ref int AreaUnit, ref int LengthUnit);
        /// <summary>
        /// Converts the current model into the specified units system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ConvertUnits(int uID, int[] Units);
        /// <summary>
        /// Sets the position of the specified node in the global XYZ system. A new node is created if the node number does not already exist. If the new node number is not consecutive with the existing node total a series of nodes are created at the origin such that the node list remains contiguous.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeXYZ(int uID, int NodeNum, double[] XYZ);
        /// <summary>
        /// Returns the coordinates of the specified node in the global XYZ system in its undeformed position.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeXYZ(int uID, int NodeNum, double[] XYZ);
        /// <summary>
        /// Sets the position of the specified node in a given UCS. A new node is created if the node number does not already exist. If the new node number is not consecutive with the existing node total a series of nodes are created at the origin such that the node list remains contiguous.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeUCS(int uID, int NodeNum, int UCSId, double[] XYZ);
        /// <summary>
        /// Returns the coordinates of the specified node in a given UCS in its undeformed position.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeUCS(int uID, int NodeNum, int UCSId, double[] XYZ);
        /// <summary>
        /// Sets the nodal connectivity and property ID for the specified element. A new entity is created if the element number does not already exist. If the new element number is not consecutive with the existing element total a series of null elements are created such that the element list remains contiguous. These null elements do not have any connectivity or property ID assigned.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetElementConnection(int uID, int Entity, int EntityNum, int PropNum, int[] Connection);
        /// <summary>
        /// Returns the connectivity information for the specified element.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetElementConnection(int uID, int Entity, int EntityNum, int[] Connection);
        /// <summary>
        /// Returns element specific geometric data for a given element.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetElementData(int uID, int Entity, int EntityNum, int ResultCase, ref double EltData);
        /// <summary>
        /// Returns element specific geometric data for a given element for geometrically nonlinear results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetElementDataGNL(int uID, int Entity, int EntityNum, int ResultCase, ref double EltData);
        /// <summary>
        /// Returns element specific geometric data for a given element for a result file with displacements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetElementDataDeformed(int uID, int Entity, int EntityNum, int ResultCase, double DispScale, ref double EltData);
        /// <summary>
        /// Returns the edge lengths of the specified plate element.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateEdgeLengths(int uID, int PlateNum, int ResultCase, double[] Lengths);
        /// <summary>
        /// Returns the edge lengths of the specified plate element for geometrically nonlinear results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateEdgeLengthsGNL(int uID, int PlateNum, int ResultCase, double[] Lengths);
        /// <summary>
        /// Returns the edge lengths of the specified plate element for a result file with displacements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateEdgeLengthsDeformed(int uID, int PlateNum, int ResultCase, double DispScale, double[] Lengths);
        /// <summary>
        /// Returns the face areas of the specified brick element.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickFaceAreas(int uID, int BrickNum, int ResultCase, double[] Areas);
        /// <summary>
        /// Returns the face areas of the specified brick element for geometrically nonlinear results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickFaceAreasGNL(int uID, int BrickNum, int ResultCase, double[] Areas);
        /// <summary>
        /// Returns the face areas of the specified brick element for a result file with displacements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickFaceAreasDeformed(int uID, int BrickNum, int ResultCase, double DispScale, double[] Areas);
        /// <summary>
        /// Returns the coordinates of the geometric centroid of the specified element in its undeformed position.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetElementCentroid(int uID, int Entity, int EntityNum, int FaceEdgeNum, double[] XYZ);
        /// <summary>
        /// Returns the coordinates of the geometric centroid of the specified element in its birth position when a result file is open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetElementCentroidAtBirth(int uID, int Entity, int EntityNum, int FaceEdgeNum, int ResultCase, double[] XYZ);
        /// <summary>
        /// Returns the coordinates of the nodes of the specified element in its birth position when a result file is open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetElementCoordinatesAtBirth(int uID, int Entity, int EntityNum, int ResultCase, double[] XYZ);
        /// <summary>
        /// Assigns the parameters for the specified master-slave link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetMasterSlaveLink(int uID, int LinkNum, int UCSId, int[] Connection, int[] Integers);
        /// <summary>
        /// Returns the parameters for the specified master-slave link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetMasterSlaveLink(int uID, int LinkNum, ref int UCSId, int[] Connection, int[] Integers);
        /// <summary>
        /// Assigns the parameters for the specified sector-symmetry link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSectorSymmetryLink(int uID, int LinkNum, int Axis, int[] Connection);
        /// <summary>
        /// Returns the parameters for the specified sector-symmetry link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSectorSymmetryLink(int uID, int LinkNum, ref int Axis, int[] Connection);
        /// <summary>
        /// Assigns the parameters for the specified coupling link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCouplingLink(int uID, int LinkNum, int Couple, int[] Connection);
        /// <summary>
        /// Returns the parameters for the specified coupling link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCouplingLink(int uID, int LinkNum, ref int Couple, int[] Connection);
        /// <summary>
        /// Assigns the parameters for the specified pinned link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPinnedLink(int uID, int LinkNum, int[] Connection);
        /// <summary>
        /// Returns the parameters for the specified pinned link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPinnedLink(int uID, int LinkNum, int[] Connection);
        /// <summary>
        /// Assigns the parameters for the specified rigid link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetRigidLink(int uID, int LinkNum, int UCSId, int Plane, int[] Connection);
        /// <summary>
        /// Returns the parameters for the specified rigid link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetRigidLink(int uID, int LinkNum, ref int UCSId, ref int Plane, int[] Connection);
        /// <summary>
        /// Assigns the parameters for the specified shrink link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetShrinkLink(int uID, int LinkNum, int[] Connection, int[] Integers);
        /// <summary>
        /// Returns the parameters for the specified shrink link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetShrinkLink(int uID, int LinkNum, int[] Connection, int[] Integers);
        /// <summary>
        /// Assigns the parameters for the specified two-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTwoPointLink(int uID, int LinkNum, int[] Connection, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the parameters for the specified two-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTwoPointLink(int uID, int LinkNum, int[] Connection, int[] Integers, double[] Doubles);
        /// <summary>
        /// Assigns the parameters for the specified attachment link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetAttachmentLink(int uID, int LinkNum, int[] Connection, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the parameters for the specified attachment link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetAttachmentLink(int uID, int LinkNum, int[] Connection, int[] Integers, double[] Doubles);
        /// <summary>
        /// Assigns the parameters for the specified interpolated multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetInterpolatedMultiPointLink(int uID, int LinkNum, int NumNodes, int Couple, int[] Connection);
        /// <summary>
        /// Returns the parameters for the specified interpolated multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInterpolatedMultiPointLink(int uID, int LinkNum, int MaxNodes, ref int NumNodes, ref int Couple, int[] Connection);
        /// <summary>
        /// Assigns the parameters for the specified master-slave multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetMasterSlaveMultiPointLink(int uID, int LinkNum, int NumNodes, int UCSId, int DoFBits, int[] Connection);
        /// <summary>
        /// Returns the parameters for the specified master-slave multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetMasterSlaveMultiPointLink(int uID, int LinkNum, int MaxNodes, ref int NumNodes, ref int UCSId, ref int DoFBits, int[] Connection);
        /// <summary>
        /// Assigns the parameters for the specified pinned multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPinnedMultiPointLink(int uID, int LinkNum, int NumNodes, int[] Connection);
        /// <summary>
        /// Returns the parameters for the specified pinned multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPinnedMultiPointLink(int uID, int LinkNum, int MaxNodes, ref int NumNodes, int[] Connection);
        /// <summary>
        /// Assigns the parameters for the specified rigid multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetRigidMultiPointLink(int uID, int LinkNum, int NumNodes, int UCSId, int Axis, int[] Connection);
        /// <summary>
        /// Returns the parameters for the specified rigid multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetRigidMultiPointLink(int uID, int LinkNum, int MaxNodes, ref int NumNodes, ref int UCSId, ref int Axis, int[] Connection);
        /// <summary>
        /// Assigns the parameters for the specified user defined multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetUserDefinedMultiPointLink(int uID, int LinkNum, int NumNodes, int CaseNum, double CFactor, int[] Connection, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the parameters for the specified user defined multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetUserDefinedMultiPointLink(int uID, int LinkNum, int MaxNodes, ref int NumNodes, ref int CaseNum, ref double CFactor, int[] Connection, int[] Integers, double[] Doubles);
        /// <summary>
        /// Assigns the parameters for the specified reaction multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetReactionMultiPointLink(int uID, int LinkNum, int NumNodes, int SetNum, int[] Connection, double[] Origin);
        /// <summary>
        /// Returns the parameters for the specified reaction multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetReactionMultiPointLink(int uID, int LinkNum, int MaxNodes, ref int NumNodes, ref int SetNum, int[] Connection, double[] Origin);
        /// <summary>
        /// Assigns attributes to a reaction multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetReactionMultiPointLinkAttributes(int uID, int LinkNum, int SetNum, double[] Origin);
        /// <summary>
        /// Returns attributes assigned to a reaction multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetReactionMultiPointLinkAttributes(int uID, int LinkNum, ref int SetNum, double[] Origin);
        /// <summary>
        /// Assigns attributes to an interpolated multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetInterpolatedMultiPointLinkAttributes(int uID, int LinkNum, int Couple);
        /// <summary>
        /// Returns attributes assigned to an interpolated multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInterpolatedMultiPointLinkAttributes(int uID, int LinkNum, ref int Couple);
        /// <summary>
        /// Assigns attributes to a master-slave multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetMasterSlaveMultiPointLinkAttributes(int uID, int LinkNum, int UCSId, int DoFBits);
        /// <summary>
        /// Returns attributes assigned to a master-slave multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetMasterSlaveMultiPointLinkAttributes(int uID, int LinkNum, ref int UCSId, ref int DoFBits);
        /// <summary>
        /// Assigns attributes to a rigid multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetRigidMultiPointLinkAttributes(int uID, int LinkNum, int UCSId, int Axis);
        /// <summary>
        /// Returns attributes assigned to a rigid multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetRigidMultiPointLinkAttributes(int uID, int LinkNum, ref int UCSId, ref int Axis);
        /// <summary>
        /// Returns the number of nodes in the specified multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumMultiPointLinkNodes(int uID, int LinkNum, ref int NumNodes);
        /// <summary>
        /// Returns the link type for the specified link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLinkType(int uID, int LinkNum, ref int LinkType);
        /// <summary>
        /// Returns the position of the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexXYZ(int uID, int VertexNum, double[] XYZ);
        /// <summary>
        /// Returns the outer loops in the specified geometry face, note that a geometry face may have one or two outer loops only.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceOuterLoops(int uID, int FaceNum, int[] OuterLoops);
        /// <summary>
        /// Returns the number of cavity loops in the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumGeometryFaceCavityLoops(int uID, int FaceNum, ref int NumCavityLoops);
        /// <summary>
        /// Returns the cavity loop numbers for the specified geometry face. Use St7GetNumGeometryFaceCavityLoops to determine the number of cavity loops in the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceCavityLoops(int uID, int FaceNum, int MaxCavityLoops, int[] Integers);
        /// <summary>
        /// Returns the number of edges in the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumGeometryFaceEdges(int uID, int FaceNum, ref int NumEdges);
        /// <summary>
        /// Returns the edge numbers for the specified geometry face. Use St7GetNumGeometryFaceEdges to determine the number of edges in the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceEdges(int uID, int FaceNum, int MaxEdges, int[] Integers);
        /// <summary>
        /// Returns the number of edges in the specified loop.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumGeometryLoopEdges(int uID, int LoopNum, ref int NumEdges);
        /// <summary>
        /// Returns the edge numbers for the specified loop. Use St7GetNumGeometryLoopEdges to determine the number of edges in the specified loop.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryLoopEdges(int uID, int LoopNum, int MaxEdges, int[] Integers);
        /// <summary>
        /// Returns the length of the specified edge in a given geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryEdgeLength(int uID, int EdgeNum, ref double EdgeLength);
        /// <summary>
        /// Returns the number of coedges in the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumGeometryFaceCoedges(int uID, int FaceNum, ref int NumCoedges);
        /// <summary>
        /// Returns the coedge numbers for the specified geometry face. Use St7GetNumGeometryFaceCoedges to determine the number of coedges in the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceCoedges(int uID, int FaceNum, int MaxCoedges, int[] Integers);
        /// <summary>
        /// Returns the number of edges in the specified loop.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumGeometryLoopCoedges(int uID, int LoopNum, ref int NumCoedges);
        /// <summary>
        /// Returns the edge numbers for the specified loop. Use St7GetNumGeometryLoopCoedges to determine the number of edges in the specified loop.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryLoopCoedges(int uID, int LoopNum, int MaxCoedges, int[] Integers);
        /// <summary>
        /// Returns the edge number of a coedge. More than one coedge can be associated with a single edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryCoedgeEdge(int uID, int CoedgeNum, ref int EdgeNum);
        /// <summary>
        /// Returns the number of vertices in a given geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumGeometryFaceVertices(int uID, int FaceNum, ref int NumVertices);
        /// <summary>
        /// Returns the vertex numbers for the specified geometry face. Use St7GetNumGeometryFaceVertices to determine the number of vertices for the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceVertices(int uID, int FaceNum, int MaxVertices, int[] Integers);
        /// <summary>
        /// Returns the vertex numbers in the specified geometry edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryEdgeVertices(int uID, int EdgeNum, int[] EdgeVertices);
        /// <summary>
        /// Returns the surface number for the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceSurface(int uID, int FaceNum, ref int SurfaceNum);
        /// <summary>
        /// Returns the type of the specified surface.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometrySurfaceType(int uID, int SurfaceNum, ref int SurfaceType);
        /// <summary>
        /// Marks the specified geometry face as invalid for subsequent deletion using the St7DeleteInvalidGeometry function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InvalidateGeometryFace(int uID, int FaceNum);
        /// <summary>
        /// Marks the specified cavity loop as invalid for subsequent deletion using the St7DeleteInvalidGeometry function. This function uses the loop ID number to identify the appropriate loop.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InvalidateGeometryFaceCavityLoopID(int uID, int FaceNum, int LoopNum);
        /// <summary>
        /// Marks the specified cavity loop as invalid for subsequent deletion using the St7DeleteInvalidGeometry function. This function uses the loop index number to identify the appropriate loop.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InvalidateGeometryFaceCavityLoopIndex(int uID, int FaceNum, int LoopIndex);
        /// <summary>
        /// Deletes all invalid faces in the specified model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteInvalidGeometry(int uID);
        /// <summary>
        /// Specifies the settings used when performing subsequent geometry clean operations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCleanGeometryOptions(int uID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Retrieves the current settings used when performing a geometry clean operation.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCleanGeometryOptions(int uID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Performs a geometry clean operation on the geometry included in the specified Strand7 model. Cleaning the geometry can be used to improve geometry definitions and is typically recommended before subsequent geometry or meshing operations are conducted. The operation consists of a number of different stages including: vertex and curve zipping, duplicate face processing, curve and surface refitting and morphing.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CleanGeometry(int uID, ref int ChangesMade, int Mode);
        /// <summary>
        /// Retrieves the relative overall size of the geometry in the specified Strand7 model. This size measure is used when calculating the relative geometry tolerance.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometrySize(int uID, ref double Size);
        /// <summary>
        /// Sets the data for a load path in the specified model. A new load path is created if a new load path ID is specified.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadPath(int uID, int LoadPathID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the data assigned to the specified load path.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadPath(int uID, int LoadPathID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Deletes the specified load path.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteLoadPath(int uID, int LoadPathID);
        /// <summary>
        /// Sets the ID number of the specified node.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeID(int uID, int NodeNum, int NodeID);
        /// <summary>
        /// Sets the restraint conditions at the specified node in the specified UCS.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeRestraint6(int uID, int NodeNum, int CaseNum, int UCSId, int[] Status, double[] Doubles);
        /// <summary>
        /// Sets the point force acting on the specified node in the global XYZ system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeForce3(int uID, int NodeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the point moment acting on the specified node in the global XYZ system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeMoment3(int uID, int NodeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the temperature at the specified node.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeTemperature1(int uID, int NodeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the type of temperature at the specified node.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeTemperatureType1(int uID, int NodeNum, int CaseNum, int TType);
        /// <summary>
        /// Specifies the table to be associated with the temperature at the specified node. A table can only be assigned for nodes with the appropriate table temperature type, as set using the St7SetNodeTemperatureType1 function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeTemperatureTable(int uID, int NodeNum, int CaseNum, int TableID);
        /// <summary>
        /// Sets the translational stiffness acting at the specified node.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeKTranslation3F(int uID, int NodeNum, int CaseNum, int UCSId, double[] Doubles);
        /// <summary>
        /// Sets the rotational stiffness acting at the specified node.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeKRotation3F(int uID, int NodeNum, int CaseNum, int UCSId, double[] Doubles);
        /// <summary>
        /// Sets the translational mass assigned to the specified node as a single value. Translational masses are active in all load and freedom cases.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeTMass1(int uID, int NodeNum, double Mass);
        /// <summary>
        /// Sets the translational mass assigned to the specified node as three components. Translational masses are active in all load and freedom cases.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeTMass3(int uID, int NodeNum, double[] Doubles);
        /// <summary>
        /// Sets the rotational mass assigned to the specified node as three components. Rotational masses are active in all load and freedom cases.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeRMass3(int uID, int NodeNum, int UCSId, double[] Doubles);
        /// <summary>
        /// Sets the non-structural mass at the specified node.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeNSMass5ID(int uID, int NodeNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Sets the translational damping coefficients at the specified node.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeKDamping3F(int uID, int NodeNum, int CaseNum, int UCSId, double[] Doubles);
        /// <summary>
        /// Sets the heat source at the specified node.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeHeatSource1(int uID, int NodeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the specified node heat source.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeHeatSourceTables(int uID, int NodeNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Sets the initial global velocity components for the specified node. These initial conditions are used when performing transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeInitialVelocity3(int uID, int NodeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the global acceleration components at the specified node. These acceleration values are not used as initial conditions when performing transient analysis, rather, they are used to generate body forces when acting on masses.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeAcceleration3(int uID, int NodeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns a response variable to the specified node.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeResponse(int uID, int NodeNum, int CaseNum, int ResponseType, int UCSId, int[] Status);
        /// <summary>
        /// Returns the ID number assigned to the specified node.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeID(int uID, int NodeNum, ref int NodeID);
        /// <summary>
        /// Returns the restraint conditions assigned to the specified node. The UCS in which these restraints were applied is also returned. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeRestraint6(int uID, int NodeNum, int CaseNum, ref int UCSId, int[] Status, double[] Doubles);
        /// <summary>
        /// Returns the point force applied to the specified node in the global XYZ system. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeForce3(int uID, int NodeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the point moment applied at the specified node in the global XYZ system. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeMoment3(int uID, int NodeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the temperature value applied at the specified node. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeTemperature1(int uID, int NodeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the temperature type assigned at the specified node. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeTemperatureType1(int uID, int NodeNum, int CaseNum, ref int TType);
        /// <summary>
        /// Returns the table associated with the temperature at the specified node. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeTemperatureTable(int uID, int NodeNum, int CaseNum, ref int TableID);
        /// <summary>
        /// Returns the translational stiffness components assigned to the specified node. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeKTranslation3F(int uID, int NodeNum, int CaseNum, ref int UCSId, double[] Doubles);
        /// <summary>
        /// Returns the rotational stiffness components assigned to the specified node. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeKRotation3F(int uID, int NodeNum, int CaseNum, ref int UCSId, double[] Doubles);
        /// <summary>
        /// Returns the translational mass components assigned to the specified node. Translational masses are active in all load and freedom cases.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeTMass3(int uID, int NodeNum, double[] Doubles);
        /// <summary>
        /// Returns the rotational mass components assigned to the specified node. Rotational masses are active in all load and freedom cases.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeRMass3(int uID, int NodeNum, ref int UCSId, double[] Doubles);
        /// <summary>
        /// Returns the non-structural mass assigned to the specified node. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeNSMass5ID(int uID, int NodeNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Returns the translational damping coefficients assigned at the specified node. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeKDamping3F(int uID, int NodeNum, int CaseNum, ref int UCSId, double[] Doubles);
        /// <summary>
        /// Returns the heat source assigned at the specified node. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeHeatSource1(int uID, int NodeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the heat source at the specified node. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeHeatSourceTables(int uID, int NodeNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the initial velocity components assigned at the specified node. These initial conditions are used when performing transient dynamic analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeInitialVelocity3(int uID, int NodeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the acceleration components assigned at the specified node. These acceleration values are not used as initial conditions when performing transient analysis, rather, they are used to generate body forces when acting on masses. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeAcceleration3(int uID, int NodeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the response variable assigned at the specified node. Response variables are only used by the load influence solver. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeResponse(int uID, int NodeNum, int CaseNum, int ResponseType, ref int UCSId, int[] Status);
        /// <summary>
        /// Sets the ID number of the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamID(int uID, int BeamNum, int BeamID);
        /// <summary>
        /// Sets the reference angle for the specified beam. This angle controls the local rotation of the beam cross section from the default orientation about the 3-axis of the beam. See Beam Local Coordinates for additional information.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamReferenceAngle1(int uID, int BeamNum, double[] Doubles);
        /// <summary>
        /// Sets the UCS used in the connection element formulation at the specified beam end. The translational and rotational stiffness components are distributed according to the 123 axis convention in the specified UCS. This attribute is only applicable to beams of connection element type.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamConnectionUCS(int uID, int BeamNum, int BeamEnd, int UCSId);
        /// <summary>
        /// Sets the taper properties for the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamTaper2(int uID, int BeamNum, int TaperAxis, int TaperType, double[] Doubles);
        /// <summary>
        /// Sets the offsets for the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamOffset2(int uID, int BeamNum, double[] Doubles);
        /// <summary>
        /// Sets the elastic support value for the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamSupport2(int uID, int BeamNum, int Direction, int CaseNum, int Status, double[] Doubles);
        /// <summary>
        /// Sets the factors for the specified beam. Each stiffness factor scales the corresponding row and column in the stiffness matrix of the beam, while the mass factor scales the entire mass matrix of the beam. Stiffness factors apply only to linear elastic beams, while the mass factor applies to all beam types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamSectionFactor7(int uID, int BeamNum, double[] Doubles);
        /// <summary>
        /// Sets the translational end release conditions at the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamTRelease3(int uID, int BeamNum, int BeamEnd, int[] Status, double[] Doubles);
        /// <summary>
        /// Sets the rotational end release conditions at the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamRRelease3(int uID, int BeamNum, int BeamEnd, int[] Status, double[] Doubles);
        /// <summary>
        /// Sets the free cable length for the specified beam. This is the unstressed cable length and is only active for beams of type cable.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamCableFreeLength1(int uID, int BeamNum, double[] Doubles);
        /// <summary>
        /// Sets the bend radius of the specified beam. This attribute is only active for beams of type pipe.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamRadius1(int uID, int BeamNum, int BeamDir, double[] Doubles);
        /// <summary>
        /// Sets the internal and external pipe pressure for the specified beam. This attribute is only active for beams of type pipe.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPipePressure2AF(int uID, int BeamNum, int CaseNum, int Status, double[] Doubles);
        /// <summary>
        /// Sets the internal and external pipe temperatures for the specified beam. This attribute is only active for beams of type pipe.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPipeTemperature2OT(int uID, int BeamNum, int CaseNum, int Status, double[] Doubles);
        /// <summary>
        /// Assigns the specified beam to a string group.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamStringGroup1(int uID, int BeamNum, int StringID);
        /// <summary>
        /// Sets the pre-load conditions for the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamPreLoad1(int uID, int BeamNum, int CaseNum, int LoadType, double[] Doubles);
        /// <summary>
        /// Sets the temperature gradient for the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamTempGradient2(int uID, int BeamNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the pre-curvature for the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamPreCurvature2(int uID, int BeamNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns point force data for the specified beam element. The force is defined in the principal axis system of the beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamPointForcePrincipal4ID(int uID, int BeamNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Assigns point force data for the specified beam element. The force is defined in the global XYZ system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamPointForceGlobal4ID(int uID, int BeamNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Assigns point moment data for the specified beam element. The moment is defined in the principal axis system of the beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamPointMomentPrincipal4ID(int uID, int BeamNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Assigns point moment data for the specified beam element. The moment is defined in the global XYZ system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamPointMomentGlobal4ID(int uID, int BeamNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Assigns distributed load data for the specified beam element. The force is defined in the principal axis system of the beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamDistributedForcePrincipal6ID(int uID, int BeamNum, int BeamDir, int CaseNum, int DLType, int ID, double[] Doubles);
        /// <summary>
        /// Assigns distributed load data for the specified beam element. The force is defined in the global XYZ system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamDistributedForceGlobal6ID(int uID, int BeamNum, int BeamDir, int ProjectFlag, int CaseNum, int DLType, int ID, double[] Doubles);
        /// <summary>
        /// Assigns distributed moment data for the specified beam element. The moment is defined in the principal axis system of the beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamDistributedMomentPrincipal6ID(int uID, int BeamNum, int BeamDir, int CaseNum, int DLType, int ID, double[] Doubles);
        /// <summary>
        /// Assigns non-structural mass for the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamNSMass10ID(int uID, int BeamNum, int CaseNum, int DLType, int ID, double[] Doubles);
        /// <summary>
        /// Sets the thermal convection coefficient and ambient temperature for the specified beam. The convection is assumed to occur uniformly over the cross section of the beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamConvection2(int uID, int BeamNum, int BeamEnd, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the convection coefficient for the specified beam end.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamConvectionTables(int uID, int BeamNum, int BeamEnd, int CaseNum, int[] Tables);
        /// <summary>
        /// Sets the thermal radiation coefficient and ambient temperature for the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamRadiation2(int uID, int BeamNum, int BeamEnd, int CaseNum, double[] Doubles);
        /// <summary>
        /// Set the tables associated with the radiation coefficient for the specified beam end.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamRadiationTables(int uID, int BeamNum, int BeamEnd, int CaseNum, int[] Tables);
        /// <summary>
        /// Sets the heat flux for the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamFlux1(int uID, int BeamNum, int BeamEnd, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the heat flux for the specified beam end.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamFluxTables(int uID, int BeamNum, int BeamEnd, int CaseNum, int[] Tables);
        /// <summary>
        /// Sets the heat source for the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamHeatSource1(int uID, int BeamNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the heat source for the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamHeatSourceTables(int uID, int BeamNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Assigns a response variable to the specified beam. Response variables are only used by the load influence solver.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamResponse(int uID, int BeamNum, int BeamEnd, int CaseNum, int[] Status);
        /// <summary>
        /// Sets the creep loading age for the specified beam. This attribute is only used when performing a creep analysis using the quasi-static or nonlinear transient dynamic solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamCreepLoadingAge1(int uID, int BeamNum, double[] Doubles);
        /// <summary>
        /// Sets the end attachment properties for the specified beam. Attachment attributes can be used to generate attachment links using the St7CreateAttachments function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamEndAttachment1(int uID, int BeamNum, int BeamEnd, int AttachType, int ConnectType, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the side attachment properties for the specified beam. Attachment attributes can be used to generate attachment links using the St7CreateAttachments function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamSideAttachment1(int uID, int BeamNum, int BeamEnd, int Direction, int AttachType, int ConnectType, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the ID number for the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamID(int uID, int BeamNum, ref int BeamID);
        /// <summary>
        /// Returns the reference angle for the specified beam. This angle controls the local rotation of the beam cross section about the 3-axis of the beam as per the beam local axis system definition. See Beam Local Coordinates for additional information.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamReferenceAngle1(int uID, int BeamNum, double[] Doubles);
        /// <summary>
        /// Returns the UCS used to define the connection element formulation for the specified beam end. The translational and rotational stiffness components are distributed according to the 123 axis convention in the specified UCS. This attribute is only applicable to beams of connection element type.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamConnectionUCS(int uID, int BeamNum, int BeamEnd, ref int UCSId);
        /// <summary>
        /// Returns the taper properties for the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamTaper2(int uID, int BeamNum, int TaperAxis, ref int TaperType, double[] Doubles);
        /// <summary>
        /// Returns the offsets assigned to the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamOffset2(int uID, int BeamNum, double[] Doubles);
        /// <summary>
        /// Returns the elastic support value assigned to the specified beam. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamSupport2(int uID, int BeamNum, int Direction, int CaseNum, ref int Status, double[] Doubles);
        /// <summary>
        /// Returns the factors for the specified beam. Each stiffness factor scales the corresponding row and column in the stiffness matrix of the beam, while the mass factor scales the entire mass matrix of the beam. Stiffness factors apply only to linear elastic beams, while the mass factor applies to all beam types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamSectionFactor7(int uID, int BeamNum, double[] Doubles);
        /// <summary>
        /// Returns the translational end release conditions assigned to the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamTRelease3(int uID, int BeamNum, int BeamEnd, int[] Status, double[] Doubles);
        /// <summary>
        /// Returns the rotational end release conditions assigned to the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamRRelease3(int uID, int BeamNum, int BeamEnd, int[] Status, double[] Doubles);
        /// <summary>
        /// Returns the free cable length for the specified beam. This is the unstressed cable length and is only active for beams of type cable.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamCableFreeLength1(int uID, int BeamNum, double[] Doubles);
        /// <summary>
        /// Returns the bend radius for the specified beam. This attribute is only active for beams of type pipe.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamRadius1(int uID, int BeamNum, ref int BeamDir, double[] Doubles);
        /// <summary>
        /// Returns the internal and external pressures applied to the specified beam. This attribute is only active for beams of type pipe. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPipePressure2AF(int uID, int BeamNum, int CaseNum, ref int Status, double[] Doubles);
        /// <summary>
        /// Returns the internal and external temperatures applied to the specified beam. This attribute of only active for beams of type pipe. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPipeTemperature2OT(int uID, int BeamNum, int CaseNum, ref int Status, double[] Doubles);
        /// <summary>
        /// Returns the ID number of the string group the specified beam is assigned to. The string group attribute is only active for truss elements and will ensure that the axial force in all members is equal.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamStringGroup1(int uID, int BeamNum, ref int StringID);
        /// <summary>
        /// Returns the pre-load assigned to the specified beam. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamPreLoad1(int uID, int BeamNum, int CaseNum, ref int LoadType, double[] Doubles);
        /// <summary>
        /// Returns the temperature gradients assigned to the specified beam. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamTempGradient2(int uID, int BeamNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the pre-curvature assigned to the specified beam. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamPreCurvature2(int uID, int BeamNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns point force data assigned to the specified beam element. The force is applied according to the principal axis system of the beam. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamPointForcePrincipal4ID(int uID, int BeamNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Returns point force data assigned to the specified beam element. The force components are defined in the global XYZ system. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamPointForceGlobal4ID(int uID, int BeamNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Returns point moment data assigned to the specified beam element. The moment is applied according to the principal axis system of the beam. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamPointMomentPrincipal4ID(int uID, int BeamNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Returns point moment data assigned to the specified beam element. The moment components are defined in the global XYZ system. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamPointMomentGlobal4ID(int uID, int BeamNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Returns distributed load data assigned to the specified beam element. The force is applied according to the principal axis system of the beam. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamDistributedForcePrincipal6ID(int uID, int BeamNum, int BeamDir, int CaseNum, int ID, ref int DLType, double[] Doubles);
        /// <summary>
        /// Returns distributed load data assigned to the specified beam element. The force components are defined in the global XYZ system. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamDistributedForceGlobal6ID(int uID, int BeamNum, int BeamDir, int CaseNum, int ID, ref int ProjectFlag, ref int DLType, double[] Doubles);
        /// <summary>
        /// Returns distributed moment data assigned to the specified beam element. The moment is applied according to the principal axis system of the beam. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamDistributedMomentPrincipal6ID(int uID, int BeamNum, int BeamDir, int CaseNum, int ID, ref int DLType, double[] Doubles);
        /// <summary>
        /// Returns non-structural mass assigned to the specified beam element. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamNSMass10ID(int uID, int BeamNum, int CaseNum, int ID, ref int DLType, double[] Doubles);
        /// <summary>
        /// Returns the thermal convection coefficient and ambient temperature assigned to the specified beam. The convection is assumed to occur uniformly over the beam cross section. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamConvection2(int uID, int BeamNum, int BeamEnd, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with convection coefficient for the specified beam end. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamConvectionTables(int uID, int BeamNum, int BeamEnd, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the thermal radiation coefficient and ambient temperature assigned to the specified beam. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamRadiation2(int uID, int BeamNum, int BeamEnd, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the radiation coefficient for the specified beam end. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamRadiationTables(int uID, int BeamNum, int BeamEnd, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the heat flux assigned to the specified beam. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamFlux1(int uID, int BeamNum, int BeamEnd, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the heat flux for the specified beam end. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamFluxTables(int uID, int BeamNum, int BeamEnd, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the heat source assigned to the specified beam. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamHeatSource1(int uID, int BeamNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the heat source for the specified beam. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamHeatSourceTables(int uID, int BeamNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the response variable assigned for the specified beam. Response variables are only used by the load influence solver. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamResponse(int uID, int BeamNum, int BeamEnd, int CaseNum, int[] Status);
        /// <summary>
        /// Returns the creep loading age for the specified beam. This attribute is only used when performing a creep analysis using the quasi-static or nonlinear transient dynamic solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamCreepLoadingAge1(int uID, int BeamNum, double[] Doubles);
        /// <summary>
        /// Returns the end attachment properties for the specified beam. This attribute can be used to generate attachment links using the St7CreateAttachments function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamEndAttachment1(int uID, int BeamNum, int BeamEnd, ref int AttachType, ref int ConnectType, ref int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the side attachment properties for the specified beam. This attribute can be used to generate attachment links using the St7CreateAttachments function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamSideAttachment1(int uID, int BeamNum, int BeamEnd, int Direction, ref int AttachType, ref int ConnectType, ref int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the ID number for the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateID(int uID, int PlateNum, int PlateID);
        /// <summary>
        /// Sets the local axis angle for the specified plate. This angle controls the rotation of the plate local xy axes about the local z axis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateXAngle1(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Sets the thickness attribute of the specified plate element, overriding the plate property thickness – see St7SetPlateThickness to set the plate property thickness.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateThickness2(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Sets the offset for the specified plate element. The offset is applied according to the plate local z axis direction and is uniform over the element surface.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateOffset1(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Sets the elastic edge support value for the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateEdgeSupport4(int uID, int PlateNum, int EdgeNum, int CaseNum, int[] Status, double[] Doubles);
        /// <summary>
        /// Sets the elastic face support value for the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateFaceSupport4(int uID, int PlateNum, int Surface, int CaseNum, int[] Status, double[] Doubles);
        /// <summary>
        /// Sets the edge release conditions for the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateEdgeRelease1(int uID, int PlateNum, int EdgeNum, int[] Status);
        /// <summary>
        /// Sets the pre-load conditions for the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlatePreLoad3(int uID, int PlateNum, int CaseNum, int LoadType, double[] Doubles);
        /// <summary>
        /// Sets the pre-curvature conditions for the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlatePreCurvature2(int uID, int PlateNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the temperature gradient for the specified plate. The temperature gradient acts according to the plate local z axis direction and is constant over the element surface. This attribute is only active for static and dynamic structural analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateTempGradient1(int uID, int PlateNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns a point force to the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlatePointForce6(int uID, int PlateNum, int CaseNum, int Position, int ID, double[] Doubles);
        /// <summary>
        /// Assigns a point moment to the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlatePointMoment6(int uID, int PlateNum, int CaseNum, int Position, int ID, double[] Doubles);
        /// <summary>
        /// Assigns a normal pressure to the specified plate edge. The pressure is applied in the plane of the element, perpendicular to the plate edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateEdgePressure1(int uID, int PlateNum, int CaseNum, int EdgeNum, double[] Doubles);
        /// <summary>
        /// Assigns a constant pressure to the specified plate edge. The pressure is defined in the global XYZ system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateEdgePressure3(int uID, int PlateNum, int CaseNum, int EdgeNum, double[] Doubles);
        /// <summary>
        /// Assigns a shear stress to the specified plate edge. The shear stress is applied tangential to the plate edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateEdgeShear1(int uID, int PlateNum, int CaseNum, int EdgeNum, double[] Doubles);
        /// <summary>
        /// Assigns a transverse shear stress to the specified plate edge. The shear stress acts normal to the plate surface at its edge, in the local +z direction.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateEdgeTransverseShear1(int uID, int PlateNum, int CaseNum, int EdgeNum, double[] Doubles);
        /// <summary>
        /// Assigns constant normal pressures to the outer +z and -z surfaces of the specified plate. The pressure is specified as a positive pressure on each face, directed inwards towards the mid-plane of the plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateNormalPressure2(int uID, int PlateNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns a constant face pressure to the specified plate surface. The pressure is defined in the global XYZ system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateGlobalPressure3S(int uID, int PlateNum, int Surface, int ProjectFlag, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns a face shear stress to the specified plate. The shear stress is applied in the plane of the element.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateShear2(int uID, int PlateNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the non-structural mass for the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateNSMass5ID(int uID, int PlateNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Sets the thermal convection coefficient and ambient temperature for the specified plate edge. This attribute is only used when performing heat transfer analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateEdgeConvection2(int uID, int PlateNum, int CaseNum, int EdgeNum, double[] Doubles);
        /// <summary>
        /// Set the tables associated with convection coefficient for the specified plate edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateEdgeConvectionTables(int uID, int PlateNum, int CaseNum, int EdgeNum, int[] Tables);
        /// <summary>
        /// Sets the thermal radiation coefficient and ambient temperature for the specified plate edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateEdgeRadiation2(int uID, int PlateNum, int CaseNum, int EdgeNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the radiation coefficient for the specified plate edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateEdgeRadiationTables(int uID, int PlateNum, int CaseNum, int EdgeNum, int[] Tables);
        /// <summary>
        /// Sets the heat flux for the specified plate edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateFlux1(int uID, int PlateNum, int CaseNum, int EdgeNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the heat flux for the specified plate edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateFluxTables(int uID, int PlateNum, int CaseNum, int EdgeNum, int[] Tables);
        /// <summary>
        /// Sets the thermal convection coefficient and ambient temperature for the specified plate surface. This attribute is only used when performing heat transfer analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateFaceConvection2(int uID, int PlateNum, int CaseNum, int Surface, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with convection coefficient for the specified plate surface.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateFaceConvectionTables(int uID, int PlateNum, int CaseNum, int Surface, int[] Tables);
        /// <summary>
        /// Sets the thermal radiation coefficient and ambient temperature for the specified plate surface.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateFaceRadiation2(int uID, int PlateNum, int CaseNum, int Surface, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the radiation coefficient for the specified plate surface.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateFaceRadiationTables(int uID, int PlateNum, int CaseNum, int Surface, int[] Tables);
        /// <summary>
        /// Sets the heat source for the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateHeatSource1(int uID, int PlateNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the heat source for the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateHeatSourceTables(int uID, int PlateNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Sets the in-situ soil stress for the specified plate. This attribute is only active for plates of property type soil.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateSoilStress2(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Sets the in-situ soil ratios for the specified plate. This attribute is only active for plates of property type soil.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateSoilRatio2(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Assigns a response variable to the specified plate. Response variables are only used by the load influence solver.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateResponse(int uID, int PlateNum, int CaseNum, int ResponseType, int UCSId, int[] Status);
        /// <summary>
        /// Sets the load patch type for the specified plate. This attribute is only active for plates of property type load patch.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateLoadPatch4(int uID, int PlateNum, int PatchType, int EdgeBits, double[] Doubles);
        /// <summary>
        /// Assigns the concrete reinforcement properties for the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateReinforcement2(int uID, int PlateNum, int LayoutID, double[] Doubles);
        /// <summary>
        /// Sets the creep loading age for the specified plate. This attribute is only active when conducting creep analysis using the quasi-static or nonlinear transient dynamic solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateCreepLoadingAge1(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Assigns an edge attachment to the specified plate edge. Attachment attributes can be used to generate attachment links using the St7CreateAttachments function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateEdgeAttachment1(int uID, int PlateNum, int EdgeNum, int Direction, int AttachType, int ConnectType, int PropNum, double[] Doubles);
        /// <summary>
        /// Assigns a face attachment to the specified plate surface. Attachment attributes can be used to generate attachment links using the St7CreateAttachments function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateFaceAttachment1(int uID, int PlateNum, int Surface, int AttachType, int ConnectType, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the factors for the specified plate. Each stiffness factor scales the corresponding row and column in the stiffness matrix of the plate, while the mass factor scales the entire mass matrix of the plate. Stiffness factors apply only to linear elastic plates, while the mass factor applies to all plate types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateSectionFactor10(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Assigns a cavity fluid layout to a surface of the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateCavityFluid(int uID, int PlateNum, int Surface, int CavityID);
        /// <summary>
        /// Returns the ID number for the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateID(int uID, int PlateNum, ref int PlateID);
        /// <summary>
        /// Returns the local axis angle for the specified plate. This angle controls the rotations of the plate local xy axes about the local z axis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateXAngle1(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Returns the thickness attribute of the specified plate, if the thickness attribute is set – see St7GetPlateThickness to get the default plate property thickness.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateThickness2(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Returns the offset for the specified plate. The offset is applied according to the plate local z axis direction and is uniform over the element surface.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateOffset1(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Returns the elastic support applied at the specified plate edge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateEdgeSupport4(int uID, int PlateNum, int EdgeNum, int CaseNum, int[] Status, double[] Doubles);
        /// <summary>
        /// Returns the elastic support applied to the specified plate surface. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateFaceSupport4(int uID, int PlateNum, int Surface, int CaseNum, int[] Status, double[] Doubles);
        /// <summary>
        /// Returns the edge release condition for the specified plate edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateEdgeRelease1(int uID, int PlateNum, int EdgeNum, int[] Status);
        /// <summary>
        /// Returns the pre-load conditions for the specified plate. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlatePreLoad3(int uID, int PlateNum, int CaseNum, ref int LoadType, double[] Doubles);
        /// <summary>
        /// Returns the pre-curvature conditions for the specified plate. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlatePreCurvature2(int uID, int PlateNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the temperature gradient for the specified plate surface. The temperature gradient acts according to the plate local z axis direction and is constant over the element surface. This attribute is only active for static and dynamic structural analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateTempGradient1(int uID, int PlateNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the point force assigned to the specified plate. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlatePointForce6(int uID, int PlateNum, int CaseNum, int Position, int ID, double[] Doubles);
        /// <summary>
        /// Returns the point moment assigned to the specified plate. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlatePointMoment6(int uID, int PlateNum, int CaseNum, int Position, int ID, double[] Doubles);
        /// <summary>
        /// Returns the normal edge pressure assigned to the specified plate edge. The pressure is applied in the plane of the element, perpendicular to the plate edge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateEdgePressure1(int uID, int PlateNum, int CaseNum, int EdgeNum, double[] Doubles);
        /// <summary>
        /// Returns the global edge pressure assigned to the specified plate edge. The pressure is constant and is defined in the global XYZ system. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateEdgePressure3(int uID, int PlateNum, int CaseNum, int EdgeNum, double[] Doubles);
        /// <summary>
        /// Returns the shear stress assigned to the specified plate edge. The shear stress is applied tangential to the plate edge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateEdgeShear1(int uID, int PlateNum, int CaseNum, int EdgeNum, double[] Doubles);
        /// <summary>
        /// Returns the transverse shear stress assigned to the specified plate edge. The shear stress acts normal to the plate surface at its edge, in the local +z direction. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateEdgeTransverseShear1(int uID, int PlateNum, int CaseNum, int EdgeNum, double[] Doubles);
        /// <summary>
        /// Returns the normal pressures applied to the outer +z and -z surfaces of the specified plate. The pressure is constant and is specified as a positive pressure on each face, directed inwards towards the mid-plane of the plate. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateNormalPressure2(int uID, int PlateNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the pressure applied to the specified plate surface. The pressure is constant and is defined in the global XYZ system. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateGlobalPressure3S(int uID, int PlateNum, int Surface, int CaseNum, ref int ProjectFlag, double[] Doubles);
        /// <summary>
        /// Returns the shear stress assigned to the specified plate surface. The shear stress is applied in the plane of the element. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateShear2(int uID, int PlateNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the non-structural mass assigned to the specified plate. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateNSMass5ID(int uID, int PlateNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Returns the edge thermal convection coefficient and ambient temperature assigned to the specified plate. This attribute is only used when performing heat transfer analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateEdgeConvection2(int uID, int PlateNum, int CaseNum, int EdgeNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with convection coefficient assigned to the specified plate edge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateEdgeConvectionTables(int uID, int PlateNum, int CaseNum, int EdgeNum, int[] Tables);
        /// <summary>
        /// Returns the thermal radiation coefficient and ambient temperature assigned to the specified plate edge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateEdgeRadiation2(int uID, int PlateNum, int CaseNum, int EdgeNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the radiation coefficient assigned to the specified plate edge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateEdgeRadiationTables(int uID, int PlateNum, int CaseNum, int EdgeNum, int[] Tables);
        /// <summary>
        /// Returns the heat flux assigned to the specified plate edge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateFlux1(int uID, int PlateNum, int CaseNum, int EdgeNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the heat flux assigned to the specified plate edge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateFluxTables(int uID, int PlateNum, int CaseNum, int EdgeNum, int[] Tables);
        /// <summary>
        /// Returns the thermal convection coefficient and ambient temperature assigned to the specified plate. This attribute is only used when performing heat transfer analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateFaceConvection2(int uID, int PlateNum, int CaseNum, int Surface, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with convection coefficient assigned to the specified plate surface. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateFaceConvectionTables(int uID, int PlateNum, int CaseNum, int Surface, int[] Tables);
        /// <summary>
        /// Returns the thermal radiation coefficient and ambient temperature assigned to the specified plate. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateFaceRadiation2(int uID, int PlateNum, int CaseNum, int Surface, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the radiation coefficient assigned to the specified plate surface. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateFaceRadiationTables(int uID, int PlateNum, int CaseNum, int Surface, int[] Tables);
        /// <summary>
        /// Returns the heat source assigned to the specified plate. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateHeatSource1(int uID, int PlateNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the heat source assigned to the specified plate. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateHeatSourceTables(int uID, int PlateNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the in-situ soil stress assigned to the specified plate. This attribute is only active for plates of property type soil.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateSoilStress2(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Returns the in-situ soil ratios assigned to the specified plate. This attribute is only active for plates of property type soil.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateSoilRatio2(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Returns the response variable assigned to the specified plate. Response variables are only used by the load influence solver. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateResponse(int uID, int PlateNum, int CaseNum, int ResponseType, ref int UCSId, int[] Status);
        /// <summary>
        /// Returns the load patch type assigned to the specified plate. This attribute is only active for plates of property type load patch.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateLoadPatch4(int uID, int PlateNum, ref int PatchType, ref int EdgeBits, double[] Doubles);
        /// <summary>
        /// Returns the concrete reinforcement conditions for the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateReinforcement2(int uID, int PlateNum, ref int LayoutID, double[] Doubles);
        /// <summary>
        /// Returns the creep loading age assigned to the specified plate. This attribute is only active when conducting creep analysis using the quasi-static or nonlinear transient dynamic solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateCreepLoadingAge1(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Returns the attachment assigned to the specified plate edge. Attachment attributes can be used to generate attachment links using the St7CreateAttachments function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateEdgeAttachment1(int uID, int PlateNum, int EdgeNum, int Direction, ref int AttachType, ref int ConnectType, ref int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the attachment assigned to the specified plate surface. Attachment attributes can be used to generate attachment links using the St7CreateAttachments function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateFaceAttachment1(int uID, int PlateNum, int Surface, ref int AttachType, ref int ConnectType, ref int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the factors for the specified plate. Each stiffness factor scales the corresponding row and column in the stiffness matrix of the plate, while the mass factor scales the entire mass matrix of the plate. Stiffness factors apply only to linear elastic plates, while the mass factor applies to all plate types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateSectionFactor10(int uID, int PlateNum, double[] Doubles);
        /// <summary>
        /// Returns the cavity fluid layout assigned to a surface of the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateCavityFluid(int uID, int PlateNum, int Surface, ref int CavityID);
        /// <summary>
        /// Sets the ID number for the specified brick.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickID(int uID, int BrickNum, int BrickID);
        /// <summary>
        /// Aligns the brick local axis system with the specified UCS. See Brick Local Coordinates for additional information.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickLocalAxes1(int uID, int BrickNum, int UCSId);
        /// <summary>
        /// Sets the elastic support conditions for the specified brick face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickSupport4(int uID, int BrickNum, int FaceNum, int CaseNum, int[] Status, double[] Doubles);
        /// <summary>
        /// Sets the pre-load conditions for the specified brick. The pre-loads are defined in the local axis system of the brick.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickPreLoad3(int uID, int BrickNum, int CaseNum, int LoadType, double[] Doubles);
        /// <summary>
        /// Assigns a point force to the specified brick face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickPointForce6(int uID, int BrickNum, int FaceNum, int CaseNum, int Position, int ID, double[] Doubles);
        /// <summary>
        /// Assigns a pressure to the specified brick face. The pressure acts into the element, normal to the plane of the face and is constant over the surface.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickNormalPressure1(int uID, int BrickNum, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns a constant pressure to the specified brick face. The pressure is defined in the global XYZ system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickGlobalPressure3(int uID, int BrickNum, int FaceNum, int ProjectFlag, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns a shear stress to the specified brick face. The shear stress acts in the plane of the face and is constant over the surface.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickShear2(int uID, int BrickNum, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns a non-structural mass to the specified brick.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickNSMass5ID(int uID, int BrickNum, int FaceNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Assigns the thermal convection coefficient and ambient temperature for the specified brick face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickConvection2(int uID, int BrickNum, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the convection coefficient assigned to the specified brick face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickConvectionTables(int uID, int BrickNum, int FaceNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Assigns the thermal radiation coefficient and ambient temperature for the specified brick face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickRadiation2(int uID, int BrickNum, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the radiation coefficient assigned to the specified brick face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickRadiationTables(int uID, int BrickNum, int FaceNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Assigns a heat flux to the specified brick face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickFlux1(int uID, int BrickNum, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the heat flux assigned to the specified brick face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickFluxTables(int uID, int BrickNum, int FaceNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Sets a heat source to the specified brick.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickHeatSource1(int uID, int BrickNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the heat source assigned to the specified brick.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickHeatSourceTables(int uID, int BrickNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Assigns the in-situ soil stress for the specified brick. This attribute is only active for bricks of property type soil.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickSoilStress2(int uID, int BrickNum, double[] Doubles);
        /// <summary>
        /// Assigns the in-situ soil ratios for the specified brick. This attribute is only active for bricks of property type soil.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickSoilRatio2(int uID, int BrickNum, double[] Doubles);
        /// <summary>
        /// Assigns a response variable to the specified brick.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickResponse(int uID, int BrickNum, int CaseNum, int UCSId, int[] Status);
        /// <summary>
        /// Assigns a creep loading age for the specified brick.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickCreepLoadingAge1(int uID, int BrickNum, double[] Doubles);
        /// <summary>
        /// Assigns an attachment to the specified brick face. Attachment attributes can be used to generate attachment links using the St7CreateAttachments function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickFaceAttachment1(int uID, int BrickNum, int FaceNum, int AttachType, int ConnectType, int PropNum, double[] Doubles);
        /// <summary>
        /// Assigns a cavity fluid layout to a face of the specified brick.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickCavityFluid(int uID, int BrickNum, int FaceNum, int CavityID);
        /// <summary>
        /// Returns the ID number assigned to the specified brick.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickID(int uID, int BrickNum, ref int BrickID);
        /// <summary>
        /// Returns the UCS used as the local axis system for the specified brick.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickLocalAxes1(int uID, int BrickNum, ref int UCSId);
        /// <summary>
        /// Returns the elastic support assigned to the specified brick face. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickSupport4(int uID, int BrickNum, int FaceNum, int CaseNum, int[] Status, double[] Doubles);
        /// <summary>
        /// Returns the pre-load conditions assigned to the specified brick. The pre-loads are defined in the local axis system of the brick. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickPreLoad3(int uID, int BrickNum, int CaseNum, ref int LoadType, double[] Doubles);
        /// <summary>
        /// Returns the point force assigned to the specified brick face. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickPointForce6(int uID, int BrickNum, int FaceNum, int CaseNum, int Position, int ID, double[] Doubles);
        /// <summary>
        /// Returns the pressure assigned to the specified brick face. The pressure acts into the element, normal to the plane of the face and is constant over the surface. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickNormalPressure1(int uID, int BrickNum, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the pressure assigned to the specified brick face. The pressure is constant and is defined in the global XYZ system. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickGlobalPressure3(int uID, int BrickNum, int FaceNum, int CaseNum, ref int ProjectFlag, double[] Doubles);
        /// <summary>
        /// Returns the shear stress assigned to the specified brick face. The shear stress acts in the plane of the face and is constant over the surface. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickShear2(int uID, int BrickNum, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the non-structural mass assigned to the specified brick. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickNSMass5ID(int uID, int BrickNum, int FaceNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Returns the thermal convection coefficient and ambient temperature assigned to the specified brick face. This attribute is only used when performing heat transfer analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickConvection2(int uID, int BrickNum, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the convection coefficient assigned to the specified brick face. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickConvectionTables(int uID, int BrickNum, int FaceNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the thermal radiation coefficient and ambient temperature assigned to the specified brick face. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickRadiation2(int uID, int BrickNum, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the radiation coefficient assigned to the specified brick face. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickRadiationTables(int uID, int BrickNum, int FaceNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the heat flux assigned to the specified brick face. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickFlux1(int uID, int BrickNum, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the heat flux assigned to the specified brick face. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickFluxTables(int uID, int BrickNum, int FaceNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the heat source assigned to the specified brick. This attribute is only used when performing heat transfer analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickHeatSource1(int uID, int BrickNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the heat source assigned to the specified brick. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickHeatSourceTables(int uID, int BrickNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the in-situ soil stress assigned to the specified brick. This attribute is only active for bricks of property type soil.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickSoilStress2(int uID, int BrickNum, double[] Doubles);
        /// <summary>
        /// Returns the in-situ soil ratios for the specified brick. This attribute is only active for bricks of property type soil.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickSoilRatio2(int uID, int BrickNum, double[] Doubles);
        /// <summary>
        /// Returns the response variable assigned to the specified brick. Response variables are only used by the load influence solver. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickResponse(int uID, int BrickNum, int CaseNum, ref int UCSId, int[] Status);
        /// <summary>
        /// Returns the creep loading age assigned to the specified brick. This attribute is only used when performing creep analysis using the quasi-static or nonlinear transient dynamic solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickCreepLoadingAge1(int uID, int BrickNum, double[] Doubles);
        /// <summary>
        /// Returns the attachment conditions assigned to the specified brick face. Attachment attributes can be used to generate attachment links using the St7CreateAttachments function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickFaceAttachment1(int uID, int BrickNum, int FaceNum, ref int AttachType, ref int ConnectType, ref int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the cavity fluid layout assigned to a face of the specified brick.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickCavityFluid(int uID, int BrickNum, int FaceNum, ref int CavityID);
        /// <summary>
        /// Assigns an ID number to the specified link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLinkID(int uID, int LinkNum, int LinkID);
        /// <summary>
        /// Returns the ID number assigned to the specified link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLinkID(int uID, int LinkNum, ref int LinkID);
        /// <summary>
        /// Sets the type for the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexType(int uID, int VertexNum, int VertexType);
        /// <summary>
        /// Assigns an ID number to the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexID(int uID, int VertexNum, int VertexID);
        /// <summary>
        /// Assigns a desired mesh size at the specified vertex. This value is used to control the local mesh resolution when using the surface automeshing tools.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexMeshSize1(int uID, int VertexNum, double[] Doubles);
        /// <summary>
        /// Assigns structural restraint conditions at the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexRestraint6(int uID, int VertexNum, int CaseNum, int UCSId, int[] Status, double[] Doubles);
        /// <summary>
        /// Assigns a point force to the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexForce3(int uID, int VertexNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns a point moment to the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexMoment3(int uID, int VertexNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns a temperature to the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexTemperature1(int uID, int VertexNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the temperature type assigned at the specified vertex. This attribute is used when performing both structural and heat transfer analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexTemperatureType1(int uID, int VertexNum, int CaseNum, int TType);
        /// <summary>
        /// Specifies the table to be associated with the temperature assigned to the specified vertex. This attribute is used when performing both structural and heat transfer analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexTemperatureTable(int uID, int VertexNum, int CaseNum, int TableID);
        /// <summary>
        /// Assigns a translational stiffness to the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexKTranslation3F(int uID, int VertexNum, int CaseNum, int UCSId, double[] Doubles);
        /// <summary>
        /// Assigns a rotational stiffness to the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexKRotation3F(int uID, int VertexNum, int CaseNum, int UCSId, double[] Doubles);
        /// <summary>
        /// Assigns a translational mass to the specified vertex as a single value.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexTMass1(int uID, int VertexNum, double Mass);
        /// <summary>
        /// Assigns a translational mass to the specified vertex as three components.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexTMass3(int uID, int VertexNum, double[] Doubles);
        /// <summary>
        /// Assigns a rotational mass to the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexRMass3(int uID, int VertexNum, int UCSId, double[] Doubles);
        /// <summary>
        /// Assigns a non-structural mass to the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexNSMass5ID(int uID, int VertexNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Assigns the translational damping coefficients for the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexKDamping3F(int uID, int VertexNum, int CaseNum, int UCSId, double[] Doubles);
        /// <summary>
        /// Assigns a heat source to the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexHeatSource1(int uID, int VertexNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the heat source assigned to the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetVertexHeatSourceTables(int uID, int VertexNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the type assigned to the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexType(int uID, int VertexNum, ref int VertexType);
        /// <summary>
        /// Returns the ID number assigned to the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexID(int uID, int VertexNum, ref int VertexID);
        /// <summary>
        /// Returns the desired mesh size assigned to the specified vertex. This value is used to control the local mesh resolution when using the surface automeshing tools.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexMeshSize1(int uID, int VertexNum, double[] Doubles);
        /// <summary>
        /// Returns the restraint conditions assigned at the specified vertex. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexRestraint6(int uID, int VertexNum, int CaseNum, ref int UCSId, int[] Status, double[] Doubles);
        /// <summary>
        /// Returns the point force assigned to the specified vertex. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexForce3(int uID, int VertexNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the point moment assigned at the specified vertex. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexMoment3(int uID, int VertexNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the temperature assigned to the specified vertex. This attribute is used when conducting both structural and heat transfer analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexTemperature1(int uID, int VertexNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the temperature type assigned to the specified vertex. This attribute is used when performing both structural and heat transfer analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexTemperatureType1(int uID, int VertexNum, int CaseNum, ref int TType);
        /// <summary>
        /// Returns the table associated with the specified vertex. This attribute is used when performing both structural and heat transfer analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexTemperatureTable(int uID, int VertexNum, int CaseNum, ref int TableID);
        /// <summary>
        /// Returns the translational stiffness assigned to the specified vertex. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexKTranslation3F(int uID, int VertexNum, int CaseNum, ref int UCSId, double[] Doubles);
        /// <summary>
        /// Returns the rotational stiffness assigned to the specified vertex. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexKRotation3F(int uID, int VertexNum, int CaseNum, ref int UCSId, double[] Doubles);
        /// <summary>
        /// Returns the translational mass assigned to the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexTMass3(int uID, int VertexNum, double[] Doubles);
        /// <summary>
        /// Returns the rotational mass assigned to the specified vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexRMass3(int uID, int VertexNum, ref int UCSId, double[] Doubles);
        /// <summary>
        /// Returns the non-structural mass assigned to the specified vertex. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexNSMass5ID(int uID, int VertexNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Returns the translational damping coefficients assigned to the specified vertex. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexKDamping3F(int uID, int VertexNum, int CaseNum, ref int UCSId, double[] Doubles);
        /// <summary>
        /// Returns the heat source assigned to the specified vertex. This attribute is only used when performing heat transfer analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexHeatSource1(int uID, int VertexNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the heat source assigned to the specified vertex. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetVertexHeatSourceTables(int uID, int VertexNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Sets the type for the specified geometry edge. This determines how its attributes are inherited by elements created by the automesher.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryEdgeType(int uID, int EdgeNum, int EdgeType);
        /// <summary>
        /// Sets the minimum number of elements to be created by the automesher along the specified geometry edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryEdgeMinDivisions(int uID, int EdgeNum, int Divisions);
        /// <summary>
        /// Sets the beam property number to be created by the automesher on the specified geometry edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryEdgeBeamProperty(int uID, int EdgeNum, int PropNum);
        /// <summary>
        /// Sets the cluster type and ID on the edge. After automeshing, all nodes along edges with the same cluster type and ID are connected according to the parameters.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryEdgeCluster(int uID, int EdgeNum, int ClusterID, int Entity, int EntityType, int OriginCode, double[] Origin);
        /// <summary>
        /// Returns the type assigned to the specified geometry edge. This determines how its attributes are inherited by elements created by the automesher.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryEdgeType(int uID, int EdgeNum, ref int EdgeType);
        /// <summary>
        /// Returns the minimum number of elements to be created by the automesher along the specified geometry edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryEdgeMinDivisions(int uID, int EdgeNum, ref int Divisions);
        /// <summary>
        /// Returns the beam property number to be created by the automesher on the specified geometry edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryEdgeBeamProperty(int uID, int EdgeNum, ref int PropNum);
        /// <summary>
        /// Returns the cluster type and ID on the edge. After automeshing, all nodes along edges with the same cluster type and ID are connected according to the parameters.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryEdgeCluster(int uID, int EdgeNum, ref int ClusterID, ref int Entity, ref int EntityType, ref int OriginCode, double[] Origin);
        /// <summary>
        /// Sets the release condition on the specified geometry coedge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryCoedgeRelease1(int uID, int CoedgeNum, int[] Status);
        /// <summary>
        /// Assigns an elastic support to the specified geometry coedge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryCoedgeSupport4(int uID, int CoedgeNum, int CaseNum, int[] Status, double[] Doubles);
        /// <summary>
        /// Assigns a normal pressure to the specified geometry coedge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryCoedgePressure1(int uID, int CoedgeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns a global pressure to the specified geometry coedge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryCoedgePressure3(int uID, int CoedgeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns a shear stress along the specified geometry coedge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryCoedgeShear1(int uID, int CoedgeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns a transverse shear stress to the specified geometry coedge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryCoedgeTransverseShear1(int uID, int CoedgeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns a thermal convection coefficient and ambient temperature to the specified geometry coedge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryCoedgeConvection2(int uID, int CoedgeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the convection coefficient assigned to the specified geometry coedge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryCoedgeConvectionTables(int uID, int CoedgeNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Assigns a thermal radiation coefficient and ambient temperature to the specified geometry coedge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryCoedgeRadiation2(int uID, int CoedgeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the radiation coefficient assigned to the specified geometry coedge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryCoedgeRadiationTables(int uID, int CoedgeNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Assigns a heat flux to the specified geometry coedge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryCoedgeFlux1(int uID, int CoedgeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the heat flux attribute assigned to the specified geometry coedge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryCoedgeFluxTables(int uID, int CoedgeNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Assigns an attachment attribute to the specified geometry coedge. Attachment attributes can be used to generate attachment links using the St7CreateAttachments function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryCoedgeAttachment1(int uID, int CoedgeNum, int Direction, int AttachType, int ConnectType, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the edge release conditions assigned to the specified geometry coedge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryCoedgeRelease1(int uID, int CoedgeNum, int[] Status);
        /// <summary>
        /// Returns the elastic edge support assigned to the specified geometry coedge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryCoedgeSupport4(int uID, int CoedgeNum, int CaseNum, int[] Status, double[] Doubles);
        /// <summary>
        /// Returns the normal edge pressure applied to the specified geometry coedge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryCoedgePressure1(int uID, int CoedgeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the global edge pressure applied to the specified geometry coedge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryCoedgePressure3(int uID, int CoedgeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the shear stress applied along the specified geometry coedge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryCoedgeShear1(int uID, int CoedgeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the transverse shear stress assigned to the specified geometry coedge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryCoedgeTransverseShear1(int uID, int CoedgeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the thermal convection coefficient and ambient temperature assigned to the specified geometry coedge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryCoedgeConvection2(int uID, int CoedgeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the convection coefficient assigned to the specified geometry coedge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryCoedgeConvectionTables(int uID, int CoedgeNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the thermal radiation coefficient and ambient temperature assigned to the specified geometry coedge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryCoedgeRadiation2(int uID, int CoedgeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the radiation coefficient assigned to the specified geometry coedge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryCoedgeRadiationTables(int uID, int CoedgeNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the heat flux assigned to the specified geometry coedge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryCoedgeFlux1(int uID, int CoedgeNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the heat flux assigned to the specified geometry coedge. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryCoedgeFluxTables(int uID, int CoedgeNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the edge attachment attribute assigned to the specified geometry coedge. Attachment attributes can be used to generate attachment links using the St7CreateAttachments function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryCoedgeAttachment1(int uID, int CoedgeNum, int Direction, ref int AttachType, ref int ConnectType, ref int PropNum, double[] Doubles);
        /// <summary>
        /// Assigns a property number to the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceProperty(int uID, int FaceNum, int PropNum);
        /// <summary>
        /// Assigns an ID number to the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceID(int uID, int FaceNum, int FaceID);
        /// <summary>
        /// Assigns a thickness to the specified geometry face. This value is constant over the surface.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceThickness2(int uID, int FaceNum, double[] Doubles);
        /// <summary>
        /// Assigns an offset to the specified geometry face. This value is constant over the surface.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceOffset1(int uID, int FaceNum, double[] Doubles);
        /// <summary>
        /// Assigns an elastic support condition to the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceSupport4(int uID, int FaceNum, int Surface, int CaseNum, int[] Status, double[] Doubles);
        /// <summary>
        /// Assigns a temperature gradient to the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceTempGradient1(int uID, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns normal pressure attributes to the specified geometry face. Two pressures are specified, corresponding to the normal pressure attributes eventually inherited by automeshed plates on their outer +z and -z surfaces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceNormalPressure2(int uID, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns components of face pressure to the specified geometry face surface in the global XYZ system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceGlobalPressure3S(int uID, int FaceNum, int Surface, int ProjectFlag, int CaseNum, double[] Doubles);
        /// <summary>
        /// Assigns a non-structural mass to the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceNSMass5ID(int uID, int FaceNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Assigns the thermal convection coefficient and ambient temperature for the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceConvection2(int uID, int FaceNum, int CaseNum, int Surface, double[] Doubles);
        /// <summary>
        /// Sets the tables associated with the convection coefficient assigned to the specified geometry face surface.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceConvectionTables(int uID, int FaceNum, int CaseNum, int Surface, int[] Tables);
        /// <summary>
        /// Assigns the thermal radiation coefficient and ambient temperature for the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceRadiation2(int uID, int FaceNum, int CaseNum, int Surface, double[] Doubles);
        /// <summary>
        /// Specifies the tables associated with the radiation coefficient assigned to the specified geometry face surface.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceRadiationTables(int uID, int FaceNum, int CaseNum, int Surface, int[] Tables);
        /// <summary>
        /// Assigns a heat source to the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceHeatSource1(int uID, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Specifies the tables associated with the heat source assigned to the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceHeatSourceTables(int uID, int FaceNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Assigns an attachment condition to the specified geometry face. Attachment attributes can be used to generate attachment links using the St7CreateAttachments function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetGeometryFaceAttachment1(int uID, int FaceNum, int Surface, int AttachType, int ConnectType, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the property assigned to the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceProperty(int uID, int FaceNum, ref int PropNum);
        /// <summary>
        /// Returns the ID number assigned to the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceID(int uID, int FaceNum, ref int FaceID);
        /// <summary>
        /// Returns the thickness assigned to the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceThickness2(int uID, int FaceNum, double[] Doubles);
        /// <summary>
        /// Returns the offset assigned to the specified geometry face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceOffset1(int uID, int FaceNum, double[] Doubles);
        /// <summary>
        /// Returns the elastic support condition assigned to the specified geometry face. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceSupport4(int uID, int FaceNum, int Surface, int CaseNum, int[] Status, double[] Doubles);
        /// <summary>
        /// Returns the temperature gradient assigned to the specified geometry face. This attribute is only used when performing structural analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceTempGradient1(int uID, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the normal pressure attributes assigned to the specified geometry face. Two pressures are returned, corresponding to the normal pressure attributes eventually inherited by automeshed plates on their outer +z and -z surfaces. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceNormalPressure2(int uID, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the components of face pressure applied to the specified geometry face surface in the global XYZ system. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceGlobalPressure3S(int uID, int FaceNum, int Surface, int CaseNum, ref int ProjectFlag, double[] Doubles);
        /// <summary>
        /// Returns the non-structural mass assigned to the specified geometry face. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceNSMass5ID(int uID, int FaceNum, int CaseNum, int ID, double[] Doubles);
        /// <summary>
        /// Returns the thermal convection coefficient and ambient temperature assigned to the specified geometry face. This attribute is only used when performing heat transfer analysis. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceConvection2(int uID, int FaceNum, int CaseNum, int Surface, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the convection coefficient assigned to the specified geometry face surface. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceConvectionTables(int uID, int FaceNum, int CaseNum, int Surface, int[] Tables);
        /// <summary>
        /// Returns the thermal radiation coefficient and ambient temperature assigned to the specified geometry face. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceRadiation2(int uID, int FaceNum, int CaseNum, int Surface, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the radiation coefficient assigned to the specified geometry face surface. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceRadiationTables(int uID, int FaceNum, int CaseNum, int Surface, int[] Tables);
        /// <summary>
        /// Returns the heat source assigned to the specified geometry face. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceHeatSource1(int uID, int FaceNum, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the tables associated with the heat source assigned to the specified geometry face. See also St7GetEntityAttributeSequenceCount and St7GetEntityAttributeSequence.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceHeatSourceTables(int uID, int FaceNum, int CaseNum, int[] Tables);
        /// <summary>
        /// Returns the attachment conditions assigned to the specified geometry face. Attachment attributes can be used to generate attachment links using the St7CreateAttachments function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGeometryFaceAttachment1(int uID, int FaceNum, int Surface, ref int AttachType, ref int ConnectType, ref int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the property for the specified element. The property does not need to be created in advance.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetElementProperty(int uID, int Entity, int EntityNum, int PropNum);
        /// <summary>
        /// Returns the property assigned to the specified element.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetElementProperty(int uID, int Entity, int EntityNum, ref int PropNum);
        /// <summary>
        /// Returns the stage-dependent property sequence assigned to the specified element for staged analysis. St7GetNumStages can be used to determine the number of stages in the model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetElementPropertySequence(int uID, int Entity, int EntityNum, int MaxProps, int[] Props);
        /// <summary>
        /// Specifies a property switch for a staged analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetElementPropertySwitch(int uID, int Entity, int EntityNum, int PropID, int Stage);
        /// <summary>
        /// Deletes the specified attribute. See Attribute Types for additional information.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteAttribute(int uID, int Entity, int EntityNum, int AttributeOrd, int[] Integers);
        /// <summary>
        /// Assigns the specified entity to a given group.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntityGroup(int uID, int Entity, int EntityNum, int GroupID);
        /// <summary>
        /// Returns the group number assigned to the specified entity.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityGroup(int uID, int Entity, int EntityNum, ref int GroupID);
        /// <summary>
        /// Returns the number of instances of the attribute on the requested entity.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityAttributeSequenceCount(int uID, int Entity, int EntityNum, int AttributeOrd, ref int NumSets);
        /// <summary>
        /// Returns details of the attribute instances on the requested entity.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityAttributeSequence(int uID, int Entity, int EntityNum, int AttributeOrd, int MaxSets, int[] Integers);
        /// <summary>
        /// Assigns a marker to an element or element face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetMarker(int uID, int Entity, int EntityNum, int FaceNum, int[] Integers);
        /// <summary>
        /// Returns information about the marker assigned to an element or element face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetMarker(int uID, int Entity, int EntityNum, int FaceNum, int[] Integers);
        /// <summary>
        /// Deletes a marker from an element or element face.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteMarker(int uID, int Entity, int EntityNum, int FaceNum);
        /// <summary>
        /// Shows a previously created marker.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ShowMarker(int uID, int Entity, int EntityNum, int FaceNum);
        /// <summary>
        /// Hides a previously created marker.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7HideMarker(int uID, int Entity, int EntityNum, int FaceNum);
        /// <summary>
        /// Returns the total number and highest property index for each of the Strand7 property types in the specified model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTotalProperties(int uID, int[] NumProperties, int[] LastProperty);
        /// <summary>
        /// Returns the property number associated with the specified property index. The property indices are stored internally and are based on a contiguous numbering system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPropertyNumByIndex(int uID, int Entity, int PropIndex, ref int PropNum);
        /// <summary>
        /// Sets the name of the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPropertyName(int uID, int Entity, int PropNum, string PropName);
        /// <summary>
        /// Returns the name of the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPropertyName(int uID, int Entity, int PropNum, StringBuilder PropName, int MaxStringLen);
        /// <summary>
        /// Sets the colour of the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPropertyColour(int uID, int Entity, int PropNum, int PropCol);
        /// <summary>
        /// Returns the colour assigned to the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPropertyColour(int uID, int Entity, int PropNum, ref int PropCol);
        /// <summary>
        /// Assigns a table to the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPropertyTable(int uID, int PropTableType, int PropNum, int TableID);
        /// <summary>
        /// Returns a table assigned to the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPropertyTable(int uID, int PropTableType, int PropNum, ref int TableID);
        /// <summary>
        /// Assigns the creep definition to the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPropertyCreepID(int uID, int Entity, int PropNum, int CreepID);
        /// <summary>
        /// Returns the creep definition of the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPropertyCreepID(int uID, int Entity, int PropNum, ref int CreepID);
        /// <summary>
        /// Sets the Rayleigh damping parameters for the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPropertyRayleighFactors(int uID, int Entity, int PropNum, int RayleighMode, double[] Doubles);
        /// <summary>
        /// Returns the Rayleigh damping parameters for the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPropertyRayleighFactors(int uID, int Entity, int PropNum, ref int RayleighMode, double[] Doubles);
        /// <summary>
        /// Sets the name of the material referenced by the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetMaterialName(int uID, int Entity, int PropNum, string MaterialName);
        /// <summary>
        /// Returns the name of the material referenced by the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetMaterialName(int uID, int Entity, int PropNum, StringBuilder MaterialName, int MaxStringLen);
        /// <summary>
        /// Sets the type of temperature/time dependence for the specified property. This setting controls the scaling used to update the material modulus values. This option is only used when an associated Factor vs Temperature/Time table is assigned to the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTimeDependentModType(int uID, int Entity, int PropNum, int ModType);
        /// <summary>
        /// Returns the type of temperature/time dependence assigned to the specified property. This setting controls the scaling used to update the material modulus values. This option is only used when an associated Factor vs Temperature/Time table is assigned to the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTimeDependentModType(int uID, int Entity, int PropNum, ref int ModType);
        /// <summary>
        /// Sets the hardening model used for the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetHardeningType(int uID, int Entity, int PropNum, int HardType);
        /// <summary>
        /// Returns the hardening model used for the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetHardeningType(int uID, int Entity, int PropNum, ref int HardType);
        /// <summary>
        /// Sets the thermal expansion table type for the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetAlphaTempType(int uID, int Entity, int PropNum, int AlphaTempType);
        /// <summary>
        /// Returns the type of thermal expansion table assigned to the specified property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetAlphaTempType(int uID, int Entity, int PropNum, ref int AlphaTempType);
        /// <summary>
        /// Deletes the specified material property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteProperty(int uID, int Entity, int PropNum);
        /// <summary>
        /// Deletes all unused properties in the specified model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteUnusedProperties(int uID, int Entity, ref int NumDeleted);
        /// <summary>
        /// Updates the display database used by the model window so that St7RedrawModel shows modifications made to entities; e.g., changes to property colours, beam section dimensions, plate thickness, etc.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7UpdateElementPropertyData(int uID, int Entity, int PropNum);
        /// <summary>
        /// Creates a new beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewBeamProperty(int uID, int PropNum, int BeamType, string PropName);
        /// <summary>
        /// Sets the section name referenced by the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamSectionName(int uID, int PropNum, string SectionName);
        /// <summary>
        /// Returns the name of the section referenced by the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamSectionName(int uID, int PropNum, StringBuilder SectionName, int MaxStringLen);
        /// <summary>
        /// Sets the beam type for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamPropertyType(int uID, int PropNum, int BeamType);
        /// <summary>
        /// Returns the beam type for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamPropertyType(int uID, int PropNum, ref int BeamType);
        /// <summary>
        /// Sets the section mirror type for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamMirrorOption(int uID, int PropNum, int MirrorType, int CompatibleTwist, double[] Doubles);
        /// <summary>
        /// Returns the section mirror type for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamMirrorOption(int uID, int PropNum, ref int MirrorType, ref int CompatibleTwist, double[] Doubles);
        /// <summary>
        /// Sets the nonlinear material type for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamNonlinearType(int uID, int PropNum, int NonlinType, int YieldType);
        /// <summary>
        /// Returns the nonlinear material type assigned to the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamNonlinearType(int uID, int PropNum, ref int NonlinType, ref int YieldType);
        /// <summary>
        /// Sets the beam section property data for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamSectionPropertyData(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the beam section property data assigned to the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamSectionPropertyData(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the beam cross section geometry data for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamSectionGeometry(int uID, int PropNum, int SectionType, double[] Doubles);
        /// <summary>
        /// Returns the beam cross section data assigned to the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamSectionGeometry(int uID, int PropNum, ref int SectionType, double[] Doubles);
        /// <summary>
        /// Sets the beam cross section geometry by specifying the dimensions of a cross section from the beam geometry library (BGL).
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamSectionGeometryBGL(int uID, int PropNum, int Shape, double[] Dimensions);
        /// <summary>
        /// Returns the values that define the geometry of a cross section from the beam geometry library (BGL) contained in the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamSectionGeometryBGL(int uID, int PropNum, ref int Shape, double[] Dimensions);
        /// <summary>
        /// Sets the discretisation values used when discretising the cross section for nonlinear beam types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamSectionNominalDiscretisation(int uID, int PropNum, int[] Integers);
        /// <summary>
        /// Returns the discretisation values used when discretising the cross section for nonlinear beam types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamSectionNominalDiscretisation(int uID, int PropNum, int[] Integers);
        /// <summary>
        /// Sets the number of circumferential divisions used when discretising circular cross sections for nonlinear beam types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamSectionCircularDiscretisation(int uID, int PropNum, int[] Integers);
        /// <summary>
        /// Returns the number of circumferential divisions used when discretising circular cross sections for nonlinear beam types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamSectionCircularDiscretisation(int uID, int PropNum, int[] Integers);
        /// <summary>
        /// Returns the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamPropertyData(int uID, int PropNum, int[] Integers, double[] SectionData, double[] MaterialData);
        /// <summary>
        /// Calculates the section properties for the standard beam cross sections defined in Beam Cross Section Shape, with the exception of bsNullSection. The function will return an error if the property does not use one of the standard section types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CalculateBeamSectionProperties(int uID, int PropNum, byte DoShear);
        /// <summary>
        /// Assigns a BXS to the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AssignBXS(int uID, int PropNum, string BXSName);
        /// <summary>
        /// Creates a Strand7 model file with a plate mesh of the discretised beam section. The function is applicable to all of the cross section definition options (standard sections, beam section library (BSL) and beam geometry library (BGL)).
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SaveBeamSectionMesh(int uID, int PropNum, string FileName);
        /// <summary>
        /// Sets the spring-damper element parameters for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSpringDamperData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the spring-damper element parameters assigned to the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSpringDamperData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the truss element parameters for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTrussData(int uID, int PropNum, int[] Integers);
        /// <summary>
        /// Returns the truss element parameters for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTrussData(int uID, int PropNum, int[] Integers);
        /// <summary>
        /// Sets the cable element parameters for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCableData(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the cable element parameters for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCableData(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the cut-off bar parameters for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCutoffBarData(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the cut-off bar parameters assigned to the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCutoffBarData(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the point contact element parameters for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPointContactData(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the point contact element parameters assigned to the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPointContactData(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the pipe element parameters for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPipeData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the pipe element parameters for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPipeData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the connection element parameters for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetConnectionData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the connection element parameters for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetConnectionData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the user defined element parameters for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetUserBeamData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the user defined element property for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetUserBeamData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Checks the quality of the section discretisation in response to unit shear forces and torque. Values closer to 1.0 are more accurate. Section quality discretisation is applicable to MNL solves.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CheckBeamSectionQuality(int uID, int PropNum, ref double Shear1, ref double Shear2, ref double Torque);
        /// <summary>
        /// Sets the thermal data required by the heat solvers for the specified Spring Damper property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSpringDamperThermalData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the thermal data set for the specified Spring Damper property that is required by the heat solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSpringDamperThermalData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the thermal data required by the heat solvers for the specified Point Contact property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPointContactThermalData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the thermal data set for the specified Point Contact property that is required by the heat solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPointContactThermalData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the thermal data required by the heat solvers for the specified user defined beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetUserBeamThermalData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the thermal data set for the specified user defined beam property that is required by the heat solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetUserBeamThermalData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the thermal data required by the heat solvers for the specified Connection property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetConnectionThermalData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the thermal data set for the specified Connection property that is required by the heat solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetConnectionThermalData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the material properties for the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamMaterialData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the material properties assigned to the specified beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamMaterialData(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the specified beam property to use either Poisson’s ratio or shear modulus for defining the material matrix.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamShearModulusMode(int uID, int PropNum, int Mode);
        /// <summary>
        /// Returns whether the specified beam property uses Poisson’s ratio or shear modulus for defining the material matrix.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamShearModulusMode(int uID, int PropNum, ref int Mode);
        /// <summary>
        /// Sets the specified beam property to use either the Fibre Stress or the Moment-Curvature option for material nonlinearity.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamNonlinearMode(int uID, int PropNum, int Mode);
        /// <summary>
        /// Returns whether the specified beam property uses the Fibre Stress or the Moment-Curvature option for material nonlinearity.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamNonlinearMode(int uID, int PropNum, ref int Mode);
        /// <summary>
        /// Creates a new plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewPlateProperty(int uID, int PropNum, int PlateType, int MaterialType, string PropName);
        /// <summary>
        /// Sets the property type for the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlatePropertyType(int uID, int PropNum, int PlateType, int MaterialType);
        /// <summary>
        /// Returns the property type for the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlatePropertyType(int uID, int PropNum, ref int PlateType, ref int MaterialType);
        /// <summary>
        /// Sets the nonlinear material type for the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateNonlinearType(int uID, int PropNum, int NonlinType, int YieldType);
        /// <summary>
        /// Returns the nonlinear material type assigned to the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateNonlinearType(int uID, int PropNum, ref int NonlinType, ref int YieldType);
        /// <summary>
        /// Sets the thickness for the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateThickness(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the thickness assigned to the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateThickness(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the number of layers used for MNL integrations through the plate thickness. The default is ten, and a maximum of 100 layers may be set.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateLayers(int uID, int PropNum, int NumLayers);
        /// <summary>
        /// Returns the number of layers used for MNL integrations through the plate thickness.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateLayers(int uID, int PropNum, ref int NumLayers);
        /// <summary>
        /// Sets the relative tolerance for load patch plate properties.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlatePatchTol(int uID, int PropNum, double PatchTol);
        /// <summary>
        /// Returns the relative tolerance for load patch plate properties.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlatePatchTol(int uID, int PropNum, ref double PatchTol);
        /// <summary>
        /// Sets the isotropic material parameters for the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateIsotropicMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the isotropic material properties for the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateIsotropicMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the orthotropic material properties for the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateOrthotropicMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the orthotropic material properties assigned to the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateOrthotropicMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the rubber material properties for the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateRubberMaterial(int uID, int PropNum, int RubberType, double[] Doubles);
        /// <summary>
        /// Returns the rubber material properties assigned to the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateRubberMaterial(int uID, int PropNum, ref int RubberType, double[] Doubles);
        /// <summary>
        /// Sets the anisotropic material properties for the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateAnisotropicMaterial(int uID, int PropNum, int MatType, double[] Doubles);
        /// <summary>
        /// Returns the anisotropic material properties assigned to the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateAnisotropicMaterial(int uID, int PropNum, ref int MatType, double[] Doubles);
        /// <summary>
        /// Sets the laminate material properties for the specified plate property. Not all parameters returned by St7GetPlateLaminateMaterial can be set, as some parameters are based on the ply properties in the layup.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateLaminateMaterial(int uID, int PropNum, int LaminateID, double[] Doubles);
        /// <summary>
        /// Returns the laminate material properties for the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateLaminateMaterial(int uID, int PropNum, ref int LaminateID, double[] Doubles);
        /// <summary>
        /// Sets the user defined material properties for the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateUserDefinedMaterial(int uID, int PropNum, int MatType, double[] Doubles);
        /// <summary>
        /// Returns the user defined material properties assigned to the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateUserDefinedMaterial(int uID, int PropNum, ref int MatType, double[] Doubles);
        /// <summary>
        /// Returns the soil type for a plate property assigned as a soil material.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateSoilType(int uID, int PropNum, ref int SoilType);
        /// <summary>
        /// Sets the material properties for the specified Mohr-Coulomb or Drucker-Prager plate property. Note that these properties correspond to the isotropic yield criterion; to set soil material properties with these yield criteria use St7SetPlateSoilMCMaterial or St7SetPlateSoilDPMaterial.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateMCDPMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the material properties assigned to the specified Mohr-Coulomb or Drucker-Prager plate property. Note that these properties correspond to the isotropic yield criterion; to get soil material properties with these yield criteria use St7GetPlateSoilMCMaterial or St7GetPlateSoilDPMaterial.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateMCDPMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the soil material properties for the specified Duncan-Chang plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateSoilDCMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the soil material properties assigned to the specified Duncan-Chang plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateSoilDCMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the soil material properties for the specified Cam-Clay plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateSoilCCMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the soil material properties assigned to the specified Cam-Clay plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateSoilCCMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Assigns the Mohr-Coulomb soil parameters for the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateSoilMCMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the Mohr-Coulomb soil parameters assigned to the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateSoilMCMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Assigns the Drucker-Prager soil parameters to the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateSoilDPMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the Drucker-Prager soil parameters assigned to the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateSoilDPMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the linear elastic soil parameters for the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateSoilLSMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the linear elastic soil parameters for the specified plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateSoilLSMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the material properties for the specified fluid plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateFluidMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the material properties assigned to the specified fluid plate property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateFluidMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the state of the Reduced Integration flag for the specified plate property. This option is only used for the 2D and Axisymmetric plate property types, applicable to quadratic elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateUseReducedInt(int uID, int PropNum, byte UseReducedInt);
        /// <summary>
        /// Returns the state of the Reduced Integration flag for the specified plate property. This option is only used for the 2D and Axisymmetric plate property types, applicable to quadratic elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateUseReducedInt(int uID, int PropNum, ref byte UseReducedInt);
        /// <summary>
        /// Sets the state of the Add Bubble Function option for the specified plate property. This option is only used for Quad4 plane stress, plane strain and axisymmetric element types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateAddBubbleFunction(int uID, int PropNum, byte AddBubbleFunction);
        /// <summary>
        /// Returns the state of the Add Bubble Function option for the specified plate property. This option is only used for Quad4 plane stress, plane strain and axisymmetric element types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateAddBubbleFunction(int uID, int PropNum, ref byte AddBubbleFunction);
        /// <summary>
        /// Creates a new brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewBrickProperty(int uID, int PropNum, int MaterialType, string PropName);
        /// <summary>
        /// Sets the material type for the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickPropertyType(int uID, int PropNum, int MaterialType);
        /// <summary>
        /// Returns the material type for the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickPropertyType(int uID, int PropNum, ref int MaterialType);
        /// <summary>
        /// Sets the nonlinear material type for the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickNonlinearType(int uID, int PropNum, int NonlinType, int YieldType);
        /// <summary>
        /// Returns the nonlinear material type assigned to the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickNonlinearType(int uID, int PropNum, ref int NonlinType, ref int YieldType);
        /// <summary>
        /// Set the isotropic material properties for the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickIsotropicMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the isotropic material properties assigned to the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickIsotropicMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the orthotropic material properties for the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickOrthotropicMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the orthotropic material properties assigned to the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickOrthotropicMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the anisotropic material properties for the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickAnisotropicMaterial(int uID, int PropNum, int MatType, double[] Doubles);
        /// <summary>
        /// Returns the anisotropic material properties assigned to the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickAnisotropicMaterial(int uID, int PropNum, ref int MatType, double[] Doubles);
        /// <summary>
        /// Sets the rubber material properties for the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickRubberMaterial(int uID, int PropNum, int RubberType, double[] Doubles);
        /// <summary>
        /// Returns the rubber material properties assigned to the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickRubberMaterial(int uID, int PropNum, ref int RubberType, double[] Doubles);
        /// <summary>
        /// Returns the soil type for a brick property assigned as a soil material.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickSoilType(int uID, int PropNum, ref int SoilType);
        /// <summary>
        /// Sets the Mohr-Coulomb and Drucker-Prager material properties for the specified brick property. Note that these properties correspond to the isotropic yield criterion; to set soil material properties with these yield criteria use St7SetBrickSoilMCMaterial or St7SetBrickSoilDPMaterial.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickMCDPMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the Mohr-Coulomb and Drucker-Prager material properties assigned to the specified brick property. Note that these properties correspond to the isotropic yield criterion; to get soil material properties with these yield criteria use St7GetBrickSoilMCMaterial or St7GetBrickSoilDPMaterial.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickMCDPMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the Duncan-Chang soil material properties for the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickSoilDCMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the Duncan-Chang soil material properties assigned to the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickSoilDCMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the Cam-Clay soil material properties for the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickSoilCCMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the Cam-Clay soil material properties assigned to the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickSoilCCMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Assigns the Mohr-Coulomb soil parameters for the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickSoilMCMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the Mohr-Coulomb soil parameters assigned to the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickSoilMCMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Assigns the Drucker-Prager soil parameters for the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickSoilDPMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the Drucker-Prager soil parameters assigned to the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickSoilDPMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Assigns the linear elastic soil parameters for the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickSoilLSMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the linear elastic soil parameters assigned to the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickSoilLSMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the fluid material properties for the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickFluidMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Returns the fluid material properties assigned to the specified brick property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickFluidMaterial(int uID, int PropNum, double[] Doubles);
        /// <summary>
        /// Sets the state of the Add Bubble Function option for the specified brick property. This option is only used for Hex8 element types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickAddBubbleFunction(int uID, int PropNum, byte AddBubbleFunction);
        /// <summary>
        /// Returns the state of the Add Bubble Function option for the specified brick property. This option is only used for Hex8 element types.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickAddBubbleFunction(int uID, int PropNum, ref byte AddBubbleFunction);
        /// <summary>
        /// Sets the number of integration (Gauss) points used by the solver along each intrinsic coordinate direction.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBrickIntegrationPoints(int uID, int PropNum, int Xi, int Eta, int Zeta);
        /// <summary>
        /// Returns the number of integration (Gauss) points used by the solver along each intrinsic coordinate direction.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickIntegrationPoints(int uID, int PropNum, ref int Xi, ref int Eta, ref int Zeta);
        /// <summary>
        /// Creates a new ply property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewPlyProperty(int uID, int PropNum, string PropName);
        /// <summary>
        /// Sets the material properties for the specified ply property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlyMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the material properties assigned to the specified ply property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlyMaterial(int uID, int PropNum, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the total number and highest ID number of the laminate stacks in the specified model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTotalLaminateStacks(int uID, ref int NumStacks, ref int LastStack);
        /// <summary>
        /// Returns the laminate number associated with the specified laminate index. The laminate indices are stored internally and are based on a contiguous numbering system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLaminateStackNumByIndex(int uID, int Index, ref int LaminateID);
        /// <summary>
        /// Creates a new laminate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewLaminate(int uID, int LaminateID, string LamName);
        /// <summary>
        /// Sets the name of the specified laminate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLaminateName(int uID, int LaminateID, string LamName);
        /// <summary>
        /// Returns the name of the specified laminate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLaminateName(int uID, int LaminateID, StringBuilder LamName, int MaxStringLen);
        /// <summary>
        /// Returns the number of plies in the specified laminate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLaminateNumPlies(int uID, int LaminateID, ref int NumPlies);
        /// <summary>
        /// Sets the ply property and ply orientation for the specified layer in a laminate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLaminatePly(int uID, int LaminateID, int Pos, int PlyPropNum, double[] Doubles);
        /// <summary>
        /// Returns the ply property and ply orientation assigned to the specified layer in a laminate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLaminatePly(int uID, int LaminateID, int Pos, ref int PlyPropNum, double[] Doubles);
        /// <summary>
        /// Adds a new ply to the specified laminate. The ply is appended to the end of the current laminate stack.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddLaminatePly(int uID, int LaminateID, int PlyPropNum, double[] Doubles);
        /// <summary>
        /// Deletes the specified ply from a laminate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteLaminatePly(int uID, int LaminateID, int Pos);
        /// <summary>
        /// Inserts a new ply at the specified position within a laminate. Note that if a laminate is at the maximum stack depth of 300 plies, inserting a new ply will cause the existing ply number 300 to be popped off the end of the stack and removed from the laminate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertLaminatePly(int uID, int LaminateID, int Pos, int PlyPropNum, double[] Doubles);
        /// <summary>
        /// Sets the user-definable data for the specified laminate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLaminateData(int uID, int LaminateID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the material matrices for the specified laminate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLaminateMatrices(int uID, int LaminateID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Deletes the specified laminate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteLaminate(int uID, int LaminateID);
        /// <summary>
        /// Deletes all unused laminates in the specified model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteUnusedLaminates(int uID, ref int NumDeleted);
        /// <summary>
        /// Returns the total number and highest ID number of the concrete reinforcement layouts in the specified model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTotalReinforcementLayouts(int uID, ref int NumLayouts, ref int LastLayout);
        /// <summary>
        /// Returns the reinforcement layout number associated with the specified layout index. The reinforcement layout indices are stored internally and are based on a contiguous numbering system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetReinforcementLayoutNumByIndex(int uID, int Index, ref int LayoutID);
        /// <summary>
        /// Creates a new concrete reinforcement layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewReinforcementLayout(int uID, int LayoutID, string LayoutName);
        /// <summary>
        /// Sets the name of the specified concrete reinforcement layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetReinforcementName(int uID, int LayoutID, string LayoutName);
        /// <summary>
        /// Returns the names assigned to the specified concrete reinforcement layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetReinforcementName(int uID, int LayoutID, StringBuilder LayoutName, int MaxStringLen);
        /// <summary>
        /// Sets the concrete reinforcement data for the specified concrete reinforcement layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetReinforcementData(int uID, int LayoutID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the concrete reinforcement data assigned to the specified concrete reinforcement layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetReinforcementData(int uID, int LayoutID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Deletes the specified concrete reinforcement layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteReinforcementLayout(int uID, int LayoutID);
        /// <summary>
        /// Returns the total number and highest ID number of the creep laws in the specified model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTotalCreepDefinitions(int uID, ref int NumSets, ref int LastSet);
        /// <summary>
        /// Returns the creep law number associated with the specified creep law index. The creep law indices are stored internally and are based on a contiguous numbering system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepDefinitionNumByIndex(int uID, int Index, ref int CreepID);
        /// <summary>
        /// Creates a new creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewCreepDefinition(int uID, int CreepID, string CreepDefinitionName);
        /// <summary>
        /// Sets the name of the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepDefinitionName(int uID, int CreepID, string CreepDefinitionName);
        /// <summary>
        /// Returns the name of the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepDefinitionName(int uID, int CreepID, StringBuilder CreepDefinitionName, int MaxStringLen);
        /// <summary>
        /// Sets the type of creep law assigned to the specified creep definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepLaw(int uID, int CreepID, int CreepLaw);
        /// <summary>
        /// Returns the type of creep law assigned to the specified creep definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepLaw(int uID, int CreepID, ref int CreepLaw);
        /// <summary>
        /// Sets the basic creep coefficients for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepBasicData(int uID, int CreepID, double[] Doubles);
        /// <summary>
        /// Returns the basic creep coefficients assigned to the specified creep definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepBasicData(int uID, int CreepID, double[] Doubles);
        /// <summary>
        /// Enables a user defined Strain vs Time table for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableCreepUserTable(int uID, int CreepID, int TableID);
        /// <summary>
        /// Disables a user defined Strain vs Time table for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableCreepUserTable(int uID, int CreepID, int TableID);
        /// <summary>
        /// Returns the enabled state of a user defined Strain vs Time table for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepUserTableState(int uID, int CreepID, int TableID, ref byte Enabled);
        /// <summary>
        /// Sets the data associated with the user defined Strain vs Time data for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepUserTableData(int uID, int CreepID, int TableID, double[] Doubles);
        /// <summary>
        /// Returns the data associated with the user defined Strain vs Time table assigned to the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepUserTableData(int uID, int CreepID, int TableID, double[] Doubles);
        /// <summary>
        /// Sets the hardening type for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepHardeningType(int uID, int CreepID, int[] Integers);
        /// <summary>
        /// Returns the hardening type assigned to the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepHardeningType(int uID, int CreepID, int[] Integers);
        /// <summary>
        /// Sets the time units for the specified metallic creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepTimeUnit(int uID, int CreepID, int[] Integers);
        /// <summary>
        /// Returns the time units for the specified metallic creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepTimeUnit(int uID, int CreepID, int[] Integers);
        /// <summary>
        /// Sets temperature dependency for the specified creep law definition, where applicable.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepTemperatureInclude(int uID, int CreepID, byte Include);
        /// <summary>
        /// Returns the temperature dependency for the specified creep law definition, where applicable.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepTemperatureInclude(int uID, int CreepID, ref byte Include);
        /// <summary>
        /// Sets the hyperbolic data for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepConcreteHyperbolicData(int uID, int CreepID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the hyperbolic data assigned to the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepConcreteHyperbolicData(int uID, int CreepID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the visco-elastic chain data for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepConcreteViscoChainData(int uID, int CreepID, int Pos, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the visco-elastic chain data assigned to the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepConcreteViscoChainData(int uID, int CreepID, int Pos, int[] Integers, double[] Doubles);
        /// <summary>
        /// Enables the user defined concrete Strain vs Time table for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableCreepConcreteUserTable(int uID, int CreepID, int TableID);
        /// <summary>
        /// Disables the user defined concrete Strain vs Time table for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableCreepConcreteUserTable(int uID, int CreepID, int TableID);
        /// <summary>
        /// Returns the enabled state of the user defined concrete Strain vs Time table for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepConcreteUserTableState(int uID, int CreepID, int TableID, ref byte Enabled);
        /// <summary>
        /// Sets the data for the user defined concrete Strain vs Time table for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepConcreteUserTableData(int uID, int CreepID, int TableID, double[] Doubles);
        /// <summary>
        /// Returns the data assigned to the user defined Strain vs Time concrete table for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepConcreteUserTableData(int uID, int CreepID, int TableID, double[] Doubles);
        /// <summary>
        /// Sets the concrete type assigned to the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepConcreteFunctionType(int uID, int CreepID, int FunctionType);
        /// <summary>
        /// Returns the concrete type assigned to the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepConcreteFunctionType(int uID, int CreepID, ref int FunctionType);
        /// <summary>
        /// Sets the default loading age for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepConcreteLoadingAge(int uID, int CreepID, double LoadingAge);
        /// <summary>
        /// Returns the default loading age assigned to the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepConcreteLoadingAge(int uID, int CreepID, ref double LoadingAge);
        /// <summary>
        /// Sets the time units for the specified concrete creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepConcreteLoadingTimeUnit(int uID, int CreepID, int[] Integers);
        /// <summary>
        /// Returns the time units for the specified concrete creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepConcreteLoadingTimeUnit(int uID, int CreepID, int[] Integers);
        /// <summary>
        /// Sets the shrinkage type assigned to the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepConcreteShrinkageType(int uID, int CreepID, int ShrinkageType);
        /// <summary>
        /// Returns the shrinkage type assigned to the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepConcreteShrinkageType(int uID, int CreepID, ref int ShrinkageType);
        /// <summary>
        /// Assigns the shrinkage formula data for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepConcreteShrinkageFormulaData(int uID, int CreepID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the shrinkage formula data assigned to the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepConcreteShrinkageFormulaData(int uID, int CreepID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Associates a table with the concrete shrinkage data for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepConcreteShrinkageTableData(int uID, int CreepID, int TableID);
        /// <summary>
        /// Returns the table associated with the concrete shrinkage data for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepConcreteShrinkageTableData(int uID, int CreepID, ref int TableID);
        /// <summary>
        /// Sets the concrete temperature data for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepConcreteTemperatureData(int uID, int CreepID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the concrete temperature data associated with the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepConcreteTemperatureData(int uID, int CreepID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the cement curing data for the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCreepConcreteCementCuringData(int uID, int CreepID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the cement curing data associated with the specified creep law definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCreepConcreteCementCuringData(int uID, int CreepID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Deletes the specified creep definition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteCreepDefinition(int uID, int CreepID);
        /// <summary>
        /// Returns the total number and highest ID number of the load path templates in the specified model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTotalLoadPathTemplates(int uID, ref int NumTemplates, ref int LastTemplate);
        /// <summary>
        /// Returns the load path template number associated with the specified template index. The load path template indices are stored internally and are based on a contiguous numbering system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadPathTemplateNumByIndex(int uID, int Index, ref int TemplateID);
        /// <summary>
        /// Creates a new load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewLoadPathTemplate(int uID, int TemplateID, string TemplateName);
        /// <summary>
        /// Sets the name of the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadPathTemplateName(int uID, int TemplateID, string TemplateName);
        /// <summary>
        /// Returns the name assigned to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadPathTemplateName(int uID, int TemplateID, StringBuilder TemplateName, int MaxStringLen);
        /// <summary>
        /// Sets the data for the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadPathTemplateParameters(int uID, int TemplateID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the data assigned to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadPathTemplateParameters(int uID, int TemplateID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Assigns the lane factor for the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadPathTemplateLaneFactor(int uID, int TemplateID, int Lane, double Factor);
        /// <summary>
        /// Returns the lane factor assigned to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadPathTemplateLaneFactor(int uID, int TemplateID, int Lane, ref double Factor);
        /// <summary>
        /// Adds a vehicle to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddLoadPathTemplateVehicle(int uID, int TemplateID);
        /// <summary>
        /// Sets the name of a vehicle in the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadPathTemplateVehicleName(int uID, int TemplateID, int Vehicle, string VehicleName);
        /// <summary>
        /// Returns the name assigned to a vehicle in the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadPathTemplateVehicleName(int uID, int TemplateID, int Vehicle, StringBuilder VehicleName, int MaxStringLen);
        /// <summary>
        /// Inserts a new vehicle at the specified position in the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertLoadPathTemplateVehicle(int uID, int TemplateID, int Vehicle);
        /// <summary>
        /// Creates a copy of a vehicle in the specified load path template and appends it to the vehicle list.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CloneLoadPathTemplateVehicle(int uID, int TemplateID, int Vehicle);
        /// <summary>
        /// Deletes a vehicle within the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteLoadPathTemplateVehicle(int uID, int TemplateID, int Vehicle);
        /// <summary>
        /// Returns the number of vehicles assigned to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumLoadPathTemplateVehicles(int uID, int TemplateID, ref int NumVehicles);
        /// <summary>
        /// Sets the data for a vehicle in the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadPathTemplateVehicleData(int uID, int TemplateID, int Vehicle, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the data assigned to a vehicle in the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadPathTemplateVehicleData(int uID, int TemplateID, int Vehicle, int[] Integers, double[] Doubles);
        /// <summary>
        /// Enables a vehicle/lane combination within the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableLoadPathTemplateVehicleLane(int uID, int TemplateID, int Vehicle, int Lane);
        /// <summary>
        /// Disables a vehicle/lane combination within the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableLoadPathTemplateVehicleLane(int uID, int TemplateID, int Vehicle, int Lane);
        /// <summary>
        /// Returns the enabled state of a vehicle/lane combination within the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadPathTemplateVehicleLaneState(int uID, int TemplateID, int Vehicle, int Lane, ref byte Enabled);
        /// <summary>
        /// Adds a point force to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddLoadPathTemplatePointForce(int uID, int TemplateID, int Vehicle);
        /// <summary>
        /// Inserts a point force within the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertLoadPathTemplatePointForce(int uID, int TemplateID, int Vehicle, int Pos);
        /// <summary>
        /// Deletes a point force from the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteLoadPathTemplatePointForce(int uID, int TemplateID, int Vehicle, int Pos);
        /// <summary>
        /// Returns the number of point forces assigned to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumLoadPathTemplatePointForces(int uID, int TemplateID, int Vehicle, ref int NumPointForces);
        /// <summary>
        /// Sets the point force data for the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadPathTemplatePointForceData(int uID, int TemplateID, int Vehicle, int Pos, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the point force data assigned to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadPathTemplatePointForceData(int uID, int TemplateID, int Vehicle, int Pos, int[] Integers, double[] Doubles);
        /// <summary>
        /// Adds a distributed force to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddLoadPathTemplateDistributedForce(int uID, int TemplateID, int Vehicle);
        /// <summary>
        /// Inserts a new distributed force to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertLoadPathTemplateDistributedForce(int uID, int TemplateID, int Vehicle, int Pos);
        /// <summary>
        /// Deletes a distributed force from the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteLoadPathTemplateDistributedForce(int uID, int TemplateID, int Vehicle, int Pos);
        /// <summary>
        /// Returns the number of distributed forces assigned to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumLoadPathTemplateDistributedForces(int uID, int TemplateID, int Vehicle, ref int NumDistributedForces);
        /// <summary>
        /// Sets the distributed force data for the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadPathTemplateDistributedForceData(int uID, int TemplateID, int Vehicle, int Pos, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the distributed force data assigned to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadPathTemplateDistributedForceData(int uID, int TemplateID, int Vehicle, int Pos, int[] Integers, double[] Doubles);
        /// <summary>
        /// Adds a new heat source to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddLoadPathTemplateHeatSource(int uID, int TemplateID, int Vehicle);
        /// <summary>
        /// Inserts a new heat source in the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertLoadPathTemplateHeatSource(int uID, int TemplateID, int Vehicle, int Pos);
        /// <summary>
        /// Deletes a heat source from the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteLoadPathTemplateHeatSource(int uID, int TemplateID, int Vehicle, int Pos);
        /// <summary>
        /// Returns the number of heat sources assigned to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumLoadPathTemplateHeatSources(int uID, int TemplateID, int Vehicle, ref int NumHeatSources);
        /// <summary>
        /// Sets the heat source data for the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadPathTemplateHeatSourceData(int uID, int TemplateID, int Vehicle, int Pos, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the heat source data assigned to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadPathTemplateHeatSourceData(int uID, int TemplateID, int Vehicle, int Pos, int[] Integers, double[] Doubles);
        /// <summary>
        /// Assigns a vehicle set to the specified vehicle in a given load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadPathTemplateVehicleSet(int uID, int TemplateID, int Vehicle, string VehicleSet);
        /// <summary>
        /// Returns the vehicle set assigned to the specified vehicle in a given load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadPathTemplateVehicleSet(int uID, int TemplateID, int Vehicle, StringBuilder VehicleSet, int MaxStringLen);
        /// <summary>
        /// Deletes the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteLoadPathTemplate(int uID, int TemplateID);
        /// <summary>
        /// Sets the centrifugal data for the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLoadPathTemplateCentrifugalData(int uID, int TemplateID, string K0, string K1, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the centrifugal data assigned to the specified load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLoadPathTemplateCentrifugalData(int uID, int TemplateID, StringBuilder K0, StringBuilder K1, int MaxStringLen, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the total number and highest ID number of the cavity fluid layouts in the specified model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTotalCavityFluidLayouts(int uID, ref int NumLayouts, ref int LastLayout);
        /// <summary>
        /// Returns the cavity fluid layout number associated with the specified layout index. The cavity fluid layout indices are stored internally and are based on a contiguous numbering system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCavityFluidLayoutNumByIndex(int uID, int Index, ref int CavityID);
        /// <summary>
        /// Creates a new cavity fluid layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewCavityFluidLayout(int uID, int CavityID, string LayoutName);
        /// <summary>
        /// Sets the name of the specified cavity fluid layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCavityFluidName(int uID, int CavityID, string LayoutName);
        /// <summary>
        /// Returns the name assigned to the specified cavity fluid layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCavityFluidName(int uID, int CavityID, StringBuilder LayoutName, int MaxStringLen);
        /// <summary>
        /// Returns the type of fluid contained in the specified cavity fluid layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCavityFluidType(int uID, int CavityID, ref int FluidType);
        /// <summary>
        /// Sets the cavity fluid type to Ideal Gas and assigns the data for the specified cavity fluid layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCavityFluidIdealGas(int uID, int CavityID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the data assigned to the specified cavity fluid layout, if it is of type Ideal Gas.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCavityFluidIdealGas(int uID, int CavityID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the cavity fluid type to Constant Bulk Modulus and assigns the data for the specified cavity fluid layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCavityFluidConstBulk(int uID, int CavityID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the data assigned to the specified cavity fluid layout, if it is of type Constant Bulk Modulus.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCavityFluidConstBulk(int uID, int CavityID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Sets the pre load data for the specified cavity fluid layout, if it is of type Constant Bulk Modulus.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCavityFluidPreLoad(int uID, int CavityID, int CaseNum, int PreType, double Value);
        /// <summary>
        /// Returns the pre load data for the specified cavity fluid layout, if it is of type Constant Bulk Modulus.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCavityFluidPreLoad(int uID, int CavityID, int CaseNum, ref int PreType, ref double Value);
        /// <summary>
        /// Deletes the specified cavity fluid layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteCavityFluidLayout(int uID, int CavityID);
        /// <summary>
        /// Returns the number of material libraries currently available.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumLibraries(int LibraryType, ref int NumLibraries);
        /// <summary>
        /// Returns the name assigned to the specified library.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLibraryName(int LibraryType, int LibraryID, StringBuilder LibraryName, int MaxStringLen);
        /// <summary>
        /// Returns the ID number assigned to the specified library.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLibraryID(int LibraryType, string LibraryName, ref int LibraryID);
        /// <summary>
        /// Returns the number of items assigned to the specified library.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumLibraryItems(int LibraryType, int LibraryID, ref int NumItems);
        /// <summary>
        /// Returns the name assigned to the specified library item.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLibraryItemName(int LibraryType, int LibraryID, int ItemID, StringBuilder ItemName, int MaxStringLen);
        /// <summary>
        /// Returns the ID number assigned to the specified library item.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLibraryItemID(int LibraryType, int LibraryID, string ItemName, ref int ItemID);
        /// <summary>
        /// Returns the values that define the geometry and properties of a cross section from the beam section library (BSL).
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLibraryBeamSectionPropertyDataBSL(int LibraryID, int ItemID, int LengthUnit, StringBuilder ItemName, int MaxStringLen, ref int ItemShape, double[] SectionData);
        /// <summary>
        /// Returns the properties of a cross section from the beam geometry library (BGL).
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLibraryBeamSectionPropertyDataBGL(int LibraryID, int ItemID, int LengthUnit, StringBuilder ItemName, int MaxStringLen, double[] Doubles);
        /// <summary>
        /// Returns the values that define the geometry of a cross section from the beam geometry library (BGL).
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLibraryBeamSectionGeometryBGL(int LibraryID, int ItemID, int LengthUnit, StringBuilder ItemName, int MaxStringLen, ref int ItemShape, double[] ItemDimensions);
        /// <summary>
        /// Assigns the specified item from the material library (.MAT) to an entity property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AssignLibraryMaterial(int uID, int Entity, int PropNum, int LibraryID, int ItemID);
        /// <summary>
        /// Assigns the specified item from the composite material library (.CML) to a ply property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AssignLibraryComposite(int uID, int PropNum, int LibraryID, int ItemID);
        /// <summary>
        /// Assigns the specified item from the beam section library (.BSL) to a beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AssignLibraryBeamSection(int uID, int PropNum, int LibraryID, int ItemID, int[] Integers);
        /// <summary>
        /// Assigns the specified item from the beam geometry library (.BGL) to a beam property.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AssignLibraryBeamSectionBGL(int uID, int PropNum, int LibraryID, int ItemID, int[] Integers);
        /// <summary>
        /// Assigns the specified item from the creep definition library (.CRL) to a creep layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AssignLibraryCreepDefinition(int uID, int CreepID, int LibraryID, int ItemID);
        /// <summary>
        /// Assigns the specified item from the load path definition library (.MLT) to a load path template.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AssignLibraryLoadPathTemplate(int uID, int TemplateID, int LibraryID, int ItemID);
        /// <summary>
        /// Assigns the specified item from the reinforcement definition library (.REO) to a reinforcement layout.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AssignLibraryReinforcementLayout(int uID, int LayoutID, int LibraryID, int ItemID);
        /// <summary>
        /// Creates a new table in the specified model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewTableType(int uID, int TableType, int TableID, int NumEntries, string TableName, double[] Doubles);
        /// <summary>
        /// Deletes the specified table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteTableType(int uID, int TableType, int TableID);
        /// <summary>
        /// Sets the name of the specified table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTableTypeName(int uID, int TableType, int TableID, string TableName);
        /// <summary>
        /// Returns the name of the specified table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTableTypeName(int uID, int TableType, int TableID, StringBuilder TableName, int MaxStringLen);
        /// <summary>
        /// Returns the ID number for a table specified by name. Where multiple names exist, the table ID with the lowest table index is returned.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTableID(int uID, string TableName, int TableType, ref int TableID);
        /// <summary>
        /// Returns the number of rows in the specified table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumTableTypeRows(int uID, int TableType, int TableID, ref int NumRows);
        /// <summary>
        /// Sets the XY data for the specified table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTableTypeData(int uID, int TableType, int TableID, int NumEntries, double[] Doubles);
        /// <summary>
        /// all uniquely identify tables by means of their TableType parameter (listed above) and TableID.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTableTypeData(int uID, int TableType, int TableID, int MaxRows, ref int NumRows, double[] Doubles);
        /// <summary>
        /// Sets the type of the specified Factor vs Frequency/Period table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFrequencyPeriodTableType(int uID, int TableID, int FreqType);
        /// <summary>
        /// Returns the type of the specified Factor vs Frequency/Period table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFrequencyPeriodTableType(int uID, int TableID, ref int FreqType);
        /// <summary>
        /// Sets the time units for the specified time based table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTimeTableUnits(int uID, int TableType, int TableID, int UnitType);
        /// <summary>
        /// Returns the time units assigned to the specified time based table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTimeTableUnits(int uID, int TableType, int TableID, ref int UnitType);
        /// <summary>
        /// Converts the time units for the specified time based table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ConvertTimeTableUnits(int uID, int TableType, int TableID, int UnitType);
        /// <summary>
        /// Sets the units for the specified Factor vs Frequency/Period table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFrequencyPeriodTableUnits(int uID, int TableID, int UnitType);
        /// <summary>
        /// Returns the units for the specified Factor vs Frequency/Period table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFrequencyPeriodTableUnits(int uID, int TableID, ref int UnitType);
        /// <summary>
        /// Sets the units assigned to the specified acceleration vs time table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetAccVsTimeTableUnits(int uID, int TableID, int UnitType);
        /// <summary>
        /// Returns the units assigned to the specified acceleration vs time table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetAccVsTimeTableUnits(int uID, int TableID, ref int UnitType);
        /// <summary>
        /// Sets the rotation units for the specified Moment vs Rotation table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetMomentRotationTableUnits(int uID, int TableID, int UnitType);
        /// <summary>
        /// Returns the rotation units assigned to the specified Moment vs Rotation table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetMomentRotationTableUnits(int uID, int TableID, ref int UnitType);
        /// <summary>
        /// Returns the number of tables of the specified type.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumTables(int uID, int TableType, ref int NumTables, ref int MaxTableNum);
        /// <summary>
        /// Returns the name and ID number of the specified table. The maximum table index is returned by the St7GetNumTables function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTableInfoByIndex(int uID, int TableType, int Index, ref int TableID, StringBuilder TableName, int MaxStringLen);
        /// <summary>
        /// Enables the specified load case and freedom case combination such that it is included in linear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableLSALoadCase(int uID, int LoadCaseNum, int FreedomCaseNum);
        /// <summary>
        /// Disables the specified load case and freedom case combination such that it is not included in linear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableLSALoadCase(int uID, int LoadCaseNum, int FreedomCaseNum);
        /// <summary>
        /// Returns the enabled state of the specified load case and freedom case combination for linear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLSALoadCaseState(int uID, int LoadCaseNum, int FreedomCaseNum, ref byte Enabled);
        /// <summary>
        /// Sets the PCG solver to use the specified result file as initial conditions. The result file name is specified using St7SetInitialPCGFile.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableInitialPCGFile(int uID, int SolverType);
        /// <summary>
        /// Sets the PCG solver to use the default initial conditions.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableInitialPCGFile(int uID, int SolverType);
        /// <summary>
        /// Returns the enabled state assigned for the PCG initial conditions.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInitialPCGFileState(int uID, int SolverType, ref byte Enabled);
        /// <summary>
        /// Assigns the initial conditions file used by the PCG solver.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetInitialPCGFile(int uID, int SolverType, string FileName);
        /// <summary>
        /// Returns the initial conditions file assigned to the PCG solver.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInitialPCGFile(int uID, int SolverType, StringBuilder FileName, int MaxStringLen);
        /// <summary>
        /// Assigns the initial conditions file to be used for linear buckling analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLBAInitial(int uID, string FileName, int VariableCaseNum, int FixedCaseNum);
        /// <summary>
        /// Returns the initial conditions file assigned for linear buckling analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLBAInitial(int uID, StringBuilder FileName, ref int VariableCaseNum, ref int FixedCaseNum, int MaxStringLen);
        /// <summary>
        /// Sets the number of modes to be calculated in linear buckling analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLBANumModes(int uID, int NumModes);
        /// <summary>
        /// Returns the number of modes to be calculated in linear buckling analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLBANumModes(int uID, ref int NumModes);
        /// <summary>
        /// Sets the load factor shift to be used in linear buckling analysis. The closest modes found, both above and below the shift value, will be calculated.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLBAShift(int uID, double Shift);
        /// <summary>
        /// Returns the load factor shift to be used in linear buckling analysis. The closest modes found, both above and below the shift value, will be calculated.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLBAShift(int uID, ref double Shift);
        /// <summary>
        /// Enables the specified load and freedom case combination such that it is included in load influence analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableLIALoadCase(int uID, int LoadCaseNum, int FreedomCaseNum);
        /// <summary>
        /// Disables the specified load and freedom case combination such that it is not included in load influence analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableLIALoadCase(int uID, int LoadCaseNum, int FreedomCaseNum);
        /// <summary>
        /// Returns the enabled state assigned to the specified load and freedom case combination for load influence analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLIALoadCaseState(int uID, int LoadCaseNum, int FreedomCaseNum, ref byte Enabled);
        /// <summary>
        /// Sets the state of the staged analysis option for nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNLAStagedAnalysis(int uID, byte StagedAnalysis);
        /// <summary>
        /// Returns the state of the staged analysis option for nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNLAStagedAnalysis(int uID, ref byte StagedAnalysis);
        /// <summary>
        /// Activates the specified stage such that it is included in nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableNLAStage(int uID, int Stage);
        /// <summary>
        /// Deactivates the specified stage such that it is not included in nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableNLAStage(int uID, int Stage);
        /// <summary>
        /// Returns the enabled state assigned to the specified stage for nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNLAStageState(int uID, int Stage, ref byte Enabled);
        /// <summary>
        /// Adds a new blank increment to the nonlinear static analysis load table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddNLAIncrement(int uID, int Stage, string IncName);
        /// <summary>
        /// Returns the name of the specified increment in the nonlinear static analysis load table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNLAIncrementName(int uID, int Stage, int Increment, StringBuilder IncName, int MaxStringLen);
        /// <summary>
        /// Inserts a new blank increment at the specified position in the nonlinear static analysis load table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertNLAIncrement(int uID, int Stage, int Increment, string IncName);
        /// <summary>
        /// Deletes the specified increment from the nonlinear static analysis load table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteNLAIncrement(int uID, int Stage, int Increment);
        /// <summary>
        /// Returns the total number of increments assigned in the nonlinear static analysis load table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumNLAIncrements(int uID, int Stage, ref int NumIncrements);
        /// <summary>
        /// Assigns the load case factors for the specified increment in the nonlinear static analysis load table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNLALoadIncrementFactor(int uID, int Stage, int Increment, int CaseNum, double Factor);
        /// <summary>
        /// Returns the load case factors assigned for the specified increment in the nonlinear static analysis load table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNLALoadIncrementFactor(int uID, int Stage, int Increment, int CaseNum, ref double Factor);
        /// <summary>
        /// Assigns the freedom case factors for the specified increment in the nonlinear static analysis load table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNLAFreedomIncrementFactor(int uID, int Stage, int Increment, int CaseNum, double Factor);
        /// <summary>
        /// Returns the freedom case factors assigned for the specified increment in the nonlinear static analysis load table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNLAFreedomIncrementFactor(int uID, int Stage, int Increment, int CaseNum, ref double Factor);
        /// <summary>
        /// Enables the specified load case such that it is included in nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableNLALoadCase(int uID, int Stage, int CaseNum);
        /// <summary>
        /// Disables the specified load case such that it is not included in nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableNLALoadCase(int uID, int Stage, int CaseNum);
        /// <summary>
        /// Enables the specified freedom case such that it is included in nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableNLAFreedomCase(int uID, int Stage, int CaseNum);
        /// <summary>
        /// Disables the specified freedom case such that it is not included in nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableNLAFreedomCase(int uID, int Stage, int CaseNum);
        /// <summary>
        /// Returns the enabled state assigned to the specified load case for nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNLALoadCaseState(int uID, int Stage, int CaseNum, ref byte Enabled);
        /// <summary>
        /// Returns the enabled state of the specified freedom case for nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNLAFreedomCaseState(int uID, int Stage, int CaseNum, ref byte Enabled);
        /// <summary>
        /// Assigns the initial conditions file to be used for nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNLAInitial(int uID, string FileName, int CaseNum);
        /// <summary>
        /// Returns the initial conditions file assigned for nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNLAInitial(int uID, StringBuilder FileName, ref int CaseNum, int MaxStringLen);
        /// <summary>
        /// Assigns the pseudo time to the specified increment for nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNLAPseudoTime(int uID, int Stage, int Increment, double Time);
        /// <summary>
        /// Returns the pseudo time in the specified increment for nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNLAPseudoTime(int uID, int Stage, int Increment, ref double Time);
        /// <summary>
        /// Enables pseudo time for nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableNLAPseudoTime(int uID, int Stage);
        /// <summary>
        /// Disables pseudo time for nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableNLAPseudoTime(int uID, int Stage);
        /// <summary>
        /// Returns the enabled state of pseudo time for nonlinear static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNLAPseudoTimeState(int uID, int Stage, ref byte Enabled);
        /// <summary>
        /// Sets the RESET MODEL flag for the specified increment in the nonlinear static analysis load table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNLAResetAtIncrement(int uID, int Increment, byte Reset);
        /// <summary>
        /// Returns the RESET MODEL flag for the specified increment in the nonlinear static analysis load table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNLAResetAtIncrement(int uID, int Increment, ref byte Reset);
        /// <summary>
        /// Assigns the initial conditions file to be used for quasi-static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetQSAInitial(int uID, string FileName, int CaseNum);
        /// <summary>
        /// Returns the initial conditions file assigned for quasi-static analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetQSAInitial(int uID, StringBuilder FileName, ref int CaseNum, int MaxStringLen);
        /// <summary>
        /// Assigns the initial conditions file to be used for natural frequency analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNFAInitial(int uID, string FileName, int CaseNum);
        /// <summary>
        /// Returns the initial conditions file assigned for natural frequency analysis. If an initial conditions file is specified, stress stiffening/softening effects will be included in the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNFAInitial(int uID, StringBuilder FileName, ref int CaseNum, int MaxStringLen);
        /// <summary>
        /// Sets the number of modes to be calculated in natural frequency analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNFANumModes(int uID, int NumModes);
        /// <summary>
        /// Returns the number of modes to be calculated in natural frequency analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNFANumModes(int uID, ref int NumModes);
        /// <summary>
        /// Sets the frequency shift to be used in natural frequency analysis. The closest modes found, both above and below the shift value, will be calculated.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNFAShift(int uID, double Shift);
        /// <summary>
        /// Returns the frequency shift assigned to the natural frequency analysis. The closest modes found, both above and below the shift value, will be calculated.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNFAShift(int uID, ref double Shift);
        /// <summary>
        /// Sets the state of the mass participation option for natural frequency analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNFAModeParticipationCalculate(int uID, byte Calculate);
        /// <summary>
        /// Returns the state of the mass participation option for natural frequency analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNFAModeParticipationCalculate(int uID, ref byte Calculate);
        /// <summary>
        /// Assigns the direction vectors and origin, used when calculating mass participation factors for natural frequency analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNFAModeParticipationVectors(int uID, double[] Doubles);
        /// <summary>
        /// Returns the direction vectors and origin assigned for natural frequency analysis, used when calculating mass participation factors.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNFAModeParticipationVectors(int uID, double[] Doubles);
        /// <summary>
        /// Assigns the frequency range for harmonic response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetHRARange(int uID, int NumSteps, double F1, double F2, byte AutoInsert);
        /// <summary>
        /// Returns the frequency range assigned for harmonic response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetHRARange(int uID, ref int NumSteps, ref double F1, ref double F2, ref byte AutoInsert);
        /// <summary>
        /// Assigns the base excitation vector for harmonic response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetHRABaseVector(int uID, double[] Doubles);
        /// <summary>
        /// Returns the base excitation vector for harmonic response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetHRABaseVector(int uID, double[] Doubles);
        /// <summary>
        /// Assigns a harmonic load case factor, phase angle and frequency to the specified load case. This option is only used when the load type is set to Applied Load.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetHRALoadCase(int uID, int CaseNum, int TableID, double[] Doubles);
        /// <summary>
        /// Returns the harmonic load case factor, phase angle and frequency assigned to the specified load case. This option is only used when the load type is set to Applied Load.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetHRALoadCase(int uID, int CaseNum, ref int TableID, double[] Doubles);
        /// <summary>
        /// Assigns the load type for harmonic response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetHRALoadType(int uID, int LType);
        /// <summary>
        /// Returns the load type for harmonic response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetHRALoadType(int uID, ref int LType);
        /// <summary>
        /// Sets the harmonic mode for harmonic response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetHRAMode(int uID, int MType);
        /// <summary>
        /// Returns the harmonic mode for harmonic response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetHRAMode(int uID, ref int MType);
        /// <summary>
        /// Enables the specified load case such that it is included when the load type is set to Applied Load.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableHRALoadCase(int uID, int CaseNum);
        /// <summary>
        /// Disables the specified load case such that it is excluded when the load type is set to Applied Load.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableHRALoadCase(int uID, int CaseNum);
        /// <summary>
        /// Sets the status of the Load Excitation setting for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSRALoadExcitation(int uID, byte Load);
        /// <summary>
        /// Returns the status of the Load Excitation setting for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSRALoadExcitation(int uID, ref byte Load);
        /// <summary>
        /// Adds a new blank Load Excitation case to the Spectral Response analysis load excitation table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddSRALoadCase(int uID, string CaseName);
        /// <summary>
        /// Inserts a new blank Load Excitation case at the specified position within the Spectral Response analysis load excitation table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertSRALoadCase(int uID, int SRACase, string CaseName);
        /// <summary>
        /// Deletes the specified Load Excitation case from the Spectral Response analysis load excitation table.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteSRALoadCase(int uID, int SRACase);
        /// <summary>
        /// Returns the number of Load Excitation cases assigned for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumSRALoadCases(int uID, ref int NumCases);
        /// <summary>
        /// Specifies the table associated with the specified Spectral Response analysis Load Excitation case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSRALoadCaseTable(int uID, int SRACase, int CaseNum, int TableID);
        /// <summary>
        /// Returns the table associated with the specified Spectral Response analysis Load Excitation case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSRALoadCaseTable(int uID, int SRACase, int CaseNum, ref int TableID);
        /// <summary>
        /// Sets the name of the specified Spectral Response analysis Load Excitation case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSRALoadCaseName(int uID, int SRACase, string CaseName);
        /// <summary>
        /// Returns the name of the specified Spectral Response analysis Load Excitation case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSRALoadCaseName(int uID, int SRACase, StringBuilder CaseName, int MaxStringLen);
        /// <summary>
        /// Enables the specified Load Excitation case for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableSRALoadCase(int uID, int SRACase);
        /// <summary>
        /// Disables the specified Load Excitation case for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableSRALoadCase(int uID, int SRACase);
        /// <summary>
        /// Returns the enabled state of the specified Load Excitation case for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSRALoadCaseState(int uID, int SRACase, ref byte Enabled);
        /// <summary>
        /// Sets the status of the Base Excitation setting for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSRABaseExcitation(int uID, byte Base);
        /// <summary>
        /// Returns the status of the Base Excitation setting for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSRABaseExcitation(int uID, ref byte Base);
        /// <summary>
        /// Adds a new Base Excitation Spectral Response analysis case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddSRABaseCase(int uID, string CaseName);
        /// <summary>
        /// Inserts a new Base Excitation Spectral Response analysis case at the specified position.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertSRABaseCase(int uID, int SRACase, string CaseName);
        /// <summary>
        /// Deletes the specified Base Excitation Spectral Response analysis case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteSRABaseCase(int uID, int SRACase);
        /// <summary>
        /// Returns the number of Base Excitation cases assigned for Spectral Response Analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumSRABaseCases(int uID, ref int NumCases);
        /// <summary>
        /// Sets the table associated with the specified Spectral Response analysis Base Excitation case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSRABaseCaseTable(int uID, int SRACase, int TableID);
        /// <summary>
        /// Returns the table associated with the specified Spectral Response analysis Base Excitation case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSRABaseCaseTable(int uID, int SRACase, ref int TableID);
        /// <summary>
        /// Sets the modal load type for the specified Spectral Response analysis Base Excitation case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSRABaseCaseType(int uID, int SRACase, int VectType);
        /// <summary>
        /// Returns the modal load type for the specified Spectral Response analysis Base Excitation case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSRABaseCaseType(int uID, int SRACase, ref int VectType);
        /// <summary>
        /// Assigns the components of the direction vector for the specified Spectral Response analysis Base Excitation case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSRABaseCaseFactors(int uID, int SRACase, double[] Doubles);
        /// <summary>
        /// Returns the components of the direction vector assigned to the specified Spectral Response analysis Base Excitation case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSRABaseCaseFactors(int uID, int SRACase, double[] Doubles);
        /// <summary>
        /// Sets the name of the specified Spectral Response analysis Base Excitation case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSRABaseCaseName(int uID, int SRACase, string CaseName);
        /// <summary>
        /// Returns the name of the specified Spectral Response analysis Base Excitation case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSRABaseCaseName(int uID, int SRACase, StringBuilder CaseName, int MaxStringLen);
        /// <summary>
        /// Enables the specified Base Excitation case for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableSRABaseCase(int uID, int SRACase);
        /// <summary>
        /// Disables the specified Base Excitation case for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableSRABaseCase(int uID, int SRACase);
        /// <summary>
        /// Returns the enabled state of the specified Base Excitation case for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSRABaseCaseState(int uID, int SRACase, ref byte Enabled);
        [DllImport("St7API.dll")]
        public static extern int St7SetSRAResultModal(int uID, byte Modal);
        [DllImport("St7API.dll")]
        public static extern int St7GetSRAResultModal(int uID, ref byte Modal);
        /// <summary>
        /// Sets the state of the SRSS result option for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSRAResultSRSS(int uID, byte SRSS);
        /// <summary>
        /// Returns the state of the SRSS result option for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSRAResultSRSS(int uID, ref byte SRSS);
        /// <summary>
        /// Sets the state of the CQC result option for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSRAResultCQC(int uID, byte CQC);
        /// <summary>
        /// Returns the state of the CQC result option for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSRAResultCQC(int uID, ref byte CQC);
        /// <summary>
        /// Assigns the spectrum type used for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSRAType(int uID, int SpectrumType);
        /// <summary>
        /// Returns the spectrum type used for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSRAType(int uID, ref int SpectrumType);
        /// <summary>
        /// Sets the results sign option for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSRAResultsSign(int uID, int ResultsSign);
        /// <summary>
        /// Returns the results sign option for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSRAResultsSign(int uID, ref int ResultsSign);
        /// <summary>
        /// Assigns the initial conditions file to be used for linear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLTAInitial(int uID, string FileName, int CaseNum);
        /// <summary>
        /// Returns the initial conditions file assigned for linear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLTAInitial(int uID, StringBuilder FileName, ref int CaseNum, int MaxStringLen);
        /// <summary>
        /// Sets the integration method used for linear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLTAMethod(int uID, int Method);
        /// <summary>
        /// Returns the integration method assigned for linear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLTAMethod(int uID, ref int Method);
        /// <summary>
        /// Sets the solution type option for linear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLTASolutionType(int uID, int SolutionType);
        /// <summary>
        /// Returns the solution type option assigned for linear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLTASolutionType(int uID, ref int SolutionType);
        /// <summary>
        /// Assigns the initial conditions file to be used for nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNTAInitial(int uID, string FileName, int CaseNum);
        /// <summary>
        /// Returns the initial conditions file assigned for nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNTAInitial(int uID, StringBuilder FileName, ref int CaseNum, int MaxStringLen);
        /// <summary>
        /// Assigns the initial conditions file to be used for transient heat analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTHAInitial(int uID, string FileName, int CaseNum);
        /// <summary>
        /// Returns the initial conditions file assigned for transient heat analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTHAInitial(int uID, StringBuilder FileName, ref int CaseNum, int MaxStringLen);
        /// <summary>
        /// Assigns the load case that specifies the nodal temperature distribution for transient heat analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTHATemperatureLoadCase(int uID, int CaseNum);
        /// <summary>
        /// Returns the load case that specifies the nodal temperature distribution for transient heat analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTHATemperatureLoadCase(int uID, ref int CaseNum);
        /// <summary>
        /// Assigns the state of the override flag to be used with the transient heat analysis initial conditions file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTHAInitialAttributeOverride(int uID, byte Active);
        /// <summary>
        /// Returns the state of the override flag to be used with the transient heat analysis initial conditions file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTHAInitialAttributeOverride(int uID, ref byte Active);
        /// <summary>
        /// Assigns the modal superposition file to be used for harmonic response, spectral response and linear transient dynamic analysis with mode superposition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetModalSuperpositionFile(int uID, string FileName);
        /// <summary>
        /// Returns the modal superposition file assigned for harmonic response, spectral response and linear transient dynamic analysis with mode superposition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetModalSuperpositionFile(int uID, StringBuilder FileName, int MaxStringLen);
        /// <summary>
        /// Returns the number of modes found in the modal superposition file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumModesInModalFile(int uID, ref int NumModes);
        /// <summary>
        /// Returns the number of modes found in a natural frequency result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumModesInNFAFile(int uID, string FileName, ref int NumModes);
        /// <summary>
        /// Enables the specified mode in the modal superposition file for harmonic response, spectral response and linear transient dynamic analysis with mode superposition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableMode(int uID, int ModeNum);
        /// <summary>
        /// Disables the specified mode in the modal superposition file for harmonic response, spectral response and linear transient dynamic analysis with mode superposition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableMode(int uID, int ModeNum);
        /// <summary>
        /// Returns the enabled state of the specified mode in the modal superposition file for harmonic response, spectral response and linear transient dynamic analysis with mode superposition.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetModeState(int uID, int ModeNum, ref byte Enabled);
        /// <summary>
        /// Sets the modal damping ratio for the specified mode in the modal superposition file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetModeDampingRatio(int uID, int ModeNum, double Ratio);
        /// <summary>
        /// Returns the modal damping ratio assigned for the specified mode in the modal superposition file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetModeDampingRatio(int uID, int ModeNum, ref double Ratio);
        /// <summary>
        /// Sets the type of initial conditions to be used for linear and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientInitialConditionsType(int uID, int InitialType);
        /// <summary>
        /// Returns the type of initial conditions assigned for linear and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientInitialConditionsType(int uID, ref int InitialType);
        /// <summary>
        /// Sets the initial acceleration and velocity vectors used for linear and nonlinear transient dynamic analysis. A uniform acceleration and velocity is applied to all nodes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientInitialConditionsVectors(int uID, double[] Doubles);
        /// <summary>
        /// Returns the initial acceleration and velocity vectors assigned for linear and nonlinear transient dynamic analysis. A uniform acceleration and velocity is applied to all nodes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientInitialConditionsVectors(int uID, double[] Doubles);
        /// <summary>
        /// Sets the load case that specifies the initial nodal velocity for linear and nonlinear transient dynamic analysis. The initial velocity components are defined by the Initial Velocity nodal attribute.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientInitialConditionsNodalVelocity(int uID, int CaseNum);
        /// <summary>
        /// Returns the load case that specifies the initial velocity for linear and nonlinear transient dynamic analysis. The initial velocity components are defined by the Initial Velocity nodal attribute.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientInitialConditionsNodalVelocity(int uID, ref int CaseNum);
        /// <summary>
        /// Sets the type of base excitation for linear and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientBaseExcitation(int uID, int BaseType);
        /// <summary>
        /// Returns the type of base excitation for linear and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientBaseExcitation(int uID, ref int BaseType);
        /// <summary>
        /// Sets the base excitation vector for linear and nonlinear transient dynamic analysis. The values in the base excitation tables (acceleration, velocity and displacement), are multiplied by the respective base vector component.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientBaseVector(int uID, double[] Doubles);
        /// <summary>
        /// Returns the base excitation vector assigned for linear and nonlinear transient dynamic analysis. The values in the base excitation tables (acceleration, velocity and displacement), are multiplied by the respective base vector component.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientBaseVector(int uID, double[] Doubles);
        /// <summary>
        /// Sets the initial base acceleration for linear and nonlinear transient dynamic analysis. All restrained nodes in the specified model will initially have this acceleration.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientBaseAcceleration(int uID, double[] Doubles);
        /// <summary>
        /// Returns the initial base acceleration assigned for linear and nonlinear transient dynamic analysis. All restrained nodes in the specified model will initially have this acceleration.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientBaseAcceleration(int uID, double[] Doubles);
        /// <summary>
        /// Sets the initial base velocity for linear and nonlinear transient dynamic analysis. All restrained nodes in the specified model will initially have this velocity.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientBaseVelocity(int uID, double[] Doubles);
        /// <summary>
        /// Returns the initial base velocity assigned for linear and nonlinear transient dynamic analysis. All restrained nodes in the specified model will initially have this velocity.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientBaseVelocity(int uID, double[] Doubles);
        /// <summary>
        /// Sets the initial base displacement for linear and nonlinear transient dynamic analysis. All restrained nodes in the specified model will initially have this displacement.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientBaseDisplacement(int uID, double[] Doubles);
        /// <summary>
        /// Returns the initial base displacement assigned for linear and nonlinear transient dynamic analysis. All restrained nodes in the specified model will initially have this displacement.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientBaseDisplacement(int uID, double[] Doubles);
        /// <summary>
        /// Specifies the time tables to be associated with the base excitation components for linear and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientBaseTables(int uID, int BaseType, int[] Integers);
        /// <summary>
        /// Returns the time tables associated with the base excitation components for linear and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientBaseTables(int uID, int BaseType, int[] Integers);
        /// <summary>
        /// Adds a new node history case for linear and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddTransientNodeHistoryCase(int uID, int NodeNum);
        /// <summary>
        /// Inserts a new node history case for linear and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertTransientNodeHistoryCase(int uID, int Pos, int NodeNum);
        /// <summary>
        /// Deletes the specified node history case for linear and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteTransientNodeHistoryCase(int uID, int Pos);
        /// <summary>
        /// Returns the number of node history cases assigned for linear and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumTransientNodeHistoryCases(int uID, ref int NumCases);
        /// <summary>
        /// Assigns the settings for the specified node history case for linear and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientNodeHistoryCaseData(int uID, int Pos, int NodeNum, byte[] Logicals);
        /// <summary>
        /// Returns the settings assigned for the specified node history case for linear and nonlinear transient Dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientNodeHistoryCaseData(int uID, int Pos, ref int NodeNum, byte[] Logicals);
        /// <summary>
        /// Sets the type of temperature data to be used for quasi-static and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientTemperatureInputType(int uID, int InputType);
        /// <summary>
        /// Returns the type of temperature data to be used for quasi-static and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientTemperatureInputType(int uID, ref int InputType);
        /// <summary>
        /// Assigns the temperature file to be used for quasi-static and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientHeatFile(int uID, string FileName, double RefTemp);
        /// <summary>
        /// Returns the temperature file assigned for quasi-static and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientHeatFile(int uID, StringBuilder FileName, int MaxStringLen, ref double RefTemp);
        /// <summary>
        /// Assigns a Factor vs Position table that factors loads on the basis of a selected spatial Degree of Freedom (DoF) for the specified load case for quasi-static and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientLoadPositionTable(int uID, int CaseNum, int TableID, int UCSId, int Axis);
        /// <summary>
        /// Returns the Factor vs Position table that factors loads on the basis of a selected spatial Degree of Freedom (DoF) for the specified load case for quasi-static and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientLoadPositionTable(int uID, int CaseNum, ref int TableID, ref int UCSId, ref int Axis);
        /// <summary>
        /// Assigns a Factor vs Position table that factors restraint conditions on the basis of a selected spatial Degree of Freedom (DoF) for the specified freedom case for quasi-static and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientFreedomPositionTable(int uID, int CaseNum, int TableID, int UCSId, int Axis);
        /// <summary>
        /// Returns the Factor vs Position table that factors restraint conditions on the basis of a selected spatial Degree of Freedom (DoF) for the specified freedom case for quasi-static and nonlinear transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientFreedomPositionTable(int uID, int CaseNum, ref int TableID, ref int UCSId, ref int Axis);
        /// <summary>
        /// Returns the temperature used as the initial temperature in a transient heat result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInitialTemperatureInTHAFile(int uID, string FileName, ref double InitialTemp);
        /// <summary>
        /// Enables the specified load case for quasi-static and transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableTransientLoadCase(int uID, int CaseNum);
        /// <summary>
        /// Disables the specified load case for quasi-static and transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableTransientLoadCase(int uID, int CaseNum);
        /// <summary>
        /// Enables the specified freedom case for quasi-static and transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableTransientFreedomCase(int uID, int CaseNum);
        /// <summary>
        /// Disables the specified freedom case for quasi-static and transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableTransientFreedomCase(int uID, int CaseNum);
        /// <summary>
        /// Returns the enabled state of the specified load case for quasi-static and transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientLoadCaseState(int uID, int CaseNum, ref byte Enabled);
        /// <summary>
        /// Returns the enabled state of the specified freedom case for quasi-static and transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientFreedomCaseState(int uID, int CaseNum, ref byte Enabled);
        /// <summary>
        /// Specifies the Factor vs Time table to be associated with a given load case for quasi-static and transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientLoadTimeTable(int uID, int CaseNum, int TableID, byte AddTimeSteps);
        /// <summary>
        /// Returns the Factor vs Time table associated with the specified load case for quasi-static and transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientLoadTimeTable(int uID, int CaseNum, ref int TableID, ref byte AddTimeSteps);
        /// <summary>
        /// Specifies the Factor vs Time table to be associated with a given freedom case for quasi-static and transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTransientFreedomTimeTable(int uID, int CaseNum, int TableID, byte AddTimeSteps);
        /// <summary>
        /// Returns the Factor vs Time table associated with the specified freedom case for quasi-static and transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTransientFreedomTimeTable(int uID, int CaseNum, ref int TableID, ref byte AddTimeSteps);
        /// <summary>
        /// Sets the number of rows used to specify the time integration intervals for the analysis. Each row may have separate time step and integration settings.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNumTimeStepRows(int uID, int NumRows);
        /// <summary>
        /// Returns the number of rows used to specify the time integration interval for the analysis. Each row may have separate time step and integration settings.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumTimeStepRows(int uID, ref int NumRows);
        /// <summary>
        /// Sets the time step and integration data used for the analysis. The integration data may be specified over multiple rows.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTimeStepData(int uID, int Row, int NumSteps, int SaveEvery, double TimeStep);
        /// <summary>
        /// Returns the time step and integration data used for the analysis. The integration data may be specified over multiple rows.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTimeStepData(int uID, int Row, ref int NumSteps, ref int SaveEvery, ref double TimeStep);
        /// <summary>
        /// Sets the units for time stepping for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetTimeStepUnit(int uID, int TimeUnit);
        /// <summary>
        /// Returns the units assigned for time stepping for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetTimeStepUnit(int uID, ref int TimeUnit);
        /// <summary>
        /// Enables the specified moving load path for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableMovingLoad(int uID, int LoadPathID);
        /// <summary>
        /// Disables the specified moving load path for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableMovingLoad(int uID, int LoadPathID);
        /// <summary>
        /// Returns the enabled state of the specified moving load path for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetMovingLoadState(int uID, int LoadPathID, ref byte Enabled);
        /// <summary>
        /// Specifies the Factor vs Time table to be associated with a given load path for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetMovingLoadTimeTable(int uID, int LoadPathID, int TableID);
        /// <summary>
        /// Returns the Factor vs Time table associated with a given load path for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetMovingLoadTimeTable(int uID, int LoadPathID, ref int TableID);
        /// <summary>
        /// Sets the option to use load path divisions appropriate for the timesteps for a given load path.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetMovingLoadAutoDivisions(int uID, int LoadPathID, byte Enabled);
        /// <summary>
        /// Returns the option to use load path divisions appropriate for the timesteps for a given load path.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetMovingLoadAutoDivisions(int uID, int LoadPathID, ref byte Enabled);
        /// <summary>
        /// Sets the state of the nonlinear option for steady heat and transient heat analysis. Models containing radiative boundary conditions or temperature dependent material conditions should use the nonlinear analysis option.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverHeatNonlinear(int uID, byte Nonlinear);
        /// <summary>
        /// Enables the specified load case such that is included in steady heat and transient heat analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableHeatLoadCase(int uID, int CaseNum);
        /// <summary>
        /// Disables the specified load case such that it is not included in steady heat and transient heat analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableHeatLoadCase(int uID, int CaseNum);
        /// <summary>
        /// Returns the enabled state of the specified load case for steady heat and transient heat analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetHeatLoadCaseState(int uID, int CaseNum, ref byte Enabled);
        /// <summary>
        /// Sets the font used in the solver window and log file viewer.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverFontName(int uID, string FontName);
        /// <summary>
        /// Returns the font used in the solver window and log file viewer.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverFontName(int uID, StringBuilder FontName, int MaxStringLen);
        /// <summary>
        /// Sets the number of threads to use for solvers that support parallelisation.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverNumCPU(int uID, int NumCPU);
        /// <summary>
        /// Returns the number of threads to use for solvers that support parallelisation.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverNumCPU(int uID, ref int NumCPU);
        /// <summary>
        /// Sets the scheme to be used for the solution of the linear system arising from the finite element model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverScheme(int uID, int Scheme);
        /// <summary>
        /// Returns the scheme assigned for the solution of the linear system arising from the finite element model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverScheme(int uID, ref int Scheme);
        /// <summary>
        /// Sets the node number re-ordering strategy used by the solver.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverSort(int uID, int Sort);
        /// <summary>
        /// Returns the node number re-ordering strategy assigned to the solver.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverSort(int uID, ref int Sort);
        /// <summary>
        /// Sets the starting node number for the Tree type re-ordering strategy.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverTreeStartNumber(int uID, int Start);
        /// <summary>
        /// Returns the starting node number assigned for the Tree type re-ordering strategy.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverTreeStartNumber(int uID, ref int Start);
        /// <summary>
        /// Sets the active stage for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverActiveStage(int uID, int Stage);
        /// <summary>
        /// Returns the active stage assigned for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverActiveStage(int uID, ref int Stage);
        /// <summary>
        /// Specifies the type of temperature dependence used in the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverTemperatureDependence(int uID, int TempType);
        /// <summary>
        /// Returns the type of temperature dependence used for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverTemperatureDependence(int uID, ref int TempType);
        /// <summary>
        /// Sets the load case used to specify the temperature dependence for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverLoadCaseTemperatureDependence(int uID, int CaseNum);
        /// <summary>
        /// Returns the load case assigned to specify the temperature dependence for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverLoadCaseTemperatureDependence(int uID, ref int CaseNum);
        /// <summary>
        /// Sets the load case that specifies the inertia loads applied to cable elements in the linear solvers. The weight of the cable defines the cable stiffness.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverLoadCaseCableInertia(int uID, int CaseNum);
        /// <summary>
        /// Returns the load case that specifies the inertia loads applied to cable elements in the linear solvers. The weight of the cable defines the cable stiffness.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverLoadCaseCableInertia(int uID, ref int CaseNum);
        /// <summary>
        /// Sets the load case that specifies the pre-loads applied to cable elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverLoadCaseCablePreLoad(int uID, int CaseNum);
        /// <summary>
        /// Returns the load case that specifies the pre-loads applied to cable elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverLoadCaseCablePreLoad(int uID, ref int CaseNum);
        /// <summary>
        /// Sets the freedom case used for the analysis. Multiple freedom cases may be specified for linear static analysis using the St7EnableLSALoadCase function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverFreedomCase(int uID, int CaseNum);
        /// <summary>
        /// Returns the freedom case assigned for the analysis. Multiple freedom cases may be specified for linear static analysis using the St7EnableLSALoadCase function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverFreedomCase(int uID, ref int CaseNum);
        /// <summary>
        /// Sets the type of damping used for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetDampingType(int uID, int DampType);
        /// <summary>
        /// Returns the type of damping assigned for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetDampingType(int uID, ref int DampType);
        /// <summary>
        /// Sets the Rayleigh damping factors used for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetRayleighFactors(int uID, int RayleighMode, double[] Doubles);
        /// <summary>
        /// Returns the Rayleigh damping factors assigned for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetRayleighFactors(int uID, ref int RayleighMode, double[] Doubles);
        /// <summary>
        /// Sets the soil/fluid options for the analysis. These parameters are only used for models containing soil or fluid properties.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSoilFluidOptions(int uID, int CaseNum, double[] Doubles);
        /// <summary>
        /// Returns the soil/fluid parameters assigned for the analysis. These parameters are only used for models containing soil or fluid properties.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSoilFluidOptions(int uID, ref int CaseNum, double[] Doubles);
        /// <summary>
        /// Sets the state of the option to Set Undrained elements above waterline to Drained.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSoilAutoDrained(int uID, byte Active);
        /// <summary>
        /// Returns the state of the option to Set Undrained elements above waterline to Drained.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSoilAutoDrained(int uID, ref byte Active);
        /// <summary>
        /// Assigns the state of the Sturm Check option, for eigenvalue analyses.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSturmCheck(int uID, byte DoSturm);
        /// <summary>
        /// Returns the state of the Sturm Check option, for eigenvalue analyses.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSturmCheck(int uID, ref byte DoSturm);
        /// <summary>
        /// Sets the state of the Nonlinear Geometry option for nonlinear analyses.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverNonlinearGeometry(int uID, byte NonlinearGeometry);
        /// <summary>
        /// Returns the state assigned for the Nonlinear Geometry option for nonlinear analyses.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverNonlinearGeometry(int uID, ref byte NonlinearGeometry);
        /// <summary>
        /// Sets the state of the Nonlinear Material option for nonlinear analyses.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverNonlinearMaterial(int uID, byte NonlinearMaterial);
        /// <summary>
        /// Returns the state assigned for the Nonlinear Material option for nonlinear analyses.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverNonlinearMaterial(int uID, ref byte NonlinearMaterial);
        /// <summary>
        /// Sets the state of the Creep option for creep analyses.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverCreep(int uID, byte Creep);
        /// <summary>
        /// Returns the state assigned for the Creep option for creep analyses.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverCreep(int uID, ref byte Creep);
        /// <summary>
        /// Sets the state of the KG option for geometric nonlinear analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverIncludeKG(int uID, byte IncludeKG);
        /// <summary>
        /// Returns the state of the KG option for geometric nonlinear analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverIncludeKG(int uID, ref byte IncludeKG);
        /// <summary>
        /// Sets the state of the stress stiffening option for natural frequency and linear transient dynamic analyses with initial conditions.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverStressStiffening(int uID, byte AddStressStiffening);
        /// <summary>
        /// Returns the state of the stress stiffening option for natural frequency and linear transient dynamic analyses with initial conditions.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverStressStiffening(int uID, ref byte AddStressStiffening);
        /// <summary>
        /// Sets the enabled state for the specified entity result. Only enabled entity results are written to the result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEntityResult(int uID, int Result, byte Enabled);
        /// <summary>
        /// Returns the enabled state for the specified entity result. Only enabled entity results are written to the result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEntityResult(int uID, int Result, ref byte Enabled);
        /// <summary>
        /// Enables the specified group results for the analysis. Only element results corresponding to enabled groups are written to the result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableResultGroup(int uID, int GroupID);
        /// <summary>
        /// Disables the specified group results for the analysis. Only element results corresponding to enabled groups are written to the result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableResultGroup(int uID, int GroupID);
        /// <summary>
        /// Returns the enabled state of the group results for the analysis. Only element results corresponding to enabled groups are written to the result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultGroupState(int uID, int GroupID, ref byte Enabled);
        /// <summary>
        /// Enables the specified property results for the analysis. Only element results corresponding to enabled properties are written to the result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableResultProperty(int uID, int Entity, int PropNum);
        /// <summary>
        /// Disables the specified property results for the analysis. Only element results corresponding to enabled properties are written to the result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableResultProperty(int uID, int Entity, int PropNum);
        /// <summary>
        /// Returns the enabled state of the specified property results for the analysis. Only element results corresponding to enabled properties are written to the result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultPropertyState(int uID, int Entity, int PropNum, ref byte Enabled);
        /// <summary>
        /// Sets the name of the results file for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultFileName(int uID, string FileName);
        /// <summary>
        /// Sets the name of the solver log-file for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultLogFileName(int uID, string LogName);
        /// <summary>
        /// Sets the name of the static restart file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetStaticRestartFile(int uID, string FileName);
        /// <summary>
        /// Returns the name of the static restart file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetStaticRestartFile(int uID, StringBuilder FileName, int MaxStringLen);
        /// <summary>
        /// Sets the name of the dynamic restart file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetDynamicRestartFile(int uID, string FileName);
        /// <summary>
        /// Returns the name of the dynamic restart file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetDynamicRestartFile(int uID, StringBuilder FileName, int MaxStringLen);
        /// <summary>
        /// Sets the name of the quasi-static restart file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetQuasiStaticRestartFile(int uID, string FileName);
        /// <summary>
        /// Returns the name of the quasi-static restart file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetQuasiStaticRestartFile(int uID, StringBuilder FileName, int MaxStringLen);
        /// <summary>
        /// Sets the name of the node history file for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetNodeHistoryFile(int uID, string FileName);
        /// <summary>
        /// Returns the name of the node history file for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeHistoryFile(int uID, StringBuilder FileName, int MaxStringLen);
        /// <summary>
        /// Enables the Save restart files option for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableSaveRestart(int uID);
        /// <summary>
        /// Disables the Save restart files option for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableSaveRestart(int uID);
        /// <summary>
        /// Enables the Save only last step option for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableSaveLastRestartStep(int uID);
        /// <summary>
        /// Disables the Save only last step option for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableSaveLastRestartStep(int uID);
        /// <summary>
        /// Returns the append/overwrite option for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetAppendSRA(int uID, byte Append);
        /// <summary>
        /// Returns the append/overwrite option for Spectral Response analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetAppendSRA(int uID, ref byte Append);
        /// <summary>
        /// Enables the non-structural mass for the specified load case such that it is included in mass matrix for natural frequency and transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableNSMassCaseInMassMatrix(int uID, int CaseNum);
        /// <summary>
        /// Disables the non-structural mass for the specified load case such that it is not included in mass matrix for natural frequency and transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableNSMassCaseInMassMatrix(int uID, int CaseNum);
        /// <summary>
        /// Returns whether non-structural mass in the specified load case is enabled for inclusion in the mass matrix for natural frequency and transient dynamic analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNSMassCaseInMassMatrixState(int uID, int CaseNum, ref byte Enabled);
        /// <summary>
        /// Sets a series of Boolean parameters for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverDefaultsLogical(int uID, int Parameter, byte Value);
        /// <summary>
        /// Returns the state assigned for a set of Boolean parameters for the analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverDefaultsLogical(int uID, int Parameter, ref byte Value);
        /// <summary>
        /// Sets the integer solver default values.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverDefaultsInteger(int uID, int Parameter, int Value);
        /// <summary>
        /// Returns the value assigned to the integer solver defaults.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverDefaultsInteger(int uID, int Parameter, ref int Value);
        /// <summary>
        /// Sets the double solver default values.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverDefaultsDouble(int uID, int Parameter, double Value);
        /// <summary>
        /// Returns the value assigned to the double solver defaults.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetSolverDefaultsDouble(int uID, int Parameter, ref double Value);
        /// <summary>
        /// Sets the type of solver to be launched for future solver invocations; either the .exe solver or the .dll solver.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetUseSolverDLL(byte UseDLL);
        /// <summary>
        /// Returns the type of solver to be launched for future solver invocations; either the .exe solver or the .dll solver.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetUseSolverDLL(ref byte UseDLL);
        /// <summary>
        /// Returns the execution state for the specified solver process.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CheckSolverRunning(int ProcessID, ref byte IsRunning);
        /// <summary>
        /// Sets the desktop position and size of new solver windows created by St7RunSolver and St7RunSolverProcess.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSolverWindowPos(int L, int T, int W, int H);
        /// <summary>
        /// Clears the solver window position set by St7SetSolverWindowPos. For subsequent executions of the solver, the solver window will appear at the default position and size.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ClearSolverWindowPos();
        /// <summary>
        /// Launches the specified Strand7 solver. All Strand7 solvers run as a separate process to the calling application.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7RunSolver(int uID, int Solver, int Mode, int Wait);
        /// <summary>
        /// Launches the specified Strand7 solver and returns the ID number for the new process created. All Strand7 solvers run as a separate process to the calling application.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7RunSolverProcess(int uID, int Solver, int Mode, int Wait, ref int ProcessID);
        /// <summary>
        /// Stops the execution of the specified solver process.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7StopSolverProcess(int ProcessID);
        /// <summary>
        /// Sets the Results Options for the specified model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultOptions(int uID, int[] Integers);
        /// <summary>
        /// Returns the Results Options for the specified model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultOptions(int uID, int[] Integers);
        /// <summary>
        /// Sets the averaging option for envelopes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEnvelopeAveragingOrder(int uID, int Order);
        /// <summary>
        /// Returns the averaging option for envelopes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEnvelopeAveragingOrder(int uID, ref int Order);
        /// <summary>
        /// Sets the option to automatically insert slices to capture maxima and other points of interest in beam force and moment envelopes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetEnvelopeAdditionalBeamSlices(int uID, byte Additional);
        /// <summary>
        /// Returns the option to automatically insert slices to capture maxima and other points of interest in beam force and moment envelopes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetEnvelopeAdditionalBeamSlices(int uID, ref byte Additional);
        /// <summary>
        /// Sets the mode of the beam position variable used by the beam result extraction functions.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetBeamResultPosMode(int uID, int Mode);
        /// <summary>
        /// Returns the mode of the beam position variable used by the beam result extraction functions.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamResultPosMode(int uID, ref int Mode);
        /// <summary>
        /// Allows the strain units set by St7SetResultOptions to override the report of absolute strains, which is the API default.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableModelStrainUnit(int uID);
        /// <summary>
        /// Restores the API default report of absolute strains, overriding the strain units set by St7SetResultOptions.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableModelStrainUnit(int uID);
        /// <summary>
        /// Allows the rotation units set by St7SetResultOptions to override the report of rotation in radians, which is the API default.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableModelRotationUnit(int uID);
        /// <summary>
        /// Restores the API default report of rotations in radians, overriding the rotation units set by St7SetResultOptions.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableModelRotationUnit(int uID);
        /// <summary>
        /// Allows the length and area units set by St7SetRCUnits to override the report of plate RC results in consistent model units, which is the API default.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableModelRCUnit(int uID);
        /// <summary>
        /// Restores the API default report of plate RC results in consistent model units, overriding the length and area units set by St7SetRCUnits.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableModelRCUnit(int uID);
        /// <summary>
        /// Returns the name of the specified result case in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultCaseName(int uID, int CaseNum, StringBuilder CaseName, int MaxStringLen);
        /// <summary>
        /// Returns the name of the freedom case in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultFreedomCaseName(int uID, StringBuilder CaseName, int MaxStringLen);
        /// <summary>
        /// Returns the stage associated with the specified result case in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultCaseStage(int uID, int CaseNum, ref int Stage);
        /// <summary>
        /// Returns the convergence of the specified result case in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultCaseConvergence(int uID, int CaseNum, ref byte Converged);
        /// <summary>
        /// Returns the Eigenvalue and Eigenvector convergence of the specified mode in the modal result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetModalConvergence(int uID, int Mode, ref byte EigvalConverged, ref byte EigvectConverged);
        /// <summary>
        /// Checks to see if the model has been reset for the specified result case in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultCaseReset(int uID, int CaseNum, ref byte Reset);
        /// <summary>
        /// Returns the integration time for the specified result case in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultCaseTime(int uID, int CaseNum, ref double Time);
        /// <summary>
        /// Returns a context-dependent factor for the specified result case in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultCaseFactor(int uID, int CaseNum, ref double Factor);
        /// <summary>
        /// Returns the kinetic energy for the specified result case in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultCaseKineticEnergy(int uID, int CaseNum, ref double Energy);
        /// <summary>
        /// Returns the total number of iterations performed by the solver for the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumIterations(int uID, ref int NumIterations);
        /// <summary>
        /// Returns the frequency for the specified result case in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFrequency(int uID, int Mode, ref double Freq);
        /// <summary>
        /// Returns the number of modes included in the modal superposition in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumModes(int uID, ref int NumModes);
        /// <summary>
        /// Returns the number of spectral Load Excitation and Base Excitation cases in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumSRACases(int uID, ref int NumCases);
        /// <summary>
        /// Returns the modal results for the specified mode in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetModalResultsNFA(int uID, int Mode, double[] ModalResult);
        /// <summary>
        /// Returns the node and degree of freedom used to normalise the Eigenvector to produce the engineering modal mass and stiffness for the specified mode in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetModalResultsNodeDofNFA(int uID, int Mode, ref int NodeNum, ref int Dof);
        /// <summary>
        /// Returns the excitation type for the specified result case in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetExcitationTypeSRA(int uID, int CaseNum, ref int ExcitationType);
        /// <summary>
        /// Returns the modal results for the specified result case in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetModalResultsSRA(int uID, int CaseNum, int Mode, double[] ModalResult);
        /// <summary>
        /// Returns the modal results for the specified result case in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetModalResultsHRA(int uID, int CaseNum, int Mode, double[] ModalResult);
        /// <summary>
        /// Returns the inertial results for the specified result case in inertial relief for the specified result case in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInertiaReliefResults(int uID, int CaseNum, double[] InertiaResult);
        /// <summary>
        /// Returns the buckling factor for the specified mode in the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBucklingFactor(int uID, int Mode, ref double Fact);
        /// <summary>
        /// Returns the details of the response variable used to generate the specified result case in the load influence result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultCaseInfluenceVariable(int uID, int CaseNum, int[] Integers);
        /// <summary>
        /// Returns the temperature used as the initial temperature for the result file currently open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInitialTemperatureTHA(int uID, ref double InitialTemp);
        /// <summary>
        /// Returns element state information for the specified result case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetElementResultState(int uID, int Entity, int EntityNum, int ResultCase, int[] State);
        /// <summary>
        /// Returns the specified nodal result quantity in the global XYZ system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeResult(int uID, int ResultType, int NodeNum, int ResultCase, double[] NodeResult);
        /// <summary>
        /// Returns the specified nodal result quantity in the global XYZ system. In addition to components, a number of combined results may also be returned, depending on ResultType.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeResultEx(int uID, int ResultType, int NodeNum, int ResultCase, double[] NodeResult);
        /// <summary>
        /// Returns the specified nodal result in a UCS.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeResultUCS(int uID, int ResultType, int UCSId, int NodeNum, int ResultCase, double[] NodeResult);
        /// <summary>
        /// Returns the specified nodal result in a UCS. In addition to components, a number of combined results may also be returned, depending on ResultType.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeResultExUCS(int uID, int ResultType, int UCSId, int NodeNum, int ResultCase, double[] NodeResult);
        /// <summary>
        /// Returns the specified beam result quantity at several stations along the length of the beam. Additional stations may be inserted to ensure that the maximum/minimum results are captured.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamResultArray(int uID, int ResultType, int ResultSubType, int BeamNum, int MinStations, int ResultCase, ref int NumStations, ref int NumColumns, double[] BeamPos, double[] BeamResult);
        /// <summary>
        /// Returns the specified beam results at a series of positions along the length of the beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamResultArrayPos(int uID, int ResultType, int ResultSubType, int BeamNum, int ResultCase, int NumStations, double[] BeamPos, ref int NumColumns, double[] BeamResult);
        /// <summary>
        /// Returns the specified beam result at the beam endpoints.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamResultEndPos(int uID, int ResultType, int ResultSubType, int BeamNum, int ResultCase, ref int NumColumns, double[] BeamResult);
        /// <summary>
        /// Returns the specified beam result at a single position along the length of the beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamResultSinglePos(int uID, int ResultType, int ResultSubType, int BeamNum, int ResultCase, double BeamPos, ref int NumColumns, double[] BeamResult);
        /// <summary>
        /// Returns the section results at the specified point on a beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamSectionResult(int uID, int ResultType, int BeamNum, int ResultCase, double BeamPos, double x, double y, double[] BeamResult);
        /// <summary>
        /// Returns the release results for the specified beam.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBeamReleaseResult(int uID, int BeamNum, int ResultCase, byte[] BeamReleased, double[] ReleaseValue);
        /// <summary>
        /// Returns the specified plate results at a series of sample locations on the element.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateResultArray(int uID, int ResultType, int ResultSubType, int PlateNum, int ResultCase, int SampleLocation, int Surface, int Layer, ref int NumPoints, ref int NumColumns, double[] PlateResult);
        /// <summary>
        /// Sets the maximum junction angle used when calculating averaged plate results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPlateResultMaxJunctionAngle(int uID, double MaxJunctionAngle, byte Enabled);
        /// <summary>
        /// Returns the maximum junction angle used when calculating averaged plate results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateResultMaxJunctionAngle(int uID, ref double MaxJunctionAngle, ref byte Enabled);
        /// <summary>
        /// Returns the position of the result Gauss points for the specified plate.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateResultGaussPoints(int uID, int PlateNum, int ResultCase, ref int NumGauss, double[] Doubles);
        /// <summary>
        /// Returns the specified brick results at one of a number of sample locations in the element.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickResultArray(int uID, int ResultType, int ResultSubType, int BrickNum, int ResultCase, int SampleLocation, ref int NumPoints, ref int NumColumns, double[] BrickResult);
        /// <summary>
        /// Returns the specified link result quantity at each node in the link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLinkResultArray(int uID, int ResultType, int UCSId, int LinkNum, int ResultCase, ref int NumPoints, ref int NumColumns, double[] LinkResult, int ArrayDim);
        /// <summary>
        /// Returns the reaction multi-point link force/moment result for structural solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetMultiPointLinkReactionSum(int uID, int LinkNum, int UCSId, int ResultCase, double[] Reaction);
        /// <summary>
        /// Returns the reaction multi-point link flux result for thermal solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetMultiPointLinkFluxSum(int uID, int LinkNum, int ResultCase, ref double Flux);
        /// <summary>
        /// Returns the force/moment results at nodes of the reaction multi-point link for structural solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetMultiPointLinkNodeReaction(int uID, int LinkNum, int UCSId, int ResultCase, double[] Reaction, int MaxNodes);
        /// <summary>
        /// Returns the flux results at nodes of the reaction multi-point link for thermal solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetMultiPointLinkNodeFlux(int uID, int LinkNum, int ResultCase, double[] Flux, int MaxNodes);
        /// <summary>
        /// Returns the position of the result Gauss points for the specified brick.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickResultGaussPoints(int uID, int BrickNum, int ResultCase, ref int NumGauss, double[] Doubles);
        /// <summary>
        /// Sets the reference case for extracted displacement results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetReferenceDisplacement(int uID, int RefCase, byte ApplyToDisplay);
        /// <summary>
        /// Returns the force/moment sum of node reactions for structural solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeReactionSum(int uID, int UCSId, int ResultCase, double[] Origin, int NodeState, double[] ReactionSum);
        /// <summary>
        /// Returns the force/moment contributions of element node forces at nodes for structural solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetElementNodeForceSum(int uID, int UCSId, int ResultCase, double[] Origin, int[] EntityState, double[] ReactionSum);
        /// <summary>
        /// Returns the node flux sum of nodes for thermal solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNodeFluxSum(int uID, int ResultCase, int NodeState, ref double FluxSum);
        /// <summary>
        /// Returns the flux contributions of elements at nodes for thermal solvers.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetElementNodeFluxSum(int uID, int ResultCase, int[] EntityState, ref double FluxSum);
        /// <summary>
        /// Enables a ply when extracting selected composite results. To access the results and for additional information see St7GetPlateResultArray.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnablePlyPropertyResults(int uID, int PropNum);
        /// <summary>
        /// Disables a ply when extracting selected composite results. To access the results and for additional information see St7GetPlateResultArray.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisablePlyPropertyResults(int uID, int PropNum);
        /// <summary>
        /// Determines if a ply is enabled for inclusion when extracting selected composite results. To access the results and for additional information see St7GetPlateResultArray.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlyPropertyResultsState(int uID, int PropNum, ref byte Enabled);
        /// <summary>
        /// Assigns a user defined equation for beam, plate or brick results and sets this as the currently active equation. The calculated results can be accessed via the St7GetBeamResultArray, St7GetPlateResultArray and St7GetBrickResultArray functions, respectively.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultUserEquation(int uID, int Entity, string Equation, int TrigType);
        /// <summary>
        /// Returns the currently active user defined equation for beam, plate or brick results. The calculated results can be accessed via the functions St7GetBeamResultArray, St7GetPlateResultArray and St7GetBrickResultArray, respectively.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultUserEquation(int uID, int Entity, StringBuilder Equation, int MaxStringLen, ref int TrigType);
        /// <summary>
        /// Stores a user defined equation.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7StoreResultUserEquation(int uID, int Entity, string Name, string Equation, int TrigType);
        /// <summary>
        /// Deletes a stored user defined equation.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteStoredResultUserEquation(int uID, int Entity, int Number);
        /// <summary>
        /// Replaces a stored user defined equation.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ReplaceStoredResultUserEquation(int uID, int Entity, int Number, string Name, string Equation, int TrigType);
        /// <summary>
        /// Retrieves a stored user defined equation.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7RetrieveStoredResultUserEquation(int uID, int Entity, int Number, StringBuilder Name, StringBuilder Equation, int MaxStringLen, ref int TrigType);
        /// <summary>
        /// Returns the number of stored user defined equations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumStoredResultUserEquations(int uID, int Entity, ref int NumEquations);
        /// <summary>
        /// Makes a stored user defined equation the currently active user defined equation.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetStoredResultUserEquation(int uID, int Entity, int Number);
        /// <summary>
        /// Generates a plate contour results file containing results of a single quantity for all plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GeneratePlateContourFile(int uID, int ResultCase, int[] Integers, ref int FileIndex);
        /// <summary>
        /// Generates a brick contour results file containing results of a single quantity for all bricks.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GenerateBrickContourFile(int uID, int ResultCase, int[] Integers, ref int FileIndex);
        /// <summary>
        /// Loads a plate contour file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7LoadPlateContourFile(int uID, int FileIndex);
        /// <summary>
        /// Loads a brick contour file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7LoadBrickContourFile(int uID, int FileIndex);
        /// <summary>
        /// Returns a result from the most recently loaded plate contour file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetPlateContourFileResult(int uID, int PlateNum, double[] PlateResult);
        /// <summary>
        /// Returns a result from the most recently loaded brick contour file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetBrickContourFileResult(int uID, int BrickNum, double[] BrickResult);
        /// <summary>
        /// Returns the number of linear load case combinations in the specified model for solver-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumLSACombinations(int uID, ref int NumCases);
        /// <summary>
        /// Sets the name of the specified linear load case combination for solver-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLSACombinationName(int uID, int CaseNum, string CaseName);
        /// <summary>
        /// Returns the name of the specified linear load case combination for solver-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLSACombinationName(int uID, int CaseNum, StringBuilder CaseName, int MaxStringLen);
        /// <summary>
        /// Sets the spectral results filename to be used in linear load combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLSACombinationSRAName(int uID, string FileName);
        /// <summary>
        /// Returns the spectral results filename used in linear load combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLSACombinationSRAName(int uID, StringBuilder FileName, int MaxStringLen);
        /// <summary>
        /// Adds a new linear load case combination to the specified model for solver-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddLSACombination(int uID, string CaseName);
        /// <summary>
        /// Inserts a new linear load case combination at the specified position for solver-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertLSACombination(int uID, int Pos, string CaseName);
        /// <summary>
        /// Deletes the specified linear load case combination from the model for solver-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteLSACombination(int uID, int Pos);
        /// <summary>
        /// Sets the multiplying factor for the specified case in a linear load case combination for solver-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLSACombinationFactor(int uID, int LType, int Pos, int LoadCaseNum, int FreedomCaseNum, double Factor);
        /// <summary>
        /// Returns the multiplying factor for the specified case in a linear load case combination for solver-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLSACombinationFactor(int uID, int LType, int Pos, int LoadCaseNum, int FreedomCaseNum, ref double Factor);
        /// <summary>
        /// Sets the enabled state of the specified linear load case combination for solver-generated .LSA files. Only enabled cases are generated as result cases.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLSACombinationState(int uID, int CaseNum, byte Enabled);
        /// <summary>
        /// Returns the enabled state of the specified linear load case combination for solver-generated .LSA files. Only enabled cases are generated as result cases.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLSACombinationState(int uID, int CaseNum, ref byte Enabled);
        /// <summary>
        /// Returns the number of linear load case combinations in the specified model for user-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumCombinedLSACombinations(int uID, ref int NumCases);
        /// <summary>
        /// Sets the name of the specified linear load case combination for user-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCombinedLSACombinationName(int uID, int CaseNum, string CaseName);
        /// <summary>
        /// Returns the name of the specified linear load case combination for user-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCombinedLSACombinationName(int uID, int CaseNum, StringBuilder CaseName, int MaxStringLen);
        /// <summary>
        /// Sets the enabled state of the specified linear load case combination for user-generated .LSA files. Only enabled cases are generated as result cases.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCombinedLSACombinationState(int uID, int CaseNum, byte Enabled);
        /// <summary>
        /// Returns the enabled state of the specified linear load case combination for user-generated .LSA files. Only enabled cases are generated as result cases.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCombinedLSACombinationState(int uID, int CaseNum, ref byte Enabled);
        /// <summary>
        /// Adds a new linear load case combination to the specified model for user-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddCombinedLSACombination(int uID, string CaseName);
        /// <summary>
        /// Inserts a new linear load case combination at the specified position for user-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertCombinedLSACombination(int uID, int Pos, string CaseName);
        /// <summary>
        /// Deletes the specified linear load case combination from the model for user-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteCombinedLSACombination(int uID, int Pos);
        /// <summary>
        /// Sets the multiplying factor for the specified case in a linear load case combination for user-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCombinedLSACombinationFactor(int uID, int Pos, int CaseNum, double Factor);
        /// <summary>
        /// Returns the multiplying factor for the specified case in a linear load case combination for user-generated .LSA files.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCombinedLSACombinationFactor(int uID, int Pos, int CaseNum, ref double Factor);
        /// <summary>
        /// Sets the linear static results filename to be used with the harmonic time results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetHRACombinationLSAName(int uID, string FileName);
        /// <summary>
        /// Returns the linear static results filename to be used with the harmonic time results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetHRACombinationLSAName(int uID, StringBuilder FileName, int MaxStringLen);
        /// <summary>
        /// Sets the result factor for the Base Displacement, Base Velocity or Base Acceleration case in harmonic time results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetHRABaseCombinationFactor(int uID, double Factor);
        /// <summary>
        /// Returns the result factor for the Base Displacement, Base Velocity or Base Acceleration case in harmonic time results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetHRABaseCombinationFactor(int uID, ref double Factor);
        /// <summary>
        /// Sets the result factor for an Applied Load case in harmonic time results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetHRACaseCombinationFactor(int uID, int CaseNum, double Factor);
        /// <summary>
        /// Returns the result factor for an Applied Load case in harmonic time results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetHRACaseCombinationFactor(int uID, int CaseNum, ref double Factor);
        /// <summary>
        /// Sets the result factor for a linear static result case in harmonic time results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetHRACombinationFactorLSA(int uID, int LoadCaseNum, int FreedomCaseNum, double Factor);
        /// <summary>
        /// Returns the result factor for a linear static result case in harmonic time results.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetHRACombinationFactorLSA(int uID, int LoadCaseNum, int FreedomCaseNum, ref double Factor);
        /// <summary>
        /// Sets the name of the load influence result file used for combinations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetInfluenceFileName(int uID, string FileName);
        /// <summary>
        /// Returns the name of the load influence result file used for combinations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInfluenceFileName(int uID, StringBuilder FileName, int MaxStringLen);
        /// <summary>
        /// Returns the number of load influence variables available in the current result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumInfluenceVariables(int uID, ref int NumVariables);
        /// <summary>
        /// Returns the number of load influence variables available in the current result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumInfluenceMultiVariableCases(int uID, ref int NumMultiVariableCases);
        /// <summary>
        /// Returns information about a load influence variable.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInfluenceVariable(int uID, int VariableID, int[] Integers);
        /// <summary>
        /// Sets the enabled state of the specified single-variable minimum load influence combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetInfluenceMinVariableState(int uID, int MinVariableID, byte Enabled);
        /// <summary>
        /// Returns the enabled state of the specified single-variable minimum load influence combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInfluenceMinVariableState(int uID, int MinVariableID, ref byte Enabled);
        /// <summary>
        /// Sets the enabled state of the specified single-variable maximum load influence combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetInfluenceMaxVariableState(int uID, int MaxVariableID, byte Enabled);
        /// <summary>
        /// Returns the enabled state of the specified single-variable maximum load influence combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInfluenceMaxVariableState(int uID, int MaxVariableID, ref byte Enabled);
        /// <summary>
        /// Set the enabled state of the specified variable within a multi-variable load influence combination case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetInfluenceMultiVariableState(int uID, int MultiVariableID, int MultiVariableCaseID, byte Enabled);
        /// <summary>
        /// Returns the enabled state of the specified variable within a multi-variable load influence combination case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInfluenceMultiVariableState(int uID, int MultiVariableID, int MultiVariableCaseID, ref byte Enabled);
        /// <summary>
        /// Sets the type of a multi-variable load influence combination case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetInfluenceMultiVariableType(int uID, int MultiVariableCaseID, int MultiVariableType);
        /// <summary>
        /// Returns the type of a multi-variable load influence combination case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInfluenceMultiVariableType(int uID, int MultiVariableCaseID, ref int MultiVariableType);
        /// <summary>
        /// Adds a new multi-variable load influence combination case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddInfluenceMultiVariableCase(int uID, int MultiVariableType, string MultiVariableName);
        /// <summary>
        /// Deletes a multi-variable load influence combination case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteInfluenceMultiVariableCase(int uID, int MultiVariableCaseID);
        /// <summary>
        /// Sets the name of a multi-variable load influence combination case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetInfluenceMultiVariableName(int uID, int MultiVariableCaseID, string MultiVariableName);
        /// <summary>
        /// Returns the name of a multi-variable load influence combination case.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInfluenceMultiVariableName(int uID, int MultiVariableCaseID, StringBuilder MultiVariableName, int MaxStringLen);
        /// <summary>
        /// Includes or excludes a group from load influence combinations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetInfluenceGroupState(int uID, int GroupID, byte Included);
        /// <summary>
        /// Returns the included state of a group from load influence combinations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInfluenceGroupState(int uID, int GroupID, ref byte Included);
        /// <summary>
        /// Includes or excludes a property from load influence combinations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetInfluencePropertyState(int uID, int Entity, int PropNum, byte Included);
        /// <summary>
        /// Returns the included status of a property from load influence combinations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInfluencePropertyState(int uID, int Entity, int PropNum, ref byte Included);
        /// <summary>
        /// Sets the load influence combination generation options.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetInfluenceCombinationOptions(int uID, int[] Integers);
        /// <summary>
        /// Returns the load influence combination generation options.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInfluenceCombinationOptions(int uID, int[] Integers);
        /// <summary>
        /// Generates load influence combination load cases.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GenerateInfluenceCases(int uID, byte RemoveExisting, byte AllowStop, byte WriteLog, int Mode, ref int NumCasesDeleted, ref int NumCasesGenerated, ref int WarningCode);
        /// <summary>
        /// Returns the number of envelopes for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumEnvelopes(int uID, ref int NumLimitEnvelopes, ref int NumCombinationEnvelopes, ref int NumFactorsEnvelopes);
        /// <summary>
        /// Returns the number of envelopes for the specified solver and solver mode.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumEnvelopesSolver(int uID, int Solver, int SolverMode, ref int NumLimitEnvelopes, ref int NumCombinationEnvelopes, ref int NumFactorsEnvelopes);
        /// <summary>
        /// Adds a new limit envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddLimitEnvelope(int uID, int EnvType, string EnvName);
        /// <summary>
        /// Inserts a new limit envelope at the specified position for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertLimitEnvelope(int uID, int Envelope, int EnvType, string EnvName);
        /// <summary>
        /// Deletes the specified limit envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteLimitEnvelope(int uID, int Envelope);
        /// <summary>
        /// Enables the specified result case in a limit envelope for the currently open solution. Only results from enabled result cases are included in the envelope.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7EnableLimitEnvelopeCase(int uID, int Envelope, int CaseNum);
        /// <summary>
        /// Disables the specified result case in a limit envelope for the currently open solution. Only results from enabled result cases are included in the envelope.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DisableLimitEnvelopeCase(int uID, int Envelope, int CaseNum);
        /// <summary>
        /// Returns the enabled state of the specified result case in a limit envelope for the currently open solution. Only results from enabled result cases are included in the envelope.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLimitEnvelopeCaseState(int uID, int Envelope, int CaseNum, ref byte Enabled);
        /// <summary>
        /// Assigns the settings for the specified limit envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetLimitEnvelopeData(int uID, int Envelope, int EnvType, string EnvName);
        /// <summary>
        /// Returns the settings assigned to the specified limit envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetLimitEnvelopeData(int uID, int Envelope, ref int EnvType, StringBuilder EnvName, int MaxStringLen);
        /// <summary>
        /// Adds a new combination envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddCombinationEnvelope(int uID, int EnvType, string EnvName);
        /// <summary>
        /// Inserts a new combination envelope at the specified position for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertCombinationEnvelope(int uID, int Envelope, int EnvType, string EnvName);
        /// <summary>
        /// Deletes the specified combination envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteCombinationEnvelope(int uID, int Envelope);
        /// <summary>
        /// Sets the state of the specified results case in a combination envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCombinationEnvelopeCase(int uID, int Envelope, int CaseNum, int State);
        /// <summary>
        /// Returns the state of the specified result case in a combination envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCombinationEnvelopeCase(int uID, int Envelope, int CaseNum, ref int State);
        /// <summary>
        /// Assigns the settings for the specified combination envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCombinationEnvelopeData(int uID, int Envelope, int EnvType, string EnvName);
        /// <summary>
        /// Returns the settings assigned to the specified combination envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCombinationEnvelopeData(int uID, int Envelope, ref int EnvType, StringBuilder EnvName, int MaxStringLen);
        /// <summary>
        /// Adds a new factors envelope to the specified model for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddFactorsEnvelope(int uID, int EnvType, string EnvName);
        /// <summary>
        /// Inserts a new factors envelope at the specified position for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertFactorsEnvelope(int uID, int Envelope, int EnvType, string EnvName);
        /// <summary>
        /// Deletes the specified factors envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteFactorsEnvelope(int uID, int Envelope);
        /// <summary>
        /// Assigns the settings for the specified factors envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFactorsEnvelopeData(int uID, int Envelope, int EnvType, string EnvName);
        /// <summary>
        /// Returns the settings assigned to the specified factors envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFactorsEnvelopeData(int uID, int Envelope, ref int EnvType, StringBuilder EnvName, int MaxStringLen);
        /// <summary>
        /// Adds a new result case dependency to the specified factors envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddFactorsEnvelopeCase(int uID, int Envelope);
        /// <summary>
        /// Inserts a new result case dependency at the specified position in a factors envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertFactorsEnvelopeCase(int uID, int Envelope, int Pos);
        /// <summary>
        /// Deletes the specified result case dependency for a factors envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteFactorsEnvelopeCase(int uID, int Envelope, int Pos);
        /// <summary>
        /// Assigns the settings for the specified factors envelope case for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFactorsEnvelopeCaseData(int uID, int Envelope, int Pos, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the settings assigned to the specified factors envelope case for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFactorsEnvelopeCaseData(int uID, int Envelope, int Pos, int[] Integers, double[] Doubles);
        /// <summary>
        /// Adds a new set to the specified factors envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddFactorsEnvelopeSet(int uID);
        /// <summary>
        /// Inserts a new set at the specified position for a factors envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertFactorsEnvelopeSet(int uID, int Pos);
        /// <summary>
        /// Deletes the specified set from a factors envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteFactorsEnvelopeSet(int uID, int Pos);
        /// <summary>
        /// Returns the number of sets assigned to the specified factors envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumFactorsEnvelopeSets(int uID, ref int NumSets);
        /// <summary>
        /// Returns the number of cases (rows) included in the specified factors envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumFactorsEnvelopeCases(int uID, int Envelope, ref int NumCases);
        /// <summary>
        /// Assigns the settings for the specified set in a factors envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetFactorsEnvelopeSetData(int uID, int Pos, int SetType, string SetName, string SetGroup);
        /// <summary>
        /// Returns the settings assigned to the specified set in a factors envelope for the currently open solution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetFactorsEnvelopeSetData(int uID, int Pos, ref int SetType, StringBuilder SetName, StringBuilder SetGroup, int MaxStringLen);
        /// <summary>
        /// Sets the name of the target file produced when forming a combined result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultFileCombTargetFileName(int uID, string FileName);
        /// <summary>
        /// Returns the name of the target file produced when forming a combined result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultFileCombTargetFileName(int uID, StringBuilder FileName, int MaxStringLen);
        /// <summary>
        /// Adds a new file to the current results file combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddResultFileCombFileName(int uID, string FileName);
        /// <summary>
        /// Deletes the specified file from the current results file combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteResultFileCombFileName(int uID, int FileNum);
        /// <summary>
        /// Sets the name of the specified file in the current result file combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultFileCombFileName(int uID, int FileNum, string FileName);
        /// <summary>
        /// Returns the name of the specified file in the current results file combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultFileCombFileName(int uID, int FileNum, StringBuilder FileName, int MaxStringLen);
        /// <summary>
        /// Adds a new case to the current result file combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AddResultFileCombCase(int uID, string CaseName);
        /// <summary>
        /// Deletes the specified case from the current result file combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteResultFileCombCase(int uID, int Pos);
        /// <summary>
        /// Sets the combination data for a combined result case in the specified result file combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultFileCombCaseData(int uID, int FileNum, int Pos, int CaseNum, double Factor);
        /// <summary>
        /// Returns the combination data assigned to a combined result case in the specified result file combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultFileCombCaseData(int uID, int FileNum, int Pos, ref int CaseNum, ref double Factor);
        /// <summary>
        /// Sets the name of a combined result case in the specified result file combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResultFileCombCaseName(int uID, int Pos, string CaseName);
        /// <summary>
        /// Returns the name assigned to a combined result case in the specified result file combination.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResultFileCombCaseName(int uID, int Pos, StringBuilder CaseName, int MaxStringLen);
        /// <summary>
        /// Generates the combined result file using the specified method.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GenerateResultFileComb(int uID, int Method);
        /// <summary>
        /// Retrieves the combination components from a previously generated result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7RetrieveResultFileComb(int uID, string FileName);
        /// <summary>
        /// Generates the time history response for the specified model based on a harmonic response analysis. An associated harmonic response result file must currently be open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GenerateHRATimeHistory(int uID, double StartTime, double EndTime, int NumSteps, ref int WarningCode);
        /// <summary>
        /// Clears the time history response for the specified model based on a harmonic response analysis. An associated harmonic response result file must currently be open.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ClearHRATimeHistory(int uID);
        /// <summary>
        /// Creates a new custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7NewResFile(int uID, string FileName, int ResultType);
        /// <summary>
        /// Returns the units in which result data must be provided to St7SetResFileNodeResult, St7SetResFileBeamResult, St7SetResFilePlateResult, St7SetResFilePlatePressureResult and St7SetResFileBrickResult.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResFileUnits(int uID, int[] Units);
        /// <summary>
        /// Opens the specified custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7OpenResFile(int uID, string FileName);
        /// <summary>
        /// Closes the open custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CloseResFile(int uID);
        /// <summary>
        /// Sets the description for the specified custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFileDescription(int uID, string Name);
        /// <summary>
        /// Returns the description of the specified custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResFileDescription(int uID, StringBuilder Name, int MaxStringLen);
        /// <summary>
        /// Sets the number of result cases in the open custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFileNumCases(int uID, int NumCases);
        /// <summary>
        /// Sets the name of the specified result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFileCaseName(int uID, int CaseNum, string CaseName);
        /// <summary>
        /// Associates load and freedom cases with the specified result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AssociateResFileCase(int uID, int CaseNum, int LoadCase, int FreedomCase);
        /// <summary>
        /// Associates a stage with the specified result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AssociateResFileStage(int uID, int CaseNum, int Stage);
        /// <summary>
        /// Associates the non-structural mass from a particular load case with a custom result file; this is relevant to natural frequency results. The association is required for correct determination of mass participation if the custom natural frequency result file is used in a conventional spectral response analysis, and the frequencies and mode shapes represented in the custom natural frequency result file depend on non-structural mass attributes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AssociateResFileNSMassCase(int uID, int CaseNum, double Factor);
        /// <summary>
        /// Sets the frequency or buckling factor for the specified result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFileMode(int uID, int CaseNum, double Mode);
        /// <summary>
        /// Returns the frequency or buckling factor for the specified result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResFileMode(int uID, int CaseNum, ref double Mode);
        /// <summary>
        /// Sets the integration time for the specified result case in the custom result file; units are seconds.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFileTime(int uID, int CaseNum, double Time);
        /// <summary>
        /// Returns the integration time assigned to the specified result case in the custom result file; units are seconds.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResFileTime(int uID, int CaseNum, ref double Time);
        /// <summary>
        /// Sets the time units displayed in the specified custom result file. Note that this setting does not affect the time input to St7SetResFileTime, which is always in seconds.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFileTimeUnit(int uID, int TimeUnit);
        /// <summary>
        /// Returns the time units displayed in the specified custom result file. Note that this setting does not affect the time output by St7GetResFileTime, which is always in seconds.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResFileTimeUnit(int uID, ref int TimeUnit);
        /// <summary>
        /// Includes the specified result quantity in a given result case of the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFileQuantity(int uID, int CaseNum, int Entity, int Quantity);
        /// <summary>
        /// Assigns the freedom case associated with the result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFileFreedomCase(int uID, int CaseNum);
        /// <summary>
        /// Returns the freedom case associated with the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResFileFreedomCase(int uID, ref int CaseNum);
        /// <summary>
        /// Removes the specified result quantity from a given result case of the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ClearResFileQuantity(int uID, int CaseNum, int Entity, int Quantity);
        /// <summary>
        /// Returns the included/excluded state of an element result quantity in a given result case of the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResFileQuantityState(int uID, int CaseNum, int Entity, int Quantity, ref byte Included);
        /// <summary>
        /// Sets the specified nodal result quantities for a given node and result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFileNodeResult(int uID, int CaseNum, int NodeNum, int Quantity, double[] Doubles);
        /// <summary>
        /// Returns the specified nodal result quantities for a given node and result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResFileNodeResult(int uID, int CaseNum, int NodeNum, int Quantity, double[] Doubles);
        /// <summary>
        /// Sets the specified beam result quantities for a given beam element and result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFileBeamResult(int uID, int CaseNum, int BeamNum, int Quantity, double[] Doubles);
        /// <summary>
        /// Returns the specified beam result quantities for a given beam element and result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResFileBeamResult(int uID, int CaseNum, int BeamNum, int Quantity, double[] Doubles);
        /// <summary>
        /// Sets the specified beam end release quantities for a given beam element and result case in the custom result file. Note that for beam end release results to be stored, St7SetResFileQuantity must have been called with either rtBeamExtraResults, or at least with rtBeamForce or rtBeamAllStrain.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFileBeamReleaseResult(int uID, int CaseNum, int BeamNum, byte[] BeamReleased, double[] Doubles);
        /// <summary>
        /// Returns the specified beam end release quantities for a given beam element and result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResFileBeamReleaseResult(int uID, int CaseNum, int BeamNum, byte[] BeamReleased, double[] Doubles);
        /// <summary>
        /// Sets the number of result stations used to store beam results for the specified result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFileBeamStations(int uID, int CaseNum, int Stations);
        /// <summary>
        /// Returns the number of result stations used to store beam results for the specified result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResFileBeamStations(int uID, int CaseNum, ref int Stations);
        /// <summary>
        /// Sets the specified plate result quantities for a given plate element and result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFilePlateResult(int uID, int CaseNum, int PlateNum, int Quantity, byte NonlinearMaterial, double[] Doubles);
        /// <summary>
        /// Returns the specified plate result quantities for a given plate element and result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResFilePlateResult(int uID, int CaseNum, int PlateNum, int Quantity, ref byte NonlinearMaterial, double[] Doubles);
        /// <summary>
        /// Sets the applied normal pressure load for a given plate element and result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFilePlatePressureResult(int uID, int CaseNum, int PlateNum, double[] Doubles);
        /// <summary>
        /// Returns the applied normal pressure load for a given plate element and result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResFilePlatePressureResult(int uID, int CaseNum, int PlateNum, double[] Doubles);
        /// <summary>
        /// Sets the specified brick result quantities for a given brick element and result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetResFileBrickResult(int uID, int CaseNum, int BrickNum, int Quantity, double[] Doubles);
        /// <summary>
        /// Returns the specified brick result quantities for a given brick element and result case in the custom result file.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetResFileBrickResult(int uID, int CaseNum, int BrickNum, int Quantity, double[] Doubles);
        /// <summary>
        /// Sets the tool options for the specified model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetToolOptions(int uID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the tool options assigned to the specified model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetToolOptions(int uID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Specifies the settings used by St7CleanMesh.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCleanMeshOptions(int uID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Returns the current settings used by St7CleanMesh.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetCleanMeshOptions(int uID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Performs a mesh cleaning operation on the Strand7 model using the current settings.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CleanMesh(int uID);
        /// <summary>
        /// Performs a surface meshing operation based on the geometry included in the specified Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SurfaceMesh(int uID, int[] Integers, double[] Doubles, int Mode);
        /// <summary>
        /// Performs a solid meshing operation based on the surface mesh definitions included in the specified Strand7 model. Surface mesh definitions can be created using the St7SurfaceMesh function, but may also be created by other means.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SolidTetMesh(int uID, int[] Integers, int Mode);
        /// <summary>
        /// Performs a solid meshing operation based on the geometry included in the specified Strand7 model. Effectively, the function combines the functionality provided by a call to St7SurfaceMesh followed by a call St7SolidTetMesh to produce a solid mesh directly from the geometry, bypassing the explicit generation of surface plate elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DirectSolidTetMesh(int uID, int[] Integers, double[] Doubles, int Mode);
        /// <summary>
        /// Performs a surface meshing operation on a single face. The definition of this face is specified explicitly using the array inputs for this function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MeshFromLoops(int uID, int[] Integers, double[] Doubles, int[] Loops, double[] Points, int Mode);
        /// <summary>
        /// Deletes nodes that are not referenced by the connectivity of any element.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteUnusedNodes(int uID, ref int NumDeleted);
        /// <summary>
        /// Marks the specified element as invalid to be subsequently removed using the St7DeleteInvalidElements function.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InvalidateElement(int uID, int Entity, int EntityNum);
        /// <summary>
        /// Deletes all elements marked as invalid from a Strand7 model.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteInvalidElements(int uID, int Entity, ref int NumDeleted);
        /// <summary>
        /// Sets paste options that will be applied by subsequent paste operations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPasteOptions(int uID, int[] Integers);
        /// <summary>
        /// Copies the selected entities from the model to the clipboard.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CopyToSt7Clipboard(int uID);
        /// <summary>
        /// Cuts the selected entities from the model to the clipboard.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CutToSt7Clipboard(int uID);
        /// <summary>
        /// Pastes the contents of the clipboard (source) into the model (target), similarly to pasting using the Adjust tab in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PasteFromSt7ClipboardByIncrements(int uID, double[] Rotation, double[] Translation, double Scaling);
        /// <summary>
        /// Pastes the contents of the clipboard (source) into the model (target), similarly to pasting via the Anchors and Adjust tabs in the GUI.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PasteFromSt7ClipboardByAnchors(int uID, int[] SourceAnchorType, int[] SourceAnchorID, int[] TargetAnchorType, int[] TargetAnchorID, double[] Rotation, double[] Translation, double Scaling);
        /// <summary>
        /// Sets the mode of projection to Source (Plate) Normal for subsequent uses of projection tools.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetProjectDirectionAsSource(int uID);
        /// <summary>
        /// Sets the mode of projection to Target Normal for subsequent uses of projection tools.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetProjectDirectionAsTarget(int uID);
        /// <summary>
        /// Sets the mode of projection to Conical for subsequent uses of projection tools.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetProjectDirectionAsConical(int uID, double[] Apex);
        /// <summary>
        /// Sets the mode of projection to Parallel for subsequent uses of projection tools.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetProjectDirectionAsParallel(int uID, double[] P1, double[] P2);
        /// <summary>
        /// Sets the Property Increment for copy operations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPropertyIncrement(int uID, int PropInc);
        /// <summary>
        /// Sets the Keep Selection flag for applicable tools operations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetKeepSelect(int uID, byte KeepSelect);
        /// <summary>
        /// Sets the state of the copy options for applicable tools operations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetCopyFlags(int uID, int[] Flags);
        /// <summary>
        /// Sets the state of the extrude options for applicable tools operations.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetExtrudeFlags(int uID, int[] Flags);
        /// <summary>
        /// Sets the parameters for the Target options for the extrusion tools.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetExtrudeTargets(int uID, int[] Targets);
        /// <summary>
        /// Sets the state of the Source option for applicable tools.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetSourceAction(int uID, int SourceAction);
        /// <summary>
        /// Sets the type of entities created by the points and lines tools.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SetPLTarget(int uID, int Target, int PropNum);
        /// <summary>
        /// Creates a new line definition based on two nodes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DefineLineN2(int uID, int NodeNum1, int NodeNum2, ref int LineID);
        /// <summary>
        /// Creates a new line definition based on two vertices.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DefineLineV2(int uID, int VertexNum1, int VertexNum2, ref int LineID);
        /// <summary>
        /// Creates a new line definition based on one node and one vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DefineLineNV(int uID, int NodeNum, int VertexNum, byte Reversed, ref int LineID);
        /// <summary>
        /// Creates a new line definition using two points in the global XYZ system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DefineLineP2(int uID, double[] P1, double[] P2, ref int LineID);
        /// <summary>
        /// Creates a new plane definition by locating one of the three global XYZ planes at a node.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DefinePlaneGlobalN(int uID, int NodeNum, int Plane, ref int PlaneID);
        /// <summary>
        /// Creates a new plane definition by locating one of the three global XYZ planes at a vertex.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DefinePlaneGlobalV(int uID, int VertexNum, int Plane, ref int PlaneID);
        /// <summary>
        /// Creates a new plane definition using three points in the global XYZ system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DefinePlaneP3(int uID, double[] P1, double[] P2, double[] P3, ref int PlaneID);
        /// <summary>
        /// Creates a new plane definition from an existing UCS.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DefinePlaneUCS(int uID, int UCSId, int UCSPlane, ref int PlaneID);
        /// <summary>
        /// Creates an entity collection from the currently selected entities.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DefineEntityCollection(int uID, ref int CollectionID);
        /// <summary>
        /// Copies selected entities by increment.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CopyByIncrement(int uID, double[] DXYZ, int UCSId, int NumCopies);
        /// <summary>
        /// Copies selected entities by rotation.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CopyByRotation(int uID, int UCSId, int Axis, double Angle, double[] Origin, int NumCopies);
        /// <summary>
        /// Copies selected entities by projection to a predefined line.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CopyByProjectionToLine(int uID, int LineID, byte EquiSpace);
        /// <summary>
        /// Copies selected entities by projection to a predefined plane.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CopyByProjectionToPlane(int uID, int PlaneID);
        /// <summary>
        /// Copies selected entities by projection to the specified ordinate on a coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CopyByProjectionToUCS(int uID, int UCSId, int UCSPlane, double Ordinate);
        /// <summary>
        /// Copies selected entities by projection to the faces of predefined entities.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CopyByProjectionToEntityFace(int uID, int CollectionID);
        /// <summary>
        /// Copies selected entities by thickness.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CopyByThickness(int uID, double Thickness, int BeamDir, int PlateSurface, int FaceSurface, byte UsePlateThickness, byte UseFaceThickness);
        /// <summary>
        /// Copies selected entities by reflecting them over a predefined plane.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CopyByMirror(int uID, int PlaneID);
        /// <summary>
        /// Copies selected entities to a fixed ordinate in a given axis of a coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CopyToAbsolute(int uID, double Value, int UCSId, int Axis);
        /// <summary>
        /// Moves selected entities by increment.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MoveByIncrement(int uID, double[] DXYZ, int UCSId);
        /// <summary>
        /// Moves selected entities by rotation.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MoveByRotation(int uID, int UCSId, int Axis, double Angle, double[] Origin);
        /// <summary>
        /// Moves selected entities by projection to a predefined line.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MoveByProjectionToLine(int uID, int LineID, byte EquiSpace);
        /// <summary>
        /// Moves selected entities by projection to a predefined plane.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MoveByProjectionToPlane(int uID, int PlaneID);
        /// <summary>
        /// Moves selected entities by projection to the specified ordinate on a coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MoveByProjectionToUCS(int uID, int UCSId, int UCSPlane, double Ordinate);
        /// <summary>
        /// Moves selected entities by projection to the faces of predefined entities.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MoveByProjectionToEntityFace(int uID, int CollectionID);
        /// <summary>
        /// Moves selected entities by thickness.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MoveByThickness(int uID, double Thickness, int BeamDir, int PlateSurface, int FaceSurface, byte UsePlateThickness, byte UseFaceThickness);
        /// <summary>
        /// Moves selected entities by reflecting them over a predefined plane.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MoveByMirror(int uID, int PlaneID);
        /// <summary>
        /// Moves selected entities by a prescribed skew amount.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MoveBySkew(int uID, double[] Origin, double[] Skew, int Axis);
        /// <summary>
        /// Moves selected entities to a fixed ordinate in a given axis of a coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MoveToAbsolute(int uID, double Value, int UCSId, int Axis);
        /// <summary>
        /// Moves selected entities to the intersection of two coordinate systems.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MoveToUCSIntersection(int uID, int UCSId1, int UCSId2, double Ordinate1, double Ordinate2);
        /// <summary>
        /// Moves selected entities by shifting a reference point to the origin of a coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MoveToOriginByPoint(int uID, int UCSId, double[] Point);
        /// <summary>
        /// Moves the minimum XYZ point of selected entities to the origin of a coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MoveToOriginMinXYZ(int uID, int UCSId);
        /// <summary>
        /// Aligns a model with the specified coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MoveToPlane(int uID, int SourcePlaneID, int TargetPlaneID);
        /// <summary>
        /// Extrudes selected entities by increment.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExtrudeByIncrement(int uID, double[] DXYZ, int UCSId, int NumCopies);
        /// <summary>
        /// Extrudes selected entities by rotation.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExtrudeByRotation(int uID, int UCSId, int Axis, double Angle, double[] Origin, int NumCopies);
        /// <summary>
        /// Extrudes selected entities by projection to a point specified by coordinates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExtrudeByProjectionToPoint(int uID, double[] Point);
        /// <summary>
        /// Extrudes selected entities by projection to a point. The point is calculated as the average of all selected nodes and all nodes in the set of selected elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExtrudeByProjectionToAveragePoint(int uID);
        /// <summary>
        /// Extrudes selected entities by projection to a predefined line.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExtrudeByProjectionToLine(int uID, int LineID, byte EquiSpace);
        /// <summary>
        /// Extrudes selected entities by projection to a predefined plane.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExtrudeByProjectionToPlane(int uID, int PlaneID);
        /// <summary>
        /// Extrudes selected entities by projection to the specified ordinate on a coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExtrudeByProjectionToUCS(int uID, int UCSId, int UCSPlane, double Ordinate);
        /// <summary>
        /// Extrudes selected entities by projection to the faces of predefined entities.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExtrudeByProjectionToEntityFace(int uID, int CollectionID);
        /// <summary>
        /// Extrudes selected entities by thickness.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExtrudeByThickness(int uID, double Thickness, int BeamDir, int PlateSurface, byte UsePlateThickness, byte SourceMidPlane);
        /// <summary>
        /// Extrudes selected entities along a line.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExtrudeByLine(int uID, int CollectionID, int Divisions, int Direction, double RotationAngle, double RadialScale);
        /// <summary>
        /// Extrudes selected entities to a fixed ordinate in a given axis of a coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ExtrudeToAbsolute(int uID, double Value, int UCSId, int Axis);
        /// <summary>
        /// Scales selected entities by a Cartesian coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ScaleByCartesianUCS(int uID, int UCSId, int ScaleAbout, double[] Factors, double[] Point);
        /// <summary>
        /// Scales selected entities by a cylindrical coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ScaleByCylindricalUCS(int uID, int UCSId, int ScaleAbout, double[] Factors, double[] Point, double AngularCentre);
        /// <summary>
        /// Scales the radius of selected entities in a spherical coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ScaleBySphericalUCS(int uID, int UCSId, double Factor);
        /// <summary>
        /// Scales the radius of selected entities in a toroidal coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ScaleByToroidalUCS(int uID, int UCSId, double Factor);
        /// <summary>
        /// Scales the radius of selected node and elements in a spherical coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ScaleByTaper(int uID, int UCSId, int LineID, int Axis, double Scale1, double Scale2);
        /// <summary>
        /// Grafts edges to geometry faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GraftEdgesToFaces(int uID, int DistanceType, double Distance);
        /// <summary>
        /// Intersects the edges of geometry faces placing a vertex at the intersection point.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7IntersectEdges(int uID, int DistanceType, double Distance, byte SplitFaces);
        /// <summary>
        /// Morphs the selected edges of geometry faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MorphEdges(int uID);
        /// <summary>
        /// Splits a geometry face between pairs of vertices.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SplitFaceByVertices(int uID, int NumVertexSets, int[] VertexSetData);
        /// <summary>
        /// Splits a geometry face at a plane.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SplitFaceByPlane(int uID, int PlaneID, int NumCutFaces, int NumRepeats, double Increment);
        /// <summary>
        /// Converts one or more plate elements to geometric faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7FaceFromPlate(int uID, byte NodeAttribToVertices, byte PlateAttribToFaces, byte CircularFaceEdges);
        /// <summary>
        /// Converts one or more beam polygons to geometric faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7FaceFromBeamPolygon(int uID, int FaceNum, int PropNum, double EdgeTol, byte BeamPropAsLoop, byte BeamGroupAsLoop);
        /// <summary>
        /// Converts one or more geometry face cavity loops to geometric faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7FaceFromCavity(int uID);
        /// <summary>
        /// Redefines the parametric space of NURBS geometry faces to improve mesh quality using parameters determined by Strand7.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7RebuildFaces(int uID);
        /// <summary>
        /// Redefines the parametric space of NURBS geometry faces to improve mesh quality using specified parameters.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7RebuildFacesUV(int uID, int DegreeU, int DegreeV, int ControlPointsU, int ControlPointsV);
        /// <summary>
        /// Converts the selected geometry faces to NURBS.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ConvertToNURBS(int uID);
        /// <summary>
        /// Extracts a mid-plane geometry from thin solids defined by a collection of faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MidPlaneThinSolids(int uID, double NormalsTol);
        /// <summary>
        /// Delete all the cavity loops within the selected faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DeleteCavityLoops(int uID);
        /// <summary>
        /// Detach selected geometry faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DetachFaces(int uID, int DetachMode);
        /// <summary>
        /// Inserts vertices at prescribed positions along an edge.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsertVerticesOnEdge(int uID, int EdgeID, int NumVertex, int VertexType, double[] Positions);
        /// <summary>
        /// Divides selected edges into the specified number of equal segments by inserting evenly spaced vertices.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SubdivideEdges(int uID, int Divisions, int VertexType);
        /// <summary>
        /// Subdivides selected elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7Subdivide(int uID, int DivsA, int DivsB, int DivsC, int PlateTarget, int BrickTarget);
        /// <summary>
        /// Grades selected elements. See Grade Types for additional information.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7Grade(int uID, int GradeType, double GradeRatio);
        /// <summary>
        /// Cuts selected beams and plates along a line.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CutElementsByLine(int uID, int LineID, int EdgeTol, int BeamPropNum, int PlatePropNum);
        /// <summary>
        /// Cuts selected beams and plates through a plane.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CutElementsByPlane(int uID, int PlaneID, int EdgeTol, int BeamPropNum, int PlatePropNum);
        /// <summary>
        /// Cuts selected beams and plates at a given radius.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CutElementsByUCS(int uID, int UCSId, int EdgeTol, int BeamPropNum, int PlatePropNum, double Radius);
        /// <summary>
        /// Splits the selected beams by a defined ratio.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SplitBeams(int uID, double SplitRatio, int SplitType);
        /// <summary>
        /// Subdivides the selected beams so they are as close as possible to the target length.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SubdivideBeams(int uID, double Length);
        /// <summary>
        /// Transitions selected beams from one property to another by interpolating section dimensions. Creates new beam properties if required.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InterpolateBeamSections(int uID, int PropNum1, int PropNum2, int Divisions);
        /// <summary>
        /// Intersects selected beams and links with selected beams, plate edges, brick edges and links. Nodes are created at found intersections, and the selected beams and links can optionally be split where these intersections are found.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7IntersectBeamsAndLinks(int uID, double MaxGap, double MinAngle, byte SplitBeams, byte SplitLinks, byte ConsiderEdgeMidsideNode);
        /// <summary>
        /// Generates cross beams and/or surfaces of plates across a set of lofting planes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7LoftBeams(int uID, int CrossBeamPropNum, int PlatePropNum, int NumSteps, int NumSubSteps, byte MakeCrossBeams, byte MakePlates);
        /// <summary>
        /// Cuts selected beams that pass through a plane, and inserts beams on plate edges that lie on the plane.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SliceOnPlane(int uID, int PlaneID, int PropNum, int NumRepeats, double Increment, byte DoBeams, byte DoPlates);
        /// <summary>
        /// Replaces a corner between selected plates with filleted Quad8 elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7FilletPlates(int uID, double Radius, byte StitchPlates);
        /// <summary>
        /// Generates a midplane mesh between two surfaces of selected plates. Two separate sets of plates should be selected prior to this call.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MidPlanePlateProjection(int uID, int PlateNum);
        /// <summary>
        /// Repairs meshes of selected Tri3 plate elements by removing sliver and slit elements that have internal angles less than a set angular tolerance. The tool is typically used to improve the geometry of imported STL files, particularly when these need to be solid automeshed into tetrahedral elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7RepairTri3Mesh(int uID, double MaxAngle);
        /// <summary>
        /// Detaches the selected cluster of elements from the rest of the mesh by duplicating nodes at the boundary and optionally connecting the duplicated nodes with links or beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7DetachElements(int uID, int[] Integers);
        /// <summary>
        /// Generates a line of nodes or beam elements on a straight line between the two end points, P1 and P2.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLLine2(int uID, double[] P1, double[] P2, int NumSteps);
        /// <summary>
        /// Generates a line of nodes or beam elements on a parabola passing through three points, P1, P2 and P3.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLParabola3(int uID, double[] P1, double[] P2, double[] P3, int NumSteps);
        /// <summary>
        /// Generates two perpendicular lines. A straight line is created between P2-P3. The second line is created from P1 to a new node on P2-P3 such that the second line is perpendicular to P2-P3.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLNormal3(int uID, double[] P1, double[] P2, double[] P3);
        /// <summary>
        /// Finds the centre of a circle with radius R such that a straight line between P1 and P2 is tangent to the circle and touches the circle at P1. P3 is necessary to define the plane of the circle. The line between P1 and the centre of the circle will be normal to the line between P1 and P2.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLNormal3R(int uID, double[] P1, double[] P2, double[] P3, double Radius, int NumSteps);
        /// <summary>
        /// Extends a line by the distance R and generates a node at the new end of the line. The line is defined by two points, P1 and P2.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLExtend2R(int uID, double[] P1, double[] P2, double Radius, int NumSteps);
        /// <summary>
        /// Creates a point such that its coordinates are the average of P1 and P2 in the prescribed coordinate system.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLAverage2(int uID, double[] P1, double[] P2, int UCSId);
        /// <summary>
        /// Generates a line of nodes or beam elements along a circular arc. The arc is located such that the two intersecting straight lines are tangents to the arc. The arc forms a fillet between the lines. The lines are defined using three points. P3 is the intersection of the two lines. Two other points are also required, one on each of the two lines. The three nodes defining the lines may not be collinear.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLFillet3R(int uID, double[] P1, double[] P2, double[] P3, double Radius, int NumSteps);
        /// <summary>
        /// Generates a line of nodes or beam elements along a circular arc. The arc is located such that the two intersecting straight lines are tangents to the arc. The arc forms a fillet between the lines. The lines are defined using four points. Points P1 and P2 define the first line and points P3 and P4 define the second line. The four points must be co-planar.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLFillet4R(int uID, double[] P1, double[] P2, double[] P3, double[] P4, double Radius, int NumSteps);
        /// <summary>
        /// Generates a line of nodes and/or beam elements around the circumference of a circle. P1 defines the centre of the circle, P2 is a point on the circumference of the circle and P3 is used to define the plane of the circle.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLCircleO3(int uID, double[] P1, double[] P2, double[] P3, int NumSteps, byte FullCircle);
        /// <summary>
        /// Generates a line of nodes and/or beam elements around an ellipse. The ellipse is centred at P1 and passes through P2 and P3.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLEllipseO3(int uID, double[] P1, double[] P2, double[] P3, int NumSteps, byte FullCircle);
        /// <summary>
        /// Generates a line of beam elements or nodes around a variable radius curve. The curve is centred at P1. The radius spirals from P2 to P3. It is similar to an ellipse.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLCurve3(int uID, double[] P1, double[] P2, double[] P3, int NumSteps);
        /// <summary>
        /// Generates a line of nodes and/or beam elements around the circumference of a circle. The circle is defined by three points on the circumference.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLCircleC3(int uID, double[] P1, double[] P2, double[] P3, int NumSteps, byte FullCircle);
        /// <summary>
        /// Two circles are defined and the two lines that are tangent to both circles are found. Four new nodes are generated, two on each of the circles (at the intersection between the tangent lines and the circles). The two circles are defined by centres P1 and P2, and radii R1 and R2 respectively. P3 is used to define the plane of the two circles.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLCirclesTangent3R(int uID, double[] P1, double[] P2, double[] P3, double R1, double R2);
        /// <summary>
        /// Generates a new node at the intersection of two lines. Each of the two lines is defined by two points, P1-P2 for line 1 and P3-P4 for line 2. All four nodes must lie on the same plane. If this is not the case then the message "Intersection not found" will be displayed.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLIntersect4(int uID, double[] P1, double[] P2, double[] P3, double[] P4);
        /// <summary>
        /// Locates the intersection between a circe and a tangent. The circle is defined by a single point, P1, and a radius R1. The line is assumed to be tangent to the circle and to pass through P2. P3 is used to define the plane of the circle.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLCircleTangent3R(int uID, double[] P1, double[] P2, double[] P3, double Radius);
        /// <summary>
        /// Finds the centre of a circle. A new node is generated at this location. The circle is defined by three points on the circumference.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLCircleCentre3(int uID, double[] P1, double[] P2, double[] P3);
        /// <summary>
        /// Generates two new nodes at the points where two overlapping circles intersect. The centre of each circle is defined using P1 and P2. The radius of each circle is defined by R1 and R2 respectively. P3 is used to define the plane of the two circles. Note that in the special case where the points P1 and P2 are R1+R2 apart, only one point is generated.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLCirclesIntersect3R(int uID, double[] P1, double[] P2, double[] P3, double R1, double R2);
        /// <summary>
        /// Generates a circular arc fillet between a straight line and a circle. The circle is defined by P1, at the centre and a radius R1. The line is defined by P2 and P3. The radius of the fillet is specified as R2.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLCircleLineInnerFillet3R(int uID, double[] P1, double[] P2, double[] P3, double R1, double R2, int NumSteps, byte FullCircle);
        /// <summary>
        /// Generates a circular arc fillet (or full circle) between a straight line and a circle. The radius of the arc can be set. The main circle is defined by point P1 and radius R1. The straight line is defined by points P2-P3. The arc has fillet radius R2. Note that R1 must be greater than R2.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLCircleLineOuterFillet3R(int uID, double[] P1, double[] P2, double[] P3, double R1, double R2, int NumSteps, byte FullCircle);
        /// <summary>
        /// Generates two nodes at the intersection between a circle and a straight line (except in the case where the line is a tangent to the circle in which case only one point is generated). The circle is defined by a point at the centre, P1, and a radius R. The line is defined by two points, P2 and P3. If one of these points lies inside the circle, the line is extended to find the second point of intersection.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLCircleLineIntersect3(int uID, double[] P1, double[] P2, double[] P3, double Radius);
        /// <summary>
        /// Generates a line of beams or nodes on a circular fillet between two circles. The fillet touches each of the two circles at a single tangent point. The two circles are defined by centres P1 and P2 and radii R1 and R2 respectively. A third point, P3, is used to define the plane of the circles. The radius of the fillet is specified as R3.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PLCirclesFillet3R(int uID, double[] P1, double[] P2, double[] P3, double R1, double R2, double R3, int NumSteps, byte FullCircle);
        /// <summary>
        /// Creates a rigid link cluster between selected nodes, such that they act as a rigid body.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateRigidLinkCluster(int uID, int UCSId, int Axis, int NodeNum);
        /// <summary>
        /// Creates a pinned link cluster between selected nodes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreatePinnedLinkCluster(int uID, int NodeNum);
        /// <summary>
        /// Creates a master-slave link cluster between selected nodes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateMasterSlaveLinkCluster(int uID, int UCSId, int DoFBits, int NodeNum);
        /// <summary>
        /// Creates a sector-symmetry links that couple nodes on angular planes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateSectorSymmetryLinkCluster(int uID, int Axis, double Plane1, double Plane2, double RadialTol, double AngularTol);
        /// <summary>
        /// Creates an interpolated multi-point link cluster between selected nodes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateInterpolatedMultiPointLink(int uID, int Couple, int NodeNum);
        /// <summary>
        /// Creates a rigid multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateRigidMultiPointLink(int uID, int UCSId, int Axis, int NodeNum);
        /// <summary>
        /// Creates a pinned multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreatePinnedMultiPointLink(int uID, int NodeNum);
        /// <summary>
        /// Creates a master-slave multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateMasterSlaveMultiPointLink(int uID, int UCSId, int DoFBits, int NodeNum);
        /// <summary>
        /// Creates a reaction multi-point link.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateReactionMultiPointLink(int uID, int SetNum, int OriginCode, double[] Origin);
        /// <summary>
        /// Creates equivalent individual links from selected Rigid, Pinned and Master-Slave multi-point links.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateLinksFromMultiPointLink(int uID, byte DeleteMPL);
        /// <summary>
        /// Creates beams on selected plate edges and brick faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateBeamsOnElementEdges(int uID, int PropNum, int QuadraticAs, int BasedOn, double FacetAngle, byte FreeEdges, byte TJunctions, byte PropBoundary, byte GroupBoundary, byte InternalBricks);
        /// <summary>
        /// Creates beams on selected geometry edges.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateBeamsOnGeometryEdges(int uID, int PropNum, int GeometryAs);
        /// <summary>
        /// Creates plates on selected brick faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreatePlatesOnBricks(int uID, byte FreeFacesOnly, byte AllowDuplicates);
        /// <summary>
        /// Creates User Coordinate Systems on selected entities.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateEntityUCS(int uID, int CurvedPipeAxis, int BeamAxis, int OriginLocation, byte OriginNode);
        /// <summary>
        /// Creates Load Patch plate elements on selected beam frameworks.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateLoadPatches(int uID, double PlaneTol, byte TriangularLoad, byte UseBeamGroup);
        /// <summary>
        /// Generates attachment links based on the pre-defined attachment attributes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateAttachments(int uID, int BrickTarget, double AngleDelta, byte DeleteExisting);
        /// <summary>
        /// Locates nodes on the three global XYZ symmetry planes (that is, X=0, Y=0 or Z=0) and assigns appropriate symmetry restraints to them.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateCartesianSymmetryRestraints(int uID, int FreedomCase);
        /// <summary>
        /// Locates nodes on the two angular planes specified and assigns appropriate symmetry restraints to them.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CreateCylindricalSymmetryRestraints(int uID, int Axis, int FreedomCase, double Theta1, double Theta2, double AngularTol);
        /// <summary>
        /// Merges pairs of selected adjacent elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MergeElementPairs(int uID, byte Quadratic);
        /// <summary>
        /// Merges lines of beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MergeLineOfBeams(int uID, double AngleTol, int AngleMode);
        /// <summary>
        /// Merges triangular plates into quadrilateral plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7MergeTriToQuad(int uID, double MinInternalAngle, double MaxInternalAngle, double MaxNormalAngle);
        /// <summary>
        /// Converts selected beams into links.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ConvertBeamsToLinks(int uID, int LinkType, int LinkOption, int CaseID);
        /// <summary>
        /// Converts selected links into beams.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ConvertLinksToBeams(int uID, int PropNum);
        /// <summary>
        /// Moves selected offset beams to their spatial locations, sets the offset attributes to zero, and connects the beams to their original nodes via rigid links.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ConvertBeamOffsetsToRigidLinks(int uID);
        /// <summary>
        /// Converts load patches in the specified load case to distributed beam loads.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ConvertPatchLoads(int uID, int CaseNum, byte Overwrite);
        /// <summary>
        /// Simulates the conversion of load patches to distributed beam loads in the specified load case without actually generating the beam loads. This allows the developer to determine which load patches can successfully transfer loads and which may require adjustment. This can be done by examining the global parameters to check for load patch plate edges that remain selected after the function has been called; edges that remain selected are those at which the load could not be transferred to beam elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CheckPatchLoads(int uID, int CaseNum);
        /// <summary>
        /// Converts selected load paths to load cases.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ConvertLoadPathsToLoadCases(int uID, byte PointForces, byte DistributedForces, byte HeatSources);
        /// <summary>
        /// Converts selected beam polygons into plates. Beam polygons can have three or four sides.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ConvertBeamPolygonsToPlates(int uID, double MinInternalAngle, double MaxInternalAngle, double MaxNormalAngle, byte CreateQuad4);
        /// <summary>
        /// Adjusts the mid-side nodes of selected elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AdjustMidsideNodes(int uID, byte MakeStraight);
        /// <summary>
        /// Smooths the selected plate elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7SmoothPlates(int uID, int UCSId, byte SmoothBoundary);
        /// <summary>
        /// Renumber mesh nodes using the Tree algorithm.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ReorderNodesTree(int uID, int StartNodeNum);
        /// <summary>
        /// Renumber mesh nodes using the Geometry algorithm.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ReorderNodesGeometry(int uID, double[] DXYZ);
        /// <summary>
        /// Renumber mesh nodes using the AMD algorithm.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ReorderNodesAMD(int uID);
        /// <summary>
        /// Place attachment links in the same groups as the elements to which they attach, as required for a staged analysis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7CorrectAttachmentLinkGroups(int uID);
        /// <summary>
        /// Removes free nodes from selected multi-point links.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7TrimMultiPointLinks(int uID);
        /// <summary>
        /// Assign offsets to selected beams to shift the node location to some point on the cross section.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7BeamOffsetsByCrossSection(int uID, int[] Offsets);
        /// <summary>
        /// Aligns the local axes of selected beams to the axes of the specified UCS.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AlignBeamAxesToUCS(int uID, int BeamAxis, int BeamAxisType, int UCSAxis, int UCSId, double AngleTol, byte KeepEndAttributeLocation);
        /// <summary>
        /// Aligns the selected beams with a notional surface that spans the beam framework.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AlignBeamAxesToFramework(int uID, int BeamAxis, int BeamAxisType, byte PositiveDir);
        /// <summary>
        /// Aligns the selected beams with the plates they are connected to.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AlignBeamAxesToPlate(int uID, int BeamAxis, int BeamAxisType, byte PositiveDir);
        /// <summary>
        /// Aligns an axis of the selected beams with a given vector.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AlignBeamAxisToVector(int uID, int BeamAxis, int BeamAxisType, double AngleTol, double[] Vector);
        /// <summary>
        /// Converts selected Beam3 elements into Beam2 elements with Principal Axis Angle attributes to provide the equivalent orientation.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7RemoveBeamReferenceNode(int uID);
        /// <summary>
        /// Offsets selected plate elements to one of the plate surfaces, based on the plate thickness.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7PlateOffsetByThickness(int uID, int Surface);
        /// <summary>
        /// Aligns the local axes of selected plates with the axis of the specified UCS.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AlignPlateAxesToUCS(int uID, int PlateAxis, int UCSAxis, int UCSId, double AngleTol);
        /// <summary>
        /// Aligns the normals on selected and connected plate elements such that their normals are consistent with the master element. The master element must be connected to the selected elements.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AlignPlateNormalByConnection(int uID, int PlateNum);
        /// <summary>
        /// Aligns the concrete reinforcement attribute of the selected plates.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AlignPlateRCDirectionsToUCS(int uID, int RCLayers, int UCSAxis, int UCSId, double AngleTol);
        /// <summary>
        /// Aligns the normals of selected faces such that they have consistent normal, based on a master face. The master face must be connected to the selected faces.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AlignFaceNormalByConnection(int uID, int FaceNum);
        /// <summary>
        /// Aligns selected beams such that they have a consistently aligned three axis.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AlignBeam3AxisByConnection(int uID, byte KeepEndAttributeLocation);
        /// <summary>
        /// Aligns selected plates such that they have a consistently aligned local axes.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7AlignPlateAxesByConnection(int uID, int PlateNum, double MaxShearAngle);
        /// <summary>
        /// Rotates the selected plate elements by reordering the nodes. This effectively swaps the A and B directions in St7Subdivide.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7RotatePlateConnections(int uID, byte Clockwise);
        /// <summary>
        /// Flips the orientation of selected entities.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7FlipEntity(int uID);
        /// <summary>
        /// Inverts the normal direction of selected load paths. The ends of the path are not flipped.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InvertPathNormal(int uID);
        /// <summary>
        /// Returns the options used in the last execution of St7InsituStress.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetInsituStressOptions(int uID, int[] Integers, double[] Doubles);
        /// <summary>
        /// Generates the soil in-situ stress distribution.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7InsituStress(int uID, int Mode, int Wait, int[] Integers, double[] Doubles, ref int ProcessID, ref int WarningCode);
        /// <summary>
        /// Returns a global integer state variable, which is internal to the Strand7 application.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGlobalIntegerValue(int Index, ref int Value);
        /// <summary>
        /// Returns a global logical variable, which is internal to the Strand7 application.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGlobalLogicalValue(int Index, ref byte Value);
        /// <summary>
        /// Returns a global string, which is internal to the Strand7 application.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetGlobalStringValue(int Index, StringBuilder Value, int MaxStringLen);
        /// <summary>
        /// Resets all the global integer values returned by St7GetGlobalIntegerValue to zero.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ClearGlobalIntegerValues();
        /// <summary>
        /// Resets all the global logical values returned by St7GetGlobalLogicalValue to False.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ClearGlobalLogicalValues();
        /// <summary>
        /// Resets all the global string values returned by St7GetGlobalStringValue to empty strings.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ClearGlobalStringValues();
        /// <summary>
        /// Generates the Strand7 24-bit colour representation for a colour defined by its RGB components. See also RGB Colours.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7RGBToColour(double Red, double Green, double Blue, ref int Colour);
        /// <summary>
        /// Extracts the RGB components from a Strand7 24-bit colour representation. See also RGB Colours.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ColourToRGB(int Colour, ref double Red, ref double Green, ref double Blue);
        /// <summary>
        /// Returns the number of Gauss points used to store result quantities for the specified entity type.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7GetNumElementResultGaussPoints(int Entity, int NumNodes, ref int NumGauss);
        /// <summary>
        /// Converts element nodal results to Gauss point results via interpolation. It is important to specify the un-averaged nodal quantities in order to capture the true element Gauss point values.
        /// </summary>
        [DllImport("St7API.dll")]
        public static extern int St7ConvertElementResultNodeToGaussPoint(int Entity, int NumNodes, int NumColumns, double[] NodeDoubles, ref int NumGauss, double[] GaussDoubles);
    }
}
