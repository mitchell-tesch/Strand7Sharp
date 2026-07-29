# St7OpenFileReadOnly

Opens a Strand7 model file in read-only mode; the file cannot be modified while open in this mode. This call is
required before any data can be read from a Strand7 model file. Multiple model files can be opened
simultaneously by using a different model file ID for each file (see St7GetMaxModelFileID).

long St7OpenFileReadOnly(long uID, char* FileName, char* ScratchPath)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and filename for the Strand7 model.
ScratchPath
A valid path to be used for temporary storage.
