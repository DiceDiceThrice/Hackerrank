using System;
using System.Linq;

class Solution
{
    static int GetMoneySpent(int[] keyboards, int[] drives, int b)
    {
        int maxSpent = -1;

        foreach (int k in keyboards)
        {
            foreach (int d in drives)
            {
                int total = k + d;
                if (total <= b && total > maxSpent)
                {
                    maxSpent = total;
                }
            }
        }

        return maxSpent;
    }

    static void Main(string[] args)
    {
        string[] firstLine = Console.ReadLine().Split(' ');
        int b = int.Parse(firstLine[0]);
        int n = int.Parse(firstLine[1]);
        int m = int.Parse(firstLine[2]);

        int[] keyboards = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] drives = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int result = GetMoneySpent(keyboards, drives, b);
        Console.WriteLine(result);
    }
}
