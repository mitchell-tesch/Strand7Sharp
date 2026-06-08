# St7GetInertiaReliefResults

Returns the inertial results for the specified result case in inertial relief for the specified result case in the result
file currently open.

long St7GetInertiaReliefResults(long uID, long CaseNum, double* InertiaResult)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Result case number.

Output Parameters

InertiaResult[0..11]

[ipMassXIRA] – Mass component in the global X direction.

[ipMassYIRA] – Mass component in the global Y direction.

[ipMassZIRA] – Mass component in the global Z direction.

[ipXcIRA] – Global X ordinate of the centre of mass.

[ipYcIRA] – Global Y ordinate of the centre of mass.

[ipZcIRA] – Global Z ordinate of the centre of mass.

[ipAccXIRA] – Translational acceleration of the centre of mass in the global X direction.

[ipAccYIRA] – Translational acceleration of the centre of mass in the global Y direction.

[ipAccZIRA] – Translational acceleration of the centre of mass in the global Z direction.

[ipAngAccXIRA] – Rotational acceleration about the global X axis (degrees/time2).

Results

[ipAngAccYIRA] – Rotational acceleration about the global Y axis (degrees/time2).

[ipAngAccZIRA] – Rotational acceleration about the global Z axis (degrees/time2).

Applicability

Applicable to stLinearStatic.
