# St7GetLoadPathTemplateHeatSourceData

Returns the heat source data assigned to the specified load path template.

long St7GetLoadPathTemplateHeatSourceData(long uID, long TemplateID,
long Vehicle, long Pos, long* Integers, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
TemplateID
Load path template ID.
Vehicle
Vehicle number.
Pos
Heat source number.

Output Parameters
Integers[0]
Currently unused.
Doubles[0..4]
[0..1] – XY position of the heat source.
[2..3] – XY dimensions of the heat source.
[4] – Heat source.
