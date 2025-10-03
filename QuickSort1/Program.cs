using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static List<int> quickSort(List<int> arr)
    {
        int pivot = arr[0];
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        
        for (int i = 1; i < arr.Count; i++)
        {
            if (arr[i] < pivot)
            {
                left.Add(arr[i]);
            }
            else
            {
                right.Add(arr[i]);
            }
        }
        
        List<int> result = new List<int>();
        result.AddRange(left);
        result.Add(pivot);
        result.AddRange(right);
        
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.quickSort(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
