using System;

class Solution
{
    static int SaveThePrisoner(int n, int m, int s)
    {
        int result = (s + m - 1) % n;
        
        return result == 0 ? n : result;
    }
    
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        
        for (int i = 0; i < t; i++)
        {
            string[] input = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(input[0]);
            int m = Convert.ToInt32(input[1]);
            int s = Convert.ToInt32(input[2]);
            
            int result = SaveThePrisoner(n, m, s);
            
            Console.WriteLine(result);
        }
    }
}
