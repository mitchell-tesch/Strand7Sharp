# St7ConvertUnits

Converts the current model into the specified units system.

long St7ConvertUnits(long uID, long* Units)
Input Parameters
uID
Strand7 model file ID.
Units[0..kLastUnit-1]
[ipLENGTHU] – luMETRE, luCENTIMETRE, luMILLIMETRE, luFOOT or luINCH.
[ipFORCEU] – fuNEWTON, fuKILONEWTON, fuMEGANEWTON, fuKILOFORCE, fuPOUNDFORCE,
fuTONNEFORCE or fuKIPFORCE.
[ipSTRESSU] – suPASCAL, suKILOPASCAL, suMEGAPASCAL, suKSCm, suPSI, suKSI or suPSF.
[ipMASSU] – muKILOGRAM, muTONNE, muGRAM, muPOUND or muSLUG.
[ipTEMPERU] – tuCELSIUS, tuFAHRENHEIT, tuKELVIN or tuRANKINE.
[ipENERGYU] – euJOULE, euKILOJOULE, euBTU, euFTLBF or euCALORIE.
