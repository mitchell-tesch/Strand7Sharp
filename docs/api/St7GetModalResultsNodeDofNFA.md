# St7GetModalResultsNodeDofNFA

Returns the node and degree of freedom used to normalise the Eigenvector to produce the engineering modal
mass and stiffness for the specified mode in the result file currently open.

long St7GetModalResultsNodeDofNFA(long uID, long Mode, long* NodeNum, long* Dof)

Input Parameters

uID

Strand7 model file ID.

Mode

Result case/mode number.

Output Parameters

NodeNum

Node number used for normalisation.

Dof

Degree of freedom used for normalisation (an integer from 1 to 6).

Applicability

Applicable to stNaturalFrequency.
