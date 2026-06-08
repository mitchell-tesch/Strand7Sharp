# St7GetEntityAttributeSequence

Returns details of the attribute instances on the requested entity.

long St7GetEntityAttributeSequence(long uID, long Entity, long EntityNum,

long AttributeOrd, long MaxSets, long* Integers)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyVERTEX, tyGEOMETRYEDGE or tyGEOMETRYFACE.

EntityNum

Entity number.

AttributeOrd

Attribute identifier; see Attribute Types.

MaxSets

Number of instances of the attribute for which space has been allocated in Integers.  Each attribute
instance requires four integers.

Output Parameters

Integers[0..4*NumSets]

For each i attribute instance,

[4*i+ ipAttrLocal] – Local number if applicable.
[4*i+ ipAttrAxis] – Axis or direction if applicable.
[4*i+ ipAttrCase] – Load or freedom case number if applicable.
[4*i+ ipAttrID] – ID number (1-192) if applicable.

For the interpretation of the four values with respect to the specific attribute types; see Attribute Types.

Strand7 API Manual

Use St7GetEntityAttributeSequenceCount to determine the number of attribute instances that will be
returned as NumSets, then ensure the length of the Integers array is at least 4*NumSets.

Properties – Beams, Plates and Bricks

Properties – Beams, Plates and Bricks
