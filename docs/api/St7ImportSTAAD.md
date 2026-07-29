# St7ImportSTAAD

Imports a STAAD model file.

long St7ImportSTAAD(long uID, char* FileName, long* Integers, long Mode)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and name for the STAAD file to be imported.
Integers[0..6]
[ipSTAADCountryType] – Default country type; one of ieSTAADAmericanCode,
ieSTAADAustralianCode or ieSTAADBritishCode.
[ipSTAADIncludeSectionLibrary] – Search additional beam cross section libraries; either btTrue
or btFalse.
[ipSTAADStripUnderscore] – Remove underscore from group names; either btTrue or btFalse.
[ipSTAADStripSectionSpaces] – Remove spaces from section names; either btTrue or btFalse.
[ipSTAADStripCaseQualifiers] – Strip qualifiers from load case strings; either btTrue or btFalse.
[ipSTAADLengthUnit] – Length unit; one of luSTAADInch, luSTAADFoot, luSTAADCentimetre,
luSTAADMetre, luSTAADMillimetre, luSTAADDecimetre or luSTAADKilometre.
[ipSTAADForceUnit] – Force unit; one of fuSTAADKip, fuSTAADPoundForce, fuSTAADKilogramForce,
fuSTAADMegatonneForce, fuSTAADNewton, fuSTAADKilonewton, fuSTAADMeganewton or
fuSTAADDecanewton.
Mode
Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
