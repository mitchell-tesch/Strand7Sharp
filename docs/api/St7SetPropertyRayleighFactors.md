# St7SetPropertyRayleighFactors

Sets the Rayleigh damping parameters for the specified property.

long St7SetPropertyRayleighFactors(long uID, long Entity, long PropNum,

long RayleighMode, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Entity

One of ptBEAMPROP, ptPLATEPROP or ptBRICKPROP.

PropNum

Property number.

RayleighMode

Type of Rayleigh factors specified; either rmSetFrequencies or rmSetAlphaBeta.

Doubles[0..5]

rmSetAlphaBeta:

 [ipRayleighAlpha]  –  Alpha.

 [ipRayleighBeta]  –  Beta.

rmSetFrequencies:

 [ipRayleighF1]  –  Rayleigh damping frequency 1.

 [ipRayleighF2]  –  Rayleigh damping frequency 2.

Properties – Beams, Plates and Bricks

 [ipRayleighR1]  –  Rayleigh damping ratio 1.

 [ipRayleighR2]  –  Rayleigh damping ratio 2.

Both:

 [ipRayleighDisplayF1]  –  Rayleigh damping graph display frequency 1.

 [ipRayleighDisplayF2]  –  Rayleigh damping graph display frequency 2.
