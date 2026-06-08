using System;
using St7API;
namespace Strand7Sharp;

/// <summary>
/// Controls the on-screen Strand7 model window for a given model. The window
/// can be created standalone or embedded inside an existing HWND, refreshed,
/// repositioned, and used to render images or animations.
/// </summary>
public readonly struct WindowApi
{
    private readonly St7Model _m;
    internal WindowApi(St7Model m) => _m = m;

    /// <summary>Create the model window (St7CreateModelWindow).</summary>
    public void Create() => St7Native.St7CreateModelWindow(_m.FileId);
    public void Destroy() => St7Native.St7DestroyModelWindow(_m.FileId);
    public void Show() => St7Native.St7ShowModelWindow(_m.FileId);
    public void Hide() => St7Native.St7HideModelWindow(_m.FileId);
    public void Clear() => St7Native.St7ClearModelWindow(_m.FileId);

    /// <summary>Get the HWND of the embedded model window.</summary>
    public IntPtr Handle => St7Native.St7GetModelWindowHandle(_m.FileId);
    /// <summary>HWND of the window currently parented as the host.</summary>
    public IntPtr Parent
    {
        get => St7Native.St7GetModelWindowParent(_m.FileId);
        set => St7Native.St7SetModelWindowParent(_m.FileId, value);
    }
    /// <summary>Window state code (St7GetModelWindowState).</summary>
    public int State => St7Native.St7GetModelWindowState(_m.FileId);

    public (int Left, int Top, int Width, int Height) Position
    {
        get => St7Native.St7GetModelWindowPosition(_m.FileId);
        set => St7Native.St7PositionModelWindow(_m.FileId, value.Left, value.Top, value.Width, value.Height);
    }
    public void SetPosition(int left, int top, int width, int height)
        => St7Native.St7PositionModelWindow(_m.FileId, left, top, width, height);

    /// <summary>Refresh-mode for the model window (0=auto, 1=manual etc., see docs).</summary>
    public int RefreshMode { set => St7Native.St7SetModelWindowRefresh(_m.FileId, value); }

    // ----- View case selection -----
    public int LoadCase    { set => St7Native.St7SetWindowLoadCase(_m.FileId, value); }
    public int FreedomCase { set => St7Native.St7SetWindowFreedomCase(_m.FileId, value); }
    public int UCSCase     { set => St7Native.St7SetWindowUCSCase(_m.FileId, value); }
    public int ResultCase  { set => St7Native.St7SetWindowResultCase(_m.FileId, value); }

    // ----- Background -----
    public int GetBackgroundMode(int windowMode) => St7Native.St7GetWindowBackgroundMode(_m.FileId, windowMode);
    public void SetBackgroundMode(int windowMode, int backgroundMode)
        => St7Native.St7SetWindowBackgroundMode(_m.FileId, windowMode, backgroundMode);
    public (int Solid, int Gradient) GetColours(int windowMode) => St7Native.St7GetWindowColours(_m.FileId, windowMode);
    public void SetColours(int windowMode, int solidColour, int gradientColour)
        => St7Native.St7SetWindowColours(_m.FileId, windowMode, solidColour, gradientColour);

    // ----- Image export -----
    public string ImageFile
    {
        get => St7Native.St7GetWindowImageFile(_m.FileId);
        set => St7Native.St7SetWindowImageFile(_m.FileId, value);
    }
    public int ImageLocation
    {
        get => St7Native.St7GetWindowImageLocation(_m.FileId);
        set => St7Native.St7SetWindowImageLocation(_m.FileId, value);
    }
    /// <summary>Size of the background image as a percentage (0..100) of the model window's
    /// width. 0 means the image is rendered pixel-by-pixel, unscaled.</summary>
    public int ImageSize
    {
        get => St7Native.St7GetWindowImageSize(_m.FileId);
        set => St7Native.St7SetWindowImageSize(_m.FileId, value);
    }

    // ----- Animations -----
    /// <summary>Create an animation handle in memory (St7CreateAnimation).</summary>
    public int CreateAnimation(int[] integers) => St7Native.St7CreateAnimation(_m.FileId, integers);
    /// <summary>Create an embedded animation hosted by another HWND.</summary>
    public int CreateAnimationEmbedded(IntPtr parent, int[] integers)
        => St7Native.St7CreateAnimationEmbedded(_m.FileId, parent, integers);
    /// <summary>Write an animation to a file.</summary>
    public void CreateAnimationFile(int[] integers, string fileName)
        => St7Native.St7CreateAnimationFile(_m.FileId, integers, fileName);
    public bool GetAnimationCase(int caseNum) => St7Native.St7GetAnimationCase(_m.FileId, caseNum) != 0;
    public void SetAnimationCase(int caseNum, bool active)
        => St7Native.St7SetAnimationCase(_m.FileId, caseNum, St7Check.AsByte(active));

    /// <summary>Close a previously-created animation handle.</summary>
    public static void CloseAnimation(int animationHandle) => St7Native.St7CloseAnimation(animationHandle);
    /// <summary>Play an animation file via Strand7's built-in player. Returns the handle.</summary>
    public static int PlayAnimationFile(string fileName) => St7Native.St7PlayAnimationFile(fileName);
}

