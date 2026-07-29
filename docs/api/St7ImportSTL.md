# St7ImportSTL

Imports a stereo-lithography file.

long St7ImportSTL(long uID, char* FileName, long* Integers, long Mode)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and name for the STL file to be imported.
Integers[0..1]
[ipSTLImportProperty] – Default property for imported plates.
[ipSTLImportLengthUnit] – Specifies a length unit for the import file; one of luSTLNone,
luSTLMillimetre, luSTLCentimetre, luSTLMetre, luSTLInch, luSTLFoot.

Mode
Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
