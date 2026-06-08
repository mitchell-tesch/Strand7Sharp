# St7GetTransientLoadTimeTable

Returns the Factor vs Time table associated with the specified load case for quasi-static and transient dynamic
analysis.

long St7GetTransientLoadTimeTable(long uID, long CaseNum, long* TableID,

bool* AddTimeSteps)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Load case number.

Output Parameters

TableID

Factor vs Time table ID, or 0 for none.

AddTimeSteps

True to Add Time Steps at ordinates in the Factor vs Time table.
