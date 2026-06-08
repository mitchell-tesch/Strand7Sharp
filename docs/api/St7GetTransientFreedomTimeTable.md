# St7GetTransientFreedomTimeTable

Returns the Factor vs Time table associated with the specified freedom case for quasi-static and transient dynamic
analysis.

long St7GetTransientFreedomTimeTable(long uID, long CaseNum, long* TableID,

bool* AddTimeSteps)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Freedom case number.

Output Parameters

TableID

Factor vs Time table ID, or 0 for none.

AddTimeSteps

True to Add Time Steps at ordinates in the Factor vs Time table.

Strand7 API Manual

Solver – Steady Heat and Transient Heat
