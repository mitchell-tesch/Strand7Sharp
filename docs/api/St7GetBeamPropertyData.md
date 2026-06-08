# St7GetBeamPropertyData

Returns the specified beam property.

long St7GetBeamPropertyData(long uID, long PropNum, long* Integers,

double* SectionData, double* MaterialData)

Input Parameters

uID

Strand7 model file ID.

PropNum

Property number.

Output Parameters

Integers[0..4]

[ipBeamPropBeamType] – Type of beam element; one of btNull, btSpring, btCable, btTruss, btCutoff,
btContact, btBeam, btUser, btPipe or btConnection.

[ipBeamPropUsePoisson] – btTrue to use E and rho for material properties, btFalse to use E and G.

[ipBeamPropSectionType] – One of the section shapes defined in Beam Cross Section Shape.

[ipBeamPropMirrorType] – One of the section mirror types defined in Beam Cross Section Mirror
Options.

[ipBeamPropCompatibleTwist] – Compatible twist option for mirrored sections; either btTrue or
btFalse.

SectionData[0..kNumBeamSectionData-1]

[ipAREA] – Section area.

[ipI11] – Second moment of area about the principal 1 axis.

[ipI22] – Second moment of area about the principal 2 axis.

Strand7 API Manual

[ipJ] – Torsion constant.

[ipSL1] – Shear centre offset in the principal 1 axis direction.

[ipSL2] – Shear centre offset in the principal 2 axis direction.

[ipSA1] – Shear area in the principal 1 axis direction.

[ipSA2] – Shear area in the principal 2 axis direction.

[ipXBAR] – Centroid x coordinate.

[ipYBAR] – Centroid y coordinate.

[ipANGLE] – Principal axis 1 angle in radians w.r.t. the local section coordinates.

[ipD1] – Section geometry D1 parameter; see Beam Cross Section Shape.

[ipD2] – Section geometry D2 parameter.

[ipD3] – Section geometry D3 parameter.

[ipT1] – Section geometry T1 parameter.

[ipT2] – Section geometry T2 parameter.

[ipT3] – Section geometry T3 parameter.

[ipGapA] – Mirrored section gap parameter A.

[ipGapB] – Mirrored section gap parameter B.

MaterialData[0..kNumMaterialData-1]

[ipModulus] – Material modulus.

[ipPoisson] – Material Poisson’s ratio.

[ipDensity] – Material density.

[ipShearModulus] – Material shear modulus.

Note that MaterialData values are as stored in the model, not as used by the solver.  The solver will take
into account Integers[ipBeamPropUsePoisson] to determine the material values to use.
