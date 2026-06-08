# St7GetEntityContourIndex

Returns the contour type specified by the combo box menus in Entity Display for beam, plate or brick elements.

long St7GetEntityContourIndex(long uID, long Entity, long* Index)

Input Parameters

uID

Strand7 model file ID.

Entity

One of tyBEAM, tyPLATE or tyBRICK.

Output Parameters

Index

A contour specified by the constants listed in Entity Contours.
