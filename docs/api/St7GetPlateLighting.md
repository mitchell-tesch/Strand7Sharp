# St7GetPlateLighting

Returns the state of the Lighting options for plate rendering.

long St7GetPlateLighting(long uID, bool* FillLighting, bool* LineLighting)
Input Parameters
uID
Strand7 model file ID.

Output Parameters
FillLighting
The lighting option for plate fill; either True or False.
LineLighting
The lighting option for plate outlines; either True or False.
