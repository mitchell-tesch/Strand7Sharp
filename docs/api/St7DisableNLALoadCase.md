# St7DisableNLALoadCase

Disables the specified load case such that it is not included in nonlinear static analysis.

long St7DisableNLALoadCase(long uID, long Stage, long CaseNum)

Input Parameters

uID

Strand7 model file ID.

Stage

Stage index – use 0 for unstaged analysis.

CaseNum

Load case number.

Solver – Nonlinear Static
