# St7ImportSAP2000

Imports a SAP2000 model file.

Import/Export Utilities

long St7ImportSAP2000(long uID, char* FileName, long* Integers, long Mode)

Input Parameters

uID

Strand7 model file ID.

FileName

Full path and name for the SAP2000 file to be imported.

Integers[0..2]

[ipSAP2000DecimalSeparator] – Decimal character; either ieSAP2000Period or ieSAP2000Comma.

[ipSAP2000ThousandSeparator] – Thousands character; one of ieSAP2000Period,
ieSAP2000Comma, ieSAP2000Space or ieSAP2000None.

[ipSAP2000MergeDuplicateFreedomSets] – Merges duplicate freedom sets in the imported file;
either btTrue or btFalse.

Mode

Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
