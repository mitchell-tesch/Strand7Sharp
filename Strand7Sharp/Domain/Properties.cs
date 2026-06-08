using St7API;
namespace Strand7Sharp;
/// <summary>Beam property definitions.</summary>
public readonly struct BeamPropertyCollection
{
    private readonly St7Model _m;
    internal BeamPropertyCollection(St7Model m) => _m = m;
    /// <summary>Number of beam properties currently defined.</summary>
    public int Count
    {
        get
        {
            var num = new int[St7.kMaxEntityTotals];
            var last = new int[St7.kMaxEntityTotals];
            St7Native.St7GetTotalProperties(_m.FileId, num, last);
            return num[St7.ipBeamPropTotal];
        }
    }
    /// <summary>Returns a strongly-typed handle for the given (1-based) beam property number.</summary>
    public BeamProperty this[int propNum] => new(_m, propNum);

    /// <summary>Creates a new beam property of the given type and returns its number.</summary>
    public int Add(BeamType beamType, string name)
    {
        int num = Count + 1;
        St7Native.St7NewBeamProperty(_m.FileId, num, (int)beamType, name);
        return num;
    }
    public string GetName(int propNum) => St7Native.St7GetBeamSectionName(_m.FileId, propNum);
    public void SetName(int propNum, string name) => St7Native.St7SetBeamSectionName(_m.FileId, propNum, name);

    /// <summary>Material data (E, nu, density, alpha) for the given property.</summary>
    public double[] GetMaterial(int propNum)
    {
        var d = new double[St7.kNumMaterialData];
        St7Native.St7GetBeamMaterialData(_m.FileId, propNum, d);
        return d;
    }
    public void SetMaterial(int propNum, double[] materialData)
        => St7Native.St7SetBeamMaterialData(_m.FileId, propNum, materialData);

    /// <summary>Iterate every beam property (1..Count).</summary>
    public St7Enumerator<BeamProperty> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<BeamProperty>(Count, i => new BeamProperty(m, i));
    }
}

/// <summary>Strongly-typed view onto one beam property.</summary>
public readonly struct BeamProperty
{
    private readonly St7Model _m;
    public int Number { get; }
    internal BeamProperty(St7Model m, int number) { _m = m; Number = number; }
    public string Name
    {
        get => St7Native.St7GetBeamSectionName(_m.FileId, Number);
        set => St7Native.St7SetBeamSectionName(_m.FileId, Number, value);
    }
    /// <summary>The beam kind (beam, truss, cable, ...).</summary>
    public BeamType BeamType => (BeamType)St7Native.St7GetBeamPropertyType(_m.FileId, Number);

    /// <summary>(E, nu, density, alpha, ...) buffer.</summary>
    public double[] Material
    {
        get { var d = new double[St7.kNumMaterialData]; St7Native.St7GetBeamMaterialData(_m.FileId, Number, d); return d; }
        set => St7Native.St7SetBeamMaterialData(_m.FileId, Number, value);
    }

    /// <summary>Assign a library beam section (St7AssignLibraryBeamSection).</summary>
    public void AssignLibrarySection(int libraryId, int itemId, int[] integers)
        => St7Native.St7AssignLibraryBeamSection(_m.FileId, Number, libraryId, itemId, integers);
    /// <summary>Assign a library material to the property.</summary>
    public void AssignLibraryMaterial(int libraryId, int itemId)
        => St7Native.St7AssignLibraryMaterial(_m.FileId, St7.tyBEAM, Number, libraryId, itemId);
    public void Delete() => St7Native.St7DeleteProperty(_m.FileId, St7.tyBEAM, Number);
}

/// <summary>Plate property definitions.</summary>
public readonly struct PlatePropertyCollection
{
    private readonly St7Model _m;
    internal PlatePropertyCollection(St7Model m) => _m = m;
    public int Count
    {
        get
        {
            var num = new int[St7.kMaxEntityTotals];
            var last = new int[St7.kMaxEntityTotals];
            St7Native.St7GetTotalProperties(_m.FileId, num, last);
            return num[St7.ipPlatePropTotal];
        }
    }
    public PlateProperty this[int propNum] => new(_m, propNum);
    public int Add(PlateType plateType, MaterialType materialType, string name)
    {
        int num = Count + 1;
        St7Native.St7NewPlateProperty(_m.FileId, num, (int)plateType, (int)materialType, name);
        return num;
    }
    public string GetName(int propNum) => St7Native.St7GetPropertyName(_m.FileId, St7.tyPLATE, propNum);
    public void SetName(int propNum, string name) => St7Native.St7SetPropertyName(_m.FileId, St7.tyPLATE, propNum, name);
    public double[] GetIsotropicMaterial(int propNum)
    {
        var d = new double[St7.kNumMaterialData];
        St7Native.St7GetPlateIsotropicMaterial(_m.FileId, propNum, d);
        return d;
    }
    public void SetIsotropicMaterial(int propNum, double[] materialData)
        => St7Native.St7SetPlateIsotropicMaterial(_m.FileId, propNum, materialData);

    /// <summary>Iterate every plate property (1..Count).</summary>
    public St7Enumerator<PlateProperty> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<PlateProperty>(Count, i => new PlateProperty(m, i));
    }
}

/// <summary>Strongly-typed view onto one plate property.</summary>
public readonly struct PlateProperty
{
    private readonly St7Model _m;
    public int Number { get; }
    internal PlateProperty(St7Model m, int number) { _m = m; Number = number; }
    public string Name
    {
        get => St7Native.St7GetPropertyName(_m.FileId, St7.tyPLATE, Number);
        set => St7Native.St7SetPropertyName(_m.FileId, St7.tyPLATE, Number, value);
    }
    public double[] IsotropicMaterial
    {
        get { var d = new double[St7.kNumMaterialData]; St7Native.St7GetPlateIsotropicMaterial(_m.FileId, Number, d); return d; }
        set => St7Native.St7SetPlateIsotropicMaterial(_m.FileId, Number, value);
    }
    public void AssignLibraryMaterial(int libraryId, int itemId)
        => St7Native.St7AssignLibraryMaterial(_m.FileId, St7.tyPLATE, Number, libraryId, itemId);
    public void AssignLibraryComposite(int libraryId, int itemId)
        => St7Native.St7AssignLibraryComposite(_m.FileId, Number, libraryId, itemId);
    public void Delete() => St7Native.St7DeleteProperty(_m.FileId, St7.tyPLATE, Number);
}

/// <summary>Brick property definitions.</summary>
public readonly struct BrickPropertyCollection
{
    private readonly St7Model _m;
    internal BrickPropertyCollection(St7Model m) => _m = m;
    public int Count
    {
        get
        {
            var num = new int[St7.kMaxEntityTotals];
            var last = new int[St7.kMaxEntityTotals];
            St7Native.St7GetTotalProperties(_m.FileId, num, last);
            return num[St7.ipBrickPropTotal];
        }
    }
    public BrickProperty this[int propNum] => new(_m, propNum);
    public int Add(MaterialType materialType, string name)
    {
        int num = Count + 1;
        St7Native.St7NewBrickProperty(_m.FileId, num, (int)materialType, name);
        return num;
    }
    public string GetName(int propNum) => St7Native.St7GetPropertyName(_m.FileId, St7.tyBRICK, propNum);
    public void SetName(int propNum, string name) => St7Native.St7SetPropertyName(_m.FileId, St7.tyBRICK, propNum, name);
    public double[] GetIsotropicMaterial(int propNum)
    {
        var d = new double[St7.kNumMaterialData];
        St7Native.St7GetBrickIsotropicMaterial(_m.FileId, propNum, d);
        return d;
    }
    public void SetIsotropicMaterial(int propNum, double[] materialData)
        => St7Native.St7SetBrickIsotropicMaterial(_m.FileId, propNum, materialData);

    /// <summary>Iterate every brick property (1..Count).</summary>
    public St7Enumerator<BrickProperty> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<BrickProperty>(Count, i => new BrickProperty(m, i));
    }
}

/// <summary>Strongly-typed view onto one brick property.</summary>
public readonly struct BrickProperty
{
    private readonly St7Model _m;
    public int Number { get; }
    internal BrickProperty(St7Model m, int number) { _m = m; Number = number; }
    public string Name
    {
        get => St7Native.St7GetPropertyName(_m.FileId, St7.tyBRICK, Number);
        set => St7Native.St7SetPropertyName(_m.FileId, St7.tyBRICK, Number, value);
    }
    public double[] IsotropicMaterial
    {
        get { var d = new double[St7.kNumMaterialData]; St7Native.St7GetBrickIsotropicMaterial(_m.FileId, Number, d); return d; }
        set => St7Native.St7SetBrickIsotropicMaterial(_m.FileId, Number, value);
    }
    public void AssignLibraryMaterial(int libraryId, int itemId)
        => St7Native.St7AssignLibraryMaterial(_m.FileId, St7.tyBRICK, Number, libraryId, itemId);
    public void Delete() => St7Native.St7DeleteProperty(_m.FileId, St7.tyBRICK, Number);
}

