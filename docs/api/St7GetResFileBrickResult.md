# St7GetResFileBrickResult

Returns the specified brick result quantities for a given brick element and result case in the custom result file.

long St7GetResFileBrickResult(long uID, long CaseNum, long BrickNum,
long Quantity, double* Doubles)
Input Parameters
uID
Strand7 model file ID.
CaseNum
Result case number.
BrickNum
Brick number.
Quantity
One of rtBrickStress, rtBrickStrain, rtBrickNodeReact, rtBrickFlux or rtBrickNodeFlux.
Output Parameters
Doubles[..]
An array defining the specified brick result quantity at each Gauss point or node on the brick, depending
on the quantity. See Custom Results for additional information.

Clipboard
Clipboard, in this section, refers to the internal Strand7 clipboard, rather than the standard Windows clipboard.
The Strand7 clipboard is used for copying/pasting entities from the model database; this functionality is accessible
via the VISUAL tab in the Strand7 GUI. The functions in this chapter allow you cut, copy and paste entities within a
single model or between models. As with the GUI, the Strand7 clipboard allows you to transfer entities between
currently open models, rather than to external programs. To copy model window graphics to the Windows
clipboard for access by other applications see St7ExportImageToClipboard.
