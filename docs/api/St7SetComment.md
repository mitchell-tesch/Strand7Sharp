# St7SetComment

Replaces the text in the specified line of a Strand7 model’s notes.

long St7SetComment(long uID, long Comment, char* CommentString)

Input Parameters

uID

Strand7 model file ID.

Comment

Index number of the note line to be replaced.

Strand7 API Manual

CommentString

String containing the replacement text. Each string is presented as a line in the Strand7 notes tab.
