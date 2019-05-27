using System;

namespace SortFramework.Internal.Algorithms
{
    public static class ShellSort
    {
        private static void sort<TNumber>(TNumber[] list)
            where TNumber : struct, IComparable<TNumber>
        {
            int length = list.Length;
            int h = 1;
            while (h < length)
                h = h * 3 + 1;
            h = h / 3;
            while(h > 0)
            {
                for (int i = h; i < length; i++)
                {
                    var c = list[i];
                    var j = i;
                    while(j >= h && list[j - h].CompareTo(c) == 1)
                    {
                        list[j] = list[j - h];
                        j = j - h;
                    }
                    list[j] = c;
                }
                h = h / 2;
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
