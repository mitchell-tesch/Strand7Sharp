# St7GetConnectionData

Returns the connection element parameters for the specified beam property.

long St7GetConnectionData(long uID, long PropNum, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
PropNum
Beam property number.
Output Parameters
Doubles[0..5]
[ipConnectionShear1] – Translational stiffness in the 1 axis direction; this is a shear stiffness for
Connection elements that do not reference a UCS.
[ipConnectionShear2] – Translational stiffness in the 2 axis direction; this is a shear stiffness for
Connection elements that do not reference a UCS.
[ipConnectionAxial] – Translational stiffness in the 3 axis direction; this is an axial stiffness for
Connection elements that do not reference a UCS.

[ipConnectionBend1] – Rotational stiffness in the plane of the 1 axis; this is a bending stiffness in
plane 1 for Connection elements that do not reference a UCS.
[ipConnectionBend2] – Rotational stiffness in the plane of the 2 axis; this is a bending stiffness in
plane 2 for Connection elements that do not reference a UCS.
[ipConnectionTorque] – Rotational stiffness about the 3 axis; this is a torque stiffness for
Connection elements that do not reference a UCS.
Usage
A UCS may be assigned to the ends of Connection elements to override the principal axis system using
St7SetBeamConnectionUCS.
