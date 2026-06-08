# St7GetResultSettingsDiagram

Returns the parameters accessible through Results Settings/Settings…/Diagram in the GUI.

Model Window Results Settings

long St7GetResultSettingsDiagram(long uID, long Solver, long* Integers)

Input Parameters

uID

Strand7 model file ID.

Solver

One of the solver types listed in Solver Types.

Output Parameters

Integers[0..5]

[ipDiagramStyle] – Either dsSingleLine or dsHatched.

[ipDiagramAxialDir] – One of adPlus1, adMinus1, adPlus2 or adMinus2.

[ipDiagramTorqueDir] – One of adPlus1, adMinus1, adPlus2 or adMinus2.

[ipDiagramRelativeLength] – Relative length in the range 0 to 100.

[ipDiagramThickness] – Thickness in the range kMinThickness to kMaxThickness.

[ipDiagramMomentSide] – Either bmTensionSide or bmCompressionSide.
