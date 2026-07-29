# St7SetElementPropertySwitch

Specifies a property switch for a staged analysis.

long St7SetElementPropertySwitch(long uID, long Entity, long EntityNum,
long PropID, long Stage)
Input Parameters
uID
Strand7 model file ID.
Entity
One of ptBEAMPROP, ptPLATEPROP or ptBRICKPROP.
EntityNum
Entity number.
PropID
Property number, as either a positive or negative integer.
Stage
Stage index.
Usage
A positive PropID signifies that the element is re-born at the switched stage (i.e., its birth stage becomes the
stage index associated with the property switch). A negative PropID signifies that the element changes its
property type but its birth stage is inherited from the current element (i.e., the Inherited Birth Stage option is
set).
