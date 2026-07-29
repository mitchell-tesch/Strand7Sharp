# St7ImportST7

Imports the specified Strand7 text file format model.

long St7ImportST7(long uID, char* FileName, long* Integers, long Mode)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and name for the Strand7 text-file to be imported.
Integers[0..1]
[ipSt7ImportRemoveCases] – btTrue to remove the existing load and freedom cases prior to import
so those from the imported model are the only cases; only applicable to empty models (that is, models
with no entities).
[ipSt7ImportMatchUCSNames] – btTrue to map incoming UCS definitions to existing UCS definitions
with the same name. Note that if the definition of the incoming UCS is not the same as that of the
existing UCS, the incoming UCS definition will be lost.
Mode
Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
