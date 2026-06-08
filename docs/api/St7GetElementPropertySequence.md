# St7GetElementPropertySequence

Returns the stage-dependent property sequence assigned to the specified element for staged analysis.
St7GetNumStages can be used to determine the number of stages in the model.

long St7GetElementPropertySequence(long uID, long Entity, long EntityNum,

long MaxProps, long* Props)

Input Parameters

uID

Strand7 model file ID.

Entity

One of ptBEAMPROP, ptPLATEPROP or ptBRICKPROP.

EntityNum

Entity number.

MaxProps

Maximum amount of storage allocated for the Props array.

Attributes General

Output Parameters

Props[0..MaxProps-1]

An array containing the property number assigned at each stage of the analysis. Property numbers can
be either positive or negative, depending on the Inherited Birth Stage setting.

Usage

A positive property number signifies that the element is re-born at the switched stage (i.e., its birth stage
becomes the stage index associated with the property switch).  A negative PropID signifies that the element
changes its property type but its birth stage is inherited from the current element (i.e., the Inherited Birth
Stage option is set).
