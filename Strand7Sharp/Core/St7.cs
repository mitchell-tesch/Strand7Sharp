using System;
using System.Runtime.CompilerServices;
using St7API;

namespace Strand7Sharp;

/// <summary>
/// Helpers for invoking raw <see cref="St7API.St7"/> functions and turning their
/// integer return codes into <see cref="St7Exception"/> instances.
/// </summary>
public static class St7Check
{
    /// <summary>
    /// Invokes <paramref name="call"/>; throws <see cref="St7Exception"/> on non-zero result.
    /// </summary>
    /// <param name="call">Delegate that invokes a raw <c>St7*</c> P/Invoke and returns its error code.</param>
    /// <param name="functionName">Auto-captured caller name used in the exception message.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Check(Func<int> call, [CallerMemberName] string? functionName = null)
    {
        int err = call();
        if (err != 0) throw new St7Exception(err, functionName);
    }

    /// <summary>
    /// Returns <paramref name="errorCode"/> if zero, otherwise throws <see cref="St7Exception"/>.
    /// Typically called as <c>St7Check.Check(St7.St7Init())</c>.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Check(int errorCode, [CallerMemberName] string? functionName = null)
    {
        if (errorCode != 0) throw new St7Exception(errorCode, functionName);
    }

    /// <summary>Convert a managed bool to the byte true/false used by St7 wrappers.</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte AsByte(bool value) => value ? (byte)1 : (byte)0;
}

