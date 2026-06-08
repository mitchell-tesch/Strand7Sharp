# St7SetTransientFreedomTimeTable

Specifies the Factor vs Time table to be associated with a given freedom case for quasi-static and transient
dynamic analysis.

Solver – Quasi-static and Transient Dynamic

long St7SetTransientFreedomTimeTable(long uID, long CaseNum, long TableID,

bool AddTimeSteps)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Freedom case number.

TableID

Factor vs Time table ID, or 0 for none.

AddTimeSteps

True to Add Time Steps at ordinates in the Factor vs Time table.
