using St7API;
namespace Strand7Sharp;

/// <summary>Title-block fields (St7.tb*).</summary>
public enum TitleField
{
    Title = St7.tbTitle,
    Project = St7.tbProject,
    Reference = St7.tbReference,
    Author = St7.tbAuthor,
    Created = St7.tbCreated,
    Modified = St7.tbModified,
}

/// <summary>
/// General model metadata, comments and miscellaneous file-wide settings.
/// </summary>
public readonly struct GeneralModelApi
{
    private readonly St7Model _m;
    internal GeneralModelApi(St7Model m) => _m = m;

    /// <summary>The Notes-tab title / project / reference / author / created / modified strings.</summary>
    public string GetTitle(TitleField field) => St7Native.St7GetTitle(_m.FileId, (int)field);
    public void SetTitle(TitleField field, string text) => St7Native.St7SetTitle(_m.FileId, (int)field, text);

    /// <summary>Convenience: Title-block "Title".</summary>
    public string Title { get => GetTitle(TitleField.Title); set => SetTitle(TitleField.Title, value); }
    public string Project { get => GetTitle(TitleField.Project); set => SetTitle(TitleField.Project, value); }
    public string Reference { get => GetTitle(TitleField.Reference); set => SetTitle(TitleField.Reference, value); }
    public string Author { get => GetTitle(TitleField.Author); set => SetTitle(TitleField.Author, value); }
    public string Created { get => GetTitle(TitleField.Created); set => SetTitle(TitleField.Created, value); }
    public string Modified { get => GetTitle(TitleField.Modified); set => SetTitle(TitleField.Modified, value); }

    /// <summary>Get / set the n-th free-form comment line.</summary>
    public string GetComment(int comment) => St7Native.St7GetComment(_m.FileId, comment);
    public void SetComment(int comment, string text) => St7Native.St7SetComment(_m.FileId, comment, text);

    /// <summary>Free-form comments collection (App / Notes-tab comments).</summary>
    public CommentCollection Comments => new(_m);

    /// <summary>Result-combination file controls: see <see cref="ResultCombinations"/>.</summary>
    public ResultCombinationsApi ResultCombinations => new(_m);
}

/// <summary>Result combination files (LSA combinations, factor envelopes, etc.).</summary>
public readonly struct ResultCombinationsApi
{
    private readonly St7Model _m;
    internal ResultCombinationsApi(St7Model m) => _m = m;

    public void AddLSACombination(string combCaseName)
        => St7Native.St7AddLSACombination(_m.FileId, combCaseName);

    public void AddCombinationEnvelope(int envType, string envName)
        => St7Native.St7AddCombinationEnvelope(_m.FileId, envType, envName);

    public void DeleteLSACombination(int pos)
        => St7Native.St7DeleteLSACombination(_m.FileId, pos);

    public void DeleteCombinationEnvelope(int envelope)
        => St7Native.St7DeleteCombinationEnvelope(_m.FileId, envelope);
}


