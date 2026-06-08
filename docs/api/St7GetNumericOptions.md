# St7GetNumericOptions

Returns the display mode of numbers in the model window.

Model Window

long St7GetNumericOptions(long uID, long Mode, long* Style, long* Digits,

long* Exponent, double* Zero)

Input Parameters

uID

Strand7 model file ID.

Output Parameters

Mode

The model window mode for which the numeric options are being retrieved.  Either nmPreProcessing or
nmPostProcessing.

Style

One of nsFixed, nsEngineering, nsScientific or nsAuto.

Digits

Number of digits to display.

Exponent

Either efLowered or efRaised.

Zero

Zero cut-off; numbers with a smaller magnitude than this are displayed as zero.
