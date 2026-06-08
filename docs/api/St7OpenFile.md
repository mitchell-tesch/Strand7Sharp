# St7OpenFile

Opens an existing Strand7 model file with an exclusive lock. This call is required before any data can be read from,
or written to, a Strand7 model file. Multiple model files can be opened simultaneously by using a different model
file ID for each file (see St7GetMaxModelFileID).

long St7OpenFile(long uID, char* FileName, char* ScratchPath)

Input Parameters

uID

Strand7 model file ID.

FileName

Full path and filename for the Strand7 model.

ScratchPath

A valid path to be used for temporary storage.
