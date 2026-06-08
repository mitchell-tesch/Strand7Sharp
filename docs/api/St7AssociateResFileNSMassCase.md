# St7AssociateResFileNSMassCase

Associates the non-structural mass from a particular load case with a custom result file; this is relevant to natural
frequency results.  The association is required for correct determination of mass participation if the custom
natural frequency result file is used in a conventional spectral response analysis, and the frequencies and mode
shapes represented in the custom natural frequency result file depend on non-structural mass attributes.

long St7AssociateResFileNSMassCase(long uID, long CaseNum, double Factor)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Load case number.

Factor

Scaling factor for load case to be associated, generally 1.0.

Applicability

Applicable to natural frequency custom result files.
