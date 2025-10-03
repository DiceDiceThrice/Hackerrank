using System;
using System.Linq;

class Solution
{
    static int simpleArraySum(int[] ar)
    {
        return ar.Sum();
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int result = simpleArraySum(ar);
        Console.WriteLine(result);
    }
}
