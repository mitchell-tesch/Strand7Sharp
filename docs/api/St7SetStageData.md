# St7SetStageData

Sets the data for the specified stage.

long St7SetStageData(long uID, long Stage, long* Integers)

Input Parameters

uID

Strand7 model file ID.

Stage

Stage index.

Integers[0..4]

[ipStageMorph] – Morphing option; either btTrue or btFalse.

[ipStageMoveFixedNodes] – Move fixed nodes option; either btTrue or btFalse.

[ipStageRotateClusters] – Rotate clusters option; either btTrue or btFalse.

[ipStageSetFluidLevel] – Set fluid level for soil in the stage; either btTrue or btFalse.

[ipStageReset] – Stage reset option; either btTrue or btFalse.
