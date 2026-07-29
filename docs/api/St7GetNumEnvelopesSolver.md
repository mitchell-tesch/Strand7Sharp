# St7GetNumEnvelopesSolver

Returns the number of envelopes for the specified solver and solver mode.

long St7GetNumEnvelopesSolver(long uID, long Solver, long SolverMode,
long* NumLimitEnvelopes, long* NumCombinationEnvelopes,
long* NumFactorsEnvelopes)
Input Parameters
uID
Strand7 model file ID.
Solver
One of the solver types listed in Solver Types.
SolverMode
One of smNone, smFreqSolution, smTimeSolution or smTimeMode when Solver is stHarmonicResponse;
ignored for all other solvers.
Output Parameters
NumLimitEnvelopes
Number of limit envelopes.

NumCombinationEnvelopes
Number of combination envelopes.
NumFactorsEnvelopes
Number of factors envelopes.
