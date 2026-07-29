# St7GetLoadPathTemplateVehicleName

Returns the name assigned to a vehicle in the specified load path template.

long St7GetLoadPathTemplateVehicleName(long uID, long TemplateID, long Vehicle,
char* VehicleName, long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.

TemplateID
Load path template ID.
Vehicle
Vehicle number.
MaxStringLen
Maximum number of characters allocated for VehicleName.
Output Parameters
VehicleName
Vehicle name.
