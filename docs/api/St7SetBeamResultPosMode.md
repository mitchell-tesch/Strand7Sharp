# St7SetBeamResultPosMode

Sets the mode of the beam position variable used by the beam result extraction functions.

long St7SetBeamResultPosMode(long uID, long Mode)

Input Parameters

uID

Strand7 model file ID.

Mode

One of bpLength or bpParam, representing beam position in physical length units of the model or as a
ratio of element length, respectively.
