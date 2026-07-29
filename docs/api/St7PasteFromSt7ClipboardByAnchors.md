# St7PasteFromSt7ClipboardByAnchors

Pastes the contents of the clipboard (source) into the model (target), similarly to pasting via the Anchors and
Adjust tabs in the GUI.

long St7PasteFromSt7ClipboardByAnchors(long uID, long* SourceAnchorType,
long* SourceAnchorID, long* TargetAnchorType, long* TargetAnchorID,
double* Rotation, double* Translation, double Scaling)
Input Parameters
uID
Strand7 model file ID.
SourceAnchorType[0..2]
Entity type defining each source anchor point; must be either tyNODE or tyVERTEX.
SourceAnchorID[0..2]
Entity number defining each source anchor point. The way the three points are used to define the axis
system is explained in the Note below.
TargetAnchorType[0..2]
Entity type defining each target anchor point; must be either tyNODE or tyVERTEX.
TargetAnchorID[0..2]
Entity number defining each target anchor point. The way the three points are used to define the axis
system is explained in the Note below.
Rotation[0..2]
Angles (degrees) around the X, Y and Z anchor axes of the source, applied to the entities being pasted.
Rotation is applied after the source anchor to target anchor transformation.
Translation[0..2]
Translation increments in the length units of the target, in the X, Y and Z global axes of the target,
applied to the entities being pasted. Translation is applied after the source anchor to target anchor
transformation.
Scaling
Factor that scales the size of the entities being pasted. Scaling is centered at the origin of the anchor
axes of the source and is applied after the source anchor to target anchor transformation.
Note
If all three anchor numbers are non-zero, the anchor axis system is defined as follows:
- The first point defines the origin;
- The vector from the first point to the second point defines the X axis;
- The third point defines the XY plane;
- The Z axis is normal to the XY plane;
- The Y axis is defined as the cross product of the Z and X axes.
If the first number is non-zero and the other two are both zero, the anchor axis system remains parallel to the
global axis system, but its origin is located at the first point.

Dependencies
Paste Options
Assigned using St7SetPasteOptions.

Tools – Line Definition
Functions in this section create API line definitions. These lines are referenced by other functions, for example, to
represent an extrusion target. API line definitions do not correspond to beams in the model, are not visible to the
user and no longer exist once the model is closed.
