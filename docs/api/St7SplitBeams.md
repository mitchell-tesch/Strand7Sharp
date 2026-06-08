# St7SplitBeams

Splits the selected beams by a defined ratio.

long St7SplitBeams(long uID, double SplitRatio, long SplitType)

Input Parameters

uID

Strand7 model file ID.

SplitRatio

Ratio of the split between ends 1 and 2, from 0.0 to 1.0.

SplitType

Property ID for the split portion of the beam.  Set -1 to assign the ID of the parent beam.

Tools – Mesh

Dependencies
Selection

Beams can be selected using functions in Entity Selection.
