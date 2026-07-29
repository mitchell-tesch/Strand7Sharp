# St7ImportNASTRAN

Imports a NASTRAN model file.

long St7ImportNASTRAN(long uID, char* FileName, long* Integers, long Mode)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and name for the NASTRAN file to be imported.
Integers[0..0]
[ipNASTRANImportUnits] – Nastran file units; one of usNASTRAN_kg_N_m, usNASTRAN_T_N_mm,
usNASTRAN_sl_lbf_ft, usNASTRAN_lbm_lbf_in, usNASTRAN_sl_lbf_in or usNASTRAN_None.
Mode
Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
