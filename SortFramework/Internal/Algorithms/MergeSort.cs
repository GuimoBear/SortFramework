using System;

namespace SortFramework.Internal.Algorithms
{
    public static class MergeSort
    {
        private static void sort<TNumber>(TNumber[] list, int startIndex, int endIndex, TNumber[] aux = null)
            where TNumber : struct, IComparable<TNumber>
        {
            int length = list.Length;
            if (aux == null)
                aux = new TNumber[length];
            if (startIndex < endIndex && startIndex >= 0 && endIndex < length && length != 0)
            {
                int middleIndex = (endIndex + startIndex) / 2;
                sort(list, startIndex, middleIndex, aux);
                sort(list, middleIndex + 1, endIndex, aux);
                merge(list, startIndex, middleIndex, endIndex, aux);
            }
        }

        private static void merge<TNumber>(TNumber[] list, int startIndex, int middleIndex, int endIndex, TNumber[] aux)
            where TNumber : struct, IComparable<TNumber>
        {
            var length = list.Length;
            Array.Copy(list, startIndex, aux, startIndex, (endIndex - startIndex) + 1);

            int i = startIndex;
            int j = middleIndex + 1;
            int k = startIndex;

            while ((i <= middleIndex) && (j <= endIndex))
            {
                if(aux[i].CompareTo(aux[j]) < 0)
                {
                    list[k] = aux[i];
                    i++;
                }
                else
                {
                    list[k] = aux[j];
                    j++;
                }
                k++;
            }

            while(i <= middleIndex)
                list[k++] = aux[i++];

            while (j <= endIndex)
                list[k++] = aux[j++];
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
