# St7GetResFileUnits

Returns the units in which result data must be provided to St7SetResFileNodeResult, St7SetResFileBeamResult,
St7SetResFilePlateResult, St7SetResFilePlatePressureResult and St7SetResFileBrickResult.

long St7GetResFileUnits(long uID, long* Units)

Input Parameters

uID

Strand7 model file ID.

Output Parameters

Units[0..kLastUnit-1]

[ipLENGTHU] – one of luMETRE, luCENTIMETRE, luMILLIMETRE, luFOOT or luINCH;
measuring length in metres, centimetres, millimetres, feet or inches respectively.

Strand7 API Manual

[ipFORCEU] – one of fuNEWTON, fuKILONEWTON, fuMEGANEWTON, fuKILOFORCE, fuPOUNDFORCE,
fuTONNEFORCE or fuKIPFORCE;
measuring force in newtons, kilonewtons, meganewtons, kilograms-force, pounds-force, tonnes-force
or kilopounds-force respectively.

[ipSTRESSU] – one of suPASCAL, suKILOPASCAL, suMEGAPASCAL, suKSCm, suPSI, suKSI or suPSF;
measuring stress in units of pascals, kilopascals, megapascals, kilograms-force per square centimetre,
pounds per square inch, kilopounds per square inch, or pounds per square foot respectively.

[ipMASSU] – one of muKILOGRAM, muTONNE, muGRAM, muPOUND or muSLUG;
measuring mass in units of kilograms, tonnes, grams, pounds or slugs respectively.

[ipTEMPERU] – one of tuCELSIUS, tuFAHRENHEIT, tuKELVIN or tuRANKINE;
measuring temperature in units of Celsius, Fahrenheit, Kelvin or Rankine respectively.

[ipENERGYU] – one of euJOULE, euKILOJOULE, euBTU, euFTLBF or euCALORIE;
measuring energy in units of joules, kilojoules, British thermal units, foot pounds-force or calories
respectively.
