# St7SetNFAModeParticipationVectors

Assigns the direction vectors and origin, used when calculating mass participation factors for natural frequency
analysis.

long St7SetNFAModeParticipationVectors(long uID, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
Doubles[0..8]
[0..2] – Vector components of the translation axis about which to calculate mode participation.
[3..5] – Origin for the calculation of rotational mode participation.

[6..8] – Vector components of the rotational axis about which to calculate mode participation.
Usage
All values are in the global XYZ system. If vector components are all zero, participation factors are returned
for three global directions. Mode participation factors are recorded in the solver log file.
