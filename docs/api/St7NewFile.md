# St7NewFile

Creates and opens a new Strand7 model file. Multiple model files can be opened simultaneously by using a
different model file ID for each file (see St7GetMaxModelFileID). Note that if a file of the same name exists, the
existing file will stay open and will not be overwritten until the new file is saved.

long St7NewFile(long uID, char* FileName, char* ScratchPath)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and filename for the Strand7 model.
ScratchPath
A valid path to be used for temporary storage.
