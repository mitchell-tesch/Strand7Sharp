# St7CheckPatchLoads

Simulates the conversion of load patches to distributed beam loads in the specified load case without actually
generating the beam loads. This allows the developer to determine which load patches can successfully transfer
loads and which may require adjustment. This can be done by examining the global parameters to check for load
patch plate edges that remain selected after the function has been called; edges that remain selected are those at
which the load could not be transferred to beam elements.

long St7CheckPatchLoads(long uID, long CaseNum)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Load case number.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
Global Parameters
ivPlateEdgesAssigned, ivPlateEdgesNotFullyAssigned.
