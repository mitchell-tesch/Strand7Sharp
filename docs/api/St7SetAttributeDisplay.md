# St7SetAttributeDisplay

Sets options related to the display of attributes in the model window.

long St7SetAttributeDisplay(long uID, long AttributeOrd, long* Integers)
Input Parameters
uID
Strand7 model file ID.
AttributeOrd
Attribute identifier. See Attribute Types for additional information.
Integers[0..9]
[ipAttribDisplayShow] – btTrue to show the attribute, or btFalse to hide it.
[ipAttribDisplayLabel] – btTrue to label the attribute with its value, or btFalse to show the
attribute without a label.
[ipAttribDisplayResultant] – btTrue to show the resultant vector, or btFalse to show the
components.
[ipAttribDisplayAnchorTail] – btTrue to anchor the vector at the tail, or btFalse to anchor the
vector at the head.
[ipAttribDisplayScaled] – btTrue to proportionally scale the attribute based on its value, or
btFalse to draw the attribute at the unscaled default size independently of its value.
[ipAttribDisplaySize] – Attribute size in the range 0 to 100. Note that some attributes have a
minimum size; the minimum size will be set if the requested size is less than the minimum.
[ipAttribDisplayThickness] – Thickness in the range kMinThickness to kMaxThickness.
[ipAttribDisplayCol1] – First colour. See also RGB Colours.
[ipAttribDisplayCol2] – Second colour. See also RGB Colours.
[ipAttribDisplayCol3] – Third colour. See also RGB Colours.
