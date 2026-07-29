# St7SetSolverWindowPos

Sets the desktop position and size of new solver windows created by St7RunSolver and St7RunSolverProcess.

long St7SetSolverWindowPos(long L, long T, long W, long H)
Input Parameters
L
Left position of the solver window, measured in pixels, relative to the origin of the desktop.
T
Top position of the solver window, measured in pixels, relative to the origin of the desktop.

W
Width of the solver window in pixels; ignored if it is less than or equal to zero.
H
Height of the solver window in pixels; ignored if it is less than or equal to zero.
Usage
The function is applicable to the following solver run modes: smNormalRun, smNormalCloseRun and
smProgressRun. For smProgressRun, the H parameter is ignored; that is, the height cannot be set. To set just
the left and/or top positions of the solver window without changing the width or height, set W and/or H to 0.
Note that the origin of the desktop might not be (0,0), particularly on systems with more than one screen.
