# St7GetCreepConcreteShrinkageTableData

Returns the table associated with the concrete shrinkage data for the specified creep law definition.

long St7GetCreepConcreteShrinkageTableData(long uID, long CreepID, long* TableID)
Input Parameters
uID
Strand7 model file ID.
CreepID
Creep layout ID.
Output Parameters
TableID
Strain vs Time table ID, or 0 for none.
