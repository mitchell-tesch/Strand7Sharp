using St7API;
namespace Strand7Sharp;

/// <summary>Free-form comment lines on the model's Notes tab.</summary>
public readonly struct CommentCollection
{
    private readonly St7Model _m;
    internal CommentCollection(St7Model m) => _m = m;
    public int Count => St7Native.St7GetNumComments(_m.FileId);
    public string this[int index]
    {
        get => St7Native.St7GetComment(_m.FileId, index);
        set => St7Native.St7SetComment(_m.FileId, index, value);
    }
    /// <summary>Append a new comment. Returns the new comment's count.</summary>
    public int Add(string text)
    {
        St7Native.St7AddComment(_m.FileId, text);
        return Count;
    }
    public void Delete(int index) => St7Native.St7DeleteComment(_m.FileId, index);
    public St7Enumerator<string> GetEnumerator()
    {
        var m = _m;
        return new St7Enumerator<string>(Count, i => St7Native.St7GetComment(m.FileId, i));
    }
}

