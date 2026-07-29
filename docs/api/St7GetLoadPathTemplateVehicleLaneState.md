# St7GetLoadPathTemplateVehicleLaneState

Returns the enabled state of a vehicle/lane combination within the specified load path template.

long St7GetLoadPathTemplateVehicleLaneState(long uID, long TemplateID,
long Vehicle, long Lane, bool* Enabled)
Input Parameters
uID
Strand7 model file ID.

TemplateID
Load path template ID.
Vehicle
Vehicle number.
Lane
Lane number.
Output Parameters
Enabled
True if the specified vehicle/lane combination is enabled.
