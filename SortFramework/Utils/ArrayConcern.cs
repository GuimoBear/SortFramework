using System;
using System.Linq;

namespace SortFramework.Utils
{
    public static class ArrayConcern
    {
        public static bool AreEquals<TNumber>(TNumber[] left, TNumber[] right)
            where TNumber: struct, IComparable<TNumber>, IEquatable<TNumber>
        {
            if ((left is null) && (right is null))
                return true;
            if ((left is null) || (right is null))
                return false;
            var length = left.Length;
            if (length != right.Length)
                return false;
            for (int i = 0; i < length; i++)
                if (left[i].CompareTo(right[i]) != 0)
                    return false;
            return true;
        }

        public static void Clone<TNumber>(TNumber[] origin, TNumber[] destiny)
            where TNumber : struct, IComparable<TNumber>, IEquatable<TNumber>
        {
            if ((origin is null) && (destiny is null))
                return;
            if ((origin is null) || (destiny is null))
                return;
            var length = origin.Length;
            if (length != destiny.Length)
                return;
            for (int i = 0; i < length; i++)
                destiny[i] = origin[i];
        }

        public static TNumber[] Clone<TNumber>(TNumber[] origin)
            where TNumber : struct, IComparable<TNumber>, IEquatable<TNumber>
        {
            if (origin is null)
                return null;
            var length = origin.Length;
            var destiny = new TNumber[length];
            if (length == 0)
                return destiny;
            Clone(origin, destiny);
            return destiny;
        }

        private static readonly Random random = new Random(67414152);

        public static TNumber[] Randomize<TNumber>(TNumber[] list)
            where TNumber : struct, IComparable<TNumber>, IEquatable<TNumber>
        {
            var length = list.Length;
            var indexes = Enumerable.Range(0, length).ToList();
            var newList = new TNumber[length];
            var i = 0;
            while(length > 0)
            {
                var index = random.Next(length - 1);
                newList[i] = list[indexes[index]];
                indexes.RemoveAt(index);
                length--;
                i++;
            }
            return newList;
        }
    }
}
