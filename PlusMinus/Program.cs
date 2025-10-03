using System;
using System.Linq;

class Solution
{
    static void plusMinus(int[] arr)
    {
        int n = arr.Length;
        int positiveCount = 0;
        int negativeCount = 0;
        int zeroCount = 0;
        
        foreach (int num in arr)
        {
            if (num > 0)
            {
                positiveCount++;
            }
            else if (num < 0)
            {
                negativeCount++;
            }
            else
            {
                zeroCount++;
            }
        }
        
        double positiveRatio = (double)positiveCount / n;
        double negativeRatio = (double)negativeCount / n;
        double zeroRatio = (double)zeroCount / n;
        
        Console.WriteLine(positiveRatio.ToString("F6"));
        Console.WriteLine(negativeRatio.ToString("F6"));
        Console.WriteLine(zeroRatio.ToString("F6"));
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        plusMinus(arr);
    }
}
