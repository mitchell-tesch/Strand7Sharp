# St7SetResultSettingsLimits

Sets the parameters accessible through Results Settings/Settings…/Limits in the GUI.

long St7SetResultSettingsLimits(long uID, long Solver, long Entity,

long Quantity, long* Integers, double* Doubles)

Input Parameters

uID

Strand7 model file ID.

Solver

One of the solver types listed in Solver Types.

Entity

One of tyBEAM, tyPLATE, tyBRICK or tyLINK.

Quantity

One of the QUANTITY options listed in Result Display Options.

Integers[0..4]

[ipContourLimit] – One of clDefault, clUserRange, clRounded or clUserSpecified.

[ipContourMode] – Either cmContinuous or cmDiscrete.

[ipNumContours] – Number of contours with the discrete setting.

[ipSetMinLimit] – btTrue if the lower limit is enabled for the user range.

[ipSetMaxLimit] – btTrue if the upper limit is enabled for the user range.

Doubles[0..1]

[ipMinLimit] – Lower limit for the user range.

[ipMaxLimit] – Upper limit for the user range.
