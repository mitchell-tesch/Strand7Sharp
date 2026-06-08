# St7SetCopyFlags

Sets the state of the copy options for applicable tools operations.

long St7SetCopyFlags(long uID, long* Flags)

Input Parameters

uID

Strand7 model file ID.

Flags[0..5]

[ipCopyNodeVertexAttributes] – either btTrue or btFalse; setting for Copy Node/Vertex
Attributes.

[ipCopyElementFaceAttributes] – either btTrue or btFalse; setting for Copy Element/Face
Attributes.

[ipIncrementStringID] – either btTrue or btFalse; setting for Increment String Group ID.

Tools – General State

[ipIncrementClusterID] – either btTrue or btFalse; setting for Increment Cluster ID.

[ipCreateNewGroup] – either btTrue or btFalse; setting for Create New Group for Copy.

[ipCopyAxisUCS] – either btTrue or btFalse; setting for Create New UCS for Element Axes.
