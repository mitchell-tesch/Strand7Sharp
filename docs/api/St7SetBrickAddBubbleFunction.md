# St7SetBrickAddBubbleFunction

Sets the state of the Add Bubble Function option for the specified brick property. This option is only used for Hex8
element types.

long St7SetBrickAddBubbleFunction(long uID, long PropNum, bool AddBubbleFunction)
Input Parameters
uID
Strand7 model file ID.
PropNum
Brick property number.
AddBubbleFunction
True to add the “bubble” contribution to the element shape functions.
