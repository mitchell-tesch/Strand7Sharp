# St7AddComment

Appends a line of text to the Strand7 model’s notes. Note lines are identified by their index, from one up to the
total number of comments.

long St7AddComment(long uID, char* CommentString)
Input Parameters
uID
Strand7 model file ID.
CommentString
String containing the text to be added. Each string is presented as a line in the Strand7 notes tab.
