# St7IntersectBeamsAndLinks

Intersects selected beams and links with selected beams, plate edges, brick edges and links.  Nodes are created at
found intersections, and the selected beams and links can optionally be split where these intersections are found.

long St7IntersectBeamsAndLinks(long uID, double MaxGap, double MinAngle,
bool SplitBeams, bool SplitLinks, bool ConsiderEdgeMidsideNode)

Input Parameters

uID

Strand7 model file ID.

MaxGap

Distance between beams or plate edges to look for an intersection.

MinAngle

Nearly parallel beams are not intersected; up to the angular tolerance specified here (degrees).

SplitBeams

True to split beams at interestions.

SplitLinks

True to split links at interestions.  Master-Slave, Pinned, Rigid, Shrink and Two-Point links can be split.
Other link types can be used to find intersection points but will not themselves be split.

ConsiderEdgeMidsideNode

True to consider the midside node of quadratic edges.

Dependencies
Selection

Beams can be selected using functions in Entity Selection.
