# St7GetMultiPointLinkNodeFlux

Returns the flux results at nodes of the reaction multi-point link for thermal solvers.

long St7GetMultiPointLinkNodeFlux(long uID, long LinkNum, long ResultCase,
double* Flux, long MaxNodes)
Input Parameters
uID
Strand7 model file ID.
LinkNum
Link number.
ResultCase
Result case number.
MaxNodes
The maximum number of nodes that can be stored in the Flux array.
Output Parameters
Flux[0..MaxNodes-1]
An array of doubles that stores the flux result for each node, up to MaxNodes.
