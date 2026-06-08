// Polyfill for compiling C# 9+ init-only members and records on .NET Framework / netstandard 2.0.
#if NETFRAMEWORK || NETSTANDARD2_0
namespace System.Runtime.CompilerServices
{
    using System.ComponentModel;

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static class IsExternalInit { }
}
#endif
