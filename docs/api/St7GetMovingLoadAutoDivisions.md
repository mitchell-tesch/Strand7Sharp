# St7GetMovingLoadAutoDivisions

Returns the option to use load path divisions appropriate for the timesteps for a given load path.

long St7GetMovingLoadAutoDivisions(long uID, long LoadPathID, bool* Enabled)
Input Parameters
uID
Strand7 model file ID.
LoadPathID
Load path ID.
Output Parameters
Enabled
True if the solver is allowed to set load path divisions.
