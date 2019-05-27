using SortFramework.Utils;
using System;

namespace SortFramework.Internal.Algorithms
{
    public static class InsertionSort
    {
        private static void sort<TNumber>(TNumber[] list)
            where TNumber : struct, IComparable<TNumber>
        {
            int length = list.Length;
            for (int i = 1; i < length; i++)
            {
                var lowest = list[i];
                var j = i - 1;

                while ((j >= 0) && NumberConcern.IsLessThan(ref lowest, ref list[j]))
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = lowest;
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
