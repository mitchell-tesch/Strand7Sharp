# St7GetResFileNodeResult

Returns the specified nodal result quantities for a given node and result case in the custom result file.

long St7GetResFileNodeResult(long uID, long CaseNum, long NodeNum, long Quantity,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Result case number.
NodeNum
Node number.
Quantity
One of rtNodeDisp, rtNodeVel, rtNodeAcc, rtNodeReact, rtNodeTemp or rtNodeFlux.
Output Parameters
Doubles[0..5]
An array defining the specified nodal result quantity. See Custom Results for additional information.
