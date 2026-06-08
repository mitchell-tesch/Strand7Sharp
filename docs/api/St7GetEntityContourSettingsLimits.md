# St7GetEntityContourSettingsLimits

Returns the parameters accessible through Entity Display/Contour/Settings…/Limits in the GUI.

long St7GetEntityContourSettingsLimits(long uID, long Entity, long* Integers,

double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE or tyBRICK.

Element Contouring

Output Parameters

Integers[0..4]

[ipContourLimit] – One of clDefault, clUserRange, clRounded or clUserSpecified.

[ipContourMode] – Either cmContinuous or cmDiscrete.

[ipNumContours] – Number of contours with the discrete setting.

[ipSetMinLimit] – btTrue if the lower limit is enabled for the user range.

[ipSetMaxLimit] – btTrue if the upper limit is enabled for the user range.

Doubles[0..1]

[ipMinLimit] – Lower limit for the user range.

[ipMaxLimit] – Upper limit for the user range.
