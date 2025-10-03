using System;
using System.Linq;

class Solution
{
    static long aVeryBigSum(int[] ar)
    {
        long sum = 0;
        for (int i = 0; i < ar.Length; i++)
        {
            sum += ar[i];
        }
        return sum;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        long result = aVeryBigSum(ar);
        Console.WriteLine(result);
    }
}
