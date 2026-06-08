# St7AssignLibraryLoadPathTemplate

Assigns the specified item from the load path definition library (.MLT) to a load path template.

long St7AssignLibraryLoadPathTemplate(long uID, long TemplateID, long LibraryID,

long ItemID)

Input Parameters

uID

Strand7 model file ID.

TemplateID

Load path template ID.

LibraryID

Library ID.

ItemID

Item ID.

Usage

This call is typically followed by a call to St7SetLoadPathTemplateParameters to set the number of lanes in the
template, amongst other settings.

Strand7 API Manual
