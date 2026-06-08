# St7SetSeismicCaseDynamicNSMassState

Sets the enabled state of the dynamic factor option for the specified seismic load case in a Strand7 model.

long St7SetSeismicCaseDynamicNSMassState(long uID, long CaseNum, bool Enabled)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Load case number.

Enabled

True to Apply dynamic factors to non-structural mass attributes.
