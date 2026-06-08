# St7InsertStage

Inserts a new stage in a Strand7 model.

long St7InsertStage(long uID, long Stage, char* StageName, long* Integers)

Input Parameters

uID

Strand7 model file ID.

Stage

Index at which to insert the new stage.

StageName

String containing the name of the new stage.

Integers[0..4]

[ipStageMorph] – Morphing option; either btTrue or btFalse.

[ipStageMoveFixedNodes] – Move fixed nodes option; either btTrue or btFalse.

[ipStageRotateClusters] – Rotate clusters option; either btTrue or btFalse.

[ipStageSetFluidLevel] – Set fluid level for soil in the stage; either btTrue or btFalse.

Staged Analysis

[ipStageReset] – Stage reset option; either btTrue or btFalse.
