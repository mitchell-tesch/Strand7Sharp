# St7ConvertBeamPolygonsToPlates

Converts selected beam polygons into plates. Beam polygons can have three or four sides.

long St7ConvertBeamPolygonsToPlates(long uID, double MinInternalAngle,
double MaxInternalAngle, double MaxNormalAngle, bool CreateQuad4)
Input Parameters
uID
Strand7 model file ID.
MinInternalAngle
Minimum internal angle for a Quad4 element (otherwise, two Tri3 elements are created).
MaxInternalAngle
Maximum internal angle for a Quad4 element (otherwise, two Tri3 elements are created).
MaxNormalAngle
Maximum normal angle between two adjacent Tri3 elements to be merged to a Quad4 (otherwise, two
Tri3 elements are created).
CreateQuad4
True to create Quad4 elements if the angular criteria are met.

Dependencies
Selection
Beams can be selected using functions in Entity Selection.
Source Action
Assigned using St7SetSourceAction.
Keep Selected
Assigned using St7SetKeepSelect.
