# St7SetUserDefinedMultiPointLink

Assigns the parameters for the specified user defined multi-point link.

long St7SetUserDefinedMultiPointLink(long uID, long LinkNum, long NumNodes,
long CaseNum, double CFactor, long* Connection, long* Integers,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
LinkNum
Link number.
NumNodes
The number of nodes in the link.
CaseNum
Freedom case that scales the constant factor in nonlinear and time-based analyses, or 0.
CFactor
Constant factor.
Connection[0..NumNodes-1]
Node numbers for linked nodes, with the slave node specified first.
Integers[0..NumNodes-1]
DoF for linked nodes, with the slave DoF specified first.
Doubles[0..NumNodes-1]
Factors for linked nodes, with the slave factor specified first.
Dependencies
Default Group
Target group for the link is specified by St7SetDefaultGroupID.
