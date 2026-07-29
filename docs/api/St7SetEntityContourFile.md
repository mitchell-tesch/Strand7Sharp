# St7SetEntityContourFile

Sets a user defined contour file for beam, plate or brick elements.

long St7SetEntityContourFile(long uID, long Entity, long FileType,
char* FileName)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyBEAM, tyPLATE or tyBRICK.
FileType
Basis for the contour values; either ucNode or ucElement.
FileName
Full path and name of the text file containing the user defined contour values.
