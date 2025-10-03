using System;

class Solution
{
    static int solveMeFirst(int a, int b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = solveMeFirst(a, b);
        Console.WriteLine(sum);
    }
}