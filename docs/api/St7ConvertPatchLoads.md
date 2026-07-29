# St7ConvertPatchLoads

Converts load patches in the specified load case to distributed beam loads.

long St7ConvertPatchLoads(long uID, long CaseNum, bool Overwrite)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Load case number.
Overwrite
True to overwrite the existing beam loads.

False to add to the existing beam loads.
Dependencies
Selection
Entities can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
Global Parameters
ivPlateEdgesAssigned, ivPlateEdgesNotFullyAssigned.
