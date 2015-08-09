using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Compare_sort_algorithms
{
    public static class Algorithms
    {
        public static void InsertionSort<T>(T[] collection, Comparer<T> comparer = null) where T : IComparable
        {
            comparer = comparer ?? Comparer<T>.Default;

            for (int i = 0; i < collection.Length - 1; i++)
            {
                int index = i + 1;
                while (index > 0)
                {
                    if (comparer.Compare(collection[index - 1], collection[index]) > 0)
                    {
                        T temp = collection[index - 1];
                        collection[index - 1] = collection[index];
                        collection[index] = temp;
                    }

                    --index;
                }
            }
        }

        public static void SelectionSort<T>(T[] collection, Comparer<T> comparer = null) where T : IComparable
        {
            comparer = comparer ?? Comparer<T>.Default;

            for (int i = 0; i < collection.Length - 1; i++)
            {
                int minInd = i;

                for (int j = i + 1; j < collection.Length; j++)
                {
                    if (comparer.Compare(collection[i], collection[j]) > 0)
                    {
                        minInd = j;
                    }
                }

                if (minInd != i)
                {
                    T temp = collection[i];
                    collection[i] = collection[minInd];
                    collection[minInd] = temp;
                }
            }
        }

        public static void QuickSort<T>(T[] collection, int left, int right, Comparer<T> comparer = null) where T : IComparable
        {
            comparer = comparer ?? Comparer<T>.Default;

            T pivot = collection[(left + right) / 2];

            int i = left;
            int j = right;

            while (i <= j)
            {
                while (comparer.Compare(collection[i], pivot) < 0)
                {
                    i++;
                }

                while (comparer.Compare(collection[j], pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    T temp = collection[i];
                    collection[i] = collection[j];
                    collection[j] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(collection, left, j, comparer);
            }

            if (i < right)
            {
                QuickSort(collection, i, right, comparer);
            }
        }
    }
}
