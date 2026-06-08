# St7Release

Releases the Strand7 API DLL and unloads the Strand7 licence manager freeing any active licences.  St7Init must
again be called before API functions can be executed again (other than St7SetIconSize, St7GetIconSize,
St7GetAPIPath, St7SetLicenceOptions, St7GetLicenceOptions, St7Version, St7BuildString, St7GetListSeparatorCode,
St7GetDecimalSeparatorCode or St7GetMaxModelFileID).

long St7Release()
