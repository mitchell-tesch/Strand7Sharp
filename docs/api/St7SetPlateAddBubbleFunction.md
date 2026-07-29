# St7SetPlateAddBubbleFunction

Sets the state of the Add Bubble Function option for the specified plate property. This option is only used for
Quad4 plane stress, plane strain and axisymmetric element types.

long St7SetPlateAddBubbleFunction(long uID, long PropNum, bool AddBubbleFunction)
Input Parameters
uID
Strand7 model file ID.
PropNum
Plate property number.
AddBubbleFunction
True to add the “bubble” contribution to the element shape functions.
