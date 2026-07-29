# St7GetTitle

Returns the information entered in the NOTES tab for the Strand7 model Title, Project, Reference, Author,
creation and last modification date.

long St7GetTitle(long uID, long TitleType, char* TitleString, long MaxStringLen)
Input Parameters
uID
Strand7 model file ID.
TitleType
One of tbTitle, tbProject, tbReference, tbAuthor, tbCreated or tbModified.

MaxStringLen
Maximum number of characters allocated for TitleString.
Output Parameters
TitleString
A string containing the text entered for the entry TitleType.
