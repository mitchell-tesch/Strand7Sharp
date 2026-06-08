# St7GetFreedomCaseRigidMotion

Returns the remove rigid body motion option for freedom cases of type inertia relief.

long St7GetFreedomCaseRigidMotion(long uID, long CaseNum, bool* Remove)

Input Parameters

uID

Strand7 model file ID.

CaseNum

Freedom case number.

Output Parameters

Remove

If True, rigid body motion is removed.
