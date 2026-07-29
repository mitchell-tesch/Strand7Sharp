# St7ConvertLoadPathsToLoadCases

Converts selected load paths to load cases.

long St7ConvertLoadPathsToLoadCases(long uID, bool PointForces,
bool DistributedForces, bool HeatSources)
Input Parameters
uID
Strand7 model file ID.
PointForces
True to generate point forces.
DistributedForces
True to generate distributed forces.
HeatSources
True to generate heat sources.
Dependencies
Selection
Load paths can be selected using functions in Entity Selection.
Keep Selected
Assigned using St7SetKeepSelect.
