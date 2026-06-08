# St7SetCutoffBarData

Sets the cut-off bar parameters for the specified beam property.

long St7SetCutoffBarData(long uID, long PropNum, long* Integers, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

PropNum

Beam property number.

Integers[0..1]

[ipCutoffType] – Type of cut-off bar; either cbBrittle or cbDuctile.

[ipKeepMass] – Use element mass; either btTrue or btFalse.

Doubles[0..1]

[ipCutoffTension] – Tensile force limit.

[ipCutoffCompression] – Compressive force limit.
