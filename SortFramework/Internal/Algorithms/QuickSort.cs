using SortFramework.Utils;
using System;

namespace SortFramework.Internal.Algorithms
{
    public static class QuickSort
    {
        private static void sort<TNumber>(TNumber[] list, int low, int high)
            where TNumber : struct, IComparable<TNumber>
        {
            int i = low;
            int j = high;
            int pivotIndex = low + (high - low) / 2;
            TNumber pivot = list[pivotIndex];
            while(i <= j)
            {
                while (list[i].CompareTo(pivot) == -1)
                    i++;
                while (list[j].CompareTo(pivot) == 1)
                    j--;
                if(i <= j)
                {
                    NumberConcern.InvertNumbers(ref list[i], ref list[j]);
                    i++;
                    j--;
                }
            }
            if (low < j)
                sort(list, low, j);
            if (i < high)
                sort(list, i, high);
        }

        public static void Sort(byte[] list)
            => sort(list, 0, list.Length - 1);

        public static void Sort(sbyte[] list)
            => sort(list, 0, list.Length - 1);

        public static void Sort(short[] list)
            => sort(list, 0, list.Length - 1);

        public static void Sort(ushort[] list)
            => sort(list, 0, list.Length - 1);

        public static void Sort(int[] list)
            => sort(list, 0, list.Length - 1);

        public static void Sort(uint[] list)
            => sort(list, 0, list.Length - 1);

        public static void Sort(long[] list)
            => sort(list, 0, list.Length - 1);

        public static void Sort(ulong[] list)
            => sort(list, 0, list.Length - 1);

        public static void Sort(decimal[] list)
            => sort(list, 0, list.Length - 1);

        public static void Sort(float[] list)
            => sort(list, 0, list.Length - 1);

        public static void Sort(double[] list)
            => sort(list, 0, list.Length - 1);
    }
}
