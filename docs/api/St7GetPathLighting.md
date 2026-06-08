# St7GetPathLighting

Returns the state of the Lighting options for load path rendering.

long St7GetPathLighting(long uID, bool* FillLighting, bool* LineLighting)

Input Parameters

uID

Strand7 model file ID.

Strand7 API Manual

Output Parameters
FillLighting

The lighting option for the load path fill; either True or False.

LineLighting

The lighting option for the load path outlines; either True or False.
