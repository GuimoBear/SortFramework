using SortFramework.Utils;
using System;

namespace SortFramework.Internal.Algorithms
{
    public static class CombSort
    {
        private static void sort<TNumber>(TNumber[] list)
            where TNumber : struct, IComparable<TNumber>
        {
            var length = list.Length;
            int gap = length;
            bool swapped = true;
            while (gap > 1 || swapped)
            {
                if (gap > 1)
                    gap = (int)(gap / 1.247330950103979);
                int i = 0;
                swapped = false;
                while(i + gap < length)
                {
                    if(list[i].CompareTo(list[i + gap]) > 0)
                    {
                        NumberConcern.InvertNumbers(ref list[i], ref list[i + gap]);
                        swapped = true;
                    }
                    i++;
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
