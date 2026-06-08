# St7GenerateInfluenceCases

Generates load influence combination load cases.

Influence Combinations

long St7GenerateInfluenceCases(long uID, bool RemoveExisting, bool AllowStop,
bool WriteLog, long Mode, long* NumCasesDeleted, long* NumCasesGenerated,
long* WarningCode)

Input Parameters

uID

Strand7 model file ID.

RemoveExisting

Remove pre-existing load influence combination cases.

AllowStop

True to permit the user to stop the generation of load influence combination cases.

WriteLog

True to write log file output of combination case generation.  If True, full filename with the path can be
accessed using St7GetGlobalStringValue.

Mode

Controls the display of a progress bar; either ieQuietRun or ieProgressRun.

Output Parameters

NumCasesDeleted

Number of pre-existing cases deleted.

NumCasesGenerated

Number of load cases generated.

WarningCode

One of wcInfluenceNoWarning to indicate success, wcInfluenceUserTerminated to indicate the
combinations are incomplete due to user termination, or wcInfluenceRanOutOfAttributeID to indicate
the supply of unique attribute IDs has been exhausted.

Dependencies

Influence Combination Options

Generated load case names controlled by St7SetInfluenceCombinationOptions.

Strand7 API Manual

Custom Result Files
