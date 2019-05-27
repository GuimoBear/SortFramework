using SortFramework.Utils;
using System;

namespace SortFramework.Internal.Algorithms
{
    public static class Bubblesort
    {
        private static void sort<TNumber>(TNumber[] list)
            where TNumber: struct, IComparable<TNumber>
        {
            int length = list.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (NumberConcern.IsLessThan(ref list[j], ref list[i]))
                        NumberConcern.InvertNumbers(ref list[j], ref list[i]);
                }
            }
        }

        public static void Sort(byte[] list)
            => sort(list);

        public static void Sort(sbyte[] list)
            => sort(list);

        public static void Sort(short[] list)
            => sort(list);

        public static void Sort(ushort[] list)
            => sort(list);

        public static void Sort(int[] list)
            => sort(list);

        public static void Sort(uint[] list)
            => sort(list);

        public static void Sort(long[] list)
            => sort(list);

        public static void Sort(ulong[] list)
            => sort(list);

        public static void Sort(decimal[] list)
            => sort(list);

        public static void Sort(float[] list)
            => sort(list);

        public static void Sort(double[] list)
            => sort(list);
    }
}
