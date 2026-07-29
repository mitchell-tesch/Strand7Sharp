# St7DeleteAttribute

Deletes the specified attribute. See Attribute Types for additional information.

long St7DeleteAttribute(long uID, long Entity, long EntityNum, long AttributeOrd,
long* Integers)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyNODE, tyBEAM, tyPLATE, tyBRICK, tyVERTEX, tyGEOMETRYEDGE, tyGEOMETRYCOEDGE,
tyGEOMETRYFACE or tyLOADPATH.
EntityNum
Entity number.
AttributeOrd
Attribute identifier; see Attribute Types.
Integers[0..3]
[ipAttrLocal] – Local attribute number; see Attribute Types.
[ipAttrAxis] – Axis or direction of the attribute; see Attribute Types.
[ipAttrCase] – Attribute load/freedom case number; see Attribute Types.
[ipAttrID] – Attribute ID number; see Attribute Types.
