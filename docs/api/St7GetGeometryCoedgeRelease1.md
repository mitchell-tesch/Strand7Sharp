# St7GetGeometryCoedgeRelease1

Returns the edge release conditions assigned to the specified geometry coedge.

long St7GetGeometryCoedgeRelease1(long uID, long CoedgeNum, long* Status)

Input Parameters

uID

Strand7 model file ID.

CoedgeNum

Coedge number.

Output Parameters

Status

Either prReleased or prFixed.
