# St7GetIconSize

Returns the size of the icons used in the model and solver windows.

long St7GetIconSize(long* IconSize)

Output Parameters
IconSize

0 – Strand7 selects a size automatically.

1..5 – User specified icon size; 1 is a 16x16 pixel icon with each successive size increasing the icon by 8
pixels (i.e. 16x16, 24x24, 32x32, 40x40 and 48x48)
