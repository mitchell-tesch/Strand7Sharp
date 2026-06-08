# St7GetMaxModelFileID

Returns the maximum model file ID.  All of the functions that operate on a model file, reference the model file via
the uID parameter in the function’s parameter list.  Multiple model files can be open simultaneously, each one
referenced by a different model file ID (for example, see St7OpenFile).

long St7GetMaxModelFileID(long* MaxID)

Output Parameters

MaxID

Maximum model file ID.   A valid uID is in the range 1 to MaxID.

Initialisation
