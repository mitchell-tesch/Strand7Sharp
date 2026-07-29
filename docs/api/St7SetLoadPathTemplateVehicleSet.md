# St7SetLoadPathTemplateVehicleSet

Assigns a vehicle set to the specified vehicle in a given load path template.

long St7SetLoadPathTemplateVehicleSet(long uID, long TemplateID, long Vehicle,
char* VehicleSet)
Input Parameters
uID
Strand7 model file ID.
TemplateID
Load path template ID.
Vehicle
Vehicle number.
VehicleSet
String identifying the vehicle set. A null string indicates that the specified vehicle does not belong to a
set.
