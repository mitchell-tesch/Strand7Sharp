# St7SetIconSize

Sets the size of the icons to be used in the model and solver windows. This function must be called before St7Init,
otherwise it will return an error code.

long St7SetIconSize(long IconSize)

Input Parameters
IconSize

0 – Strand7 selects a size automatically.

1..5 – User specified icon size; 1 is a 16x16 pixel icon with each successive size increasing the icon by 8
pixels (i.e. 24x24, 32x32, etc.)
