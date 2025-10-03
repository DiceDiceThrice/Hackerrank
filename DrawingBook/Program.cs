using System;

class Solution
{
    static int PageCount(int n, int p)
    {
        int fromFront = p / 2;

        int fromBack = (n / 2) - (p / 2);

        return Math.Min(fromFront, fromBack);
    }

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int result = PageCount(n, p);
        Console.WriteLine(result);
    }
}
