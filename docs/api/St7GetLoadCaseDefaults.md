# St7GetLoadCaseDefaults

Returns the default values for the specified load case within a Strand7 model; not applicable to seismic load cases.

long St7GetLoadCaseDefaults(long uID, long CaseNum, double* Defaults)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Load case number.

Load and Freedom Cases

Output Parameters

Defaults[0..12]

[ipLoadCaseRefTemp] – Reference temperature.

[ipLoadCaseOrigX, ipLoadCaseOrigY, ipLoadCaseOrigZ] – Origin for angular velocity and
acceleration.

[ipLoadCaseAccX, ipLoadCaseAccY, ipLoadCaseAccZ] – Linear acceleration components.

[ipLoadCaseAngVelX, ipLoadCaseAngVelY, ipLoadCaseAngVelZ] – Angular velocity
components.

[ipLoadCaseAngAccX, ipLoadCaseAngAccY, ipLoadCaseAngAccZ] – Angular acceleration
components.
