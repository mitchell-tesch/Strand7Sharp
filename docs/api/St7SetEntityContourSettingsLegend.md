# St7SetEntityContourSettingsLegend

Sets the parameters accessible through Entity Display/Contour/Settings…/Legend in the GUI.

long St7SetEntityContourSettingsLegend(long uID, long Entity, long* Integers)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE or tyBRICK.

Integers[0..5]

[ipLegendPosition] – One of lpNone, lpTopLeft, lpTopRight, lpBottomLeft, lpBottomRight or
lpFloating.

[ipOpaqueLegend] – btTrue for Opaque.

[ipShowMinMax] – btTrue for Show Min/Max.

[ipHistogram] – btTrue for Histogram.

[ipLegendWidth] – Legend width.

[ipLegendHeight] – Legend height.
