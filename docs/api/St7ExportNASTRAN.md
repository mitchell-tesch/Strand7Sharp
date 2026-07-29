# St7ExportNASTRAN

Exports the current Strand7 model as a NASTRAN model file.

long St7ExportNASTRAN(long uID, char* FileName, long* Integers, double* Doubles,
long Mode)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and name for the NASTRAN file to be created.
Integers[0..17]
[ipNASTRANFreedomCase] – Exported freedom case.
[ipNASTRANLoadCaseNSMass] – Exported load case for non-structural mass attributes.
[ipNASTRANSolver] – Nastran solver type; one of ieNASTRANSolverLSA, ieNASTRANSolverNFA,
ieNASTRANSolverLBA or ieNASTRANSolverNLA.
[ipNASTRANExportUnits] – Units for exported file; one of usNASTRAN_kg_N_m,
usNASTRAN_T_N_mm, usNASTRAN_sl_lbf_ft, usNASTRAN_lbm_lbf_in, usNASTRAN_sl_lbf_in or
usNASTRAN_None.
[ipNASTRANBeamStressSections] – Number of sections defined for exported beam elements.

[ipNASTRANBeamSectionGeometry] – Export beam section geometry; either
ieNASTRANExportGeometryProps or ieNASTRANExportPropsOnly.
[ipNASTRANExportHeatTransfer] – Export heat transfer property data; either btTrue or btFalse.
[ipNASTRANExportNSMass] – Export non-structural mass attributes; either btTrue or btFalse.
[ipNASTRANExportUnusedProps] – Export unreferenced material properties; either btTrue or
btFalse.
[ipNASTRANTemperatureCase] – Load case from which reference temperature is exported.
[ipNASTRANPreLoadCase] – Load case from which contact element pre-strain value is taken.
[ipNASTRANNInc] – NINC value for SOL 106 export.
[ipNASTRANMaxIter] – MAXITER value for SOL 106 export.
[ipNASTRANDoEPSU] – Include displacement in the SOL 106 convergence criteria; either btTrue or
btFalse.
[ipNASTRANDoEPSP] – Include force in the SOL 106 convergence criteria; either btTrue or btFalse.
[ipNASTRANDoEPSW] – Include work in the SOL 106 convergence criteria; either btTrue or btFalse.
[ipNASTRANExportPyramid] – Export Pyramid elements; either ieNASTRANExportPyramidAsHexa
for collapsed hexahedra or ieNASTRANExportPyramidAsPyram for CPYRAM.
[ipNASTRANExportQuad4] – Export Quad4 elements; either ieNASTRANExportCQUAD4 for CQUAD4
or ieNASTRANExportCQUADR for CQUADR.
Doubles[0..3]
[ipNASTRANExportZeroFields] – Zero tolerance. Parameters with magnitude less than this value
are set to zero on export.
[ipNASTRANEPSU] – Tolerance for displacement criterion in SOL 106.
[ipNASTRANEPSP] – Tolerance for force criterion in SOL 106.
[ipNASTRANEPSW] – Tolerance for work criterion in SOL 106.
Mode
Controls the display of a progress bar; either ieQuietRun or ieProgressRun.
