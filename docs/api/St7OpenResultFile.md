# St7OpenResultFile

Opens a result file associated with the specified Strand7 model. All supported result file types may be opened.

long St7OpenResultFile(long uID, char* FileName, char* SpectralName,
long CombinationCode, long* NumPrimary, long* NumSecondary)
Input Parameters
uID
Strand7 model file ID.
FileName
Full path and filename for the Strand7 result file.
SpectralName
Full path and filename for the spectral result file to be combined. A null string may be passed to
combine with the default spectral file as defined by the user in the Strand7 model.
CombinationCode
kNoCombinations – no combinations.
kGenerateNewCombinations – generate new combinations.
kUseExistingCombinations – open previously saved combinations if a valid .LSC file exists, otherwise,
generate the combinations.
Note that result envelopes are not calculated – use St7GenerateEnvelopes for these.
Output Parameters
NumPrimary
Number of primary result cases available.
NumSecondary
Number of secondary result cases (excluding envelopes). If they were not generated at the time the
results were opened (that is, Combinations was set to kNoCombinations), they can be generated when
they are required by calling St7GenerateLSACombinations.
Dependencies
Hidden Results
Result cases may be hidden according to the settings of St7SetResultFileOpenFlag and
St7SetNFAFileOpenMinMass.
