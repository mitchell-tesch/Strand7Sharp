# St7SetResFilePlatePressureResult

Sets the applied normal pressure load for a given plate element and result case in the custom result file.

long St7SetResFilePlatePressureResult(long uID, long CaseNum, long PlateNum,
double* Doubles)
Input Parameters
uID
Strand7 model file ID.

CaseNum
Result case number.
PlateNum
Plate number.
Output Parameters
Doubles[0..1]
[0] – Normal face pressure over the -z surface of the plate.
[1] – Normal face pressure over the +z surface of the plate.
Positive pressure is directed from the relevant surface into the plate. See Custom Results for additional
information.
