# St7GetTransientNodeHistoryCaseData

Returns the settings assigned for the specified node history case for linear and nonlinear transient Dynamic
analysis.

long St7GetTransientNodeHistoryCaseData(long uID, long Pos, long* NodeNum,
bool* Logicals)
Input Parameters
uID
Strand7 model file ID.
Pos
Node history case number.
Output Parameters
NodeNum
Node number.
Logicals[0..5]
[0..2] – True to include each of the global XYZ nodal result components respectively.
[3..5] – True to include displacement, velocity and acceleration results respectively.

Solver – Quasi-static and Nonlinear Transient Dynamic
