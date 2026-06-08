# St7GetModalSuperpositionFile

Returns the modal superposition file assigned for harmonic response, spectral response and linear transient
dynamic analysis with mode superposition.

long St7GetModalSuperpositionFile(long uID, char* FileName, long MaxStringLen)

Input Parameters

uID

Strand7 model file ID.

MaxStringLen

Maximum number of characters allocated for FileName.

Output Parameters
FileName

Full path and name for the modal superposition file.
