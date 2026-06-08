# St7GetEntityAttributeSequenceCount

Returns the number of instances of the attribute on the requested entity.

long St7GetEntityAttributeSequenceCount(long uID, long Entity, long EntityNum,

long AttributeOrd, long* NumSets)

Input Parameters

uID

Strand7 model file ID.

Attributes General

Entity

One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyVERTEX, tyGEOMETRYEDGE or tyGEOMETRYFACE.

EntityNum

Entity number.

AttributeOrd

Attribute identifier; see Attribute Types.

Output Parameters

NumSets

Number of instances of the attribute on the element.  Use St7GetEntityAttributeSequence to get details
of each instance.
