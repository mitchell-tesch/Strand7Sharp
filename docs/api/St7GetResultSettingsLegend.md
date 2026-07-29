# St7GetResultSettingsLegend

Returns the parameters accessible through Results Settings/Settings…/Legend in the GUI.

long St7GetResultSettingsLegend(long uID, long Solver, long Entity,
long Quantity, long* Integers)
Input Parameters
uID
Strand7 model file ID.
Solver
One of the solver types listed in Solver Types.
Entity
One of tyBEAM, tyPLATE, tyBRICK or tyLINK.
Quantity
One of the QUANTITY options listed in Result Display Options.
Output Parameters
Integers[0..5]
[ipLegendPosition] – One of lpNone, lpTopLeft, lpTopRight, lpBottomLeft, lpBottomRight or
lpFloating.
[ipOpaqueLegend] – btTrue for Opaque.
[ipShowMinMax] – btTrue for Show Min/Max.
[ipHistogram] – btTrue for Histogram.
[ipLegendWidth] – Legend width.
[ipLegendHeight] – Legend height.
