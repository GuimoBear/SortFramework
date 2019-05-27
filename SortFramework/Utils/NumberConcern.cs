using System;
using System.Runtime.CompilerServices;

namespace SortFramework.Utils
{
    public static class NumberConcern
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsLessThan<TNumber>(ref TNumber left, ref TNumber right)
            where TNumber: IComparable<TNumber>
            => left.CompareTo(right) == -1;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void InvertNumbers<TNumber>(ref TNumber left, ref TNumber right)
            where TNumber: struct
            => (left, right) = (right, left);
    }
}
