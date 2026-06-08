# St7SubdivideEdges

Divides selected edges into the specified number of equal segments by inserting evenly spaced vertices.

long St7SubdivideEdges(long uID, long Divisions, long VertexType)

Input Parameters

uID

Strand7 model file ID.

Divisions

Number of segments to divide edges into.

Strand7 API Manual

VertexType

Either vtFree or vtFixed.

Dependencies
Selection

Entities can be selected using functions in Entity Selection.

Keep Selected

Assigned using St7SetKeepSelect.
