# St7GetMovingLoadTimeTable

Returns the Factor vs Time table associated with a given load path for the analysis.

long St7GetMovingLoadTimeTable(long uID, long LoadPathID, long* TableID)

Input Parameters

uID

Strand7 model file ID.

LoadPathID

Load path ID.

Output Parameters

TableID

Factor vs Time table ID number, or 0 if no table is assigned.
