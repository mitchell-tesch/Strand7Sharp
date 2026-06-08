# St7GetElementNodeFluxSum

Returns the flux contributions of elements at nodes for thermal solvers.

long St7GetElementNodeFluxSum(long uID, long ResultCase, long* EntityState,

double* FluxSum)

Input Parameters

uID

Strand7 model file ID.

ResultCase

Result case number.

EntityState[0..kMaxEntity-1]

[tyNODE] – Nodes for which the entity node flux should be collected – either ssSelected or
ssUnselected.

[tyBEAM] – Beams that contribute flux – either ssSelected or ssUnselected.

[tyPLATE] – Plates that contribute flux – either ssSelected or ssUnselected.

[tyBRICK] – Bricks that contribute flux – either ssSelected or ssUnselected.

[tyLINK] – Links that contribute flux – either ssSelected or ssUnselected.

Output Parameters

FluxSum

Flux.

Strand7 API Manual
