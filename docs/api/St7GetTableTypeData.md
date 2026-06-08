# St7GetTableTypeData

all uniquely identify tables by means of their TableType parameter (listed above) and TableID.

Functions that pass a TableID parameter always assume a given TableType is being passed. Usually a given
function parameter will only set a given table type. In the case of St7SetPropertyTable and St7GetPropertyTable,
the assumed type depends on the parameter PropTableType. The constants to define this parameter are listed
below, along with the TableType they are setting.

PropTableType

Table Type

Information

ptBeamStiffModVsTemp

Factor vs temperature

Beam Modulus or Stiffness vs Temperature

ptBeamAlphaVsTemp

Factor vs temperature

Beam Thermal Expansion vs Temperature

Table Types

ptBeamConductVsTemp

Factor vs temperature

Beam Conductivity vs Temperature

ptBeamCpVsTemp

Factor vs temperature

Beam Specific Heat vs Temperature

ptBeamStiffModVsTime

Factor vs time

Beam Modulus or Stiffness vs Time

ptBeamConductVsTime

Factor vs time

Beam Conductivity vs Time

ptSpringAxialVsDisp

Force vs Displacement

Spring Axial Force vs Displacement

ptSpringTorqueVsTwist  Moment vs Rotation

Spring Torque vs Angle of Twist

ptSpringAxialVsVelocity  Force vs Velocity

Spring Axial Force vs Velocity

ptBeamStressVsStrain

Stress vs Strain

Beam Stress vs Strain

ptBeamMomentK1

ptBeamMomentK2

Moment vs Curvature

Beam Moment vs Curvature Plane 1

Moment vs Curvature

Beam Moment vs Curvature Plane 2

ptConnectionShear1

Force vs Displacement

Connection Translation Stiffness 1

ptConnectionShear2

Force vs Displacement

Connection Translation Stiffness 2

ptConnectionAxial

Force vs Displacement

Connection Translation Stiffness 3

ptConnectionBend1

Moment vs Rotation

Connection Rotation Stiffness 1

ptConnectionBend2

Moment vs Rotation

Connection Rotation Stiffness 2

ptConnectionTorque

Moment vs Rotation

Connection Rotation Stiffness 3

ptBeamYieldVsTemp

Factor vs Temperature

Beam Yield vs Temperature

ptPlateModVsTemp

Factor vs Temperature

Plate Modulus vs Temperature

ptPlateAlphaVsTemp

Factor vs Temperature

Plate Thermal Expansion vs Temperature

ptPlateConductVsTemp

Factor vs Temperature

Plate Conductivity vs Temperature

ptPlateCpVsTemp

Factor vs Temperature

Plate Specific Heat vs Temperature

ptPlateModVsTime

Factor vs time

Plate Modulus vs Time

ptPlateConductVsTime

Factor vs time

Plate Conductivity vs Time

ptPlateStressVsStrain

Stress vs Strain

Plate Stress vs Strain

ptPlateYieldVsTemp

Factor vs Temperature

Plate Yield vs Temperature

ptBrickModVsTemp

Factor vs Temperature

Brick Modulus vs Temperature

ptBrickAlphaVsTemp

Factor vs Temperature

Brick Thermal Expansion vs Temperature

ptBrickConductVsTemp

Factor vs Temperature

Brick Conductivity vs Temperature

ptBrickCpVsTemp

Factor vs Temperature

Brick Specific Heat vs Temperature

ptBrickModVsTime

Factor vs time

Brick Modulus vs Time

ptBrickConductVsTime

Factor vs time

Brick Conductivity vs Time

ptBrickStressVsStrain

Stress vs Strain

Brick Stress vs Strain

ptBrickYieldVsTemp

Factor vs Temperature

Brick Yield vs Temperature

Strand7 API Manual

Solver Options

Solver Types

Strand7 offers the following solvers:

stLinearStatic

stLinearBuckling

stLoadInfluence

stNonlinearStatic

stQuasiStatic

stNaturalFrequency

stHarmonicResponse

stSpectralResponse

stLinearTransientDynamic

Linear static analysis for displacement and stress.

Linear elastic buckling of structures subjected to internal forces
calculated using one of stLinearStatic, stNonlinearStatic or stQuasiStatic.

Linear influence surface calculation for displacement, force, moment and
stress variables.

Nonlinear static analysis for displacement and stress. Nonlinearity can be
material, geometric and contact.

Nonlinear quasi-static response of structures subject to constant or
time-varying loads. Nonlinearity can be material, geometric and contact.

Undamped natural frequencies of structures, with or without internal
forces; internal forces calculated using one of stLinearStatic,
stNonlinearStatic or stQuasiStatic.

Dynamic steady state response of structures subjected to sinusoidal
excitations (external forces, base displacement, base velocity or base
acceleration) using modal superposition of modes calculated using
stNaturalFrequency.

Spectral response of structures due to loading defined by way of a
frequency response spectrum, using modal superposition of modes
calculated using stNaturalFrequency.

Linear dynamic response of structures subject to constant or time-
varying loads, using either full system integration or modal superposition
of modes calculated using stNaturalFrequency.

stNonlinearTransientDynamic  Nonlinear dynamic response of structures subject to constant or time-

varying loads, using full system integration. Nonlinearity can be material,
geometric and contact.

stSteadyHeat

stTransientHeat

Solver Modes

Steady state linear or nonlinear heat transfer analysis of structures for
conduction, convection and radiation.

Transient linear or nonlinear heat transfer analysis of structures for
conduction, convection and radiation with time dependent material and
boundary conditions.

Solvers may be launched by the Strand7 API in one of several modes, relating to the creation and display of a
solver window. These inputs, used by St7InsituStress, St7RunSolver and St7RunSolverProcess, are described below.

Solver Options

smBackgroundRun

 No solver dialog is created, process terminates on completion.

smNormalCloseRun

 Full solver dialog is displayed, process terminates on completion.

smNormalRun

 Full solver dialog is displayed, process waits for manual termination.

smProgressRun

 Solver progress bar is displayed, process terminates on completion.

Result Types

It is possible to control which of the calculated results are written to the result file, using the functions
St7SetEntityResult and St7GetEntityResult.

Mechanical solvers

srNodeAcceleration

Node acceleration.

srNodeInertia

Node inertia force; applicable to harmonic response and spectral response.

srNodeReaction

Node reaction.

srNodeVelocity

Node velocity.

srBeamForce

Beam force.

srBeamMNLStress

Beam MNL stresses.

srBeamStrain

Beam strain.

srPlateStress

Plate stress.

srPlateStrain

Plate strain.

srBrickStress

Brick stress.

srBrickStrain

Brick strain.

srElementNodeForce

Element node force.

srLinkForce

Link node force.

Heat solvers

hrNodeFlux

 Node heat flux.

hrBeamFlux

 Beam heat flux.

hrPlateFlux

 Plate heat flux.

Strand7 API Manual

hrBrickFlux

 Brick heat flux.

hrLinkFlux

 Link heat flux.

Modal solvers

frBeamForcePattern

 Beam force pattern.

frBeamStrainPattern

 Beam strain pattern.

frPlateStressPattern

 Plate stress pattern.

frPlateStrainPattern

 Plate strain pattern.

frBrickStressPattern

 Brick stress pattern.

frBrickStrainPattern

 Brick strain pattern.

Solver Parameters

Solver defaults in Strand7 are set under the SOLVERS tab. These defaults fall into three categories of information;
logical flags (checkboxes), integer parameters (fields setting an integer) or double parameters (fields accepting a
real number).

Logical Parameters

The functions St7SetSolverDefaultsLogical and St7GetSolverDefaultsLogical may be used to manipulate the logical
solver parameters indicated by the constants below.

spAddKg

spAllowExtraIterations

spAppendRemainingTime

spAutoNewmarkAlpha

Applies to geometric nonlinear analysis.  If True, the geometric or
stress stiffness matrix, KG, is added to the global stiffness matrix to
form a tangent stiffness matrix.

Applies to the nonlinear solvers. If True, extra iterations beyond
spMaxIterationNonlin are allowed when the solution is convergent
but not yet converged.

Applies to the time-based solvers when continuing a previous
analysis. If True, the remaining time in the time table, depending on
the restart time, is used to continue the analysis.  If False, the entire
time table is appended to the continuing analysis.

Applies to transient dynamic analysis with the Newmark method. If
True, the Newmark Alpha parameter is calculated automatically from
the Beta parameter.  If False, a user-specifed value of Alpha is used.

spAutoPCGIterations

If True, the maximum number of PCG iterations when using the PCG
solver scheme is automatically set.

Solver Options

spAutoScaleKg

spAutoShift

spAutoWorkingSet

spCablesAsMultiCase

Applies to geometric nonlinear analysis.  If True, the geometric
stiffness matrix, KG, is automatically scaled to help improve
convergence, where necessary.

Applies to natural frequency analysis.  If True, a frequency shift is
automatically applied when rigid body motion is detected.

Applies to natural frequency and linear buckling analysis.  If True, the
working set of eigenvectors available for subspace iteration is
automatically expanded.

Applies to cables in linear static analysis.  If True, a global stiffness
matrix is assembled for each load case, solving one load case at a
time.  Each assembly calculates the stiffness of the cable based on the
loads in that load case.  If False, a single global stiffness matrix is
assembled for all load cases, with the cable stiffness calculated from a
single specified load case; this cable stiffness is used for all the
considered load cases.

spCalcDampingRatios

Applies to natural frequency analysis.  If True, damping ratios are
calculated for each mode and reported in the solver log file.

spCheckEigenvector

spDampingForce

spDoInstantNTA

Applies to natural frequency and linear buckling analysis.  If True,
iteration continues until both the eigenvalue and the eigenvector are
converged.  If False, iteration continues only until the eigenvalue is
converged.

Applies to transient dynamic analysis.  If True, the internal damping
forces due to viscous and Rayleigh damping are added to the nodal
reactions.

Applies to nonlinear transient dyanamic analysis with creep.  If True,
the quasi-static initial stress state is established before commencing
the time-based analysis.

spDoResidualsCheck

Applies to linear staic analysis.  If True, a residuals check is performed
to assess the equilibrium of the solution.

spDoSturm

spExcludeMassX

spExcludeMassY

Applies to natural frequency and linear buckling analysis.  If True, a
Sturm check is performed at the end of the eigenvalue extraction
procedure to detect whether any modes are missing from the
calculated set.

Applies to dynamic analysis. If True, mass components in the global X
direction of the mass matrix are set to zero.

Applies to dynamic analysis. If True, mass components in the global Y
direction of the mass matrix are set to zero.

Strand7 API Manual

spExcludeMassZ

Applies to dynamic analysis. If True, mass components in the global Z
direction of the mass matrix are set to zero.

spForceSingularityCheck

Applies to the structural solvers. If True, the presence of singularities
in the global stiffness matrix is detected before factorising the matrix.

spFullSystemTransient

Applies to linear transient dynamic analysis.  If True, full system
integration is used.  If False, modal superposition is used.

spIgnoreCompressiveBeamKg

Applies to geometric nonlinear analysis.  If True, the geometric
stiffness matrix, KG, is not added for beam elements in compression.

spIncludeFollowerLoadKG

spIncludeLinkReactions

Applies to linear buckling analysis.  If True, the geometric stiffness due
to follower loads is added to the global geometric stress stiffness
matrix, KG.

For the structural solvers, if True, nodal forces due to links are added
to the nodal reactions.  For the heat solvers, if True, nodal flux due to
links is added to the nodal reactions.

spIncludeRotationalMass

Applies to dynamic analysis. If True, rotational mass components in
the global mass matrix are included.  If False, they are set to zero.

spInertiaForce

spLegacyMaxStress

spLimitDisplacementNLA

spLimitRotationNLA

spLumpedLoadBeam

Applies to transient dynamic analysis.  If True, the internal forces due
to inertia are added to the nodal reactions.

Use legacy material model for Max Stress materials (not
recommended).

Applies to the nonlinear solvers.  If True, an upper limit of
displacement, set by spMaxDisplacementNLA, is imposed in the
analysis. If this displacement is exceeded, the solver will terminate
either immediately or at the end of the current step or sub-step,
depending on the state of spSaveFinalSubStep.

Applies to the nonlinear solvers.  If True, an upper limit of rotation,
set by spMaxRotationNLA, is imposed in the analysis. If this rotation is
exceeded, the solver will terminate, either immediately or at the end
of the current step or sub-step, depending on the state of
spSaveFinalSubStep.

Applies to the structural solvers.  If True, loads applied to beam
elements will be represented by a simplified lumped nodal force
vector. If False, a consistent nodal vector containing forces and
moments will be used.

spLumpedLoadPlate

Applies to the structural solvers.  If True, loads applied to plate
elements will be represented by a simplified lumped nodal force

Solver Options

spLumpedMassBeam

spLumpedMassBrick

spLumpedMassPlate

vector. If False, a consistent nodal vector containing forces and
moments will be used.

If True, the mass matrix for beam elements will be represented by a
lumped diagonal matrix. If False, a consistent, non-diagonal mass
matrix will be used.

If True, the mass matrix for brick elements will be represented by a
lumped diagonal matrix. If False, a consistent, non-diagonal mass
matrix will be used.

If True, the mass matrix for plate elements will be represented by a
lumped diagonal matrix. If False, a consistent, non-diagonal mass
matrix will be used.

spNonlinearGeometry

Applies to the nonlinear structural solvers.  If True, geometric
nonlinearity is considered in the analysis.

spNonlinearHeat

Applies to the heat solvers.  If True, nonlinearity is considered in the
analysis.

spNonlinearMaterial

Applies to the nonlinear structural solvers.  If True, material
nonlinearity is considered in the analysis.

spPredictImpact

spReducedLogFile

spSaveCQCSpectral

spSaveFinalSubStep

spSaveIntermediate

spSaveLastRestartStep

Applies to nonlinear transient dynamic analysis.  If True, additional
time steps are inserted near contact activation events to help improve
the capture of the contact event.

If True, the solver log file will limit the number of times the same
warning or note is generated.  The limit is set by
spMaxNumRepeatedMessages.  If False, all warnings and notes are
generated.

Applies to spectral response analysis.  If True, the CQC spectral results
are generated and stored in the result file.

When spLimitDisplacementNLA or spLimitRotationNLA are set, by also
setting spSaveFinalSubStep to True the final sub-step in the analysis
will be saved to the result file.  If False, that sub-step will not be saved
as the solver will terminate immediately.

Applies to the nonlinear solvers.  If True, the results of sub-steps
generated by any of the automatic sub-stepping options will be stored
in the result file.  If False, the sub-steps will not be stored.

Applies to the nonlinear solvers.  If True, the restart file will contain
only the information required to restart the analysis from the last
saved step.  If False, the restart file will contain the information
required to restart the analysis from any saved step.

Strand7 API Manual

spSaveRestartFile

spSaveSRSSSpectral

spSaveTableInsertedSteps

spScaleSupports

Applies to the nonlinear solvers.  If True, a restart file will be saved
enabling the analysis to be subsequently restarted.

Applies to spectral response analysis.  If True, the SRSS spectral results
are generated and stored in the result file.

Applies to the time-based solvers.  If True, additional time steps are
added to the analysis to coincide with points contained in the time
tables associated with considered load cases.

Applies to nonlinear analysis.  If True, the stiffness of element face
support attributes is scaled, if required to help achieve better
convergence.

spShowConvergenceGraph

If True, the solver window will initially show the convergence graph.

spShowMessages

If True, the solver window will initially show the solver messages.

spShowProgress

If True, the progress bar will initially be shown in the solver window.

spSolverGeneratesCombinations   Applies to linear static analysis.  If True, combinations are generated

by the solver as part of the linear static analysis.

spSpectralBaseExcitation

Applies to spectral response analysis.  If True, base excitation cases
are considered in the analysis.

spSpectralLoadExcitation

Applies to spectral response analysis.  If True, load excitation cases
are considered in the analysis.

spSuppressAllSingularities

If True, all singularities detected in the global stiffness matrix are
artificially suppressed by the addition of a small fictitious stiffness.  If
False, the singularity will cause the solver to terminate with an error.

Integer Parameters

The functions St7SetSolverDefaultsInteger and St7GetSolverDefaultsInteger may be used to manipulate the
integer solver parameters indicated by the constants below.

spBeamKgType

spBeamLength

Applies to geometric nonlinear analysis to set how the beam
geometric stress stiffness matrix, KG, is calculated; either
scSimplifiedBeamKg or scCompleteBeamKg.

Applies to geometric nonlinear analysis to set whether the beam
length is updated or not during the analysis; either
scInitialBeamLength or scUpdatedBeamLength.

Solver Options

spCurveFitTimeUnit

spDynamicAutoStepping

spExpandWorkingSet

Applies to quasi-static and nonlinear transient dynamic analysis when
creep nonlinearity is included: creep curve fit time unit; one of
tuMilliSec, tuSec, tuMin, tuHour or tuDay.

Applies to quasi-static and nonlinear transient dynamic analysis:
dynamic sub-stepping option; one of scDynamicAutoStepNone,
scDynamicAutoStepTime, scDynamicAutoStepDispTime or
scDynamicAutoStepDispDisp.

Applies to linear buckling and natural frequency analysis when
spAutoWorkingSet is False;  additional modes to be included in the
subspace iteration, which can help with convergence.

spFiniteStrainDefinition

Finite strain definition for geometric nonlinear analysis; one of
scFiniteStrainNominal, scFiniteStrainEng, scFiniteStrainGreen.

spFormNonlinHeatStiffMatrix

spFormStiffMatrix

Applies to nonlinear transient heat transfer analysis: matrix update
option; one of scHeatMatrixEveryRow, scHeatMatrixSavedStep or
scHeatMatrixEveryStep.

Applies to the nonlinear structural solvers: stiffness matrix update
option; one of scStiffnessMatrixEveryIteration,
scStiffnessMatrixTwoIterations, scStiffnessMatrixOneIteration,
scStiffnessMatrixAutomatic.

spMaxConjugateGradientIter

Maximum number of PCG iterations when using the PCG solver
scheme.

spMaxIterationEig

Applies to linear buckling and natural frequency analysis; maximum
number of iterations for the eigenvalue solver.

spMaxIterationHeat             Maximum number of iterations for nonlinear steady heat transfer

analysis.

spMaxIterationNonlin

Applies to nonlinear static, quasi-static and nonlinear transient
dynamic analysis; maximum number of iterations for a load step.

spMaxNumViscoUnits

Applies to the nonlinear solvers with creep; maximum number of
visco-elastic creep units to be used in any creep material. The value is
a hint for the solver rather than an absolute setting.

spMaxNumRepeatedMessages

Maximum number of log file notes and warnings of the same type.

spMaxUpdateInterval

Maximum number of iterations between stiffness matrix updates
when spFormStiffMatrix=scStiffnessMatrixAutomatic.

Strand7 API Manual

spMinNumViscoUnits

Applies to the nonlinear solvers with creep; minimum number of
visco-elastic creep units to be used in any creep material.  The value is
a hint for the solver rather than an absolute setting.

spNumBeamSlicesModal

Applies to natural frequency, harmonic response and spectral
response; number of beam slices to be generated for force and
moment results along a beam element.

spNumBucklingModes

Number of modes to be calculated in linear buckling analysis.

spNumFrequency

Number of modes to be calculated in natural frequency analysis.

spStaticAutoStepping

Applies to nonlinear static analysis: static sub-stepping option; one of
scStaticAutoStepNone, scStaticAutoStepLoad,
scStaticAutoStepDispLoad, scStaticAutoStepDispDisp or
scStaticAutoStepDispArc.

spTreeStartNumber

Refers to a node number, which applies when the Matrix Node
Ordering option is set to Tree.

Double Parameters

The functions St7SetSolverDefaultsDouble and St7GetSolverDefaultsDouble may be used to manipulate the double
solver parameters (real numbers) indicated by the constants below.

spBucklingShift

Buckling shift for linear buckling analysis; modes nearest to
spBucklingShift are calculated.

spCavityVolumeAveraging

Cavity volume averaging factor for convergence control of
nonlinear analysis of ideal gas cavities.

spClusterZeroDiagonal

Constraint matrix zero diagonal for the factorisation of link
matrices.

spConjugateGradientTol

Solver tolerance to define convergence when using the PCG solver
scheme.

spCurveFitTime

Applies to the nonlinear solvers with creep; creep curve fit time
parameter used to interpolate creep strain as a function of time to
the calculation of creep coefficients.

spDrillStiffFactorQ4

Drilling stiffness multiplier for Quad4 shell elements.

spDrillStiffFactorQ8

Drilling stiffness multiplier for Tri6, Quad8 and Quad9 shell
elements.

spDrillStiffFactorT3

Drilling stiffness multiplier for Tri3 shell elements.

Solver Options

spEigenTolerance

Applies to linear buckling and natural frequency analysis;
eigenvalue tolerance for defining convergence of eigenvalues, and
convergence of eigenvectors when spCheckEigenvector=True.

spFrequencyShift

Frequency shift for natural frequency analysis; modes nearest to
spFrequencyShift are calculated.

spFrictionModulusRatio           Applies to point contact elements in the nonlinear structural

solvers and sets the ratio between tangent and secant modulus for
point contact elements with friction to help improve convergence.

spGlobalZeroDiagonal

Matrix zero diagonal for the global stiffness matrix; a diagonal less
than spGlobalZeroDiagonal signifies a singular matrix.

spMaxDispChange

spMaxDisplacementNLA

Applies to the nonlinear structural solvers when
spFormStiffMatrix=scStiffnessMatrixAutomatic; maximum residual
displacement ratio change before the stiffness matrix is updated.

Applies to the nonlinear structural solvers when
spLimitDisplacementNLA is True. The solver will terminate when
the total displacements exceed this value.

spMaxDynamicPointContactFactor  Applies to the nonlinear structural solvers; maximum scaling factor

applicable to dynamic stiffness point contact elements.

spMaxEigenRatio

Ratio between maximum and minimum Eigenvalues during
Subspace iteration; Eigenvalues that exceed this ratio are removed
from the Subspace.

spMaxFibreStrainInc

Applies to the nonlinear material structural solvers; maximum MNL
beam fibre strain increment before sub-stepping is invoked.

spMaxRotation

spMaxDispRatio

spMaxNormalsAngle

spMaxResidualChange

Applies to the nonlinear structural solvers; maximum incremental
rotation change before sub-stepping is invoked.

Applies to the nonlinear structural solvers; maximum residual
displacement change, as a ratio of the bounding box length of the
model, before sub-stepping is invoked.

Maximum angle between normals of adjacent plate elements
within which an average normal direction will be used for the
addition of drilling stiffness.

Applies to the nonlinear structural solvers when
spFormStiffMatrix=scStiffnessMatrixAutomatic; maximum residual
force norm change before the stiffness matrix is updated.

Strand7 API Manual

spMaxRotationNLA

spMinArcLengthFactor

spMinDimension

spMinInternalAngle

spMinLoadReductionFactor

spMinTimeStep

spMNLTangentRatio

spNewmarkAlpha

spNewmarkBeta

spNonlinDispTolerance

spNonlinHeatTolerance

spNonlinResidualTolerance

Applies to the nonlinear structural solvers when
spLimitRotationNLA is True. The solver will terminate when the
total rotations exceed this value.

Applies to the nonlinear static solver when the Displacement
control (Arc length) sub-stepping option is used; minimum arc
length reduction factor for non-convergent load steps.  The arc
length in non-convergent load steps will be reduced until the step
is converged or this factor is reached.

Minimum element dimension, such as beam length or plate edge
length, below which it is considered to be zero.

Minimum element internal angle in plate elements, below which a
warning is issued.  The setting does not affect the element matrix.

Minimum load reduction factor for nonlinear analysis with sub-
stepping enabled.  The load in non-convergent load steps will be
reduced until the step is converged or this factor is reached.

Applies to the quasi-static and nonlinear transient dynamic solvers;
the time step in non-convergent steps will be reduced until the
step is converged or this time step is reached.

Applies to elements that consider nonlinear material behaviour in
the nonlinear structural solvers; sets the ratio between tangent
and secant modulus to help improve convergence.

Applies to linear and nonlinear transient dynamic analysis with the
Newmark time integration scheme when
spAutoNewmarkAlpha=False; alpha parameter.

Applies to linear and nonlinear transient dynamic analysis with the
Newmark time integration scheme; beta parameter.

Applies to the nonlinear structural solvers; displacements in a load
step are considered converged when the ratio of the iterative
displacement norm to the total displacement norm is below this
value.

Applies to the steady heat solver; temperatures are considered
converged when the ratio of the temperature change norm to the
total temperature norm is below this value.

Applies to the nonlinear structural solvers; residual forces in a load
step are considered acceptable, and the load step therefore
converged, when the ratio of the current residual force norm to the
total applied force norm is below this value.

Solver Options

spRelaxationFactor

spSpacingBias

spSupportUpdate

spTimeStepParam

Applies to transient heat transfer analysis; relaxation parameter to
control the time integration between an explicit scheme
(spRelaxationFactor = 0.0) and an implicit scheme
(spRelaxationFactor = 1.0).

Applies to the nonlinear solvers with creep; creep curve fit spacing
parameter used to bias the insertion of time sampling points either
closer to time = 0.0 or closer to time = spCurveFitTime.

Applies to the nonlinear solvers for element support attributes
with compression-only or limited bearing capacity; sets a
parameter between 0.0 (stable) and 1.0 (fast) to control
convergence.

Applies to the nonlinear solvers with creep; relaxation parameter
to control the creep strain time integration between an explicit
scheme (spTimeStepParam = 0.0) and an implicit scheme
(spTimeStepParam = 1.0).

spTransientReferenceTemperature   Applies to quasi-static and nonlinear transient dynamic analysis
when the temperature time history in the analysis comes from a
transient heat transfer analysis; reference temperature to be used
for thermal strain.

spUpdateDirContactCheckPoint

spWilsonTheta

spZeroBucklingEigen

spZeroContactFactor

spZeroDiagonal

spZeroDisplacement

Applies to the nonlinear structural solvers; the axis of update-
direction point contacts is kept constant when the compressed
element length is less than its initial length times this factor.

Applies to linear transient dynamic analysis with the Wilson-Theta
time integration scheme; theta parameter.

Applies to linear buckling anlysis; eigenvalues (buckling factors) less
than this value are considered as zero.

Applies to nonlinear structural analysis; inactive point contact
elements are scaled by this factor when adding their contribution
to the global stiffness matrix.

For the purpose of issuing a warning, diagonals in the local element
stiffness matrix below this value are considered as zero.

Applies to the nonlinear structural solvers; an iterative
displacement norm less than this value considers the load step to
be converged as far as displacements are concerned, irrespective
of the displacement norm ratio.

spZeroForce

Applies to the nonlinear structural solvers; a residual force norm
less than this value considers the load step to be converged as far

Strand7 API Manual

spZeroFrequency

spZeroModalDisp

spZeroRotation

spZeroTranslation

as residual forces are concerned, irrespective of the force norm
ratio.

Applies to natural frequency analysis; frequencies less than this
value are considered as zero.

Translational displacement components in the Eigenvector of a
natural frequency analysis are not considered for the calculation of
modal mass and modal stiffness unless their magnitude is greater
than this value.

Used by the structural solvers for the detection of zero rotational
stiffness and for the suppression of drilling degrees of freedom on
plate elements. At a node, a rotational stiffness that is less than
this value times the maximum rotational stiffness will be
considered a singularity; it will be suppressed if it corresponds to a
plate drilling degree of freeedom or reported in the log file, if
spForceSingularityCheck=True.

Used by the structural solvers for the detection of zero
translational stiffness when spForceSingularityCheck=True.  At a
node, a translational stiffness that is less than this value times the
maximum translational stiffness will be considered a singularity and
will be reported in the log file.

Node Results

Node Results

Node results include displacement, velocity, acceleration, phase, reaction, temperature, heat flux and influence.
The functions St7GetNodeResult, St7GetNodeResultEx, St7GetNodeResultUCS and St7GetNodeResultExUCS can be
used to access these result quantities.  Result types can be selected by the following input:

ResultType

One of rtNodeDisp, rtNodeVel, rtNodeAcc, rtNodePhase, rtNodeReact, rtNodeTemp, rtNodeFlux,
rtNodeInfluence or rtNodeInertia.

Results obtained using St7GetNodeResult and St7GetNodeResultUCS are returned in a 6-element array of data.
Results obtained using St7GetNodeResultEx and St7GetNodeResultExUCS are returned in a 14-element array of
data.

ResultType: [rtNodeDisp, rtNodeVel, rtNodeAcc, rtNodePhase, rtNodeReact, rtNodeInertia]

These refer to vector results of nodal displacement, velocity, acceleration, phase, reaction and inertia,
respectively.

All four functions return the first six result components in the 123456 convention via the following array indices:

[0..2] – correspond to the translational degrees of freedom, and

[3..5] – correspond to the rotational degrees of freedom.

The functions St7GetNodeResultEx and St7GetNodeResultExUCS return an additional eight results combining the
component results via the following array indices:

[6] – corresponds to the translational magnitude given by √[0]2 + [1]2,

[7] – corresponds to the translational magnitude given by √[1]2 + [2]2,

[8] – corresponds to the translational magnitude given by √[2]2 + [0]2,

[9] – corresponds to the translational magnitude given by √[0]2 + [1]2 + [2]2,

[10] – corresponds to the rotational magnitude given by √[3]2 + [4]2,

[11] – corresponds to the rotational magnitude given by √[4]2 + [5]2,

[12] – corresponds to the rotational magnitude given by √[5]2 + [3]2, and

[13] – corresponds to the rotational magnitude given by √[3]2 + [4]2 + [5]2.

ResultType: [rtNodeInfluence]

Result components are returned in the 123456 convention via the following array indices:

[0..2] – correspond to translational degrees of freedom, and

[3..5] – correspond to rotational degrees of freedom.

ResultType: [rtNodeTemp, rtNodeFlux]

Results are the scalar quantities of temperature and total heat flux into the node, respectively.

[0] – scalar quantity of interest.

Strand7 API Manual

Beam Results

Beam results include force, stress, strain, release, cable position, flux, creep strain, strain energy, beam
displacement and beam reactions.  The functions St7GetBeamResultArray, St7GetBeamResultArrayPos,
St7GetBeamResultEndPos and St7GetBeamResultSinglePos can be used to access these result quantities.

Result quantities can be selected via a combination of the following inputs:

ResultType

One of rtBeamForce, rtBeamAllStrain, rtBeamAllTotalStrain, rtBeamAllStress, rtBeamAxialStress,
rtBeamBendingStress, rtBeamFibreStress, rtBeamAvShearStress, rtBeamShearStress,
rtBeamCombinedStress, rtPipeHoopStress, rtBeamYieldAreaRatio, rtBeamCableXYZ, rtBeamFlux,
rtBeamNodeFlux, rtBeamGradient, rtBeamCreepStrain, rtBeamEnergy, rtBeamNodeReact, rtBeamDisp,
rtBeamBirthDisp or rtBeamUser.

ResultSubType

One of stBeamLocal, stBeamPrincipal, stBeamGlobal or a UCS ID.

Results are returned in a one-dimensional array BeamResult, which consists of contiguous blocks of data. Each
block corresponds to a location along the beam. The length NumColumns of each block is also returned by the
function as it depends on the requested ResultType and ResultSubType.

The number of these blocks is dependent on the function that is called – for example, St7GetBeamResultSinglePos
will return one such block, whereas St7GetBeamResultArray will return an array containing NumStations such
blocks.

Constants are provided that index specific result quantities within each block of data. For example, the axial force
at the ith beam station is stored in the location:

BeamResult[(i-1)*NumColumns+ipBeamAxialF]

These constants are specific to the result type requested – appropriate constants for each result type are listed in
the rest of this section.

ResultType: rtBeamForce with

ResultSubType: stBeamPrincipal

ipBeamSF1 – Shear force in the 1 axis direction.

ipBeamBM1 – Bending moment in the 1 axis direction.

ipBeamSF2 – Shear force in the 2 axis direction.

ipBeamBM2 – Bending moment in the 2 axis direction.

ipBeamAxialF – Axial force.

ipBeamTorque – Torque.

ResultType: rtBeamForce with

ResultSubType: stBeamLocal

ipBeamSFx – Shear force in the local x axis direction.

ipBeamBMx – Bending moment in the local x axis direction.

Beam Results

ipBeamSFy – Shear force in the local y axis direction.

ipBeamBMy – Bending moment in the local y axis direction.

ipBeamAxialF – Axial force.

ipBeamTorque – Torque.

ResultType: rtBeamForce with

ResultSubType: stBeamGlobal

At any cut section, the forces/moments are those required to keep End 2 of the beam in equilibrium.

ipBeamFX – Internal force in the global X direction.

ipBeamMX – Internal moment in the global X direction.

ipBeamFY – Internal force in the global Y direction.

ipBeamMY – Internal moment in the global Y direction.

ipBeamFZ – Internal force in the global Z direction.

ipBeamMZ – Internal moment in the global Z direction.

ResultType: rtBeamForce with
ResultSubType: UCS ID

At any cut section, the forces/moments are those required to keep End 2 of the beam in equilibrium.

ipBeamFX – Internal force in the global 1 direction of the UCS.

ipBeamMX – Internal moment in the global 1 direction of the UCS.

ipBeamFY – Internal force in the global 2 direction of the UCS.

ipBeamMY – Internal moment in the global 2 direction of the UCS.

ipBeamFZ – Internal force in the global 3 direction of the UCS.

ipBeamMZ – Internal moment in the global 3 direction of the UCS.

ResultType: rtBeamAllStress

ipMinFibreStress – Minimum fibre stress.

ipMaxFibreStress – Maximum fibre stress.

ipMaxShearStress1 – Maximum shear stress in the 1 axis direction.

ipMaxShearStress2 – Maximum shear stress in the 2 axis direction.

ipShearF1MeanShearStress – Average stress due to shear force in the 1 axis direction.

ipShearF2MeanShearStress – Average stress due to shear force in the 2 axis direction.

ipShearStressMag – Shear stress magnitude.

ipMaxPrincipalStress – Maximum principal stress.

ipMinPrincipalStress – Minimum principal stress.

Strand7 API Manual

ipMinPipeHoopStress – Minimum hoop stress.

ipMaxPipeHoopStress – Maximum hoop stress.

ipMinAxialStress – Minimum axial stress.

ipMaxAxialStress – Maximum axial stress.

ipMinBendingStress1 – Minimum bending stress in the 1 axis direction.

ipMaxBendingStress1 – Maximum bending stress in the 1 axis direction.

ipMinBendingStress2 – Minimum bending stress in the 2 axis direction.

ipMaxBendingStress2 – Maximum bending stress in the 2 axis direction.

ipYieldAreaRatio – Portion of beam section that has yielded.

ipVonMisesStress – von Mises stress.

ipTrescaStress – Tresca stress.

ipTorqueShearStress – Shear stress due to torque.

ipShearF1ShearStress – Largest magnitude shear stress due to shear force in the 1 axis direction.

ipShearF2ShearStress – Largest magnitude shear stress due to shear force in the 2 axis direction.

ResultType: rtBeamAxialStress, rtBeamBendingStress, rtBeamFibreStress, rtBeamAvShearStress,

rtBeamShearStress, rtBeamCombinedStress, rtPipeHoopStress, rtBeamYieldAreaRatio

Since beam stress results can require significant computation to determine, requesting only a subset of the
components is a way of speeding up result extraction in applications where not all stress components are
relevant.  With subset stress result types the index positions are the same as for rtBeamAllStress, but inactive
components will not be calculated.  Active components for each of the subset stress result types are tabulated
below.

s
s
e
r
t
S
p
o
o
H
e
p
P
n
M
p

i

i

i

s
s
e
r
t
S
p
o
o
H
e
p
P
x
a
M
p

i

i

s
s
e
r
t
S
r
a
e
h
S
n
a
e
M

F
r
a
e
h
S
p

i

s
s
e
r
t
S
r
a
e
h
S
n
a
e
M

F
r
a
e
h
S
p

i

i

s
s
e
r
t
S
g
n
d
n
e
B
x
a
M
p

i

s
s
e
r
t
S
e
r
b
i
F
n
M
p

i

i

s
s
e
r
t
S
e
r
b
i
F
x
a
M
p

i

s
s
e
r
t
S
r
a
e
h
S
x
a
M
p

i

s
s
e
r
t
S
r
a
e
h
S
x
a
M
p

i

g
a
M

s
s
e
r
t
S
r
a
e
h
S
p

i

s
s
e
r
t
S
r
a
e
h
S
e
u
q
r
o
T
p

i

s
s
e
r
t
S
r
a
e
h
S

F
r
a
e
h
S
p

i

s
s
e
r
t
S
r
a
e
h
S

F
r
a
e
h
S
p

i

s
s
e
r
t
S
l
a
p
i
c
n
i
r
P
n
M
p

i

i

s
s
e
r
t
S
l
a
p
i
c
n
i
r
P
x
a
M
p

i

s
s
e
r
t
S
s
e
s
i

M
n
o
V
p

i

s
s
e
r
t
S
a
c
s
e
r
T
p

i

i

s
s
e
r
t
S
g
n
d
n
e
B
n
M
p

i

i

i

s
s
e
r
t
S
g
n
d
n
e
B
n
M
p

i

i

i

s
s
e
r
t
S
g
n
d
n
e
B
x
a
M
p

i

Beam Results

s
s
e
r
t
S
l
a
i
x
A
n
M
p

i

i

s
s
e
r
t
S
l
a
i
x
A
x
a
M
p

i

rtBeamAllStress

rtBeamAvShearStress

rtBeamAxialStress

rtBeamBendingStress

rtBeamCombinedStress

rtBeamFibreStress

rtBeamShearStress

rtBeamYieldAreaRatio

rtPipeHoopStress

o
i
t
a
R
a
e
r
A
d
e
Y
p

i

l

i

ResultType: rtBeamAllStrain, rtBeamAllTotalStrain

ipAxialStrain – Axial strain.

ipCurvature1 – Curvature in the 1 axis direction.

ipCurvature2 – Curvature in the 2 axis direction.

ipTwist – Twist.

ipMinFibreStrain – Minimum fibre strain.

ipMaxFibreStrain – Maximum fibre strain.

ResultType: rtBeamCreepStrain

ipMinFibreCreepStrain – Minimum fibre creep strain.

ipMaxFibreCreepStrain – Maximum fibre creep strain.

ipMinFibreCreepStrainRate – Minimum fibre creep strain rate.

ipMaxFibreCreepStrainRate – Maximum fibre creep strain rate.

ipShrinkageStrain – Shrinkage strain.

Strand7 API Manual

ResultType: rtBeamCableXYZ

Global displacement components indexed according to the 123 convention.

ResultType: rtBeamEnergy

ipBeamEnergyStored – Stored energy.

ipBeamEnergySpent – Spent energy.

ResultType: rtBeamNodeReact with

ResultSubType: stBeamLocal, stBeamPrincipal or stBeamGlobal

Reaction components in the selected coordinate system indexed according to the 123456 convention
via the following array indices:

[0..2] – correspond to the translational degrees of freedom, and

[3..5] – correspond to the rotational degrees of freedom.

ResultType: rtBeamNodeReact with

ResultSubType: UCS ID

UCS reaction components indexed according to the 123456 convention via the following array indices:

[0..2] – correspond to the translational degrees of freedom, and

[3..5] – correspond to the rotational degrees of freedom.

ResultType: [rtBeamDisp/rtBeamBirthDisp] with

ResultSubType: [stBeamLocal/stBeamGlobal/stBeamPrincipal]

Displacement components in the selected coordinate system indexed according to the 123456
convention via the following array indices:

[0..2] – correspond to the translational degrees of freedom, and

[3..5] – correspond to the rotational degrees of freedom.

ResultType: rtBeamFlux

Heat flux within element.

ResultType: rtBeamGradient

Temperature gradient.

ResultType: rtBeamNodeFlux

Heat flux at nodes.

Plate Results

Plate Results

Plate results include stress, strain, strain energy, force moment, effective force, curvature, ply stress, ply strain,
ply reserve, heat flux, temperature gradient, reinforcement design, creep strain, soil characteristics, nodal
reactions and user defined quantities. The St7GetPlateResultArray function can be used to access these result
quantities.

Result quantities can be selected via a combination of the following inputs:

ResultType

One of rtPlateStress, rtPlateEffectiveStress, rtPlateStrain, rtPlateTotalStrain, rtPlateEnergyDensity,
rtPlateEnergyIntegral, rtPlateForce, rtPlateEffectiveForce, rtPlateMoment, rtPlateCurvature,
rtPlateTotalCurvature, rtPlatePlyStress, rtPlatePlyStrain, rtPlatePlyReserve, rtPlateFlux, rtPlateNodeFlux,
rtPlateGradient, rtPlateRCDesign, rtPlateCreepStrain, rtPlateSoil, rtPlateUser, rtPlateNodeReact,
rtPlateNodeDisp or rtPlateNodeBirthDisp.

ResultSubType

One of stPlateLocal, stPlateGlobal, stPlateCombined, stPlateSupport, stPlateDevLocal, stPlateDevGlobal,
stPlateDevCombined, stPlateCavity or the ID of a UCS into which result components are to be
transformed. Note that the Global Cartesian coordinate system is defined as UCS 1.

The rtPlateEffectiveForce quantity is not available for axisymmetric plates.

The Layers input has a different interpretation depending on ResultType.  When ResultType is rtPlateRCDesign,
use the reinforcement layer number (1 to 4).  When ResultType is one of rtPlatePlyStress, rtPlatePlyStrain or
rtPlatePlyReserve, refer to the table below.  For other result types the input is not relevant.

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

rsPlyMinValueActivePlies

Minimum of plies enabled by St7EnablePlyPropertyResults.

rsPlyMaxValueActivePlies

Maximum of plies enabled by St7EnablePlyPropertyResults.

rsPlyMaxMagActivePlies

Maximum magnitude of plies enabled by St7EnablePlyPropertyResults.

Results are returned in a one-dimensional array PlateResult, which consists of contiguous blocks of data. Each
block corresponds to a location on the plate. The length NumColumns of each block depends on the requested
result quantity and is returned by St7GetPlateResultArray. The total number of these blocks NumPoints depends
on the input SampleLocation and is also returned. The total number of quantities returned in PlateResult is
therefore NumPoints*NumColumns.

Constants are provided that index specific result quantities within each block of data. For example, the plate local
xy force at the ith Gauss point is stored in the location:

Strand7 API Manual

PlateResult[(i-1)*NumColumns+ipPlateLocalxy]

These constants are specific to the result type requested – appropriate constants for each result type are listed in
the rest of this section.

ResultType: [rtPlateStress/rtPlateEffectiveStress/rtPlateStrain/rtPlateTotalStrain/
rtPlateCurvature/rtPlateTotalCurvature/rtPlateCreepStrain/rtPlateMoment/
rtPlateForce/rtPlateEffectiveForce] with
ResultSubType: stPlateLocal

ipPlateLocalxx – Local xx component.

ipPlateLocalyy – Local yy component.

ipPlateLocalzz – Local zz component.

ipPlateLocalxy – Local xy component.

ipPlateLocalyz – Local yz component.

ipPlateLocalxz – Local zx component.

ResultType: [rtPlateStress/rtPlateEffectiveStress/rtPlateStrain/rtPlateTotalStrain/rtPlateCurvature/

rtPlateTotalCurvature/rtPlateForce/rtPlateEffectiveForce/rtPlateMoment/rtPlateCreepStrain] with
ResultSubType: stPlateGlobal

ipPlateGlobalXX – Global XX component.

ipPlateGlobalYY – Global YY component.

ipPlateGlobalZZ – Global ZZ component.

ipPlateGlobalXY – Global XY component.

ipPlateGlobalYZ – Global YZ component.

ipPlateGlobalZX – Global ZX component.

Exceptionally, for axisymmetric plates use the following constants:

ipPlateAxiGlobalRR – Axisymmetric RR component.

ipPlateAxiGlobalZZ – Axisymmetric ZZ component.

ipPlateAxiGlobalTT – Axisymmetric TT component.

ipPlateAxiGlobalRZ – Axisymmetric RZ component.

ResultType: [rtPlateStress/rtPlateEffectiveStress/rtPlateStrain/rtPlateTotalStrain/
rtPlateCurvature/rtPlateTotalCurvature/rtPlateForce/rtPlateEffectiveForce/
rtPlateMoment/rtPlateCreepStrain] with
ResultSubType: UCS ID

ipPlateUCSXX – UCS 11 component.

ipPlateUCSYY – UCS 22 component.

ipPlateUCSZZ – UCS 33 component.

Plate Results

ipPlateUCSXY – UCS 12 component.

ipPlateUCSYZ – UCS 23 component.

ipPlateUCSZX – UCS 31 component.

ResultType: [rtPlateStress/rtPlateEffectiveStress] with

ResultSubType: stPlateCombined

ipPlateCombPrincipal11 – Principal 11 component.

ipPlateCombPrincipal22 – Principal 22 component.

ipPlateCombPrincipalAngle – Principal axis angle.

ipPlateCombVonMises – von Mises quantity.

ipPlateCombTresca – Tresca quantity.

ipPlateCombMohrCoulomb – Mohr Coulomb quantity.

ipPlateCombDruckerPrager – Drucker-Prager quantity.

ipPlateCombYieldIndex – Yield index.

ipPlateCombMagnitude – Maximum absolute principal component.

Exceptionally, for axisymmetric plates use the following constants:

ipPlateAxiCombPrincipal11 – Axisymmetric principal 11 component.

ipPlateAxiCombPrincipal22 – Axisymmetric principal 22 component.

ipPlateAxiCombPrincipal33 – Axisymmetric principal 33 component.

ipPlateAxiCombVonMises – Axisymmetric von Mises quantity.

ipPlateAxiCombTresca – Axisymmetric Tresca quantity.

ipPlateAxiCombMohrCoulomb – Axisymmetric Mohr-Coulomb quantity.

ipPlateAxiCombDruckerPrager – Axisymmetric Drucker-Prager quantity.

ipPlateAxiCombYieldIndex – Axisymmetric yield index.

ipPlateAxiCombMagnitude – Maximum absolute principal component.

ResultType: rtPlateStrain/rtPlateTotalStrain with

ResultSubType: stPlateCombined

ipPlateCombPrincipal11 – Principal 11 component.

ipPlateCombPrincipal22 – Principal 22 component.

ipPlateCombPrincipalAngle – Principal axis angle.

ipPlateCombVonMises – von Mises quantity.

ipPlateCombTresca – Tresca quantity.

ipPlateCombPlasticStrain – Plastic strain.

Strand7 API Manual

ipPlateCombMagnitude – Maximum absolute principal component.

Exceptionally, for axisymmetric plates use the following constants:

ipPlateAxiCombPrincipal11 – Axisymmetric principal 11 component.

ipPlateAxiCombPrincipal22 – Axisymmetric principal 22 component.

ipPlateAxiCombPrincipal33 – Axisymmetric principal 33 component.

ipPlateAxiCombVonMises – Axisymmetric von Mises quantity.

ipPlateAxiCombTresca – Axisymmetric Tresca quantity.

ipPlateAxiCombPlasticStrain – Axisymmetric plastic strain quantity.

ResultType: rtPlateCreepStrain with
ResultSubType: stPlateCombined

ipPlateCombPrincipal11 – Principal 11 component.

ipPlateCombPrincipal22 – Principal 22 component.

ipPlateCombPrincipalAngle – Principal axis angle.

ipPlateCombVonMises – von Mises quantity.

ipPlateCombTresca – Tresca quantity.

ipPlateCombMagnitude – Maximum absolute principal component.

ipPlateCombCreepEffRate – Effective creep strain rate.

ipPlateCombCreepShrinkage – Concrete shrinkage strain.

Exceptionally, for axisymmetric plates use the following constants:

ipPlateAxiCombPrincipal11 – Axisymmetric principal 11 component.

ipPlateAxiCombPrincipal22 – Axisymmetric principal 22 component.

ipPlateAxiCombPrincipal33 – Axisymmetric principal 33 component.

ipPlateAxiCombVonMises – Axisymmetric von Mises quantity.

ipPlateAxiCombTresca – Axisymmetric Tresca quantity.

ipPlateAxiCombCreepEffRate – Axisymmetric effective creep strain rate.

ipPlateAxiCombCreepShrinkage – Axisymmetric concrete shrinkage strain.

ResultType: [rtPlateForce/rtPlateEffectiveForce/rtPlateMoment/rtPlateCurvature/rtPlateTotalCurvature]

with ResultSubType: stPlateCombined

ipPlateCombPrincipal11 – Principal 11 component.

ipPlateCombPrincipal22 – Principal 22 component.

ipPlateCombPrincipalAngle – Principal axis angle.

ipPlateCombVonMises – von Mises quantity.

Plate Results

ipPlateCombTresca – Tresca quantity.

ipPlateCombMagnitude – Maximum absolute principal component.

ResultType: rtPlateStress with

ResultSubType: stPlateSupport

ipPlateEdgeSupport – Edge support component.

ipPlateFaceSupport – Face support component.

ResultType: [rtPlateStress/rtPlateEffectiveStress] with

ResultSubType: stPlateDevLocal

ipPlateLocalMean – Mean.

ipPlateLocalDevxx – Deviatoric xx component.

ipPlateLocalDevyy – Deviatoric yy component.

ResultType: [rtPlateStress/rtPlateEffectiveStress] with

ResultSubType: stPlateDevGlobal

ipPlateGlobalMean – Mean.

ipPlateGlobalDevXX – Deviatoric XX component.

ipPlateGlobalDevYY – Deviatoric YY component.

ipPlateGlobalDevZZ – Deviatoric ZZ component.

Exceptionally, for axisymmetric plates use the following constants:

ipPlateAxiGlobalMean – Mean.

ipPlateAxiGlobalDevRR – Axisymmetric deviatoric RR component.

ipPlateAxiGlobalDevZZ – Axisymmetric deviatoric ZZ component.

ipPlateAxiGlobalDevTT – Axisymmetric deviatoric TT component.

ResultType: [rtPlateStress/rtPlateEffectiveStress] with

ResultSubType: stPlateDevCombined

ipPlateCombMean – Mean.

ipPlateCombDev11 – Deviatoric principal 11 component.

ipPlateCombDev22 – Deviatoric principal 22 component.

Exceptionally, for axisymmetric plates use the following constants:

ipPlateAxiCombMean – Mean.

ipPlateAxiCombDev11 – Axisymmetric deviatoric principal 11 component.

ipPlateAxiCombDev22 – Axisymmetric deviatoric principal 22 component.

ipPlateAxiCombDev33 – Axisymmetric deviatoric principal 33 component.

Strand7 API Manual

ResultType: [rtPlateEnergyDensity/rtPlateEnergyIntegral]

ipPlateEnergyStored – Stored energy.

ipPlateEnergySpent – Spent energy.

ResultType: rtPlatePlyStress

ipPlyStress11 – Ply 11 component.

ipPlyStress22 – Ply 22 component.

ipPlyStress12 – Ply 12 component.

ipPlyILSx – Interlamina Sx component.

ipPlyILSy – Interlamina Sy component.

ipPlyStressPrincipal11 – Principal 11 component.

ipPlyStressPrincipal22 – Principal 22 component.

ipPlyStressVonMises – von Mises quantity.

ipPlyStressTresca – Tresca quantity.

ResultType: rtPlatePlyStrain

ipPlyStrain11 – Ply 11 component.

ipPlyStrain22 – Ply 22 component.

ipPlyStrain12 – Ply 12 component.

ipPlyStrainPrincipal11 – Principal 11 component.

ipPlyStrainPrincipal22 – Principal 22 component.

ResultType: rtPlatePlyReserve

ipPlyMaxStress – Maximum stress.

ipPlyMaxStrain – Maximum strain.

ipPlyTsaiHill – Tsai-Hill measure.

ipPlyModTsaiWu – Modified Tsai-Wu measure.

ipPlyHoffman – Hoffman measure.

ipPlyInterlam – Interlamina stress.

ResultType: rtPlateRCDesign

ipPlateRCWoodArmerMoment – Wood-Armer moment.

ipPlateRCWoodArmerForce – Wood-Armer force.

ipPlateRCSteelArea – Steel area.

ipPlateRCConcreteStrain – Concrete strain ratio.

Plate Results

ipPlateRCSteelAreaLessBase – Steel area less base area.

ipPlateRCUserSteelStress – User steel stress.

ipPlateRCUserConcreteStrain – User concrete strain.

ipPlateRCBlockRatio – Block ratio.

ResultType: rtPlateSoil

ipPlateSoilTotalPorePressure – Total pore pressure.

ipPlateSoilExcessPorePressure – Excess pore pressure.

ipPlateSoilOCRIndex – OCR index.

ipPlateSoilStateIndex – Failure index.

ipPlateSoilVoidRatio – Void ratio.

ResultType: rtPlateNodeReact with
ResultSubType: stPlateGlobal

Global reaction components indexed according to the 123456 convention.

ResultType: rtPlateNodeReact with

ResultSubType: UCS ID

UCS reaction components indexed according to the 123456 convention.

ResultType: [rtPlateNodeDisp/rtPlateNodeBirthDisp] with

ResultSubType: stPlateGlobal

Global displacement components indexed according to the 123456 convention.

ResultType: [rtPlateNodeDisp/rtPlateNodeBirthDisp] with

ResultSubType: UCS ID

UCS displacement components indexed according to the 123456 convention.

ResultType: rtPlateUser

A scalar result calculated by the user defined equation defined by St7GetResultUserEquation. See User
Defined Results for details.

ResultType: [rtPlateFlux/rtPlateGradient] with

ResultSubType: stPlateLocal

ipPlateFluxLocalx – Local x component.

ipPlateFluxLocaly – Local y component.

ipPlateFluxLocalMagxy – Flux magnitude.

ResultType: [rtPlateFlux/rtPlateGradient] with

ResultSubType: stPlateGlobal

ipPlateFluxGlobalX – Global X component.

ipPlateFluxGlobalY – Global Y component.

Strand7 API Manual

ipPlateFluxGlobalZ – Global Z component.

ipPlateFluxGlobalMagXY – Magnitude of global projection on the XY plane.

ipPlateFluxGlobalMagYZ – Magnitude of global projection on the XY plane.

ipPlateFluxGlobalMagZX – Magnitude of global projection on the XY plane.

ipPlateFluxGlobalMagXYZ – Flux Magnitude

ResultType: [rtPlateFlux/rtPlateGradient] with

ResultSubType: UCS ID

ipPlateFluxUCSX – UCS 1 component.

ipPlateFluxUCSY – UCS 2 component.

ipPlateFluxUCSZ – UCS 3 component.

ipPlateFluxUCSMagXY – Magnitude of projection on the UCS 12 plane.

ipPlateFluxUCSMagYZ – Magnitude of projection on the UCS 23 plane.

ipPlateFluxUCSMagZX – Magnitude of projection on the UCS 31 plane.

ipPlateFluxUCSMagXYZ – Flux magnitude.

ResultType: [rtPlateNodeFlux]

Heat flux at nodes.

Brick Results

Brick Results

Brick results include stress, strain, strain energy, heat flux, temperature gradient, creep strain, soil characteristics,
nodal reactions and user defined quantities. The St7GetBrickResultArray function can be used to access these
result quantities.

Result quantities can be selected via a combination of the following inputs:

ResultType

One of rtBrickStress, rtBrickEffectiveStress, rtBrickStrain, rtBrickTotalStrain, rtBrickEnergyDensity,
rtBrickEnergyIntegral, rtBrickFlux, rtBrickNodeFlux, rtBrickGradient, rtBrickCreepStrain, rtBrickSoil,
rtBrickUser, rtBrickNodeReact, rtBrickNodeDisp or rtBrickNodeBirthDisp.

ResultSubType

One of stBrickLocal, stBrickGlobal, stBrickCombined, stBrickSupport, stBrickDevLocal,
stBrickDevGlobal, stBrickDevCombined, stBrickCavity or the ID of a UCS into which result components
are to be transformed. Note that the Global Cartesian coordinate system is defined as UCS 1.

Results are returned in a one-dimensional array BrickResult, which consists of contiguous blocks of data. Each
block corresponds to a location on the brick. The length NumColumns of each block depends on the requested
result quantity and is returned by St7GetBrickResultArray. The total number of these blocks NumPoints depends
on the input SampleLocation and is also returned. The total number of quantities returned in BrickResult is
therefore NumPoints*NumColumns.

Constants are provided that index specific result quantities within each block of data. For example, the brick local
xy stress component at the ith Gauss point is stored in the location:

BrickResult[(i-1)*NumColumns+ipBrickLocalxy]

These constants are specific to the result type requested – appropriate constants for each result type are listed in
the rest of this section.

ResultType: [rtBrickStress/rtBrickEffectiveStress/rtBrickStrain/rtBrickTotalStrain/rtBrickCreepStrain] with

ResultSubType: stBrickLocal

ipBrickLocalxx – Local xx component.

ipBrickLocalyy – Local yy component.

ipBrickLocalzz – Local zz component.

ipBrickLocalxy – Local xy component.

ipBrickLocalyz – Local yz component.

ipBrickLocalzx – Local zx component.

ResultType: [rtBrickStress/rtBrickEffectiveStress/rtBrickStrain/rtBrickTotalStrain/rtBrickCreepStrain] with

ResultSubType: stBrickGlobal

ipBrickGlobalXX – Global XX component.

ipBrickGlobalYY – Global YY component.

ipBrickGlobalZZ – Global ZZ component.

Strand7 API Manual

ipBrickGlobalXY – Global XY component.

ipBrickGlobalYZ – Global YZ component.

ipBrickGlobalZX – Global ZX component.

ResultType: [rtBrickStress/rtBrickEffectiveStress/rtBrickStrain/rtBrickTotalStrain/rtBrickCreepStrain] with

ResultSubType: UCS ID

ipBrickUCSXX – UCS 11 component.

ipBrickUCSYY – UCS 22 component.

ipBrickUCSZZ – UCS 33 component.

ipBrickUCSXY – UCS 12 component.

ipBrickUCSYZ – UCS 23 component.

ipBrickUCSZX – UCS 31 component.

ResultType: [rtBrickStress/rtBrickEffectiveStress] with

ResultSubType: stBrickCombined

ipBrickCombPrincipal11 – Principal 11 component.

ipBrickCombPrincipal22 – Principal 22 component.

ipBrickCombPrincipal33 – Principal 33 component.

ipBrickCombVonMises – von Mises quantity.

ipBrickCombTresca – Tresca quantity.

ipBrickCombMohrCoulomb – Mohr-Coulomb quantity.

ipBrickCombDruckerPrager – Drucker-Prager quantity.

ipBrickCombMean – Mean.

ipBrickCombYieldIndex – Yield index.

ipBrickCombMagnitude – Maximum absolute principal component.

ResultType: rtBrickStrain/rtBrickTotalStrain with

ResultSubType: stBrickCombined

ipBrickCombPrincipal11 – Principal 11 component.

ipBrickCombPrincipal22 – Principal 22 component.

ipBrickCombPrincipal33 – Principal 33 component.

ipBrickCombVonMises – von Mises quantity.

ipBrickCombTresca – Tresca quantity.

ipBrickCombPlasticStrain – Plastic strain.

ipBrickCombMean – Mean.

Brick Results

ipBrickCombMagnitude – Maximum absolute principal component.

ResultType: rtBrickCreepStrain with
ResultSubType: stBrickCombined

ipBrickCombPrincipal11 – Principal 11 component.

ipBrickCombPrincipal22 – Principal 22 component.

ipBrickCombPrincipal33 – Principal 33 component.

ipBrickCombVonMises – von Mises quantity.

ipBrickCombTresca – Tresca quantity.

ipBrickCombCreepEffRate – Effective creep rate.

ipBrickCombCreepShrinkage – Concrete shrinkage strain.

ipBrickCombMagnitude – Maximum absolute principal component.

ResultType: rtBrickStress with

ResultSubType: stPlateSupport

ipBrickFaceSupport – Face support.

ResultType: [rtBrickStress/rtBrickEffectiveStress] with

ResultSubType: stBrickDevLocal

ipBrickLocalMean – Mean.

ipBrickLocalDevxx – Local deviatoric xx component.

ipBrickLocalDevyy – Local deviatoric yy component.

ipBrickLocalDevzz – Local deviatoric zz component.

ResultType: [rtBrickStress/rtBrickEffectiveStress] with

ResultSubType: stBrickDevGlobal

ipBrickGlobalMean – Mean.

ipBrickGlobalDevXX – Global deviatoric XX component.

ipBrickGlobalDevYY – Global deviatoric YY component.

ipBrickGlobalDevZZ – Global deviatoric ZZ component.

ResultType: [rtBrickStress/rtBrickEffectiveStress] with

ResultSubType: stBrickDevCombined

ipBrickCombDevMean – Mean.

ipBrickCombDev11 – Principal 11 deviatoric component.

ipBrickCombDev22 – Principal 22 deviatoric component.

ipBrickCombDev33 – Principal 33 deviatoric component.

Strand7 API Manual

ResultType: rtBrickNodeReact with
ResultSubType: stBrickGlobal

Global reaction components indexed according to the 123456 convention.

ResultType: rtBrickNodeReact with

ResultSubType: UCS ID

UCS reaction components indexed according to the 123456 convention.

ResultType: [rtBrickNodeDisp/rtBrickNodeBirthDisp] with

ResultSubType: stBrickGlobal

Global displacement components indexed according to the 123456 convention.

ResultType: [rtBrickNodeDisp/rtBrickNodeBirthDisp] with

ResultSubType: UCS ID

UCS displacement components indexed according to the 123456 convention.

ResultType: [rtBrickEnergyDensity/rtBrickEnergyIntegral]

ipBrickEnergyStored – Stored energy.

ipBrickEnergySpent – Spent energy.

ResultType: rtBrickSoil

ipBrickSoilTotalPorePressure – Total pore pressure.

ipBrickSoilExcessPorePressure – Excess pore pressure.

ipBrickSoilOCRIndex – OCR index.

ipBrickSoilStateIndex – Failure index.

ipBrickSoilVoidRatio – Void ratio.

ResultType: rtBrickUser

A scalar result calculated by the user defined equation defined by St7GetResultUserEquation. See User
Defined Results for details.

ResultType: [rtBrickFlux/rtBrickGradient] with

ResultSubType: stBrickLocal

ipBrickFluxLocalx – Local X component.

ipBrickFluxLocaly – Local Y component.

ipBrickFluxLocalz – Local Z component.

ipBrickFluxLocalMagxy – Magnitude of local projection on the XY plane.

ipBrickFluxLocalMagyz – Magnitude of local projection on the YZ plane..

ipBrickFluxLocalMagzx – Magnitude of local projection on the ZX plane..

ipBrickFluxLocalMagxyz – Flux magnitude.

Brick Results

ResultType: [rtBrickFlux/rtBrickGradient] with

ResultSubType: stBrickGlobal

ipBrickFluxGlobalX – Global X component.

ipBrickFluxGlobalY – Global Y component.

ipBrickFluxGlobalZ – Global Z component.

ipBrickFluxGlobalMagXY – Magnitude of global projection on the XY plane.

ipBrickFluxGlobalMagYZ – Magnitude of global projection on the YZ plane.

ipBrickFluxGlobalMagZX – Magnitude of global projection on the ZX plane.

ipBrickFluxGlobalMagXYZ – Flux magnitude.

ResultType: [rtBrickFlux/rtBrickGradient] with

ResultSubType: UCS ID

ipBrickFluxUCSX – UCS 1 component.

ipBrickFluxUCSY – UCS 2 component.

ipBrickFluxUCSZ – UCS 3 component.

ipBrickFluxUCSMagXY – Magnitude of projection on the UCS 12 plane.

ipBrickFluxUCSMagYZ – Magnitude of projection on the UCS 23 plane.

ipBrickFluxUCSMagZX – Magnitude of projection on the UCS 31 plane.

ipBrickFluxUCSMagXYZ – Flux magnitude.

ResultType: [rtBrickNodeFlux]

Heat flux at nodes.

Strand7 API Manual

User Defined Results

The calculation of user defined results based on primary result quantities is made possible by the definition of a
text equation (string) that uses the primary result quantities as variables (primary variables). In the Strand7 GUI,
this is a contour option available for beams, plates and bricks via the Results Settings dialog and the Equations
menu under VISUAL/Results. The following functions are used to manage these equations in the Strand7 API:

•  St7SetResultUserEquation
•  St7GetResultUserEquation
•  St7StoreResultUserEquation
•  St7DeleteStoredResultUserEquation
•  St7ReplaceStoredResultUserEquation
•  St7RetrieveStoredResultUserEquation
•  St7GetNumStoredResultUserEquations
•  St7SetStoredResultUserEquation

Syntax

Equation strings are case-insensitive and whitespace is ignored.  They are formed as a parseable string containing
primary variables in square brackets […], numeric constants, operators and functions.

The following is an example of a valid equation for plate elements; it defines the von Mises stress as a function of
the principal stresses in 2D:

SQRT(0.5*(([S11]-[S22])^2 + [S22]^2 + [S11]^2))

Here [S11] is a primary variable, 0.5 is a constant, SQRT() is a function, and ^ is an operator, amongst other
components.

Beam Primary Variables

Beam primary variables include element forces and moments along the beam, in either the principal or local
directions, as well as a range of section properties such as cross section area, moments of area, and so on (note
that in a tapered beam, the section properties may vary along the beam length).  The following table lists all the
available beam primary variables.

Beam Primary Variables

Description

[SF1]

[SF2]

[SFx]

[SFy]

[AxF]

[BM1]

[BM2]

[BMx]

[BMy]

Shear force in principal 1 direction

Shear force in principal 2 direction

Shear force in local x direction

Shear force in local y direction

Axial force

Bending moment in principal 1 plane

Bending moment in principal 2 plane

Bending moment in local x plane

Bending moment in local y plane

User Defined Results

[Trq]

[CvD1]

[CvD2]

[AxDS]

[CvT1]

[CvT2]

[AxTS]

[Tws]

[I11]

[I22]

[Ixx]

[Iyy]

[Ixy]

[Area]

[J]

[SA1]

[SA2]

[S11]

[S22]

[Sxx]

[Syy]

[Z11p]

[Z11n]

[Z22p]

[Z22n]

[Zxxp]

[Zxxn]

[Zyyp]

[Zyyn]

Torque

Deformational curvature in principal 1 plane

Deformational curvature in principal 2 plane

Deformational axial strain

Total curvature in principal 1 plane

Total curvature in principal 2 plane

Total axial strain

Twist

Maximum second moment of area

Minimum second moment of area

Moment of area about local x axis

Moment of area about local y axis

Cross moment of area about local x-y axes

Cross section area

Torsion constant

Shear area in principal 1 direction

Shear area in principal 2 direction

Plastic modulus in principal 1 direction

Plastic modulus in principal 2 direction

Plastic modulus in local x direction

Plastic modulus in local y direction

Section modulus in the principal 1 direction for stress on the positive side

Section modulus in the principal 1 direction for stress on the negative side

Section modulus in the principal 2 direction for stress on the positive side

Section modulus in the principal 2 direction for stress on the negative side

Section modulus in the local x direction for stress on the positive side

Section modulus in the local x direction for stress on the negative side

Section modulus in the local y direction for stress on the positive side

Section modulus in the local y direction for stress on the negative side

Plate Primary Variables

Plate primary variables are generally defined with the convention [ABCD], where:

A – Result type; one of stress [S], deformation strain [E], total strain [T], force [F], moment [M],
deformation curvature [K] or total curvature [L].

B – Component axis directions defined by the coordinate system (e.g. xx, yy, 11, etc).

Strand7 API Manual

C – Coordinate system; one of local [L], global [G], UCS [U] or combined.

D – Optional plate surface definition, from which the primary variable result is to be extracted; one of
mid-plane [-MP], -z [-NZ] or +z [-PZ]. This applies only to the contour shown on the rendered element in
the model window; if the option is omitted, the contour displayed depends on how the plate element is
rendered (i.e. whether it is rendered as solid or as surface). For the extraction of user defined results on
plate elements via functions such as St7GetPlateResultArray, the surface is specifed in the function call,
therefore this option is not relevant.

In addition, user defined results for plates may also use the membrane thickness [TM] and the bending thickness
[TB] of the plate.

Not all plate primary variables require all of A, B, C and D.  The following table illustrates some of the variations of
plate primary variable definitions for stress, strain, force and curvature.

Plate Primary Variables

Description

[SXXL]

[SXXL-NZ]

[SYYG]

[SYYG-PZ]

[SXXU]

[SXYU-NZ]

[EXXL]

[EXXL-NZ]

[EYYG]

[EYYG-PZ]

[EXXU]

[EXYU-NZ]

[FXXL]

[FYYG]

[FXXU]

[FXYU]

[MXXL]

[MYYG]

Direct stress in the local x direction on the surface that is displayed

Direct stress in the local x direction on the -z surface

Direct stress in the global Y direction on the surface that is displayed

Direct stress in the global Y direction on the +z surface

Direct stress in the first axis direction of the current UCS on the surface that is
displayed

Shear stress in the first two axis directions of the current UCS on the -z surface

Direct deformation strain in the local x direction on the surface that is displayed

Direct deformation strain in the local x direction on the -z surface

Direct deformation strain in the global Y direction on the surface that is displayed

Direct deformation strain in the global Y direction on the +z surface

Direct deformation strain in the first axis direction of the current UCS on the
surface that is displayed

Shear deformation strain in the first two axis directions of the current UCS on the -
z surface

Direct force in the local x direction (surface is not relevant for force results)

Direct force in the global Y direction (surface is not relevant for force results)

Direct force in the first axis direction of the current UCS (surface is not relevant for
force results)

Shear force in the first two axis directions of the current UCS (surface is not
relevant for force results)

Direct moment in the local x direction (surface is not relevant for moment results)

Direct moment in the global Y direction (surface is not relevant for moment
results)

User Defined Results

[MXXU]

[MXYU]

[KXXL]

[KYYG]

[KXXU]

[KXYU]

[S11-PZ]

[SMEAN-NZ]

[SVM-NZ]

[STR-NZ]

[TM]

[TB]

Direct moment in the first axis direction of the current UCS (surface is not relevant
for moment results)

Twisting moment in the first two axis directions of the current UCS (surface is not
relevant for moment results)

Direct deformation curvature in the local x direction (surface is not relevant for
curvature results)

Direct deformation curvature in the global Y direction (surface is not relevant for
curvature results)

Direct deformation curvature in the first axis direction of the current UCS (surface
is not relevant for curvature results)

Twist in the first two axis directions of the current UCS (surface is not relevant for
curvature results)

Maximum principal stress on the +z surface

Mean stress on the -z surface

von Mises stress on the -z surface

Tresca stress on the -z surface

Plate membrane thickness

Plate bending thickness

Brick Primary Variables

Brick primary variables are generally defined with the convention [ABC], where:

A – Result type; one of stress [S], deformation strain [E] or total strain [T].

B – Component axis directions defined by the coordinate system (e.g. xx, yy, 11, etc).

C – Coordinate system; one of local [L], global [G], UCS [U] or combined.

Not all brick primary variables require all of A, B and C.  The following table illustrates some of the variations of
brick primary variables for stress and strain.

Brick Primary Variables  Description

[SXXL]

[SYYG]

[SXXU]

[SXYU]

[EXXL]

[EYYG]

[EXXU]

[EXYU]

Direct stress in the local x direction

Direct stress in the global Y direction

Direct stress in the first axis direction of the current UCS

Shear stress in the first two axis directions of the current UCS

Direct deformation strain in the local x direction

Direct deformation strain in the global Y direction

Direct deformation strain in the first axis direction of the current UCS

Shear deformation strain in the first two axis directions of the current UCS

Strand7 API Manual

[S11]

[S33]

[SMEAN]

[SVM]

[STR]

Numeric Constants

Maximum principal stress

Minimum principal stress

Mean stress

von Mises stress

Tresca stress

Numeric constants may be entered in integer format (e.g. 100), in simple floating point format (e.g. 3.14), or in
scientific notation (e.g. 1.67E-2, where E separates the mantissa from the exponent).  If used, the decimal point
must be entered as the decimal separator defined in Windows.  This is typically the period (.) or the comma (,).

Operators

The equation string supports the standard operators: addition +, subtraction -, multiplication *, division / and
exponentiation ^, as well as brackets () to control the order of operations (otherwise the standard BODMAS
convention applies).

Functions

The following functions may be used in the equation string.

Function

Description

ABS

ACOS

ASIN

ATAN

COS

EXP

FACT

HACOS

HASIN

HATAN

HCOS

HSIN

HTAN

IF

IFNEG

IFNEGB

IFPOS

absolute value

arccosine

arcsine

arctangent

cosine

natural exponent (base e)

factorial

hyperbolic arccosine

hyperbolic arcsine

hyperbolic arctangent

hyperbolic cosine

hyperbolic sine

hyperbolic tangent

If (logical test; value if true; value if false) where “;” is the list separator character

returns argument when argument is negative, 0.0 otherwise

returns 1.0 when argument is negative, 0.0 otherwise

returns argument when argument is positive, 0.0 otherwise

User Defined Results

IFPOSB

returns 1.0 when argument is positive, 0.0 otherwise

LN

LOG

MAX

MIN

SIN

SQR

SQRT

TAN

natural log (base e)

log base 10

returns the maximum of a series of values separated by the list separator character

returns the minimum of a series of values separated by the list separator character

sine

square

square root

tangent

Strand7 API Manual

Creep Definitions

A number of the creep laws available in Strand7 require the specification of coefficients. These coefficients are
defined by the Doubles array passed by St7SetCreepBasicData and St7GetCreepBasicData. The positions of these
coefficients in this array are listed below, along with their relevant creep law.

Primary Power Law – clPrimaryPower

Doubles[0..3] – Coefficients C1, C2, C3 and CT.

Secondary Power Law – clSecondaryPower

Doubles[0..2] – Coefficients C1, C2 and CT.

Primary + Secondary Power Law – clPrimarySecondaryPower

Doubles[0..6] – Coefficients C1, C2, C3, CT1, C4, C5 and CT2.

Secondary Hyperbolic Creep – clSecondaryHyperbolic

Doubles[0..3] – Coefficients C1, C2, C3 and CT.

Secondary Exponential Creep – clSecondaryExponential

Doubles[0..2] – Coefficients C1, C2 and CT.

Theta Projection Creep – clThetaProjection

Doubles[0..3] – Coefficients A1, A2, A3 and A4.

Doubles[4..7] – Coefficients B1, B2, B3 and B4.

Doubles[8..11] – Coefficients C1, C2, C3 and C4.

Doubles[12..15] – Coefficients D1, D2, D3 and D4.

Generalised Graham Creep – clGenGraham

Doubles[0..7] – Coefficients C1, C2, C3, C4, C5, C6, C7 and CT.

Generalised Blackburn Creep – clGenBlackburn

Doubles[0..6] – Coefficients C1, C2, C3, C4, C5, C6 and C7.

Model Window Components

Model Window Components

The model window has a number of optional components that may be activated or deactivated using the
functions in Model Window.  The components are shown below, along with the functions used to show or enable
them.
