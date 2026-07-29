# St7SetProjectDirectionAsParallel

Sets the mode of projection to Parallel for subsequent uses of projection tools.

long St7SetProjectDirectionAsParallel(long uID, double* P1, double* P2)
Input Parameters
uID
Strand7 model file ID.

P1[0..2]
Origin point of projection direction.
P2[0..2]
Destination point of projection direction.

Tools – General State
Functions in this section set a variety of states as referenced by later function calls. The states persists until the
model is closed.
