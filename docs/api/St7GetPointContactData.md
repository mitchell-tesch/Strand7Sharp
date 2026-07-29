# St7GetPointContactData

Returns the point contact element parameters assigned to the specified beam property.

long St7GetPointContactData(long uID, long PropNum, long* Integers,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Output Parameters
Integers[0..6]
[ipContactType] – Type of contact element; one of ctZeroGap, ctNormal, ctTension or ctTakeup.
[ipContactSubType] – Type of Takeup contact; either tuTension or tuCompression.
[ipDynamicStiffness] – Update the stiffness of the contact element; either btTrue or btFalse.
[ipUpdateDirection] – Update the direction of the contact throughout solution; either btTrue or
btFalse.
[ipFrictionModel] – Type of friction model used; either cfElastic or cfPlastic.
[ipFrictionYieldType] – Type of yield; either cyRectangular or cyElliptical.
[ipTensionLateralStiffness] – Use lateral stiffness with tuTension elements; either btTrue or
btFalse.
Doubles[0..5]
[ipContactAxialStiffness] – Penalty stiffness value in axial direction. This value is updated
dynamically based on the Update Direction settings.
[ipContactLateralStiffness] – Penalty stiffness value in lateral direction.
[ipFrictionC1] – Lateral friction coefficient in the 1 axis direction.
[ipFrictionC2] – Lateral friction coefficient in the 2 axis direction.
[ipContactMaxTension] – Maximum tensile force value.
[ipContactStrainTol] – Target strain range for active point contacts with Dynamic Stiffness.
