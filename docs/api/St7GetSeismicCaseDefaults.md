# St7GetSeismicCaseDefaults

Returns the defaults for the specified load case of type lcSeismic within a Strand7 model.

Strand7 API Manual

long St7GetSeismicCaseDefaults(long uID, long CaseNum, double* Defaults)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Load case number.

Output Parameters

Defaults[0..9]

[ipSeismicCaseRefTemp] – Reference temperature.

[ipSeismicCaseAlpha] – Seismic case α parameter.

[ipSeismicCasePhi] – Seismic case ϕ parameter.

[ipSeismicCaseBeta] – Seismic case β parameter.

[ipSeismicCaseK] – Seismic case k parameter.

[ipSeismicCaseh0] – Seismic base height parameter h0.

[ipSeismicCaseDir] – Seismic acceleration direction; one of 1, 2 or 3 to denote the global XYZ
directions respectively.

[ipSeismicCaseLinAcc] – Seismic acceleration value.

[ipSeismicCaseV1] – Component of base excitation in the first lateral direction.

[ipSeismicCaseV2] – Component of base excitation in the second lateral direction.
