using System;
using St7API;
namespace Strand7Sharp;
/// <summary>
/// Geometry / mesh / cleanup tools that act on the whole model.
/// </summary>
public readonly struct ToolsApi
{
    private readonly St7Model _m;
    internal ToolsApi(St7Model m) => _m = m;

    // ----- Cleaning -----
    /// <summary>Run the mesh cleaner (St7CleanMesh).</summary>
    public void CleanMesh() => St7Native.St7CleanMesh(_m.FileId);

    /// <summary>Run the geometry cleaner; returns the number of changes made.</summary>
    public int CleanGeometry(int mode = 0) => St7Native.St7CleanGeometry(_m.FileId, mode);

    /// <summary>Read/write the mesh-cleaner option buffer (St7Get/SetCleanMeshOptions).</summary>
    public (int[] Integers, double[] Doubles) GetCleanMeshOptions(int intLen = 16, int doubleLen = 16)
    {
        var ints = new int[intLen]; var dbls = new double[doubleLen];
        St7Native.St7GetCleanMeshOptions(_m.FileId, ints, dbls);
        return (ints, dbls);
    }
    public void SetCleanMeshOptions(int[] integers, double[] doubles)
        => St7Native.St7SetCleanMeshOptions(_m.FileId, integers, doubles);

    /// <summary>Read/write the geometry-cleaner option buffer.</summary>
    public (int[] Integers, double[] Doubles) GetCleanGeometryOptions(int intLen = 16, int doubleLen = 16)
    {
        var ints = new int[intLen]; var dbls = new double[doubleLen];
        St7Native.St7GetCleanGeometryOptions(_m.FileId, ints, dbls);
        return (ints, dbls);
    }
    public void SetCleanGeometryOptions(int[] integers, double[] doubles)
        => St7Native.St7SetCleanGeometryOptions(_m.FileId, integers, doubles);

    /// <summary>Drop nodes that are not referenced by any element. Returns the count deleted.</summary>
    public int DeleteUnusedNodes() => St7Native.St7DeleteUnusedNodes(_m.FileId);

    /// <summary>Drop unused property definitions of the given entity. Returns the count deleted.</summary>
    public int DeleteUnusedProperties(EntityType entity)
        => St7Native.St7DeleteUnusedProperties(_m.FileId, (int)entity);

    /// <summary>Repair zero-area tri3 elements.</summary>
    public void RepairTri3Mesh(double maxAngle) => St7Native.St7RepairTri3Mesh(_m.FileId, maxAngle);

    /// <summary>Move mid-side nodes to the chord midpoint when <paramref name="makeStraight"/>.</summary>
    public void AdjustMidsideNodes(bool makeStraight)
        => St7Native.St7AdjustMidsideNodes(_m.FileId, St7Check.AsByte(makeStraight));

    // ----- Meshing -----
    /// <summary>Surface-mesh the selected faces (St7SurfaceMesh).</summary>
    public void SurfaceMesh(int[] integers, double[] doubles, int mode = 0)
        => St7Native.St7SurfaceMesh(_m.FileId, integers, doubles, mode);

    /// <summary>Solid (tet) mesh from surface (St7SolidTetMesh).</summary>
    public void SolidTetMesh(int[] integers, int mode = 0)
        => St7Native.St7SolidTetMesh(_m.FileId, integers, mode);

    /// <summary>Direct tet-mesh of a closed surface (St7DirectSolidTetMesh).</summary>
    public void DirectSolidTetMesh(int[] integers, double[] doubles, int mode = 0)
        => St7Native.St7DirectSolidTetMesh(_m.FileId, integers, doubles, mode);

    /// <summary>Mesh from a set of geometric loops (St7MeshFromLoops).</summary>
    public void MeshFromLoops(int[] integers, double[] doubles, int[] loops, double[] points, int mode = 0)
        => St7Native.St7MeshFromLoops(_m.FileId, integers, doubles, loops, points, mode);

    // ----- Subdivision -----
    /// <summary>Subdivide selected elements (St7Subdivide).</summary>
    public void Subdivide(int divsA, int divsB, int divsC, int plateTarget = 0, int brickTarget = 0)
        => St7Native.St7Subdivide(_m.FileId, divsA, divsB, divsC, plateTarget, brickTarget);
    public void SubdivideBeams(double length) => St7Native.St7SubdivideBeams(_m.FileId, length);
    public void SubdivideEdges(int divisions, int vertexType = 0)
        => St7Native.St7SubdivideEdges(_m.FileId, divisions, vertexType);

    // ----- Reordering -----
    /// <summary>Renumber nodes via the AMD ordering algorithm.</summary>
    public void ReorderNodesAMD() => St7Native.St7ReorderNodesAMD(_m.FileId);
    public void ReorderNodesTree(int startNode) => St7Native.St7ReorderNodesTree(_m.FileId, startNode);
    public void ReorderNodesGeometry(double dx, double dy, double dz)
        => St7Native.St7ReorderNodesGeometry(_m.FileId, new[] { dx, dy, dz });

    // ----- Copy / Move / Extrude / Mirror / Rotate (act on the current selection) -----
    /// <summary>Set the per-operation copy flags (St7SetCopyFlags) - controls which attributes carry across.</summary>
    public void SetCopyFlags(int[] flags) => St7Native.St7SetCopyFlags(_m.FileId, flags);
    public void SetExtrudeFlags(int[] flags) => St7Native.St7SetExtrudeFlags(_m.FileId, flags);
    public void SetExtrudeTargets(int[] targets) => St7Native.St7SetExtrudeTargets(_m.FileId, targets);

    public void CopyByIncrement(Vector3 delta, int ucsId, int numCopies)
        => St7Native.St7CopyByIncrement(_m.FileId, delta.ToArray(), ucsId, numCopies);
    public void CopyByRotation(int ucsId, int axis, double angleRad, Vector3 origin, int numCopies)
        => St7Native.St7CopyByRotation(_m.FileId, ucsId, axis, angleRad, origin.ToArray(), numCopies);
    public void CopyByMirror(int planeId) => St7Native.St7CopyByMirror(_m.FileId, planeId);
    public void CopyToAbsolute(double value, int ucsId, int axis)
        => St7Native.St7CopyToAbsolute(_m.FileId, value, ucsId, axis);

    public void MoveByIncrement(Vector3 delta, int ucsId)
        => St7Native.St7MoveByIncrement(_m.FileId, delta.ToArray(), ucsId);
    public void MoveByRotation(int ucsId, int axis, double angleRad, Vector3 origin)
        => St7Native.St7MoveByRotation(_m.FileId, ucsId, axis, angleRad, origin.ToArray());
    public void MoveByMirror(int planeId) => St7Native.St7MoveByMirror(_m.FileId, planeId);
    public void MoveToAbsolute(double value, int ucsId, int axis)
        => St7Native.St7MoveToAbsolute(_m.FileId, value, ucsId, axis);
    public void MoveToOriginByPoint(int ucsId, Vector3 point)
        => St7Native.St7MoveToOriginByPoint(_m.FileId, ucsId, point.ToArray());
    public void MoveToOriginMinXYZ(int ucsId) => St7Native.St7MoveToOriginMinXYZ(_m.FileId, ucsId);
    public void MoveToPlane(int sourcePlaneId, int targetPlaneId)
        => St7Native.St7MoveToPlane(_m.FileId, sourcePlaneId, targetPlaneId);

    public void ExtrudeByIncrement(Vector3 delta, int ucsId, int numCopies)
        => St7Native.St7ExtrudeByIncrement(_m.FileId, delta.ToArray(), ucsId, numCopies);
    public void ExtrudeByRotation(int ucsId, int axis, double angleRad, Vector3 origin, int numCopies)
        => St7Native.St7ExtrudeByRotation(_m.FileId, ucsId, axis, angleRad, origin.ToArray(), numCopies);

    /// <summary>Rotate the whole model about the current axes by (rX, rY, rZ) radians.</summary>
    public void RotateModel(double rx, double ry, double rz) => St7Native.St7RotateModel(_m.FileId, rx, ry, rz);

    // ----- Plane-based operations -----
    public void CutElementsByPlane(int planeId, int edgeTol, int beamPropNum, int platePropNum)
        => St7Native.St7CutElementsByPlane(_m.FileId, planeId, edgeTol, beamPropNum, platePropNum);
    public void SliceOnPlane(int planeId, int propNum, int numRepeats, double increment, bool doBeams = true, bool doPlates = true)
        => St7Native.St7SliceOnPlane(_m.FileId, planeId, propNum, numRepeats, increment,
            St7Check.AsByte(doBeams), St7Check.AsByte(doPlates));
    public void SplitFaceByPlane(int planeId, int numCutFaces, int numRepeats, double increment)
        => St7Native.St7SplitFaceByPlane(_m.FileId, planeId, numCutFaces, numRepeats, increment);

    // ----- Mid-plane / merging -----
    public void MidPlanePlateProjection(int plateNum) => St7Native.St7MidPlanePlateProjection(_m.FileId, plateNum);
    public void MidPlaneThinSolids(double normalsTolRad) => St7Native.St7MidPlaneThinSolids(_m.FileId, normalsTolRad);
    public void MergeElementPairs(bool quadratic = false) => St7Native.St7MergeElementPairs(_m.FileId, St7Check.AsByte(quadratic));

    // ----- Plane definitions (return a 1-based planeID usable by Cut/Move/Copy/Slice/Mirror) -----
    /// <summary>Plane through the given node, normal to the global axis (1=X, 2=Y, 3=Z).</summary>
    public int DefinePlaneAtNode(int nodeNum, int planeAxis) => St7Native.St7DefinePlaneGlobalN(_m.FileId, nodeNum, planeAxis);
    public int DefinePlaneAtVertex(int vertexNum, int planeAxis) => St7Native.St7DefinePlaneGlobalV(_m.FileId, vertexNum, planeAxis);
    public int DefinePlane(Vector3 p1, Vector3 p2, Vector3 p3) => St7Native.St7DefinePlaneP3(_m.FileId, p1.ToArray(), p2.ToArray(), p3.ToArray());
    public int DefinePlaneUCS(int ucsId, int ucsPlane) => St7Native.St7DefinePlaneUCS(_m.FileId, ucsId, ucsPlane);
}

