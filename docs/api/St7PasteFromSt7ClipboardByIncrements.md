# St7PasteFromSt7ClipboardByIncrements

Pastes the contents of the clipboard (source) into the model (target), similarly to pasting using the Adjust tab in
the GUI.

long St7PasteFromSt7ClipboardByIncrements(long uID, double* Rotation,

double* Translation, double Scaling)

Input Parameters

uID

Strand7 model file ID.

Rotation[0..2]

Rotation angles (degrees) about the X, Y and Z global axes of the source, applied to the entities being
pasted.

Translation[0..2]

Translation increments in the length units of the target, in the X, Y and Z global axes of the target,
applied to the entities being pasted.

Scaling

Factor that scales the size of the entities being pasted.  Scaling is centered at the origin of the global
axes of the source.

Dependencies

Paste Options

Assigned using St7SetPasteOptions.
