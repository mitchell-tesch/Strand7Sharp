# St7GetCableDroopDirection

Returns the initial droop direction applied to cable elements in a Strand7 model.

long St7GetCableDroopDirection(long uID, long* Direction)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
Direction
1: cable droops in positive global X direction;
-1: cable droops in negative global X direction;
2: cable droops in positive global Y direction;
-2: cable droops in negative global Y direction;
3: cable droops in positive global Z direction;
-3: cable droops in negative global Z direction;
