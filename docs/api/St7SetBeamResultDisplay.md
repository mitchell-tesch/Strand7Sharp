# St7SetBeamResultDisplay

Sets the display options for beam results within the model window.

long St7SetBeamResultDisplay(long uID, long* Integers)
Input Parameters
uID
Strand7 model file ID.
Integers[0..12]
[ipResultType] – Beam result type; one of rtAsNone, rtAsContour, rtAsDiagram or rtAsVector.
[ipResultQuantity] – See Result Display Options. When result quantity is rqBeamUserC, the
currently active user equation must be assigned via St7SetResultUserEquation or
St7SetStoredResultUserEquation before calling St7SetBeamResultDisplay.
[ipResultSystem] – See Result Display Options.
[ipResultComponent] – See Result Display Options.

[ipVectorStyle] – Vector display style; one of vtVectorTranslationMag, vtVectorRotationMag,
vtVectorTranslationComponents or vtVectorRotationComponents.
[ipReferenceNode] – Reference node number when showing displacement results, or 0 for total
displacement.
[ipAbsoluteValue] – btTrue to contour the absolute value for rtAsContour.
[ipDiagram1..ipDiagram6] – An array of flags, either btTrue or btFalse, that are used to set up
rtAsDiagram displays.
[ipVector1..ipVector6] – An array of flags, either btTrue or btFalse, that are used to set up
rtAsVector displays.
