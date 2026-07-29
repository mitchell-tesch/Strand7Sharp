# St7ExportANSYS

Exports the current Strand7 model as an ANSYS model file.

long St7ExportANSYS(long uID, char* FileName, long* Integers, long Mode)
Input Parameters
uID
Strand7 model file ID.

FileName
Full path and name for the ANSYS file to be created.
Integers[0..9]
[ipANSYSExportFormat] – Export format; one of ieANSYSBatch1Export, ieANSYSBatch3Export,
ieANSYSBlockedCDBExport or ieANSYSUnblockedCDBExport.
[ipANSYSFreedomCase] – Exported freedom case.
[ipANSYSLoadCase] – Exported load case for pre-load and non-structural mass attributes.
[ipANSYSUnits] – Units for the exported file; one of usANSYS_None, usANSYS_kg_m_C,
usANSYS_g_cm_C, usANSYS_T_mm_C, usANSYS_sl_ft_F or usANSYS_lbm_in_F.
[ipANSYSEndRelease] – Export partial beam end-release attributes; either ieANSYSEndReleaseFixed
or ieANSYSEndReleaseFull.
[ipANSYSExportNonlinearMat] – Export nonlinear material data; either btTrue or btFalse.
[ipANSYSExportHeatTransfer] – Export heat transfer property data; either btTrue or btFalse.
[ipANSYSExportPreLoadNSMass] – Export pre-load and non-structural mass attributes; either
btTrue or btFalse.
[ipANSYSExportTetraOption] – Export Tet4/Tet10 brick elements as SOLID72/SOLID92; either
btTrue or btFalse.
[ipANSYSExportQuad8Option] – Export Quad8 plate elements as SHELL91; either btTrue or btFalse.
Mode
Controls the display of a progress bar; either ieQuietRun or ieProgressRun.

Animation
