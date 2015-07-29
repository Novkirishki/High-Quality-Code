using System;
using System.Linq;
using System.Diagnostics;

class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr.Length > 0, "The array is empty");

        for (int index = 0; index < arr.Length-1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }

        // method is inside assert intentionally so it will not be executed in release
        Debug.Assert(checkIfArrIsSorted(arr), "Array is not sorted");
    }
  
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        Debug.Assert(arr.Length > 0, "The array is empty");
        Debug.Assert(startIndex <= endIndex, "Start index is bigger than end index");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    private static bool checkIfArrIsSorted<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr.Length > 0, "The array is empty");

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i].CompareTo(arr[i + 1]) > 0)
            {
                return false;
            }
        }

        return true;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr.Length > 0, "The array is empty");

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                Debug.Assert(ValueIsInArray(arr, value, midIndex), "Value is not found on this position in the array");
                return midIndex;
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        Debug.Assert(ValueIsNotInArray(arr, value), "Value is found in array, but binary search fails to find it");
        return -1;
    }

    private static bool ValueIsInArray<T>(T[] arr, T value, int position)
        where T : IComparable<T>
    {
        if (arr[position].Equals(value))
        {
            return true;
        }

        return false;
    }

    private static bool ValueIsNotInArray<T>(T[] arr, T value)
        where T : IComparable<T>
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Equals(value))
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}
