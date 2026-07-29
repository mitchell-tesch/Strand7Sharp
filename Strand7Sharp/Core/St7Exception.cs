using System;
using System.Text;
using St7API;

namespace Strand7Sharp;

/// <summary>
/// Exception thrown when a Strand7 API call returns a non-zero error code.
/// Wraps the raw integer error returned by <c>St7API.dll</c> and, when possible,
/// the human-readable error string from <see cref="St7.St7GetAPIErrorString"/>.
/// </summary>
[Serializable]
public sealed class St7Exception : Exception
{
    /// <summary>The raw Strand7 error code (e.g. one of the <c>ERR7_*</c> constants).</summary>
    public int ErrorCode { get; }

    /// <summary>Typed view of <see cref="ErrorCode"/>. Cast to inspect codes not enumerated in <see cref="St7ErrorCode"/>.</summary>
    public St7ErrorCode Code => (St7ErrorCode)ErrorCode;

    /// <summary>The name of the St7API function that produced the error, if known.</summary>
    public string? FunctionName { get; }

    public St7Exception(int errorCode, string? functionName = null)
        : base(BuildMessage(errorCode, functionName))
    {
        ErrorCode = errorCode;
        FunctionName = functionName;
    }

    private static string BuildMessage(int errorCode, string? functionName)
    {
        var sb = new StringBuilder(St7.kMaxStrLen);
        string detail;
        try
        {
            // St7GetAPIErrorString itself returns an int, but we ignore it here.
            St7.St7GetAPIErrorString(errorCode, sb, St7.kMaxStrLen);
            detail = sb.ToString();
        }
        catch
        {
            detail = string.Empty;
        }

        var fn = string.IsNullOrEmpty(functionName) ? "St7API" : functionName;
        return string.IsNullOrEmpty(detail)
            ? $"{fn} failed with error code {errorCode}."
            : $"{fn} failed with error code {errorCode}: {detail}";
    }
}

