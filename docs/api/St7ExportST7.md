# St7ExportST7

Exports the current model in the Strand7 text file format.

long St7ExportST7(long uID, char* FileName, long Mode, long ExportFormat)

Input Parameters

uID

Strand7 model file ID.

FileName

Full path and name for the Strand7 text-file to be created.

Mode

Controls the display of a progress bar; either ieQuietRun or ieProgressRun.

ExportFormat

Controls the export format for backwards compatibility; one of ieSt7ExportCurrent, ieSt7Export106,
ieSt7Export21x, ieSt7Export22x, ieSt7Export23x or ieSt7Export24x.
