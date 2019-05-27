using SortFramework.Utils;
using System;

namespace SortFramework.Internal.Algorithms
{
    public static class Cocktailsort
    {
        private static void sort<TNumber>(TNumber[] list)
            where TNumber : struct, IComparable<TNumber>
        {
            int lowerIndex = 0;
            int higherIndex = list.Length - 1;
            while (lowerIndex < higherIndex)
            {
                for (int i = lowerIndex + 1; i <= higherIndex; i++)
                {
                    if (NumberConcern.IsLessThan(ref list[i], ref list[lowerIndex]))
                        NumberConcern.InvertNumbers(ref list[i], ref list[lowerIndex]);
                }
                lowerIndex++;
                for (int i = higherIndex - 1; i >= lowerIndex; i--)
                {
                    if (NumberConcern.IsLessThan(ref list[higherIndex], ref list[i]))
                        NumberConcern.InvertNumbers(ref list[higherIndex], ref list[i]);
                }
                higherIndex--;
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
