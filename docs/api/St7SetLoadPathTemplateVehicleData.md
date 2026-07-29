# St7SetLoadPathTemplateVehicleData

Sets the data for a vehicle in the specified load path template.

long St7SetLoadPathTemplateVehicleData(long uID, long TemplateID, long Vehicle,
long* Integers, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
TemplateID
Load path template ID.

Vehicle
Vehicle number.
Integers[0..1]
[ipLPTVehicleInstance] – Vehicle instance type; either lpVehicleSingleLane or
lpVehicleDoubleLane.
[ipLPTVehicleDirection] – Vehicle direction flag; either lpVehicleForward or lpVehicleBackward.
Doubles[0..1]
[ipLPTVehicleVelocity] – Vehicle velocity.
[ipLPTVehicleStartTime] – Vehicle start time.
