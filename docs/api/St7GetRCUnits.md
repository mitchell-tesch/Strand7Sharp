# St7GetRCUnits

Returns the units used for Plate RC results (in Results Settings). Note that this setting is ignored unless
St7EnableModelRCUnit is called.

long St7GetRCUnits(long uID, long* AreaUnit, long* LengthUnit)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
AreaUnit
One of luMETRE, luCENTIMETRE, luMILLIMETRE, luFOOT or luINCH.
LengthUnit
One of luMETRE, luCENTIMETRE, luMILLIMETRE, luFOOT or luINCH.
