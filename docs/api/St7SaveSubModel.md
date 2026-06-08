# St7SaveSubModel

Saves selected entities as a new Strand7 file.

Strand7 API Manual

long St7SaveSubModel(long uID, char* FileName)

Input Parameters

uID

Strand7 model file ID.

FileName

Full path and filename for the Strand7 model.

Dependencies
Selection

Entities can be selected using functions in Entity Selection.

Usage

If a result file is open, a set of enforced displacements is applied to all nodes that lie on the boundary between
selected and unselected elements. The displacement scale setting has no effect on the node coordinates
stored in the sub-model.
