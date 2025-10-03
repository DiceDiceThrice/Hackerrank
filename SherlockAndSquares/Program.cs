using System;

class Solution
{
    static int Squares(int a, int b)
    {
        int start = (int)Math.Ceiling(Math.Sqrt(a));
        int end = (int)Math.Floor(Math.Sqrt(b));
        
        return Math.Max(0, end - start + 1);
    }
    
    static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());
        
        for (int i = 0; i < q; i++)
        {
            string[] input = Console.ReadLine().TrimEnd().Split(' ');
            int a = Convert.ToInt32(input[0]);
            int b = Convert.ToInt32(input[1]);
            
            int result = Squares(a, b);
            
            Console.WriteLine(result);
        }
    }
}
