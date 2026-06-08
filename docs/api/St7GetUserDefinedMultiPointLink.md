# St7GetUserDefinedMultiPointLink

Returns the parameters for the specified user defined multi-point link.

long St7GetUserDefinedMultiPointLink(long uID, long LinkNum, long MaxNodes,
long* NumNodes, long* CaseNum, double* CFactor, long* Connection,
long* Integers, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

LinkNum

Link number.

MaxNodes

The allocated size of the Connection array.  If the full connectivity of the link is required this should be
at least as large as the number of nodes attached to the link, which can be obtained using
St7GetNumMultiPointLinkNodes.

Output Parameters
NumNodes

The number of nodes in the link.

CaseNum

Freedom case that scales the constant factor in nonlinear and time-based analyses, or 0.

CFactor

Constant factor.

Connection[0..Min(NumNodes,MaxNodes)-1]

Node numbers for linked nodes, with the slave node specified first.

Integers[0..Min(NumNodes,MaxNodes)-1]

DoF for linked nodes, with the slave DoF specified first.

Doubles[0..Min(NumNodes,MaxNodes)-1]

Factors for linked nodes, with the slave factor specified first.
