# St7SetFreedomCaseDefaults

Sets the defaults for the specified freedom case within a Strand7 model.

long St7SetFreedomCaseDefaults(long uID, long CaseNum, long* Defaults)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Freedom case number.

Defaults[0..5]

An array describing the global restraint conditions for each DoF in the global XYZ system. Defaults[i]
= btTrue indicates that DoF i is fixed.

Load and Freedom Cases
