using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static void insertionSort1(int n, List<int> arr)
    {
        int valueToInsert = arr[n - 1];
        int i = n - 2;
        
        while (i >= 0 && arr[i] > valueToInsert)
        {
            arr[i + 1] = arr[i];
            Console.WriteLine(string.Join(" ", arr));
            i--;
        }
        
        arr[i + 1] = valueToInsert;
        Console.WriteLine(string.Join(" ", arr));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.insertionSort1(n, arr);
    }
}
