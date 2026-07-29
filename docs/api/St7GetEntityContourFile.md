# St7GetEntityContourFile

Returns the user defined contour file specified for beam, plate or brick elements.

long St7GetEntityContourFile(long uID, long Entity, long* FileType,
char* FileName, long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
Entity
One of tyBEAM, tyPLATE or tyBRICK.
MaxStringLen
Maximum number of characters allocated for FileName.
Output Parameters
FileType
Basis of the contour values; either ucNode or ucElement.
FileName
Full path and name of the text file containing the user defined contour values.
