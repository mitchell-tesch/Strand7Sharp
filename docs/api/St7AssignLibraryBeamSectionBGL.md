# St7AssignLibraryBeamSectionBGL

Assigns the specified item from the beam geometry library (.BGL) to a beam property.

long St7AssignLibraryBeamSectionBGL(long uID, long PropNum, long LibraryID,
long ItemID, long* Integers)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
LibraryID
Library ID.
ItemID
Item ID.
Integers[0..3]
[0] – btTrue to import beam material data.
[1] – not used.

[2] – btTrue to import material damping values if importing material data.
[3] – btTrue to replace the property name with the library name.
