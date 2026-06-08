# St7GetModalConvergence

Returns the Eigenvalue and Eigenvector convergence of the specified mode in the modal result file currently open.

long St7GetModalConvergence(long uID, long Mode, bool* EigvalConverged,

bool* EigvectConverged)

Input Parameters

uID

Strand7 model file ID.

Mode

Mode number.

Output Parameters

EigvalConverged

True if the Eigenvalue for the specified mode is converged.

EigvectConverged

True if the Eigenvector for the specified mode is converged.

Applicability

Applicable to stLinearBuckling and stNaturalFrequency.

Results
