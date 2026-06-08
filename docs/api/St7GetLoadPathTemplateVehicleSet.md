# St7GetLoadPathTemplateVehicleSet

Returns the vehicle set assigned to the specified vehicle in a given load path template.

long St7GetLoadPathTemplateVehicleSet(long uID, long TemplateID, long Vehicle,

char* VehicleSet, long MaxStringLen)

Input Parameters

uID

Strand7 model file ID.

TemplateID

Load path template ID.

Vehicle

Vehicle number.

Strand7 API Manual

MaxStringLen

Maximum number of characters allocated for VehicleSet.

Output Parameters
VehicleSet

String identifying the vehicle set. A null string indicates that the specified vehicle does not belong to a
set.
