using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static int runningTime(List<int> arr)
    {
        int shiftCount = 0;
        int n = arr.Count;
        
        for (int i = 1; i < n; i++)
        {
            int current = arr[i];
            int j = i - 1;
            
            while (j >= 0 && arr[j] > current)
            {
                arr[j + 1] = arr[j];
                shiftCount++;
                j--;
            }
            
            arr[j + 1] = current;
        }
        
        return shiftCount;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.runningTime(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
