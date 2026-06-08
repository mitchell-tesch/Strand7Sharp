# St7SetLinkResultDisplay

Sets the display options for the link results within the model window.

long St7SetLinkResultDisplay(long uID, long* Integers)

Input Parameters

uID

Strand7 model file ID.

Integers[0..12]

[ipResultType] – Link result type; one of rtAsNone, rtAsContour or rtAsVector.

[ipResultQuantity] – See Result Display Options.

[ipResultSystem] – See Result Display Options.

[ipResultComponent] – See Result Display Options.

[ipVectorStyle] – Vector display style; one of vtVectorTranslationMag, vtVectorRotationMag,
vtVectorTranslationComponents or vtVectorRotationComponents.

Model Window

[ipReferenceNode] – Reference node number when showing displacement results, or 0 for total
displacement.

[ipAbsoluteValue] – btTrue to contour the absolute value for rtAsContour.

[ipVector1..ipVector6] – An array of flags, either btTrue or btFalse, that are used to set up
rtAsVector displays.
