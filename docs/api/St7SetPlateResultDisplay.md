# St7SetPlateResultDisplay

Sets the display options for plate results within the model window.

long St7SetPlateResultDisplay(long uID, long* Integers)

Input Parameters

uID

Strand7 model file ID.

Integers[0..12]

[ipResultType] – Plate result type; one of rtAsNone, rtAsContour or rtAsVector.

[ipResultQuantity] – See Result Display Options. When result quantity is rqPlateUserC, the
currently active user equation must be assigned via St7SetResultUserEquation or
St7SetStoredResultUserEquation before calling St7SetPlateResultDisplay.

[ipResultSystem] – See Result Display Options.

[ipResultComponent] – See Result Display Options; ignored when result type is rtAsVector.

[ipResultSurface] – See Result Display Options.

[ipVectorStyle] – Vector display style; one of vtVectorTranslationMag, vtVectorRotationMag,
vtVectorTranslationComponents or vtVectorRotationComponents; used when result quantity is a nodal
quantity (e.g. displacement); ignored when result quantity is an element quantity (e.g. principal stress).

[ipReferenceNode] – Reference node number when showing displacement results, or 0 for total
displacement.

[ipAbsoluteValue] – btTrue to contour the absolute value for rtAsContour.

[ipVector1..ipVector6] – An array of flags, either btTrue or btFalse, that are used to set up
rtAsVector displays; applicable to nodal result quantities (e.g. displacement) and element result
quantities (e.g. principal stress).
