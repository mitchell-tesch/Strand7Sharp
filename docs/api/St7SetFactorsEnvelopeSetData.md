# St7SetFactorsEnvelopeSetData

Assigns the settings for the specified set in a factors envelope for the currently open solution.

Envelopes

long St7SetFactorsEnvelopeSetData(long uID, long Pos, long SetType,

char* SetName, char* SetGroup)

Input Parameters

uID

Pos

Strand7 model file ID.

Set position.

SetType

Type of set; either stExclusiveOR or stExclusiveAND.

SetName

Name of the set.

SetGroup

Group identifier for set.
