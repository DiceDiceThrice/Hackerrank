using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static int hourglassSum(List<List<int>> arr)
    {
        int maxSum = int.MinValue;
        
        for (int i = 0; i <= 3; i++)
        {
            for (int j = 0; j <= 3; j++)
            {
                int currentSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]  
                               + arr[i + 1][j + 1]                          
                               + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2]; 
                
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        
        return maxSum;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}