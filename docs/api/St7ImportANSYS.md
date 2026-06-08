# St7ImportANSYS

Imports an ANSYS model file.

long St7ImportANSYS(long uID, char* FileName, char* LoadCaseFilePath,

long* Integers, long Mode)

Input Parameters

uID

Strand7 model file ID.

FileName

Full path and name for the ANSYS file to be imported.

LoadCaseFilePath

Full path to the directory containing the load case data for the ANSYS file.

Integers[0..5]

[ipANSYSImportFormat] – Import format; one of ieANSYSBatchImport, ieANSYSCDBImport or
ieANSYSBatchCDBImport.

[ipANSYSArrayParameters] – Array parameter type; one of ieANSYSArrayOverwrite,
ieANSYSArrayIgnore or ieANSYSArrayPrompt.

[ipANSYSImportLoadCaseFiles] – Import additional load case files; either btTrue or btFalse.

Strand7 API Manual

[ipANSYSImportIGESEntities] – Import IGES geometry definitions; either btTrue or btFalse.

[ipANSYSFixElementConnectivity] – Fix element connectivity; either btTrue or btFalse.

[ipANSYSRemoveDuplicateProps] – Remove duplicate property definitions; either btTrue or
btFalse.

Mode

Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
