using St7API;
namespace Strand7Sharp;
/// <summary>
/// Tables defined in the model (factor-vs-X, time, temperature, moment-rotation, …).
/// Each table is keyed by (tableType, tableID); names are unique per type.
/// </summary>
public readonly struct TableCollection
{
    private readonly St7Model _m;
    internal TableCollection(St7Model m) => _m = m;

    /// <summary>(NumTables, MaxTableNum) for the given table-type code.</summary>
    public (int NumTables, int MaxTableNum) Counts(TableType tableType) => St7Native.St7GetNumTables(_m.FileId, (int)tableType);

    /// <summary>Number of tables of the given type.</summary>
    public int Count(TableType tableType) => Counts(tableType).NumTables;

    /// <summary>Returns the (id, name) for the given table by 1-based index.</summary>
    public (int Id, string Name) GetByIndex(TableType tableType, int index)
        => St7Native.St7GetTableInfoByIndex(_m.FileId, (int)tableType, index);

    /// <summary>Look up a table ID by its name.</summary>
    public int GetIdByName(TableType tableType, string tableName)
        => St7Native.St7GetTableID(_m.FileId, tableName, (int)tableType);

    /// <summary>Returns a handle to manipulate a specific table.</summary>
    public Table this[TableType tableType, int tableId] => new(_m, (int)tableType, tableId);

    /// <summary>
    /// Create a new table of the given type at the given ID. <paramref name="data"/>
    /// is the flat (x,y) row-major buffer of length <c>numEntries*2</c>.
    /// </summary>
    public Table Add(TableType tableType, int tableId, string tableName, int numEntries, double[] data)
    {
        St7Native.St7NewTableType(_m.FileId, (int)tableType, tableId, numEntries, tableName, data);
        return new Table(_m, (int)tableType, tableId);
    }

    /// <summary>Iterate every table of the given type.</summary>
    public St7Enumerator<Table> Enumerate(TableType tableType)
    {
        var m = _m;
        int tt = (int)tableType;
        return new St7Enumerator<Table>(Count(tableType), i =>
        {
            int id = St7Native.St7GetTableInfoByIndex(m.FileId, tt, i).TableID;
            return new Table(m, tt, id);
        });
    }
}

/// <summary>Strongly-typed view onto one table.</summary>
public readonly struct Table
{
    private readonly St7Model _m;
    public int TableType { get; }
    public int Id { get; }
    internal Table(St7Model m, int tableType, int id) { _m = m; TableType = tableType; Id = id; }

    public string Name
    {
        get => St7Native.St7GetTableTypeName(_m.FileId, TableType, Id);
        set => St7Native.St7SetTableTypeName(_m.FileId, TableType, Id, value);
    }

    /// <summary>Number of rows currently defined.</summary>
    public int RowCount => St7Native.St7GetNumTableTypeRows(_m.FileId, TableType, Id);

    /// <summary>Flat (x,y) row-major buffer of length <c>RowCount*2</c>.</summary>
    public double[] Data
    {
        get
        {
            int rows = RowCount;
            var buf = new double[rows * 2];
            St7Native.St7GetTableTypeData(_m.FileId, TableType, Id, rows, buf);
            return buf;
        }
        set => St7Native.St7SetTableTypeData(_m.FileId, TableType, Id, value.Length / 2, value);
    }

    /// <summary>Delete this table.</summary>
    public void Delete() => St7Native.St7DeleteTableType(_m.FileId, TableType, Id);
}

