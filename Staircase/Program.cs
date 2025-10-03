using System;

class Solution
{
    static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }
            
            for (int j = 0; j < i; j++)
            {
                Console.Write("#");
            }
            
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        staircase(n);
    }
}
