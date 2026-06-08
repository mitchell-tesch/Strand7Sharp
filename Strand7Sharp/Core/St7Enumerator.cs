using System;
using System.Collections;
using System.Collections.Generic;

namespace Strand7Sharp;

/// <summary>
/// 1-based forward enumerator over Strand7 entities exposed by a collection.
/// Designed for <c>foreach (var x in collection)</c> with no per-call allocation.
/// </summary>
public struct St7Enumerator<T> : IEnumerator<T>
{
    private readonly Func<int, T> _at;
    private readonly int _count;
    private int _idx;
    internal St7Enumerator(int count, Func<int, T> at) { _count = count; _at = at; _idx = 0; }
    public T Current => _at(_idx);
    object? IEnumerator.Current => Current;
    public bool MoveNext()
    {
        if (_idx >= _count) return false;
        _idx++;
        return true;
    }
    public void Reset() => _idx = 0;
    public void Dispose() { }
}


