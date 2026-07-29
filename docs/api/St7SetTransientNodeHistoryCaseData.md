# St7SetTransientNodeHistoryCaseData

Assigns the settings for the specified node history case for linear and nonlinear transient dynamic analysis.

long St7SetTransientNodeHistoryCaseData(long uID, long Pos, long NodeNum,
bool* Logicals)
Input Parameters
uID
Strand7 model file ID.
Pos
Node history case number.
NodeNum
Node number.
Logicals[0..5]
[0..2] – True to include each of the global XYZ nodal result components respectively.
[3..5] – True to include displacement, velocity and acceleration results respectively.
