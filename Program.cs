using System;

class Sort
{

    public static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
            return;

        int mid = arr.Length / 2;

        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        for (int i = 0; i < mid; i++)
            left[i] = arr[i];

        for (int i = mid; i < arr.Length; i++)
            right[i - mid] = arr[i];

        MergeSort(left);
        MergeSort(right);

        Merge(arr, left, right);
    }

    private static void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
                arr[k++] = left[i++];
            else
                arr[k++] = right[j++];
        }

        while (i < left.Length)
            arr[k++] = left[i++];

        while (j < right.Length)
            arr[k++] = right[j++];
    }

    static void Main()
    {
        int[] ints = { 8, 875, 7, 9, 764, 55 };

        Console.WriteLine("Original array:");
        foreach (int i in ints)
        {
            Console.WriteLine(i);
        }


        MergeSort(ints);

        Console.WriteLine("Sorted array:");

        foreach (int i in ints)
        {
            Console.WriteLine(i);
        }
    }
}