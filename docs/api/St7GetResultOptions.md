# St7GetResultOptions

Returns the Results Options for the specified model.

long St7GetResultOptions(long uID, long* Integers)
Input Parameters
uID
Strand7 model file ID.
Output Parameters
Integers[0..8]
[ipResOptsRotationUnit] – Rotation units for model window output; either auRadian or
auDegree. By default this setting is ignored by the Strand7 API; see St7EnableModelRotationUnit.
[ipResOptsStrainUnit] – Strain unit; one of suUnit, suPercent or suMicro. By default this setting is
ignored by the Strand7 API; see St7EnableModelStrainUnit.
[ipResOptsAddGNLDisp] – btTrue to add initial GNL displacements.
[ipResOptsOffsetDisp] – btTrue to consider elements offset in displacement results.
[ipResOptsNFADisp] – Either dmUnitModalMass or dmEngModalMass.
[ipResOptsReactionLinkGNL] – btTrue to move reaction multi-point link origin by average node
displacement of connected node, or btFalse to use the unmodified user-specified origin.
[ipResOptsBaseDisp] – Displacement results to present for transient analyses, bmRelative for
Relative to Base or bmTotal for Total.
[ipResOptsBaseVel] – Velocity results to present for transient analyses, bmRelative for Relative to
Base or bmTotal for Total.
[ipResOptsBaseAcc] – Acceleration results to present for transient analyses, bmRelative for Relative
to Base or bmTotal for Total.
