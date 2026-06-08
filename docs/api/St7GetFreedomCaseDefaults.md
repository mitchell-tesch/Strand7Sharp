# St7GetFreedomCaseDefaults

Returns the defaults for the specified freedom case in a Strand7 model.

long St7GetFreedomCaseDefaults(long uID, long CaseNum, long* Defaults)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Freedom case number.

Output Parameters

Defaults[0..5]

An array describing the global restraint conditions for each DoF in the global XYZ system.
Defaults[i] = btTrue indicates that DoF i is fixed.
