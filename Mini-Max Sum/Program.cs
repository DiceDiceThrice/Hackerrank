using System;

class Solution
{
    static void miniMaxSum(int[] arr)
    {
        long totalSum = 0;
        int minElement = arr[0];
        int maxElement = arr[0];
        
        foreach (int num in arr)
        {
            totalSum += num;
            if (num < minElement) minElement = num;
            if (num > maxElement) maxElement = num;
        }
        
        long minSum = totalSum - maxElement;
        long maxSum = totalSum - minElement;
        
        Console.WriteLine(minSum + " " + maxSum);
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        miniMaxSum(arr);
    }
}
