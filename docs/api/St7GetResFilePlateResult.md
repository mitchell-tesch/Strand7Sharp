# St7GetResFilePlateResult

Returns the specified plate result quantities for a given plate element and result case in the custom result file.

long St7GetResFilePlateResult(long uID, long CaseNum, long PlateNum,
long Quantity, bool* NonlinearMaterial, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Result case number.
PlateNum
Plate number.
Quantity
One of rtPlateStress, rtPlateStrain, rtPlateNodeReact, rtPlateFlux or rtPlateNodeFlux.
Output Parameters
NonlinearMaterial
True if the results correspond to a material nonlinear analysis. This option applies only for result files of
type stNonlinearStatic, stQuasiStatic and stNonlinearTransientDynamic.
Doubles[..]
An array defining the specified plate result quantity at each Gauss point or node on the plate,
depending on the quantity. See Custom Results for additional information.
