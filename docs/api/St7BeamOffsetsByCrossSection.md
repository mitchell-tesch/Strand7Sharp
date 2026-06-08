# St7BeamOffsetsByCrossSection

Assign offsets to selected beams to shift the node location to some point on the cross section.

long St7BeamOffsetsByCrossSection(long uID, long* Offsets)

Input Parameters

uID

Strand7 model file ID.

Offsets[0..11]

Assign the desired offset by setting the value in the index position corresponding to each beam cross
section type.

Index positions are ipCircularSection, ipSquareSection, ipCSection, ipISection, ipTSection, ipLSection,
ipZSection, ipBXSSection, ipTrapezoidalSection, ipTriangularSection, ipCruciformSection and
ipUndefinedSection.

Cross section offset values are soNoChange, soTopLeft, soTopMid, soTopRight, soMidLeft,
soGeometricCenter, soMidRight, soBottomLeft, soBottomMid, soBottomRight, soCentroid or
soShearCenter.
