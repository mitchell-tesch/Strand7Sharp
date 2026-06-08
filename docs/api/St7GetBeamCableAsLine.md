# St7GetBeamCableAsLine

Returns the option for cables to ignore the beam style and use bsLine instead.

long St7GetBeamCableAsLine(long uID, bool* AsLine)

Input Parameters

uID

Strand7 model file ID.

Output Parameters

AsLine

If True, the cable is rendered using the bsLine style; if False, the cable is rendered using the set beam
style.
