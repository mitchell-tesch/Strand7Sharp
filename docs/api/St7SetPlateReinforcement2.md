# St7SetPlateReinforcement2

Assigns the concrete reinforcement properties for the specified plate.

long St7SetPlateReinforcement2(long uID, long PlateNum, long LayoutID,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PlateNum

Plate number.

Plate Attributes – Set

LayoutID

Reinforcement layout ID.

Doubles[0..1]

A 2-element array describing the angular orientation (degrees) of the 1-3 and 2-4 reinforcement layers
respectively.
