# St7GetStageData

Returns the data for the specified stage.

Staged Analysis

long St7GetStageData(long uID, long Stage, long* Integers)

Input Parameters

uID

Strand7 model file ID.

Stage

Stage index.

Output Parameters

Integers[0..4]

[ipStageMorph] – Morphing option; either btTrue or btFalse.

[ipStageMoveFixedNodes] – Move fixed nodes option; either btTrue or btFalse.

[ipStageRotateClusters] – Rotate clusters option; either btTrue or btFalse.

[ipStageSetFluidLevel] – Set fluid level for soil in the stage; either btTrue or btFalse.

[ipStageReset] – Stage reset option; either btTrue or btFalse.
