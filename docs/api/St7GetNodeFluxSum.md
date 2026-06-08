# St7GetNodeFluxSum

Returns the node flux sum of nodes for thermal solvers.

Results

long St7GetNodeFluxSum(long uID, long ResultCase, long NodeState,

double* FluxSum)

Input Parameters

uID

Strand7 model file ID.

ResultCase

Result case number.

NodeState

Nodes to be included in the sum – either ssSelected or ssUnselected.

Output Parameters

FluxSum

Flux.
