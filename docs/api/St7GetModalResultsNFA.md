# St7GetModalResultsNFA

Returns the modal results for the specified mode in the result file currently open.

long St7GetModalResultsNFA(long uID, long Mode, double* ModalResult)
Input Parameters
uID
Strand7 model file ID.
Mode
Result case/mode number.
Output Parameters
ModalResult[0..15]
[ipFrequencyNFA] – Mode frequency (Hz).
[ipModalMassNFA] – Modal mass.
[ipModalStiffNFA] – Modal stiffness.
[ipModalDampNFA] – Modal damping.
[ipModalTMassP1] – Translational Mass Participation. If a translational direction vector is defined for
St7GetNFAModeParticipationVectors, the total participation, otherwise the participation in global X.
[ipModalTMassP2] – Translational Mass Participation. If a translational direction vector is defined for
St7GetNFAModeParticipationVectors, zero, otherwise the participation in global Y.
[ipModalTMassP3] – Translational Mass Participation. If a translational direction vector is defined for
St7GetNFAModeParticipationVectors, zero, otherwise the participation in global Z.
[ipModalRMassP1] – Rotational Mass Participation. If a rotational direction vector is defined for
St7GetNFAModeParticipationVectors, the total participation, otherwise the participation about global X.
[ipModalRMassP2] – Rotational Mass Participation. If a rotational direction vector is defined for
St7GetNFAModeParticipationVectors, zero, otherwise the participation about global Y.
[ipModalRMassP3] – Rotational Mass Participation. If a rotational direction vector is defined for
St7GetNFAModeParticipationVectors, zero, otherwise, the participation about global Z.
[ipModalModeD1] – Translational Mode Participation. If a translational direction vector is defined for
St7GetNFAModeParticipationVectors, the total participation, otherwise the participation in global X.
[ipModalModeD2] – Translational Mode Participation. If a translational direction vector is defined for
St7GetNFAModeParticipationVectors, zero, otherwise the participation in global Y.
[ipModalModeD3] – Translational Mode Participation. If a translational direction vector is defined for
St7GetNFAModeParticipationVectors, zero, otherwise the participation in global Z.
[ipModalModeR1] – Rotational Mode Participation. If a rotational direction vector is defined for
St7GetNFAModeParticipationVectors, the total participation, otherwise the participation about global X.
[ipModalModeR2] – Rotational Mode Participation. If a rotational direction vector is defined for
St7GetNFAModeParticipationVectors, zero, otherwise the participation about global Y.
[ipModalModeR3] – Rotational Mode Participation. If a rotational direction vector is defined for
St7GetNFAModeParticipationVectors, the total participation, otherwise the participation about global Z.

Applicability
Applicable to stNaturalFrequency.
