# St7GetUCSID

Returns the ID number corresponding to the specified UCS index in a Strand7 model.

long St7GetUCSID(long uID, long Index, long* UCSId)

Input Parameters

uID

Strand7 model file ID.

Index

The UCS index number. The list of available UCSs is always contiguous.

Output Parameters

UCSId

The UCS ID number corresponding to Index. UCS ID numbers are not required to be contiguous.
