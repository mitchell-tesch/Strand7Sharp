# St7SaveBeamSectionMesh

Creates a Strand7 model file with a plate mesh of the discretised beam section.  The function is applicable to all of
the cross section definition options (standard sections, beam section library (BSL) and beam geometry library
(BGL)).

long St7SaveBeamSectionMesh(long uID, long PropNum, char* FileName)

Input Parameters

uID

Strand7 model file ID.

PropNum

Beam property number.

FileName

Full path and filename for the Strand7 model containing the beam section discretisation.
