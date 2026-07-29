# St7GetTwoPointLink

Returns the parameters for the specified two-point link.

long St7GetTwoPointLink(long uID, long LinkNum, long* Connection, long* Integers,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.
LinkNum
Link number.
Output Parameters
Connection[0..2]
[0] – Number of nodes in the link (2).
[1..2] – Node numbers.
Integers[0..4]
[ipTwoPointDOF1] – DoF at node 1; one of 1, 2, 3, 4, 5 or 6.
[ipTwoPointDOF2] – DoF at node 2; one of 1, 2, 3, 4, 5 or 6.
[ipTwoPointUCS1] – UCS ID number at node 1.
[ipTwoPointUCS2] – UCS ID number at node 2.
[ipTwoPointFC] – Freedom case that scales the constant coefficient in a nonlinear analysis, or 0 if
this parameter is not set.
Doubles[0..2]
[ipTwoPointC1] – Coefficient of node 1.
[ipTwoPointC2] – Coefficient of node 2.
[ipTwoPointConst] – Constant coefficient.
