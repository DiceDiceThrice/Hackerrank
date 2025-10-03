using System;
using System.Linq;

class Solution
{
    static int[] compareTriplets(int[] a, int[] b)
    {
        int aliceScore = 0;
        int bobScore = 0;
        
        for (int i = 0; i < 3; i++)
        {
            if (a[i] > b[i])
            {
                aliceScore++;
            }
            else if (a[i] < b[i])
            {
                bobScore++;
            }
        }
        
        return new int[] { aliceScore, bobScore };
    }

    static void Main(string[] args)
    {
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        int[] result = compareTriplets(a, b);
        Console.WriteLine(string.Join(" ", result));
    }
}
