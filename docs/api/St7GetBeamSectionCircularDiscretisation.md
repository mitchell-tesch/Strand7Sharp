# St7GetBeamSectionCircularDiscretisation

Returns the number of circumferential divisions used when discretising circular cross sections for nonlinear beam
types.

long St7GetBeamSectionCircularDiscretisation(long uID, long PropNum,

long* Integers)

Input Parameters

uID

Strand7 model file ID.

PropNum

Beam property number.

Output Parameters
Integers[0]

Number of circumferential divisions used to discretise the circular beam cross section; one of
0 – for Auto divisions
1 – for 8 divisions
2 – for 16 divisions
3 – for 24 divisions
4 – for 32 divisions
5 – for 40 divisions
6 – for 48 divisions.
