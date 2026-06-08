# St7SetTransientLoadTimeTable

Specifies the Factor vs Time table to be associated with a given load case for quasi-static and transient dynamic
analysis.

Strand7 API Manual

long St7SetTransientLoadTimeTable(long uID, long CaseNum, long TableID,

bool AddTimeSteps)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Load case number.

TableID

Factor vs Time table ID, or 0 for none.

AddTimeSteps

True to Add Time Steps at ordinates in the Factor vs Time table.
