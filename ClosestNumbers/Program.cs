using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static List<int> closestNumbers(List<int> arr)
    {
        arr.Sort();
        
        int minDiff = int.MaxValue;
        for (int i = 1; i < arr.Count; i++)
        {
            int diff = arr[i] - arr[i - 1];
            if (diff < minDiff)
            {
                minDiff = diff;
            }
        }
        
        List<int> result = new List<int>();
        for (int i = 1; i < arr.Count; i++)
        {
            if (arr[i] - arr[i - 1] == minDiff)
            {
                result.Add(arr[i - 1]);
                result.Add(arr[i]);
            }
        }
        
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

        List<int> result = Result.closestNumbers(arr);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
