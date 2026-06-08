# St7GetComment

Returns the specified line of a Strand7 model’s notes.

long St7GetComment(long uID, long Comment, char* CommentString,

long MaxStringLen)

Input Parameters

uID

Strand7 model file ID.

Comment

Index number for the note line to be returned.

MaxStringLen

Maximum number of characters allocated for CommentString.

Output Parameters
CommentString

String containing the returned note line.
