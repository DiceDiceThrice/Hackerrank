using System;

class Solution
{
    static int FindDigits(int n)
    {
        int count = 0;
        int originalNumber = n;
        
        while (n > 0)
        {
            int digit = n % 10;
            n /= 10;
            
            if (digit != 0 && originalNumber % digit == 0)
            {
                count++;
            }
        }
        
        return count;
    }
    
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        
        for (int i = 0; i < t; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            
            int result = FindDigits(n);
            
            Console.WriteLine(result);
        }
    }
}
