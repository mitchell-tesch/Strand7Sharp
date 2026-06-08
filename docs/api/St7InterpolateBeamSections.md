# St7InterpolateBeamSections

Transitions selected beams from one property to another by interpolating section dimensions.  Creates new beam
properties if required.

long St7InterpolateBeamSections(long uID, long PropNum1, long PropNum2,

long Divisions)

Input Parameters

uID

Strand7 model file ID.

PropNum1

Property number at beam end 1.

PropNum2

Property number at beam end 2.

Divisions

Number of divisions.

Dependencies
Selection

Beams can be selected using functions in Entity Selection.

Strand7 API Manual
