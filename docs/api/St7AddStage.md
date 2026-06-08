# St7AddStage

Adds a new stage to a Strand7 model.

long St7AddStage(long uID, char* StageName, long* Integers)

Input Parameters

uID

Strand7 model file ID.

StageName

String containing the name of the new stage.

Integers[0..4]

[ipStageMorph] – Morphing option; either btTrue or btFalse.

[ipStageMoveFixedNodes] – Move fixed nodes option; either btTrue or btFalse.

[ipStageRotateClusters] – Rotate clusters option; either btTrue or btFalse.

[ipStageSetFluidLevel] – Set fluid level for soil in the stage; either btTrue or btFalse.

[ipStageReset] – Stage reset option; either btTrue or btFalse.
