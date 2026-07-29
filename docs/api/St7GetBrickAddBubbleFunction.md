# St7GetBrickAddBubbleFunction

Returns the state of the Add Bubble Function option for the specified brick property. This option is only used for
Hex8 element types.

long St7GetBrickAddBubbleFunction(long uID, long PropNum,
bool* AddBubbleFunction)
Input Parameters
uID
Strand7 model file ID.
PropNum
Brick property number.
Output Parameters
AddBubbleFunction
True if the “bubble” contribution is added to the element shape functions.
