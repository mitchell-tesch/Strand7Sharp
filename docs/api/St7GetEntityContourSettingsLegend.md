# St7GetEntityContourSettingsLegend

Returns the parameters accessible through Entity Display/Contour/Settings…/Legend in the GUI.

long St7GetEntityContourSettingsLegend(long uID, long Entity, long* Integers)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE or tyBRICK.

Element Contouring

Output Parameters

Integers[0..5]

[ipLegendPosition] – One of lpNone, lpTopLeft, lpTopRight, lpBottomLeft, lpBottomRight or
lpFloating.

[ipOpaqueLegend] – btTrue for Opaque.

[ipShowMinMax] – btTrue for Show Min/Max.

[ipHistogram] – btTrue for Histogram.

[ipLegendWidth] – Legend width.

[ipLegendHeight] – Legend height.
